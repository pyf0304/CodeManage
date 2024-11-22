
/*-- -- -- -- -- -- -- -- -- -- --
类名:SysSkillCRUDEx
表名:SysSkill(01120646)
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
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { SysSkillCRUD } from "./SysSkillCRUD.js";

import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js";
import { clsvSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";

import { Public_SysSkill } from "../GraduateEduPublicPage/Public_SysSkill.js";
import { clsRTSysSkillRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js";
import { clsSysSkillVEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSkillVEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsSysOperationTypeEN } from "../TS/L0_Entity/ParameterTable/clsSysOperationTypeEN.js";
import { clsSysSecurityLevelEN } from "../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js";
import { vPaper_GetObjLstByPagerAsync, vPaper_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js";
import { SysComment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js";
import { RTSysSkillRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js";
import { SysSkill_AddNewRecordWithReturnKeyAsync, SysSkill_GetObjBySkillIdAsync, SysSkill_GetObjLstAsync, SysSkill_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js";
import { vSysSkill_GetObjLstByPagerAsync, vSysSkill_GetObjLstByPager_Cache, vSysSkill_GetRecCountByCondAsync, vSysSkill_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { SysSkillV_DelSysSkillVsAsync, SysSkillV_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillVWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { SysOperationType_BindDdl_OperationTypeIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSysOperationTypeWApi.js";
import { SysSecurityLevel_BindDdl_LevelIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;

declare function HideDialogThree(): void;
/* SysSkillCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class SysSkillCRUDEx extends SysSkillCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvSysSkillBy: string = "skillId";
    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";
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
        var objPage: SysSkillCRUDEx = new SysSkillCRUDEx();
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
                //建立缓存
                var strViewType = "01";
                $("#hidViewType").val(strViewType);
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();

                this.hidSortvSysSkillBy = "skillName Asc";
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vSysSkill();
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

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
   */
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPubSessionStorage.GetSession_UserId() != "") {
                $("#divLoading").hide();
                //论文
                this.hidSortvPaperBy = "updDate Desc";

                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();

                this.hidSortvSysSkillBy = "skillName Asc";
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vSysSkill_Cache();

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
        this.OpType = "Add";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Add');
                this.bolIsLoadEditRegion = true;  //
                //获取分享Id
                const responseText1 = await gs_UserConfigEx_GetNewReturnShareIdEx("09", clsPubSessionStorage.GetSession_UserId());
                var strShareId: string = responseText1;
                //var returnBool: boolean = !!responseText2;
                if (strShareId != "") {
                    this.shareId = strShareId;
                }
                const responseText = this.AddNewRecord();
            }
            else {
                ShowDialog('Add');
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

    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 <returns>条件串(strWhereCond)</returns>
*/
    public CombinevSysSkillCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.SkillName_q != "") {
                strWhereCond += ` And ${clsvSysSkillEN.con_SkillName} like '% ${this.SkillName_q}%'`;
            }
            if (this.OperationTypeId_q != "" && this.OperationTypeId_q != "0") {
                strWhereCond += ` And ${clsvSysSkillEN.con_OperationTypeId} = '${this.OperationTypeId_q}'`;
            }

            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();
            $("#hidUserId").val(strUserId);
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                $("#btnDelRecord").show();
                $("#btnCancelSubmit").show();
                if (this.UpdUser_q != "") {
                    strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} like '% ${this.UpdUser_q}%'`;
                }

            }
            else if (strRoleId == "00620002") {
                //教师
                $("#btnDelRecord").hide();
                $("#btnCancelSubmit").show();
                if (this.UpdUser_q != "") {
                    strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} like '% ${this.UpdUser_q}%'`;
                }
            }
            else {
                //学生 教师；
                $("#btnDelRecord").hide();
                $("#btnCancelSubmit").hide();
                //学生00620003 00620002教师
                var strViewType = $("#hidViewType").val();
                if (strViewType == "01") {
                    strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} = '${strUserId}'`;
                }
                else {
                    strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} <> '${strUserId}'`;
                }
                
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
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevSysSkillCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvSysSkillObjLst: Array<clsvSysSkillEN> = [];

        try {
            const responseRecCount = await vSysSkill_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvSysSkillBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vSysSkill_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvSysSkillObjLst = <Array<clsvSysSkillEN>>jsonData;
            });

            ////换行符
            //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            ////动态显示对应的数据
            //var strhtml = "";
            //var strUserId = clsPubSessionStorage.GetSession_UserId();
            //var strRoleId = clsPubSessionStorage.GetSession_RoleId();
            ////技能
            //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加技能" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加技能</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvSysSkillObjLst.length; i++) {
            //    //得到skillId；
            //    var strSkillId = arrvSysSkillObjLst[i].skillId;
            //    v++;
            //    var strProcess = arrvSysSkillObjLst[i].process;
            //    strProcess = strProcess.replace(/\r\n/g, strBr);
            //    strProcess = strProcess.replace(/\n/g, strBr);
            //    //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
            //    strhtml += '<li><span class="rowtit color3">[技能名称]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].skillName + '</span></li>';
            //    strhtml += '<li><span class="rowtit color3">[实施过程]：</span><span class="abstract-text">' + strProcess + '</span></li>';
            //    //strhtml += '<li><span class="rowtit color3">[客观推论]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].conclusion + '</span></li>';
            //    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'

            //    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].updDate + '</span>';

            //    //获取用户名称；根据id；
            //    var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
            //    //获取用户名；
            //    arrUsers = arrUsers.filter(x => x.userId == arrvSysSkillObjLst[i].updUser);//专家观点；


            //    for (var j = 0; j < arrUsers.length; j++) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrUsers[j].userName + '</span>';
            //        break;
            //    }


            //    //判断ture 、false
            //    if (arrvSysSkillObjLst[i].isSubmit == true) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
            //    }
            //    else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
            //    }
            //    //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[是否提交]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].isSubmit + '</span></div>';


            //    if (strUserId == arrvSysSkillObjLst[i].updUser) {
            //        strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit colorRed">[操作]：</span>';
            //        //修改技能
            //        strhtml += '&nbsp;&nbsp;<button title="修改技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + arrvSysSkillObjLst[i].skillId + '")> <i class="layui-icon" >&#xe642;</i>修改技能</button>';
            //        //删除技能
            //        strhtml += '&nbsp;&nbsp;<button title="删除技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + arrvSysSkillObjLst[i].skillId + '")> <i class="layui-icon" >&#xe642;</i>删除技能</button>';
            //        //数据提交
            //        strhtml += '&nbsp;&nbsp;<button title="提交技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + arrvSysSkillObjLst[i].skillId + '")> <i class="layui-icon" >&#xe642;</i>提交技能</button>';
            //        //历史版本
            //        //if (arrvSysSkillObjLst[i].versionCount > 0 && arrvSysSkillObjLst[i].versionCount != null) {
            //        //    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvSysSkillObjLst[i].skillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //        //}
            //        strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?KeyId=" + strSkillId + "&TypeId=09','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系</button >";
            //    } else {
            //        strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
            //    }
            //    //读取session角色 来判断绑定不同数据列表
            //    //获取用户角色来判断显示不同的列表数据；


            //    //管理员则不需要隐藏
            //    if (strRoleId != "00620003") {

            //        //取消提交
            //        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvSysSkillObjLst[i].skillId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';

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
            //拼接；

            var strHtml = await Public_SysSkill.BindList_vSysSkill("01", arrvSysSkillObjLst);

            var strViewType = $("#hidViewType").val();
            if (strViewType == "01") {
                //拼接；
                $("#divDataLst").html(strHtml);
            }
            else {
                //拼接；
                $("#divOtherDataLst").html(strHtml);
            }

            if (this.RecCount >= 10) {
                $("#divPager1").show();
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
        //if (arrvSysSkillObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        //try {
        //    this.BindTab_vSysSkill(strListDiv, arrvSysSkillObjLst);
        //    console.log("完成BindGv_vSysSkill!");
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //    alert(strMsg);
        //}
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
                            //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            //    var returnBool2: boolean = jsonData;
                            //    if (returnBool2 == true) {
                            //        HideDialog();
                            //        this.BindGv_vSysSkill();
                            //    }
                            //});
                            const responseText2 = await this.AddNewRecordWithReturnKeyAsync().then((jsonData) => {

                                HideDialog();
                                this.BindGv_vSysSkill();
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vSysSkill();
                                }
                            });
                        }
                        //更新总表3个参数 主键、子表类型、页面操作类型；

                        var strSysskillId = $("#hidSkillId").val();
                        const responseText8 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSysskillId, "09", "1", this.Id_CurrEduCls);
                        var returnBool8: boolean = !!responseText8;
                        if (returnBool8 == true) {
                            console.log("技能数据总表同步成功；");
                        }
                        else {
                            console.log("技能数据总表同步失败；");
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In SysSkillCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vSysSkill();
                            }
                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；

                        var strSysskillId = $("#hidSkillId").val();
                        const responseText9 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSysskillId, "09", "2", this.Id_CurrEduCls);
                        var returnBool9: boolean = !!responseText9;
                        if (returnBool9 == true) {
                            console.log("技能数据总表同步成功；");
                        }
                        else {
                            console.log("技能数据总表同步失败；");
                        }
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
    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public async UpdateRecordSave() {
        this.DivName = "divUpdateRecordSave";
        var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
        objSysSkillEN.skillId = this.KeyId;
        $("#hidSkillId").val(this.KeyId);
        this.PutDataToSysSkillClass(objSysSkillEN);
        objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await SysSkill_UpdateRecordAsync(objSysSkillEN);
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
    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
  */
    public async AddNewRecordWithReturnKeyAsync() {
        this.DivName = "divAddNewRecordWithMaxIdSave";
        var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
        objSysSkillEN.createDate = clsPubFun4Web.getNowDate_ymd();
        this.PutDataToSysSkillClass(objSysSkillEN);
        try {
            const responseText2 = await SysSkill_AddNewRecordWithReturnKeyAsync(objSysSkillEN);//.AddNewRecordWithMaxIdAsync(objSysSkillEN);
            var strSysSkillId: string = responseText2;
            if (strSysSkillId != "") {
                $("#hidSkillId").val(strSysSkillId);
                var strInfo: string = `添加记录成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return strSysSkillId;//一定要有一个返回值，否则会出错！
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
 <param name = "pobjSysSkillEN">数据传输的目的类对象</param>
*/
    public PutDataToSysSkillClass(pobjSysSkillEN: clsSysSkillEN) {
        pobjSysSkillEN.skillId = this.skillId;// 技能Id
        pobjSysSkillEN.skillName = this.skillName;// 技能名称
        pobjSysSkillEN.operationTypeId = this.operationTypeId;// 操作类型
        pobjSysSkillEN.levelId = this.levelId;// 级别Id
        pobjSysSkillEN.process = this.process;// 实施过程
        pobjSysSkillEN.shareId = this.shareId;
        pobjSysSkillEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改人
        pobjSysSkillEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjSysSkillEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        pobjSysSkillEN.isSubmit = this.isSubmit;// 是否提交
        pobjSysSkillEN.citationId = this.citationId;// 引用Id
        pobjSysSkillEN.memo = this.memo;// 备注
    }
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
 <returns>条件串(strWhereCond)</returns>
*/
    public CombinevSysSkillConditionObj(): clsvSysSkillEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvSysSkill_Cond: clsvSysSkillEN = new clsvSysSkillEN();
        objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_id_CurrEduCls, clsPublocalStorage.Getid_CurrEduCls(), "=");
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.SkillName_q != "") {
                strWhereCond += ` And ${clsvSysSkillEN.con_SkillName} like '% ${this.SkillName_q}%'`;
                objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_SkillName, this.SkillName_q, "like");
            }
            if (this.OperationTypeId_q != "" && this.OperationTypeId_q != "0") {
                strWhereCond += ` And ${clsvSysSkillEN.con_OperationTypeId} = '${this.OperationTypeId_q}'`;
                objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_OperationTypeId, this.OperationTypeId_q, "=");
            }
            //if (this.UpdUser_q != "") {
            //    strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} like '% ${this.UpdUser_q}%'`;
            //    objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_UpdUser, this.UpdUser_q, "like");
            //}

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();

            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                $("#btnCancelSubmit").show();
                if (this.UpdUser_q != "") {
                    strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} like '% ${this.UpdUser_q}%'`;
                    objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_UpdUser, this.UpdUser_q, "like");
                }
            }
            else if (strRoleId == "00620002") {
                $("#btnCancelSubmit").show();
                if (this.UpdUser_q != "") {
                    strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} like '% ${this.UpdUser_q}%'`;
                    objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_UpdUser, this.UpdUser_q, "like");
                }
            }
            else {
                $("#btnCancelSubmit").hide();
                //学生； 
                strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} = '${strUserId}'`;
                objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_UpdUser, strUserId, "=");
            }
            $("#hidUserId").val(strUserId);

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineSysSkillConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvSysSkill_Cond;
    }

    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
*/
    public async BindGv_vSysSkill_Cache() {
        var strListDiv: string = this.mstrListDiv;
        var objvSysSkill_Cond = this.CombinevSysSkillConditionObj();
        objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_id_CurrEduCls, SysSkillCRUD.strid_CurrEduCls_Cache, "=");
        var strWhereCond = JSON.stringify(objvSysSkill_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvSysSkillObjLst: Array<clsvSysSkillEN> = [];
        try {
            this.RecCount = await vSysSkill_GetRecCountByCond_Cache(objvSysSkill_Cond, SysSkillCRUD.strid_CurrEduCls_Cache);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvSysSkillBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrvSysSkillObjLst = await vSysSkill_GetObjLstByPager_Cache(objPagerPara, SysSkillCRUD.strid_CurrEduCls_Cache);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvSysSkillObjLst.length == 0) {
        //    var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=SysSkill_${SysSkillCRUD.strid_CurrEduCls_Cache})`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vSysSkill(strListDiv, arrvSysSkillObjLst);
            console.log("完成BindGv_vSysSkill!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 显示vSysSkill对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrSysSkillObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vSysSkill(divContainer: string, arrvSysSkillObjLst: Array<clsvSysSkillEN>) {
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
                    FldName: "skillName",
                    ColHeader: "技能名称",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "process",
                    ColHeader: "实施过程",
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
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "okCount",
                //    ColHeader: "点赞统计",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "appraiseCount",
                //    ColHeader: "评论数",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "score",
                //    ColHeader: "评分",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "stuScore",
                //    ColHeader: "学生平均分",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "teaScore",
                //    ColHeader: "教师评分",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "pdfContent",
                //    ColHeader: "Pdf内容",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "pdfPageNum",
                //    ColHeader: "Pdf页码",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "citationCount",
                //    ColHeader: "引用统计",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "versionCount",
                //    ColHeader: "版本统计",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
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
        clsCommonFunc4Web.BindTabV2(o, arrvSysSkillObjLst, arrDataColumn, "skillId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public async btnUpdateRecordInTab_Click(strKeyId: string) {
        this.OpType = "Update";
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

    /* 修改记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
*/
    public async btnUpdateRecord_Click(strKeyId:string) {
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
            //ShowDialog('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {

            //ShowDialog('Update');
            this.UpdateRecord(strKeyId);
        }
    }

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
            var strWhere1 = ` 1=1 And ${clsRTSysSkillRelaEN.con_SkillId} = '${strKeyId}'`;
            var RTVCount: number = 0;
            const responseText1 = await RTSysSkillRela_GetRecCountByCondAsync(strWhere1).then((jsonData) => {
                RTVCount = jsonData;
            });

            //查询和id相关的评论评分是否存在09
            var strWhere2 = " 1=1 And tableKey ='" + strKeyId + "' and commentTypeId='09'";
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

                //先获取历史版本再删除；
                var strSkillVWhereCond = " SkillvId='" + strKeyId + "' order by updDate Asc";
                var arrSkillVWObjLst: Array<clsSysSkillVEN> = [];
                const responseText1 = await SysSkillV_GetObjLstAsync(strSkillVWhereCond).then((jsonData) => {
                    arrSkillVWObjLst = <Array<clsSysSkillVEN>>jsonData;
                });
                var arrSelectedKeys: Array<string> =
                    arrSkillVWObjLst.map((x) => {
                        var strId = x.skillVId.toString();
                        //var strKey = strId.substring(3);
                        return strId;
                    });

                //更新总表3个参数 主键、子表类型、页面操作类型；
                var strSkillId = strKeyId;
                const responseText6 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSkillId, "09", "3", this.Id_CurrEduCls);
                var returnBool6: boolean = !!responseText6;
                if (returnBool6 == true) {
                    console.log("技能数据总表删除成功；");
                }
                else {
                    console.log("技能数据总表删除失败；");
                }
                const responseText0 = await this.VDelMultiRecord(arrSelectedKeys);
                const responseText = await this.DelRecord(strKeyId);
                const responseBindGv = await this.BindGv_vSysSkill();
            }



            ////const responseText = await this.DelRecord(strKeyId);
            ////const responseText2 = await this.BindGv_vSysSkill();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }
    //批量删除
    public VDelMultiRecord(arrSkillIdVId: Array<string>) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = SysSkillV_DelSysSkillVsAsync(arrSkillIdVId).then((jsonData) => {
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

    /* 函数功能:为编辑区绑定下拉框
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
*/
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面
        var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
        const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
        var objSysOperationType_Cond: clsSysOperationTypeEN = new clsSysOperationTypeEN();//编辑区域
        var objSysSecurityLevel_Cond: clsSysSecurityLevelEN = new clsSysSecurityLevelEN();//编辑区域
        const ddlOperationTypeId = await SysOperationType_BindDdl_OperationTypeIdInDiv_Cache(this.divName4List, "ddlOperationTypeId");//编辑区域
        const ddlLevelId = await SysSecurityLevel_BindDdl_LevelIdInDiv_Cache(this.divName4List, "ddlLevelId");//编辑区域
        //文献类型；
        const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");

    }
    // <summary>
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
    /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
    public async UpdateRecord(strSkillId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = strSkillId;
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        try {
            const responseText = await SysSkill_GetObjBySkillIdAsync(strSkillId);
            var objSysSkillEN: clsSysSkillEN = <clsSysSkillEN>responseText;
            // //通过判断数据用户是否是当前登录用户；
            if (objSysSkillEN.updUser == strUserId) {

                //判断数据是否提交，提交则不可修改；
                if (objSysSkillEN.isSubmit == false) {
                    ShowDialog('Update');
                    this.GetDataFromSysSkillClass(objSysSkillEN);
                    console.log("完成UpdateRecord!");
                }
                else {
                    alert("当前数据已提交,不能修改！");
                    return;
                }

            }
            else {
                alert("当前数据不是您所添加，不能修改！");
                return;
            }
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 函数功能:把类对象的属性内容显示到界面上
  注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
   如果在设置数据库时,就应该一级字段在前,二级字段在后
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
   <param name = "pobjSysSkillEN">表实体类对象</param>
 */
    public GetDataFromSysSkillClass(pobjSysSkillEN: clsSysSkillEN) {
        this.skillId = pobjSysSkillEN.skillId;// 技能Id
        this.skillName = pobjSysSkillEN.skillName;// 技能名称
        this.operationTypeId = pobjSysSkillEN.operationTypeId;// 操作类型
        this.levelId = pobjSysSkillEN.levelId;// 级别Id
        this.process = pobjSysSkillEN.process;// 实施过程
        this.shareId = pobjSysSkillEN.shareId;
        this.updUser = pobjSysSkillEN.updUser;// 修改人
        this.updDate = pobjSysSkillEN.updDate;// 修改日期
        this.isSubmit = pobjSysSkillEN.isSubmit;// 是否提交
        this.citationId = pobjSysSkillEN.citationId;// 引用Id
        this.memo = pobjSysSkillEN.memo;// 备注
    }
    /* 删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
*/
    public async btnDelRecord_Click() {
        try {
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
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
            var strWhereCond = " skillId in (" + strKeyList + ")";
            var arrSysSkillObjLst: Array<clsSysSkillEN> = [];
            const responseText1 = await SysSkill_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrSysSkillObjLst = <Array<clsSysSkillEN>>jsonData;
                //查询是否有提交的数据
                arrSysSkillObjLst = arrSysSkillObjLst.filter(x => x.isSubmit == true);
                if (arrSysSkillObjLst.length > 0) {
                    alert("包含有已提交数据，不能删除！");
                    return "";
                }
            });


            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vSysSkill();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }


    //技能提交审核
    public async btnIsSubmit_Click(strKeyId: string) {

        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        this.SubmitRecord(strKeyId);

    }
    //提交判断；
    public async SubmitRecord(strSkillId: string) {

        this.KeyId = strSkillId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = SysSkill_GetObjBySkillIdAsync(strSkillId).then((jsonData) => {
                    var objSysSkillEN: clsSysSkillEN = <clsSysSkillEN>jsonData;

                    //通过session 权限获取权限
                    var strUserId = clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage.GetSession_RoleId();

                    //判断角色 //学生00620003
                    if (strRoleId == "00620003") {
                        // //通过判断数据用户是否是当前登录用户；
                        if (objSysSkillEN.updUser == strUserId) {
                            //判断数据是否已审核
                            if (objSysSkillEN.isSubmit == false) {
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
                        if (objSysSkillEN.isSubmit == false) {
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
        var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
        objSysSkillEN.skillId = this.KeyId;
        objSysSkillEN.isSubmit = true;
        objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = SysSkill_UpdateRecordAsync(objSysSkillEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `提交成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                        //HideDialog();
                        this.BindGv_vSysSkill();// BindGv_vSysSkill_Cache();
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
        var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
        objSysSkillEN.skillId = strKeyId;
        objSysSkillEN.isSubmit = false;
        objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
            throw "关键字不能为空!";
        }

        try {
            const responseText = SysSkill_UpdateRecordAsync(objSysSkillEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {
                    var strInfo: string = `取消成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);

                    //HideDialog();
                    this.BindGv_vSysSkill();
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








    //----------------------------------------------------------------论文部分

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



            //排除获取已被当前观点引用过的论文数据；
            //strWhereCond += ` And paperId not in (select paperId from RTPaperRela where viewpointId = '${strTopicId}')`;

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
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "periodical",
                    ColHeader: "期刊",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    ColHeader: "作者",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "keyword",
                    ColHeader: "关键字",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "提交日期",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "提交用户",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定",TdClass: "text-left",SortBy: "",
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
        clsCommonFunc4Web.BindTabV2Where(o, arrvPaperObjLst, arrDataColumn, "paperId", "TopicPaper");
        //clsCommonFunc4Web.BindTabV2(o, arrvPaperObjLst, arrDataColumn, "paperId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }



    //选择论文弹出列表数据；
    public async selectPaper_Click() {
        //论文用户
        var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
        const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域
        const responseObjList = await this.BindGv_vPaper();
    }
    //查询论文列表
    public async btnPaperQuery_Click() {
        const responseObjList = await this.BindGv_vPaper();
    }
    //确定选择的论文 并添加到关系表中
    public btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)
        $("#txtCitationId").val(strkeyId);
        //设置只读属性；
        $("#txtCitationId").attr("disabled", "disabled");
        //关闭列表
        HideDialogThree();

    }
    /* 
论文
*/
    public async SortByPaper(strSortByFld: string) {
        if (this.hidSortvPaperBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvPaperBy.indexOf("Asc") >= 0) {
                this.hidSortvPaperBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvPaperBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvPaperBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vPaper();
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