/*-- -- -- -- -- -- -- -- -- -- --
类名:Viewpoint_QUDI_TSEx
表名:Viewpoint(01120542)
生成代码版本:2019.12.06.1
生成日期:2019/12/27 11:02:10
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
import { Viewpoint_QUDI } from "./Viewpoint_QUDI.js";
//import { clsvQxUserRoleRelationEN } from "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js";
//import { stuUserLoginInfo } from "../TS/FunClass/stuUserLoginInfo.js";
import { clsRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js";
import { clsViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsViewpointAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js";
import { clsViewpointCitationEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointCitationEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
//import { clsvPaperExWApi } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js";
//import { clsvViewpointExWApi } from "../TS/L3_ForWApiEx/GraduateEdu/clsvViewpointExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";

import { Public_Viewpoint } from "../GraduateEduPublicPage/Public_Viewpoint.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsViewpointVEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointVEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { vPaper_GetObjLstByPagerAsync, vPaper_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js";
import { SysComment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js";
import { ResearchTopic_GetObjLstByPagerAsync, ResearchTopic_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { RTViewpointRela_AddNewRecordAsync, RTViewpointRela_GetRecCountByCondAsync, RTViewpointRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js";
import { ViewpointAttachment_AddNewRecordAsync, ViewpointAttachment_DelViewpointAttachmentsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js";
import { ViewpointCitation_AddNewRecordAsync, ViewpointCitation_DelViewpointCitationsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointCitationWApi.js";
import { ViewpointV_AddNewRecordAsync, ViewpointV_DelViewpointVsAsync, ViewpointV_GetObjLstAsync, ViewpointV_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointVWApi.js";
import { Viewpoint_AddNewRecordAsync, Viewpoint_GetMaxStrIdAsync, Viewpoint_GetObjByViewpointIdAsync, Viewpoint_IsExistAsync, Viewpoint_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js";
import { vViewpoint_GetObjByViewpointIdAsync, vViewpoint_GetObjLstAsync, vViewpoint_GetObjLstByPagerAsync, vViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { ViewpointType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogTwo(): void;
declare function HideDialogThree(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* Viewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Viewpoint_QUDIEx extends Viewpoint_QUDI {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvViewpointBy: string = "viewpointId";


    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";
    //主题列表
    public mstrListdivTopicDataLst: string = "divTopicDataLst";
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

                //首次加载默认个人观点
                var strViewType = "01";
                $("#hidViewType").val(strViewType);

                ////读取session角色 来判断绑定不同数据列表
                //if (clsPubSessionStorage.GetSession_RoleId() == "00620001") {

                //    $("#btnDelRecord").show();
                //}
                //else {
                //    //学生00620003 教师 
                //    $("#btnDelRecord").hide();

                //}
                $("#hidUserId").val(clsPubSessionStorage.GetSession_UserId());


                //1、为下拉框设置数据源,绑定列表数据
                const ddl_ViewpointTypeId = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId");
                const ddl_ViewpointTypeId_q = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId_q");
                this.hidSortvViewpointBy = "updDate Desc";
                this.hidSortResearchTopicBy = "updDate Desc";
                //论文
                this.hidSortvPaperBy = "updDate Desc";

                //论文用户下拉框绑定
                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//观点查询区域
                const ddl_UserId_q = await clsDropDownList.BindDdl_UserIdInvViewpoint_Cache("ddlViewPointUserId_q", objUsers_Cond); // this.BindDdl_UserId("ddlUserId_q");

                //var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//论文查询区域
                const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域

                //文献类型；
                const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                //论文
                this.hidSortvRTPaperRelaBy = "updDate Desc";

                //var strWhereCond = this.CombinevViewpointCondition();
                //const responseText = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vViewpoint();

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
    /// 为下拉框获取数据,从表:[ViewpointType]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_ViewpointTypeId(ddlViewpointTypeId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlViewpointTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlViewpointTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = ViewpointType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrViewpointTypeObjLst: Array<clsViewpointTypeEN> = <Array<clsViewpointTypeEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlViewpointTypeId, arrViewpointTypeObjLst, clsViewpointTypeEN.con_ViewpointTypeId, clsViewpointTypeEN.con_ViewpointTypeName, "观点类型");
                    console.log("完成BindDdl_ViewpointTypeId!");
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

    ////用户下拉框
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
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperEN.con_UpdUser, clsvPaperEN.con_UserName, "用户");
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



    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjViewpointEN">数据传输的目的类对象</param>
  */
    public PutDataToViewpointVClass(pobjViewpointVEN: clsViewpointVEN) {
        pobjViewpointVEN.viewpointId = this.viewpointId;// 观点Id
        pobjViewpointVEN.viewpointName = this.viewpointName;// 观点名称
        pobjViewpointVEN.viewpointContent = this.viewpointContent;// 观点内容
        pobjViewpointVEN.viewpointTypeId = this.viewpointTypeId;// 观点类型Id
        pobjViewpointVEN.reason = this.reason;// 理由
        pobjViewpointVEN.source = this.source;// 来源
        pobjViewpointVEN.citationId = this.paperId;//引用论文id；
        //判断用户类型，然后添加数据
        var strhidUserTypeId = $("#hidUserTypeId").val();
        if (strhidUserTypeId != "") {
            pobjViewpointVEN.userTypeId = strhidUserTypeId;
        }
        pobjViewpointVEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        pobjViewpointVEN.vpProposePeople = $("#hidUserId").val();// 观点提出人
        pobjViewpointVEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjViewpointVEN.updUser = $("#hidUserId").val();// 修改人
        pobjViewpointVEN.memo = this.memo;// 备注
    }


    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjViewpointEN">数据传输的目的类对象</param>
  */
    public PutDataToViewpointClass(pobjViewpointEN: clsViewpointEN) {
        pobjViewpointEN.viewpointId = this.viewpointId;// 观点Id
        pobjViewpointEN.viewpointName = this.viewpointName;// 观点名称
        pobjViewpointEN.viewpointContent = this.viewpointContent;// 观点内容
        pobjViewpointEN.viewpointTypeId = this.viewpointTypeId;// 观点类型Id
        pobjViewpointEN.reason = this.reason;// 理由
        pobjViewpointEN.source = this.source;// 来源
        pobjViewpointEN.isSubmit = false;//是否提交；
        pobjViewpointEN.citationId = this.paperId;//引用论文id；
        //判断用户类型，然后添加数据
        var strhidUserTypeId = $("#hidUserTypeId").val();
        if (strhidUserTypeId != "") {
            pobjViewpointEN.userTypeId = strhidUserTypeId;
        }
        pobjViewpointEN.shareId = this.shareId;
        pobjViewpointEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        pobjViewpointEN.vpProposePeople = $("#hidUserId").val();// 观点提出人
        pobjViewpointEN.updDate = clsPubFun4Web.getNowDate();// 修改日期

        pobjViewpointEN.updUser = $("#hidUserId").val();// 修改人

        pobjViewpointEN.memo = this.memo;// 备注
    }




    /* 修改记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
  */
    public btnUpdateRecord_Click(strKeyId: string) {
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        this.UpdateRecord(strKeyId);
    }
    /* 根据关键字获取相应的记录的对象
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
    <param name = "sender">参数列表</param>
  */
    public UpdateRecord(strViewpointId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = strViewpointId;
        var strUserId = $("#hidUserId").val();
        return new Promise((resolve, reject) => {
            try {
                const responseText = Viewpoint_GetObjByViewpointIdAsync(strViewpointId).then((jsonData) => {
                    var objViewpointEN: clsViewpointEN = <clsViewpointEN>jsonData;

                    // //通过判断数据用户是否是当前登录用户；
                    if (objViewpointEN.updUser == strUserId) {

                        //判断数据是否提交，提交则不可修改；
                        if (objViewpointEN.isSubmit == false) {
                            ShowDialog('Update');
                            this.GetDataFromViewpointClass(objViewpointEN);
                            console.log("完成UpdateRecord!");
                            resolve(jsonData);
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
    <param name = "pobjViewpointEN">表实体类对象</param>
  */
    public GetDataFromViewpointClass(pobjViewpointEN: clsViewpointEN) {
        this.viewpointId = pobjViewpointEN.viewpointId;// 观点Id
        this.viewpointName = pobjViewpointEN.viewpointName;// 观点名称
        this.viewpointContent = pobjViewpointEN.viewpointContent;// 观点内容
        this.viewpointTypeId = pobjViewpointEN.viewpointTypeId;// 观点类型Id
        this.reason = pobjViewpointEN.reason;// 理由
        this.source = pobjViewpointEN.source;// 来源
        this.isSubmit = pobjViewpointEN.isSubmit;//是否提交；
        this.vpProposePeople = pobjViewpointEN.vpProposePeople;// 观点提出人
        this.shareId = pobjViewpointEN.shareId;
        this.paperId = pobjViewpointEN.citationId;//引用Id;
        this.updDate = pobjViewpointEN.updDate;// 修改日期
        this.updUser = pobjViewpointEN.updUser;// 修改人
        this.memo = pobjViewpointEN.memo;// 备注
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
            var strWhere1 = ` 1=1 And ${clsRTViewpointRelaEN.con_ViewpointId} = '${strKeyId}'`;
            var RTVCount: number = 0;
            const responseText1 = await RTViewpointRela_GetRecCountByCondAsync(strWhere1).then((jsonData) => {
                RTVCount = jsonData;
            });

            //查询和id相关的评论评分是否存在
            var strWhere2 = " 1=1 And tableKey ='" + strKeyId + "' and commentTypeId='03'";
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
                var strViewpointVWhereCond = " viewpointId='" + strKeyId + "' order by updDate Asc";
                var arrViewpointVObjLst: Array<clsViewpointVEN> = [];
                const responseText1 = await ViewpointV_GetObjLstAsync(strViewpointVWhereCond).then((jsonData) => {
                    arrViewpointVObjLst = <Array<clsViewpointVEN>>jsonData;
                });
                var arrSelectedKeys: Array<string> =
                    arrViewpointVObjLst.map((x) => {
                        var strId = x.viewpointVId.toString();
                        //var strKey = strId.substring(3);
                        return strId;
                    });

                //更新总表3个参数 主键、子表类型、页面操作类型；
                var strSubViewpointId = strKeyId;
                const responseText7 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSubViewpointId, "04", "3", this.Id_CurrEduCls);
                var returnBool7: boolean = !!responseText7;
                if (returnBool7 == true) {
                    console.log("个人观点数据总表删除成功；");
                }
                else {
                    console.log("个人观点数据总表删除失败；");
                }
                const responseText0 = await this.VDelMultiRecord(arrSelectedKeys);
                const responseText = this.DelRecord(strKeyId);
                const responseText2 = this.BindGv_vViewpoint();
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }


    public VDelMultiRecord(arrViewpointVId: Array<string>) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = ViewpointV_DelViewpointVsAsync(arrViewpointVId).then((jsonData) => {
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
            var strWhereCond = " viewpointId in (" + strKeyList + ")";
            var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
            const responseText1 = await vViewpoint_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvViewpointObjLst = <Array<clsvViewpointEN>>jsonData;
                //查询是否有提交的数据
                arrvViewpointObjLst = arrvViewpointObjLst.filter(x => x.isSubmit == true);
                if (arrvViewpointObjLst.length > 0) {
                    alert("包含有已提交数据，不能删除！");
                    return "";
                }
            });


            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseText2 = await this.BindGv_vViewpoint();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    //观点提交审核
    public async btnIsSubmit_Click(strKeyId: string) {

        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        this.SubmitRecord(strKeyId);

    }
    //提交判断；
    public async SubmitRecord(strViewpointId: string) {

        this.KeyId = strViewpointId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = Viewpoint_GetObjByViewpointIdAsync(strViewpointId).then((jsonData) => {
                    var objViewpointEN: clsViewpointEN = <clsViewpointEN>jsonData;

                    //通过session 权限获取权限
                    var strUserId = clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage.GetSession_RoleId();

                    //判断角色 //学生00620003
                    if (strRoleId == "00620003") {

                        // //通过判断数据用户是否是当前登录用户；
                        if (objViewpointEN.updUser == strUserId) {

                            //判断数据是否已审核
                            if (objViewpointEN.isSubmit == false) {

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
                        if (objViewpointEN.isSubmit == false) {

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
        var objViewpointEN: clsViewpointEN = new clsViewpointEN();
        objViewpointEN.viewpointId = this.KeyId;
        objViewpointEN.isSubmit = true;
        //this.PutDataToViewpointClass(objViewpointEN);
        objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Viewpoint_UpdateRecordAsync(objViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `提交成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                        HideDialog();
                        this.BindGv_vViewpoint();
                    }
                    else {
                        var strInfo: string = `提交不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("提交失败");
                    }

                    $("#btnIsSubmit").attr("disabled", false);
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
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async btnQuery_Click(strListDiv: string) {
        try {
            this.BindGv_vViewpoint();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
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
            const responseText1 = await gs_UserConfigEx_GetNewReturnShareIdEx("04", clsPubSessionStorage.GetSession_UserId());
            var strShareId: string = responseText1;
            //var returnBool: boolean = !!responseText2;
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

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vViewpoint() {
        var strListDiv: string = this.mstrListDiv;
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

            var strUserTypeId = $("#hidUserTypeId").val();
            var strHtml = await Public_Viewpoint.BindList_vViewpoint("01", strUserTypeId, arrvViewpointObjLst)

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


            ////换行符
            //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            ////动态显示对应的数据
            //var strhtml = "";
            //var strUserId = clsPubSessionStorage.GetSession_UserId();
            //var strRoleId = clsPubSessionStorage.GetSession_RoleId();
            ////个人观点
            //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            ////strhtml += '<div style="float:left;"><a href="#" title="当前论文相关' + strTitle + '">当前论文相关' + strTitle + '</a></div>';
            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加个人观点" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加个人观点</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvViewpointObjLst.length; i++) {
            //    //得到viewpointId；
            //    var strViewpointId = arrvViewpointObjLst[i].viewpointId;
            //    v++;

            //    //对内容进行换行替换
            //    var strViewpointContent = arrvViewpointObjLst[i].viewpointContent;
            //    var strReason = arrvViewpointObjLst[i].reason;

            //    strViewpointContent = strViewpointContent.replace(/\r\n/g, strBr);
            //    strViewpointContent = strViewpointContent.replace(/\n/g, strBr);

            //    strReason = strReason.replace(/\r\n/g, strBr);
            //    strReason = strReason.replace(/\n/g, strBr);

            //    strhtml += '<li><span class="rowtit color3">[观点名称]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointName + '</span></li>';

            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[类型]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointTypeName + '</span></li>';
            //    strhtml += '<li><span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + strViewpointContent + '</span></li>';
            //    //类型+理由
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + strReason + '</span></li>';

            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[来源]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].source + '</span></li>';

            //    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">';


            //    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].updDate + '</span>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].userName + '</span>';
            //    //判断ture 、false
            //    if (arrvViewpointObjLst[i].isSubmit == true) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
            //    }
            //    else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
            //    }
            //    //strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[是否提交]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].isSubmit + '</span></div>';



            //    if (strUserId == arrvViewpointObjLst[i].updUser) {
            //        strhtml += '<div style="float:right;width:30%;"><span class="rowtit colorRed">[操作]：</span>';
            //        //修改个人观点
            //        if (arrvViewpointObjLst[i].isSubmit != true) {
            //            strhtml += '&nbsp;&nbsp;<button title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + arrvViewpointObjLst[i].viewpointId + '")> <i class="layui-icon" >&#xe642;</i>修改</button>';
            //            //观点提交
            //            strhtml += '&nbsp;&nbsp;<button title="观点提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + arrvViewpointObjLst[i].viewpointId + '")> <i class="layui-icon" >&#xe642;</i>观点提交</button>';
            //        }
            //        //删除个人观点
            //        strhtml += '&nbsp;&nbsp;<button title="删除" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelRecordInTab_Click("' + arrvViewpointObjLst[i].viewpointId + '")> <i class="layui-icon" >&#xe640;</i>删除</button>';

            //        //历史版本
            //        if (arrvViewpointObjLst[i].versionCount > 0 && arrvViewpointObjLst[i].versionCount != null) {
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('个人观点历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvViewpointObjLst[i].viewpointId + "&Type=03')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //        }
            //    } else {
            //        strhtml += '<div style="float:right;width:30%;"><span class="rowtit color5">[操作]：</span>';
            //    }

            //    //读取session角色 来判断绑定不同数据列表
            //    //管理员则不需要隐藏
            //    if (strRoleId != "00620003") {
            //        //取消提交
            //        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvViewpointObjLst[i].viewpointId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';

            //    }

            //    strhtml += '</div></div></li>';

            //    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';
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
        //try {
        //    this.BindTab_vViewpoint(strListDiv, arrvViewpointObjLst);
        //    console.log("完成BindGv_vViewpoint!");
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //    alert(strMsg);
        //}
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
        var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
        const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
        this.UpdateRecord(strKeyId);
    }
    ////专业下拉框绑定
    //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "1=1 And userTypeId ='01'") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlUserId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = vViewpointEx_GetViewpointUserObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrUserObjLst: Array<clsvViewpointEN> = <Array<clsvViewpointEN>>jsonData;
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvViewpointEN.con_UpdUser, clsvViewpointEN.con_UserName, "编辑用户");
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
    public CombinevViewpointCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.ViewpointName_q != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_ViewpointName} like '% ${this.ViewpointName_q}%'`;
            }
            if (this.ViewpointTypeId_q != "" && this.ViewpointTypeId_q != "0") {
                strWhereCond += ` And ${clsvViewpointEN.con_ViewpointTypeId} = '${this.ViewpointTypeId_q}'`;
            }
            //if (this.Reason_q != "") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_Reason} like '% ${this.Reason_q}%'`;
            //}
            //if (this.UserName_q != "") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_UserName} like '% ${this.UserName_q}%'`;
            //}
            if (this.User_q != "" && this.User_q != "0") {
                strWhereCond += ` And ${clsvViewpointEN.con_UpdUser} = '${this.User_q}'`;
            }
            if (this.StartDate_q != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_UpdDate} > '${this.StartDate_q}'`;
            }
            if (this.EndDate_q != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_UpdDate} < '${this.EndDate_q}'`;
            }

            var strhidUserTypeId = $("#hidUserTypeId").val();
            if (strhidUserTypeId != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_UserTypeId} = '${strhidUserTypeId}'`;
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
                ////可以查看所有；
                ////strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.Getid_CurrEduCls() + "') or updUser='" + strUserId + "'";
                ////strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.Getid_CurrEduCls() + "')";
                //strWhereCond += ` And ${clsvViewpointEN.con_id_CurrEduCls} = '${clsPublocalStorage.Getid_CurrEduCls()}'`;
                //var strhidUserTypeId = $("#hidUserTypeId").val();
                //if (strhidUserTypeId != "") {
                //    strWhereCond += ` And ${clsvViewpointEN.con_UserTypeId} = '${strhidUserTypeId}'`;
                //}

                ////strWhereCond += "[exclude]or [/exclude]";
            }
            else {
                //学生 教师；
                $("#btnDelRecord").hide();
                $("#btnCancelSubmit").hide();
                //学生00620003 00620002教师

                //这里判断--如果类型为01 个人观点、否则是他人观点；
                var strViewType = $("#hidViewType").val();
                if (strViewType == "01") {
                    strWhereCond += ` And ${clsvViewpointEN.con_UpdUser} = '${strUserId}'`;
                }
                else {
                    strWhereCond += ` And ${clsvViewpointEN.con_UpdUser} <> '${strUserId}'`;
                }

            }
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
                {
                    FldName: "reason",
                    ColHeader: "理由",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "source",
                    ColHeader: "来源",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "vpProposePeople",
                    ColHeader: "观点提出人",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },

                {
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
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
                    FldName: "userName",
                    ColHeader: "用户",
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
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvViewpointObjLst, arrDataColumn, "viewpointId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /* 在数据表里修改记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
 */
    public btnDetailInTab_Click(strKeyId: string) {

        if (strKeyId == "") {
            alert("请选择需要的记录！");
            return;
        }
        this.DetailRecord(strKeyId);
    }

    /* 根据关键字获取相应的记录的对象
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
      <param name = "sender">参数列表</param>
    */
    public DetailRecord(strViewpointId: string) {

        this.KeyId = strViewpointId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = vViewpoint_GetObjByViewpointIdAsync(strViewpointId).then((jsonData) => {
                    var objvViewpointEN: clsvViewpointEN = <clsvViewpointEN>jsonData;
                    //数据显示
                    $("#txtViewpointNameDetail").html(objvViewpointEN.viewpointName);
                    $("#txtViewpointTypeNameDetail").html(objvViewpointEN.viewpointTypeName);
                    $("#txtViewpointContentDetail").html(objvViewpointEN.viewpointContent);
                    $("#txtReasonDetail").html(objvViewpointEN.reason);
                    $("#txtSourceDetail").html(objvViewpointEN.source);
                    $("#txtMemoDetail").html(objvViewpointEN.memo);

                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `当前无数据获取失败,${e}.`;
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

                                //HideDialog();
                                //this.BindGv_vViewpoint();
                            }
                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；
                        var strTopicObjectiveId = $('#hidViewpointId').val();
                        const responseText6 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strTopicObjectiveId, "04", "1", this.Id_CurrEduCls);
                        var returnBool6: boolean = !!responseText6;
                        if (returnBool6 == true) {
                            console.log("客观数据总表同步成功；");
                        }
                        else {
                            console.log("客观数据总表同步失败；");
                        }
                        //添加记录的同时添加历史版本
                        const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vViewpoint();
                                //alert("添加历史版本出问题！");
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                            }
                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；
                        var strTopicObjectiveId = $('#hidViewpointId').val();
                        const responseText7 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strTopicObjectiveId, "04", "2", this.Id_CurrEduCls);
                        var returnBool7: boolean = !!responseText7;
                        if (returnBool7 == true) {
                            console.log("专家观点数据总表同步成功；");
                        }
                        else {
                            console.log("专家观点数据总表同步失败；");
                        }
                        //修改记录的同时添加历史版本
                        const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vViewpoint();
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

            $('#divLoading').hide();
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", false);
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }



    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        try {
            const responseText = await Viewpoint_GetMaxStrIdAsync().then((jsonData) => {
                var returnString: string = jsonData.toString();
                if (returnString == "") {
                    var strInfo: string = `获取表ViewPoint的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtViewpointId').val(returnString);
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
        if ($('#txtViewpointId').val() != "") {
            this.DivName = "divAddNewRecordSave";
            var objViewpointEN: clsViewpointEN = new clsViewpointEN();
            //objViewpointEN.viewpointId = $('#txtViewpointId').val();
            
            $('#hidViewpointId').val($('#txtViewpointId').val());
            objViewpointEN.createDate = clsPubFun4Web.getNowDate_ymd();
            this.PutDataToViewpointClass(objViewpointEN);
            try {
                const responseText = await Viewpoint_IsExistAsync(objViewpointEN.viewpointId);
                var bolIsExist: boolean = responseText;
                if (bolIsExist == true) {
                    var strMsg: string = `添加记录时，关键字：${objViewpointEN.viewpointId}已经存在！`;
                    alert(strMsg);
                    return responseText;//一定要有一个返回值，否则会出错！
                }
                //const responseText2 = await Viewpoint_AddNewRecordWithMaxIdAsync(objViewpointEN);
                const responseText2 = await Viewpoint_AddNewRecordAsync(objViewpointEN);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {

                    //执行之前需要判断是否有引用 ;有就添加论文、没有就添加附件；
                    //  if ($("#txtPaperId").val() == "") {
                    //添加成功，则执行附件添加方法；
                    //判断是否有返回的附件路径值
                    if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                        var fileOne = $("#hdnFileOne").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                    }
                    else {
                        if ($("#hdnFileTwo").val() != "") {
                            var fileTwo = $("#hdnFileTwo").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            if ($("#hdnFileThree").val() != "") {
                                var fileThree = $("#hdnFileThree").val();
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                            }
                        }

                    }
                    // }
                    //else {
                    //    //1.这里执行添加观点引用论文；
                    //    var objclsViewpointCitationEN: clsViewpointCitationEN = new clsViewpointCitationEN();
                    //    this.PutDataToclsViewpointCitationClass(objclsViewpointCitationEN);
                    //    //引用论文；
                    //    const responseText3 = await ViewpointCitation_AddNewRecordAsync(objclsViewpointCitationEN);
                    //    var returnBool: boolean = !!responseText3;

                    //    if (returnBool == true) {

                    //        //添加成功，则执行附件添加方法；
                    //        //判断是否有返回的附件路径值
                    //        if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    //            var fileOne = $("#hdnFileOne").val();
                    //            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                    //        }
                    //        else {
                    //            if ($("#hdnFileTwo").val() != "") {
                    //                var fileTwo = $("#hdnFileTwo").val();
                    //                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    //            }
                    //            else {
                    //                if ($("#hdnFileThree").val() != "") {
                    //                    var fileThree = $("#hdnFileThree").val();
                    //                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                    //                }
                    //            }

                    //        }


                    //    }
                    //    else {

                    //    }

                    //}




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
        }
        else {
            var strInfo: string = `获取最大关键字为空，不成功!`;
            //显示信息框
            alert(strInfo);

        }


        return true;//一定要有一个返回值，否则会出错！
    }


    /* 函数功能:把界面上的属性数据传到类对象中
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
<param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
*/
    public PutDataToclsViewpointCitationClass(pobjViewpointCitationEN: clsViewpointCitationEN) {

        var strPaperId = $("#txtPaperId").val();
        var strViewpointId = $("#txtViewpointId").val();
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        pobjViewpointCitationEN.paperId = strPaperId;// 论文编号
        pobjViewpointCitationEN.viewpointId = strViewpointId;// 观点Id
        pobjViewpointCitationEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjViewpointCitationEN.updUserId = strUserId;// 修改用户Id// 修改用户Id
        //pobjRTViewpointRelaEN.memo = this.memo;// 备注
    }


    //////////////////////////////////////////////////////////////////////附件添加
    //添加上传论文附件方法
    public async AddNewRecordobjPaperSubAttachmentENSave(filePath: string, strfileNum: string) {
        var objViewpointAttachmentEN: clsViewpointAttachmentEN = new clsViewpointAttachmentEN();
        this.PutDataToPaperAttachmentClass(objViewpointAttachmentEN, filePath);
        try {
            const responseText2 = await ViewpointAttachment_AddNewRecordAsync(objViewpointAttachmentEN);
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
    public PutDataToPaperAttachmentClass(pobjViewpointAttachmentEN: clsViewpointAttachmentEN, filePath: string) {
        pobjViewpointAttachmentEN.viewpointId = $("#txtViewpointId").val();// 观点Id

        var strfilePath = filePath;
        //判断地址不为空则执行截取操作
        if (strfilePath != "") {
            var index = strfilePath.lastIndexOf("\/");
            strfilePath = strfilePath.substring(index + 1, strfilePath.length);
            pobjViewpointAttachmentEN.filePath = filePath;

            pobjViewpointAttachmentEN.viewpointAttachmentName = strfilePath;
        }
        pobjViewpointAttachmentEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjViewpointAttachmentEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();//教学班
        pobjViewpointAttachmentEN.updUserId = clsPubSessionStorage.GetSession_UserId();// 修改用户Id


    }

    ////////////////////////////////////////////////修改时的方法
    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public UpdateRecordSave(): Promise<boolean> {
        this.DivName = "divUpdateRecordSave";
        var objViewpointEN: clsViewpointEN = new clsViewpointEN();
        objViewpointEN.viewpointId = this.KeyId;
        $('#hidViewpointId').val(this.KeyId);
        this.PutDataToViewpointClass(objViewpointEN);
        objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Viewpoint_UpdateRecordAsync(objViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        ////判断引用的论文ID是否为空
                        //var strPaperId = $("#txtPaperId").val();
                        //if (strPaperId != "") {
                        //    //，如果不为空，根据Id删除引用文件
                        //    var strwhere = "viewpointId ='" + objViewpointEN.viewpointId + "'";
                        //    this.DelRecordViewpointCitationByWhere(strwhere);

                        //}
                        //else {

                        //如果等于空，那么就去判断附件是否为空；
                        //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                        if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            //根据Id删除附件
                            var strwhere = "viewpointId ='" + objViewpointEN.viewpointId + "'";
                            this.DelRecordByWhere(strwhere);

                        }
                        //  }




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

    //添加历史版本
    public async AddVersionRecordSave() {
        this.DivName = "divUpdateRecordSave";
        var objViewpointVEN: clsViewpointVEN = new clsViewpointVEN();
        objViewpointVEN.viewpointId = this.viewpointId;
        this.PutDataToViewpointVClass(objViewpointVEN);

        try {
            const responseText2 = await ViewpointV_AddNewRecordAsync(objViewpointVEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                var strWhereCond2 = " 1 =1 and viewpointId=" + this.viewpointId;
                var intVersionCount = await ViewpointV_GetRecCountByCondAsync(strWhereCond2);


                var objViewpointEN: clsViewpointEN = new clsViewpointEN();
                objViewpointEN.viewpointId = this.viewpointId;
                objViewpointEN.versionCount = intVersionCount;


                objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                    throw "关键字不能为空!";
                }


                const responseText = Viewpoint_UpdateRecordAsync(objViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        return true;
                    }
                    else {
                        var strInfo: string = `添加历史版本数不成功!`;
                        alert(strInfo);
                        console.log("添加历史版本数不成功");
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


    //删除附件
    public DelRecordViewpointCitationByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = ViewpointCitation_DelViewpointCitationsByCondAsync(strWhere).then((jsonData) => {
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
                    //清除后、添加新的论文数据；
                    this.AddNewRecordViewpointCitationSave();

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
    //添加引用论文
    public async AddNewRecordViewpointCitationSave() {
        //1.这里执行添加观点引用论文；
        var objclsViewpointCitationEN: clsViewpointCitationEN = new clsViewpointCitationEN();
        this.PutDataToclsViewpointCitationClass(objclsViewpointCitationEN);
        //引用论文；
        const responseText3 = await ViewpointCitation_AddNewRecordAsync(objclsViewpointCitationEN);
        var returnBool: boolean = !!responseText3;

        if (returnBool == true) {

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
                const responseText = ViewpointAttachment_DelViewpointAttachmentsByCondAsync(strWhere).then((jsonData) => {
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


    ////////////////////////////////////////////////////////////////////////////////// 添加主题关系部分

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_ResearchTopic() {
        var strListDiv: string = this.mstrListdivTopicDataLst;
        var strWhereCond = this.CombineResearchTopicCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrResearchTopicObjLst: Array<clsResearchTopicEN> = [];
        try {
            const responseRecCount = await ResearchTopic_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortResearchTopicBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await ResearchTopic_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrResearchTopicObjLst = <Array<clsResearchTopicEN>>jsonData;
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

    /* 显示ResearchTopic对象的所有属性值
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
   <param name = "divContainer">显示容器</param>
   <param name = "arrResearchTopicObjLst">需要绑定的对象列表</param>
 */
    public BindTab_ResearchTopic(divContainer: string, arrResearchTopicObjLst: Array<clsResearchTopicEN>) {
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
                //{
                //    FldName: "topicProposePeople",
                //    ColHeader: "主题提出人",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "orderNum",
                //    ColHeader: "序号",
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

    /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
    public CombineResearchTopicCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'

        var strViewpointId = $('#hidViewpointId').val();//观点
        var strTopicId = $("#hidTopicId").val();//主题
        var strUserId = $("#hidUserId").val();

        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.TopicName_q != "") {
            //    strWhereCond += ` And ${clsResearchTopicEN.con_TopicName} like '% ${this.TopicName_q}%'`;
            //}
            //if (this.TopicProposePeople_q != "") {
            //    strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} like '% ${this.TopicProposePeople_q}%'`;
            //}
            //排除获取已存在的关系数据 根据当前用户；
            strWhereCond += ` And topicId not in (select topicId from RTViewpointRela where viewpointId = '${strViewpointId}' And updUser = '${strUserId}')`;
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineResearchTopicCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    //添加主题关系 展示主题列表数据
    public async btnAddRela_Click() {
        const responseObjList = await this.BindGv_ResearchTopic();
    }
    //确定选择的主题 并添加到关系表中
    public btnOkInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidTopicId").val(strkeyId)
        //执行添加关系方法
        this.AddNewRecordSaveViewpointRela();
    }
    /* 添加新记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 */
    public async AddNewRecordSaveViewpointRela() {
        var strViewpointId = $('#hidViewpointId').val();//观点
        var strTopicId = $("#hidTopicId").val();//主题
        var strUserId = $("#hidUserId").val();
        var objRTViewpointRelaEN: clsRTViewpointRelaEN = new clsRTViewpointRelaEN();
        this.PutDataToRTViewpointRelaClass(objRTViewpointRelaEN);

        try {
            //同一主题 同一观点 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId + "'";
            //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
            const responseText = await RTViewpointRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一观点不能重复添加同一个主题！`;
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
                window.location.href = "../GraduateEdu/ViewpointAdd?TopicRelaId=" + strViewpointId;
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

        var strViewpointId = $("#hidViewpointId").val();
        var strTopicId = $("#hidTopicId").val();
        var strUserId = $("#hidUserId").val();
        pobjRTViewpointRelaEN.topicId = strTopicId;// 主题编号
        pobjRTViewpointRelaEN.viewpointId = strViewpointId;// 观点Id
        pobjRTViewpointRelaEN.proposePeople = strUserId;// 提出人
        pobjRTViewpointRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjRTViewpointRelaEN.updUser = strUserId;// 修改用户Id// 修改用户Id
        //pobjRTViewpointRelaEN.memo = this.memo;// 备注
    }
    /* 函数功能:从界面列表中根据某一个字段排序
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
    <param name = "strSortByFld">排序的字段</param>
  */
    //public async SortBy(strSortByFld: string) {
    //    if (this.hidSortResearchTopicBy.indexOf(strSortByFld) >= 0) {
    //        if (this.hidSortResearchTopicBy.indexOf("Asc") >= 0) {
    //            this.hidSortResearchTopicBy = `${strSortByFld} Desc`;
    //        }
    //        else {
    //            this.hidSortResearchTopicBy = `${strSortByFld} Asc`;
    //        }
    //    }
    //    else {
    //        this.hidSortResearchTopicBy = `${strSortByFld} Asc`;
    //    }
    //    const responseText2 = await this.BindGv_ResearchTopic();
    //}
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

    /* 函数功能:在数据 列表中跳转到某一页
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
<param name = "intPageIndex">页序号</param>
*/
    public IndexPageOne(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        this.BindGv_ResearchTopic();
    }


    ///////////////////////////////////////////////////////论文列表部分
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
    public get UserId_q(): string {
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
            if (this.UserId_q != "" && this.UserId_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_UpdUser} = '${this.UserId_q}'`;
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
                //{
                //    FldName: "literatureSources",
                //    ColHeader: "文献来源",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
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
                //{
                //    FldName: "pcount",
                //    ColHeader: "读写数",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "attachmentCount",
                //    ColHeader: "附件数",
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



    //选择论文

    //添加用户关系
    public async selectPaper_Click() {

        const responseObjList = await this.BindGv_vPaper();
    }
    //查询论列表
    public async btnPaperQuery_Click() {
        const responseObjList = await this.BindGv_vPaper();
    }
    ////查询用户数据
    //public async btnUserQuery_Click() {
    //    const responseObjList = await this.BindGv_vPaper();
    //}
    //确定选择的论文 并添加到关系表中
    public btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)
        $("#txtPaperId").val(strkeyId);
        //设置只读属性；
        $("#txtPaperId").attr("disabled", "disabled");
        //关闭列表
        HideDialogThree();

    }
    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.viewpointId = "";
        this.viewpointName = "";
        this.viewpointContent = "";
        $('#ddlViewpointTypeId option[0]').attr("selected", true);
        this.reason = "";
        this.source = "";
        this.vpProposePeople = "";
        this.updDate = "";
        this.updUser = "";
        this.memo = "";
        this.paperId = "";

        $("#hdnFileOne").val("");
        $("#hdnFileTwo").val("");
        $("#hdnFileThree").val("");
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

    /*取消论文
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async CancelSubmitRecordSave(strKeyId: string) {
        //this.DivName = "divUpdateRecordSave";
        var objViewpointEN: clsViewpointEN = new clsViewpointEN();
        objViewpointEN.viewpointId = strKeyId;
        objViewpointEN.isSubmit = false;
        //objPaperEN..submitter = $("#hidUserId").val();//提交人；
        objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
            throw "关键字不能为空!";
        }

        try {
            const responseText = Viewpoint_UpdateRecordAsync(objViewpointEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {
                    var strInfo: string = `取消成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);

                    //HideDialog();
                    this.BindGv_vViewpoint();
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
    public get UserName_q(): string {
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
        return $("#ddlViewPointUserId_q").val();
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