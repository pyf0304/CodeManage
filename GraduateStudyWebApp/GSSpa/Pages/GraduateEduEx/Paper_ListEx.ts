/*-- -- -- -- -- -- -- -- -- -- --
类名:Paper_QUDI_TSEx
表名:Paper(01120535)
生成代码版本:2019.12.06.1
生成日期:2019/12/25 17:37:11
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
import { Paper_QUDI_TS } from "../GraduateEduPaper/Paper_QUDI_TS.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsgs_PaperAttentionEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
import { clsgs_PaperGroupEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperCollectionLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js";
import { clsPaperDownloadLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsvPaperCountEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperCountEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsgs_PaperTypeEN } from "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { gs_PaperAttention_AddNewRecordAsync, gs_PaperAttention_GetObjLstAsync, gs_PaperAttention_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { gs_PaperGroup_AddNewRecordWithReturnKeyAsync, gs_PaperGroup_GetFirstObjAsync, gs_PaperGroup_ReFreshCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js";
import { PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { PaperCollectionLog_AddNewRecordAsync, PaperCollectionLog_GetObjLstAsync, PaperCollectionLog_GetRecCountByCondAsync, PaperCollectionLog_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js";
import { PaperDownloadLog_AddNewRecordAsync, PaperDownloadLog_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js";
import { Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vgs_PaperAttention_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js";
import { vPaperCount_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCountWApi.js";
import { vPaper_GetObjLstByPagerAsync, vPaper_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js";
import { SysVote_AddNewRecordAsync, SysVote_GetObjLstAsync, SysVote_GetRecCountByCondAsync, SysVote_IsExistRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { gs_PaperType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js";
import { LiteratureType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { vPaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsSysPara4WebApi2 } from "../TS/PubFun/clsSysPara4WebApi2.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogOne(): void;

declare function setTextboxio(): void;

declare function doDownLoad(filepath, filename): void;
declare function layui_Alert(iconKey, strMsg): void;
declare var $;
declare var window;
/* Paper_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Paper_ListEx extends Paper_QUDI_TS {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperBy: string = "paperId";


    //专业方向
    public mstrListDivMajorDirection: string = "divMajorDirectionDataLst";

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
                //加载页面所需数据源到缓存
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                //绑定编辑文献类型

                this.hidSortvPaperBy = "updDate Desc";
                this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";


                $("#hidUserId").val(clsPubSessionStorage.GetSession_UserId());
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                const gvResult = await this.BindGv_vPaper();

                this.objPager.RecCount = this.RecCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);

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


    public async Refresh_Click() {
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
        vPaperEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEducls);
        location.reload();
    }

    public async BindDdl4QueryRegion() {

        var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
        const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域

        //var objXzMajor_Cond: clsXzMajorEN = new clsXzMajorEN();//查询区域
        //const ddl_id_XzMajor_q = await clsDropDownList.BindDdl_XzMajorInvPaper_Cache("ddlid_XzMajor_q", objXzMajor_Cond);//专业查询区域


        const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN);

        const ddl_PaperTypeId_q = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId_q");

        //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
        //const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajorNum("ddlid_XzMajor_q");
    }


    public async BindDdl_gs_PaperType_Cache(ddlgs_PaperTypeId: string) {
        var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlgs_PaperTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlgs_PaperTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }

        try {

            var arrObjLst_Sel: Array<clsgs_PaperTypeEN> = await gs_PaperType_GetObjLstAsync(strWhereCond);

            clsCommonFunc4Web.BindDdl_ObjLst(ddlgs_PaperTypeId, arrObjLst_Sel, clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN.con_PaperTypeName, "论文类型");
            console.log("完成BindDdl_gs_PaperType_Cache!");


        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }
    ////专业下拉框绑定
    //public BindDdl_id_XzMajorNum(ddlid_XzMajor: string, strWhereCond: string = "1=1") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlid_XzMajor);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = vPaperEx_GetMajorNumObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrXzMajorObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsvPaperEN.con_id_XzMajor, clsvPaperEN.con_MajorName, "专业");
    //                console.log("完成BindDdl_id_XzMajor!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}

    public async BindDdl_LiteratureTypeId_Cache(ddlLiteratureTypeId: string, objLiteratureType_Cond: clsLiteratureTypeEN) {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlLiteratureTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }

        try {

            var arrObjLst_Sel: Array<clsLiteratureTypeEN> = await LiteratureType_GetSubObjLst_Cache(objLiteratureType_Cond);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsLiteratureTypeEN.con_LiteratureTypeId]);
            clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
            console.log("完成BindDdl_LiteratureTypeId!");

        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }
    /* 查询
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async btnQuery_Click(strListDiv: string) {
        try {
            $("#divLoading").show();
            const gvResultPaper = await this.BindGv_vPaper();
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
            $("#divLoading").hide();

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    /* 所有论文
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async liAllPaper_Click(key: string) {
        try {
            const gvResultPaper = await this.BindGv_vPaper();
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    /* 本专业
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async liMajor_Click(strListDiv: string) {
        try {
            //绑定专业论文
            const gvResultMajor = await this.BindGv_vPaperMajor();
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    /* 本专业方向
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async liMajorDirection_Click(strListDiv: string) {
        try {
            //绑定方向论文
            const gvResultDirection = await this.BindGv_vPaperDirection();
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }








    //排序事件
    public async PaperSort_Click() {
        try {
            if (this.PaperSort == "1") {
                this.hidSortvPaperBy = "updDate Desc";
                const gvResult = await this.BindGv_vPaper();

            }
            else if (this.PaperSort == "2") {
                this.hidSortvPaperBy = "paperTitle Asc";
                const gvResult = await this.BindGv_vPaper();
            }
            else if (this.PaperSort == "3") {
                this.hidSortvPaperBy = "appraiseCount Desc";
                const gvResult = await this.BindGv_vPaper();
            }
            else if (this.PaperSort == "4") {
                this.hidSortvPaperBy = "score Desc";
                const gvResult = await this.BindGv_vPaper();
            }
            else if (this.PaperSort == "5") {
                this.hidSortvPaperBy = "pcount Desc";
                const gvResult = await this.BindGv_vPaper();
            }
            else if (this.PaperSort == "6") {
                this.hidSortvPaperBy = "downloadCount Desc";
                const gvResult = await this.BindGv_vPaper();
            }
            else if (this.PaperSort == "7") {
                this.hidSortvPaperBy = "okCount Desc";
                const gvResult = await this.BindGv_vPaper();
            }
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);

        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }


    }

    ////专业下拉框绑定
    //public BindDdl_id_XzMajor(ddlid_XzMajor: string, strWhereCond: string = "1=1") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlid_XzMajor);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = vPaperEx_GetMajorNumObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrXzMajorObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsvPaperEN.con_id_XzMajor, clsvPaperEN.con_MajorName, "专业");
    //                console.log("完成BindDdl_id_XzMajor!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}


    ////专业下拉框绑定
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
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperEN.con_UpdUser, clsvPaperEN.con_UserName, "编辑用户");
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
    public CombinevPaperCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

        try {
            //if ($("#hidTabPaper").val() == "1") {
            //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
            //}
            //if ($("#hidTabPaper").val() == "2") {
            //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
            //}
            if (this.PaperTitle_q != "") {
                strWhereCond += ` And ${clsvPaperEN.con_PaperTitle} like '%${this.PaperTitle_q}%'`;
            }
            if (this.UpdDate_q != "") {
                strWhereCond += ` And ${clsvPaperEN.con_UpdDate} like '%${this.UpdDate_q}%'`;
            }
            if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
            }
            if (this.User_q != "" && this.User_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_UpdUser} = '${this.User_q}'`;
            }
            //论文类型
            if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_PaperTypeId} = '${this.PaperTypeId_q}'`;
            }


            //if (this.User_q != "" && this.User_q != "0") {
            //    strWhereCond += ` And ${clsvPaperEN.con_UpdUser} = '${this.User_q}'`;
            //}
            //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
            //    strWhereCond += ` And ${clsvPaperEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;

            //    //if (this.MajorDirectionId_q != "" && this.MajorDirectionId_q != "0") {
            //    //    strWhereCond += " and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId='" + this.MajorDirectionId_q + "')";
            //    //}
            //}


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    public CombinevPaperConditionobj(): clsvPaperEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        //var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";

        var objvPaper_Cond: clsvPaperEN = new clsvPaperEN();

        //objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_id_CurrEduCls, clsPublocalStorage.Getid_CurrEduCls(), "=");
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperTitle_q != "") {
                objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_PaperTitle, this.PaperTitle_q, "like");
            }
            if (this.UpdDate_q != "") {
                objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_UpdDate, this.UpdDate_q, "like");
            }
            if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_LiteratureTypeId, this.LiteratureTypeId_q, "=");
            }
            if (this.User_q != "" && this.User_q != "0") {
                objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_UpdUser, this.User_q, "=");
            }
            //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
            //    objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");
            //}
            //论文类型
            if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_PaperTypeId, this.PaperTypeId_q, "=");
            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineUsersConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvPaper_Cond;
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




    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vPaper() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevPaperCondition();
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();

        //var strWhereCond2: string = "";
        //var objvPaper_Cond: clsvPaperEN = this.CombinevPaperConditionobj();

        ////objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");

        
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperObjLst0: Array<clsvPaperEN> = [];
        var arrvPaperObjLst: Array<clsvPaperEN> = [];
        var objPagerPara: stuPagerPara = {
            pageIndex: intCurrPageIndex,
            pageSize: this.pageSize,
            whereCond: strWhereCond,
            orderBy: this.hidSortvPaperBy,
            sortFun: (x, y) => { return 0; }
        };

        try {

            //this.RecCount = await vPaper_GetRecCountByCond_Cache(objvPaper_Cond, strid_CurrEducls);
            //console.log("完成计数!");
            //arrvPaperObjLst0 = await vPaper_GetObjLstByPager_Cache(objPagerPara, strid_CurrEducls);
            //console.log("完成对象列表获取!");


            const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            //const responseText = await vPaper_GetObjLstByPager_WA_CacheAsync(objPagerPara);
            //arrvPaperObjLst = <Array<clsvPaperEN>>responseText;

            const responseObjLst = await vPaper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperObjLst0 = <Array<clsvPaperEN>>jsonData;
            });


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvPaperObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            if (strid_CurrEducls == "00000050")//私有空间
            {
                //arrvPaperObjLst = arrvPaperObjLst0.filter(x => x.id_CurrEduCls != "00000050");

                //const gvResultPaper = await this.BindList_vPaper("1", arrvPaperObjLst);
                const gvResultPaper = await this.BindList_vPaper("1", arrvPaperObjLst0);
            }
            else {
                const gvResultPaper = await this.BindList_vPaper("1", arrvPaperObjLst0);
            }

            $("#divPager").show();
            //if (arrvPaperObjLst.length >= 10) {

            //    $("#divPager").show();
            //    this.objPager.RecCount = this.RecCount;
            //    this.objPager.pageSize = this.pageSize;
            //    this.objPager.ShowPagerV2(this, this.divName4Pager);
            //} else {
            //    $("#divPager").hide();
            //}


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定论文视图对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    //绑定个性化论文列表
    public async BindList_vPaper(strTypeId: string, arrvPaperObjLst: Array<clsvPaperEN>) {

        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        var arrPaperCollectionLogObjLst: Array<clsPaperCollectionLogEN> = [];
        var arrgs_PaperAttentionObjLst: Array<clsgs_PaperAttentionEN> = [];


        var arrvPaperCountObjLst: Array<clsvPaperCountEN> = [];
        var strhtml = "";
        var strWhereCond1 = " 1 =1 and updUser='" + $("#hidUserId").val() + "' and voteTypeId='01'";
        var strWhereCond2 = " 1 =1 and updUser='" + $("#hidUserId").val() + "'";

        //var strWhereCond3 = " 1 =1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
        var strWhereCond3 = this.CombinevPaperCondition();


        try {

            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            const responseText = await SysVote_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            });

            const responseText2 = await PaperCollectionLog_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrPaperCollectionLogObjLst = <Array<clsPaperCollectionLogEN>>jsonData;
            });

            const responseText3 = await vPaperCount_GetObjLstAsync(strWhereCond3).then((jsonData) => {
                arrvPaperCountObjLst = <Array<clsvPaperCountEN>>jsonData;
            });

            const responseText4 = await gs_PaperAttention_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrgs_PaperAttentionObjLst = <Array<clsgs_PaperAttentionEN>>jsonData;
            });


            for (var i = 0; i < arrvPaperObjLst.length; i++) {



                var objCount = arrvPaperCountObjLst.find(x => x.paperId == arrvPaperObjLst[i].paperId);//使用find必须通过if判断不能为空后才能调用属性

                if (objCount != null) {

                    strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';
                    //strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + arrvPaperObjLst[i].paperId + '">' + arrvPaperObjLst[i].paperTitle + '</a>';
                    //判断引用论文，自研论文
                    if (arrvPaperObjLst[i].paperTypeId == "02") {
                        //自研论文
                        strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(原创论文)', '../GraduateEduEx/PaperDetail?paperId=" + arrvPaperObjLst[i].paperId + "')\"><span class='text-info'>" + arrvPaperObjLst[i].paperTitle + "(" + arrvPaperObjLst[i].paperTypeName + ")</a>";

                    }
                    else {
                        strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(引用论文)', '../GraduateEduEx/PaperDetail?paperId=" + arrvPaperObjLst[i].paperId + "')\">" + arrvPaperObjLst[i].paperTitle + "(" + arrvPaperObjLst[i].paperTypeName + ")</a>";
                    }


                    //if (objCount.attachmentCount > 0) {
                    //    strhtml += "<span class=\"btn-2\" style=\"padding-left:50px;\"><a style=\"font-size:15px; color:#f98c51\" href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvPaperObjLst[i].paperId + "')\">pdf查看</a></span>";
                    //}

                    strhtml += '<span class="btn-2" style="padding-left:50px;"><a style="font-size:15px; color:#f98c51" href="#" onclick=PaperSubV_Click("' + arrvPaperObjLst[i].paperId + '")>pdf论文子观点查看</a></span>';

                    //只有自研论文才有历史版本
                    if (arrvPaperObjLst[i].paperTypeId == "02") {
                        if (arrvPaperObjLst[i].versionCount > 0 && arrvPaperObjLst[i].versionCount != null) {
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('自研论文历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvPaperObjLst[i].paperId + "&Type=10')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                        }
                    }


                    strhtml += '</h6>';
                    strhtml += '<div class="baseinfo"><span><a href="#">' + arrvPaperObjLst[i].author + '</a></span><span><a href="#">' + arrvPaperObjLst[i].literatureSources + '</a></span>';
                    strhtml += '<span>' + arrvPaperObjLst[i].periodical + '</span><em>' + arrvPaperObjLst[i].keyword + '</em>';
                    strhtml += '</div>';
                    strhtml += '<div class="abstract">' + arrvPaperObjLst[i].paperContent + '</div>';
                    strhtml += '<div class="opts"><ul class="opts-count">';
                    strhtml += '<li>评论数:<em>' + objCount.appraiseCount + '</em></li><li>综合评分:<em>' + objCount.score + '</em></li>';
                    if (objCount.teaScore != null) {
                        strhtml += '<li>教师评分:<em>' + objCount.teaScore + '</em></li>';
                    }
                    if (objCount.stuScore != null) {
                        strhtml += '<li>学生评分:<em>' + objCount.stuScore + '</em></li>';
                    }
                    strhtml += '<li>读写数:<em>' + objCount.pcount + '</em></li><li>浏览量:<em>' + arrvPaperObjLst[i].browseNumber + '</em></li>';
                    //strhtml += '<li>:<em>' + arrvPaperObjLst[i].pcount + '</em></li>';
                    var objUser = arrUsers.find(x => x.userId == arrvPaperObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<li class="date">编辑用户：' + objUser.userName + '</li><li class="date">发表日期：' + arrvPaperObjLst[i].updDate + '</li></ul>';
                    }

                    strhtml += '<ul class="opts-btn">';


                    var objAttention = arrgs_PaperAttentionObjLst.find(x => x.paperId == arrvPaperObjLst[i].paperId);

                    if (objAttention == null) {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + arrvPaperObjLst[i].paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px;"></i><b>关注</b></a></li>';

                    } else {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + arrvPaperObjLst[i].paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px; color: #1E9FFF;"></i><b>已关注</b></a></li>';

                    }

                    var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrvPaperObjLst[i].paperId);

                    //if (objLike == null) {
                    //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan" href="javascript:void(0)" onclick=btnAddVote_Click("' + arrvPaperObjLst[i].paperId + '","' + arrvPaperObjLst[i].updUser + '")><i></i>点赞</a></li>';
                    //    //console.log("null!");
                    //} else {
                    //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan_" href="javascript:void(0)" onclick=btnAddVote_Click("' + arrvPaperObjLst[i].paperId + '","' + arrvPaperObjLst[i].updUser + '")><i></i>已点赞</a></li>';
                    //    //console.log(objLike.paperId);
                    //}
                    if (objLike == null) {
                        strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + arrvPaperObjLst[i].paperId + '","' + arrvPaperObjLst[i].updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; "></i>点赞</a></li>';
                        //console.log("null!");
                    } else {
                        strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + arrvPaperObjLst[i].paperId + '","' + arrvPaperObjLst[i].updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; color: #1E9FFF;"></i>已点赞</a></li>';
                        //console.log(objLike.paperId);
                    }


                    var objCollection = arrPaperCollectionLogObjLst.find(x => x.paperId == arrvPaperObjLst[i].paperId);
                    //var objSysVoteObjLst: Array<clsvSysVoteEN> = [];
                    //objSysVoteObjLst = arrvSysVoteObjLst.filter(x => x.updUser == "2020/02/18");



                    //if (objCollection == null) {
                    //    strhtml += '<li class="btn-collect"><a class="icon-collect" href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrvPaperObjLst[i].paperId + '")><i></i><b>收藏</b></a></li>';
                    //    //console.log("null!");
                    //} else {
                    //    strhtml += '<li class="btn-collect"><a class="icon-collect_" href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrvPaperObjLst[i].paperId + '")><i></i><b>已收藏</b></a></li>';
                    //    //console.log(objCollection.paperId);
                    //}
                    if (objCollection == null) {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrvPaperObjLst[i].paperId + '")><i class="layui-icon layui-icon-rate" style="font-size: 22px; "></i><b>收藏</b></a></li>';
                        //console.log("null!");
                    } else {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrvPaperObjLst[i].paperId + '")><i class="layui-icon layui-icon-rate-solid" style="font-size: 22px; color: #1E9FFF;"></i><b>已收藏</b></a></li>';
                        //console.log(objCollection.paperId);
                    }


                    //if (objCount.attachmentCount > 0) {
                    //    strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click("' + arrvPaperObjLst[i].paperId + '")><i></i><b>点击下载</b></a></li>';
                    //} else {
                    //    strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
                    //}
                    if (objCount.attachmentCount > 0) {
                        strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile"  href="#" onclick=btnDownLoadFile_Click("' + arrvPaperObjLst[i].paperId + '")> <i class="layui-icon layui-icon-download-circle" style="font-size: 24px; "></i><b>点击下载</b></a></li>';
                    } else {
                        strhtml += '<li><a id="btnDownLoadFile" href="#" title="暂无下载文件"><i class="layui-icon layui-icon-download-circle" style="font-size: 24px; color: #1E9FFF;"></i><b>无下载文件</b></a></li>';
                    }

                }

                strhtml += '</ul></div>';

                strhtml += '</dd></dl></div>';


            }
            if (strTypeId == "1") {
                if ($("#hidTabPaper").val() == "1") {
                    $("#divDataLst").html(strhtml);
                } else {
                    $("#divCurrEduClsDataLst").html(strhtml);
                }

            } else if (strTypeId == "2") {
                $('#divDataLstMajor').html(strhtml);
            } else if (strTypeId == "3") {
                $('#divDataLstDirection').html(strhtml);
            }

            //if (strTypeId == "1") {
            //    $("#divDataLst").append(strhtml);
            //} else if (strTypeId == "2") {
            //    $('#divDataLstMajor').append(strhtml);
            //} else if (strTypeId == "3") {
            //    $('#divDataLstDirection').append(strhtml);
            //}


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }





    //绑定本专业
    public async BindGv_vPaperMajor() {
        //var strListDiv: string = this.mstrListDivMajor;
        var strWhereCond = this.CombinevPaperCondition();

        //通过登录的用户得到用户专业

        var strid_XzMajor = clsPubSessionStorage.GetSession_id_XzMajor();

        //strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where id_XzMajor= '${strid_XzMajor}')`;

        strWhereCond += " and  id_XzMajor= '" + strid_XzMajor + "'";

        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperObjLst: Array<clsvPaperEN> = [];
        try {
            //const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            //    this.RecCount = jsonData;
            //});
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: 50,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperObjLst = <Array<clsvPaperEN>>jsonData;
            });
            ////绑定方向论文
            //const gvResultDirection = await this.BindGv_vPaperDirection();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取本专业的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvPaperObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            //this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
            const gvResultPaper = await this.BindList_vPaper("2", arrvPaperObjLst);
            console.log("完成BindGv_vPaperMajor!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定本专业对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    //绑定本方向
    public async BindGv_vPaperDirection() {
        //var strListDiv: string = this.mstrListDivDirection;
        var strWhereCond = this.CombinevPaperCondition();

        //通过登录的用户得到用户专业


        var strid_XzMajor = clsPubSessionStorage.GetSession_id_XzMajor();

        strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId in (select majorDirectionId from XzMajorDirection where id_XzMajor= '${strid_XzMajor}'))`;



        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperObjLst: Array<clsvPaperEN> = [];
        try {
            //const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            //    this.RecCount = jsonData;
            //});
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: 50,
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
            var strMsg: string = `根据条件获取本方向的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvPaperObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            //this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
            const gvResultPaper = await this.BindList_vPaper("3", arrvPaperObjLst);
            console.log("完成BindGv_vPaperDirection!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定本方向对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:在数据 列表中跳转到某一页
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
   <param name = "intPageIndex">页序号</param>
 */
    public async IndexPage(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);

        const gvResult = await this.BindGv_vPaper();

        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);


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
        //this.BindGv_vXzMajorDirection();
    }

    /*
  * 修改用户Id
 */
    public set updUser(value: string) {
        $("#hidUserId").val(value);
    }
    /*
    * 修改用户Id
   */
    public get updUser(): string {
        return $("#hidUserId").val();
    }

    /*
   * 设置排序字段-相当使用ViewState功能
  */
    public set hidSortvXzMajorDirectionBy(value: string) {
        $("#hidSortvXzMajorDirectionBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvXzMajorDirectionBy(): string {
        return $("#hidSortvXzMajorDirectionBy").val();
    }

    /*
* 用户
*/
    //public get ReadUser_q(): string {
    //    return $("#txtReadUser_q").val();
    //}
    public get User_q(): string {
        return $("#ddlUserId_q").val();
    }


    public get PaperSort(): string {
        return $("#ddlPaperSort").val();
    }

    //  /*
    // * 专业流水号
    //*/
    //  public set id_XzMajor_q(value: string) {
    //      $("#ddlid_XzMajor_q").val(value);
    //  }
    //  /*
    //  * 专业流水号
    // */
    //  public get id_XzMajor_q(): string {
    //      return $("#ddlid_XzMajor_q").val();
    //  }


    /*
 * 专业方向号
*/
    // public set MajorDirectionId_q(value: string) {
    //     $("#ddlMajorDirectionId_q").val(value);
    // }
    // /*
    // * 专业方向号
    //*/
    // public get MajorDirectionId_q(): string {
    //     return $("#ddlMajorDirectionId_q").val();
    // }



    //添加关注
    public async btnAttention_Click(strPaperId: string) {
        try {
            var strUserId = clsPublocalStorage.GetUserId();

            var strWhereCond = " 1 =1 and updUser='" + strUserId + "' and paperId=" + strPaperId;

            const responseText = await gs_PaperAttention_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经关注过这条论文了，请关注其他论文！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }



            var strWhereCond1 = " updUser='" + strUserId + "' and paperGroupName='" + clsPublocalStorage.GeteduClsName() + "'";

            var objgs_PaperGroup: clsgs_PaperGroupEN = await gs_PaperGroup_GetFirstObjAsync(strWhereCond1);

            var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
            objgs_PaperAttentionEN.paperId = strPaperId;
            objgs_PaperAttentionEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
            objgs_PaperAttentionEN.updUser = strUserId;// 修改用户Id
            objgs_PaperAttentionEN.userId = strUserId;// 修改用户Id
            if (objgs_PaperGroup != null) {
                objgs_PaperAttentionEN.paperGroupId = objgs_PaperGroup.paperGroupId;
            } else {
                var objgs_PaperGroupEN: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
                objgs_PaperGroupEN.paperGroupName = clsPublocalStorage.GeteduClsName();
                objgs_PaperGroupEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
                objgs_PaperGroupEN.updUser = strUserId;// 修改用户Id

                var strPaperGroupId = await gs_PaperGroup_AddNewRecordWithReturnKeyAsync(objgs_PaperGroupEN);
                if (strPaperGroupId != "") {
                    objgs_PaperAttentionEN.paperGroupId = strPaperGroupId;
                    gs_PaperGroup_ReFreshCache(strUserId);//刷新论文组
                }
            }

            const responseText3 = await gs_PaperAttention_AddNewRecordAsync(objgs_PaperAttentionEN);
            var returnBool: boolean = !!responseText3;
            if (returnBool == true) {
                this.BindGv_vPaper();
                layui_Alert(1, "已关注！")
                vgs_PaperAttention_ReFreshThisCache(strUserId);//刷新论文关注
                //var strWhereCond3 = " paperId=" + strPaperId;
                //var intCollectionCount = await gs_PaperAttention_GetRecCountByCondAsync(strWhereCond3);
                //var objPaperEN: clsPaperEN = new clsPaperEN();
                //objPaperEN.paperId = strPaperId;
                //objPaperEN.collectionCount = intCollectionCount;

                //objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                //if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                //    throw "关键字不能为空!";
                //}
                //const responseText4 = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                //    var returnBool: boolean = jsonData;
                //    if (returnBool == true) {
                //        //const gvResult = await this.BindGv_vPaper();
                //        this.BindGv_vPaper();
                //    }
                //    else {
                //        var strInfo: string = `关注不成功!`;
                //        alert(strInfo);
                //        console.log("关注不成功");
                //    }

                //});

            }
            else {
                var strInfo: string = `关注不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return responseText3;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `关注不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }



    //添加点赞
    public async btnAddVote_Click(strPaperId: string, strUserId: string) {
        //this.DivName = "divAddNewRecordSave";
        var objSysVoteEN: clsSysVoteEN = new clsSysVoteEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objSysVoteEN.tableKey = strPaperId;
        objSysVoteEN.voteTypeId = "01";
        objSysVoteEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        objSysVoteEN.updUser = $("#hidUserId").val();// 修改用户Id
        objSysVoteEN.userId = strUserId;//被点赞用户
        objSysVoteEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();

        var strWhereCond = " 1 =1 and updUser='" + $("#hidUserId").val() + "' and tableKey=" + strPaperId;
        try {
            const responseText = await SysVote_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await SysVote_AddNewRecordAsync(objSysVoteEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {



                var strWhereCond2 = " 1=1 and voteTypeId='01' and tableKey=" + strPaperId;
                var intVoteCount = await SysVote_GetRecCountByCondAsync(strWhereCond2);

                var objPaperEN: clsPaperEN = new clsPaperEN();
                objPaperEN.paperId = strPaperId;
                objPaperEN.okCount = intVoteCount;

                objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    throw "关键字不能为空!";
                }

                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //const gvResult = await this.BindGv_vPaper();
                        this.BindGv_vPaper();
                    }
                    else {
                        var strInfo: string = `点赞不成功!`;
                        alert(strInfo);
                        console.log("点赞不成功");
                    }

                });
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


    //添加收藏
    public async btnAddCollection_Click(strPaperId: string) {

        var objPaperCollectionLogEN: clsPaperCollectionLogEN = new clsPaperCollectionLogEN();

        objPaperCollectionLogEN.paperId = strPaperId;
        objPaperCollectionLogEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        objPaperCollectionLogEN.updUser = $("#hidUserId").val();// 修改用户Id
        var strWhereCond = " updUser='" + objPaperCollectionLogEN.updUser + "' and paperId=" + strPaperId;
        try {
            const responseText = await PaperCollectionLog_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经收藏过这条论文了！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await PaperCollectionLog_AddNewRecordAsync(objPaperCollectionLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {

                var strWhereCond2 = " paperId=" + strPaperId;
                var intCollectionCount = await PaperCollectionLog_GetRecCountByCondAsync(strWhereCond2);
                var objPaperEN: clsPaperEN = new clsPaperEN();
                objPaperEN.paperId = strPaperId;
                objPaperEN.collectionCount = intCollectionCount;

                objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    throw "关键字不能为空!";
                }
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //const gvResult = await this.BindGv_vPaper();
                        this.BindGv_vPaper();
                    }
                    else {
                        var strInfo: string = `收藏不成功!`;
                        alert(strInfo);
                        console.log("收藏不成功");
                    }

                });

            }
            else {
                var strInfo: string = `收藏不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `收藏不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }


    //添加下载量
    public async btnAddDownload_Click(strPaperId: string) {
        //this.DivName = "divAddNewRecordSave";
        var objPaperDownloadLogEN: clsPaperDownloadLogEN = new clsPaperDownloadLogEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objPaperDownloadLogEN.paperId = strPaperId;
        objPaperDownloadLogEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        objPaperDownloadLogEN.updUser = $("#hidUserId").val();// 修改用户Id
        var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + strPaperId;
        try {

            const responseText2 = await PaperDownloadLog_AddNewRecordAsync(objPaperDownloadLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {

                var strWhereCond2 = " paperId=" + strPaperId;
                var intDownloadCount = await PaperDownloadLog_GetRecCountByCondAsync(strWhereCond2);
                var objPaperEN: clsPaperEN = new clsPaperEN();
                objPaperEN.paperId = strPaperId;
                objPaperEN.downloadCount = intDownloadCount;

                objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    throw "关键字不能为空!";
                }
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //const gvResult = await this.BindGv_vPaper();
                        this.BindGv_vPaper();
                    }
                    else {
                        var strInfo: string = `添加下载量不成功!`;
                        alert(strInfo);
                        console.log("添加下载量不成功");
                    }

                });
            }
            else {
                var strInfo: string = `添加下载量不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加下载量不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }

    //下载文件
    public btnDownLoadFile_Click(strPaperId: string) {

        //下载函数
        this.GetPaperAttachmentRecord(strPaperId);
        //添加下载记录
        this.btnAddDownload_Click(strPaperId);
    }

    //下载函数
    public GetPaperAttachmentRecord(strPaperId: string) {
        var strPapeId = strPaperId;
        //this.KeyId = strPaperRWId;
        var strWhereCond = ` ${clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
        var arrPaperAttachmentObjLst: Array<clsPaperAttachmentEN> = [];
        try {
            var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
            const responseText = PaperAttachment_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrPaperAttachmentObjLst = <Array<clsPaperAttachmentEN>>jsonData;
                for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {

                    var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                    doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
                }
            });
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*
* 论文类型查询
*/
    public set PaperTypeId_q(value: string) {
        $("#ddlPaperTypeId_q").val(value);
    }
    /*
    * 论文类型查询
    */
    public get PaperTypeId_q(): string {
        return $("#ddlPaperTypeId_q").val();
    }

    ////通过专业得到专业方向
    //public async selectXzMajorDirection_Click() {
    //    try {
    //        //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
    //        //var strWhereCond = " id_XzMajor='" + this.id_XzMajor_q + "'";
    //        //const ddl_MajorDirectionId = await this.BindDdl_MajorDirectionId("ddlMajorDirectionId_q", strWhereCond);

    //    }
    //    catch (e) {
    //        var strMsg: string = `获取数据有问题,${e}.`;
    //        alert(strMsg);
    //    }


    //}


    ////绑定下拉专业方向
    //public BindDdl_MajorDirectionId(ddlMajorDirectionId: string, strWhereCond: string) {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlMajorDirectionId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlMajorDirectionId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = XzMajorDirection_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrXzMajorDirectionObjLst: Array<clsXzMajorDirectionEN> = <Array<clsXzMajorDirectionEN>>jsonData;
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlMajorDirectionId, arrXzMajorDirectionObjLst, clsXzMajorDirectionEN.con_MajorDirectionId, clsXzMajorDirectionEN.con_MajorDirectionName, "专业方向");
    //                console.log("完成BindDdl_id_XzMajorDirection!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}


}