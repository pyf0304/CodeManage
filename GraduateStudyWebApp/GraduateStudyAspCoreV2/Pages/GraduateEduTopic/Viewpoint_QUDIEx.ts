
//import { clsvQxUserRoleRelationEN } from "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js";
//import { stuUserLoginInfo } from "../TS/FunClass/stuUserLoginInfo.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js";
import { clsViewpointAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js";
import { clsViewpointCitationEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointCitationEN.js";
import { clsViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { BindDdl_ObjLst, BindTab_V, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
//import { clsvPaperExWApi } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperExWApi.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js";
//import { clsvViewpointExWApi } from "../TS/L3_ForWApiEx/GraduateEdu/clsvViewpointExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";

import { Public_Viewpoint } from "../GraduateEduPublicPage/Public_Viewpoint.js";
import { Pub_PaperList } from "../GraduateEduPublicPage/Pub_PaperList.js";
import { Pub_ResearchTopicList } from "../GraduateEduPublicPage/Pub_ResearchTopicList.js";
import { ViewpointCRUD } from "../PagesBase/GraduateEduTopic/ViewpointCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsViewpointVerEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointVerEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { SysComment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js";
import { RTViewpointRela_AddNewRecordAsync, RTViewpointRela_GetRecCountByCondAsync, RTViewpointRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js";
import { ViewpointAttachment_AddNewRecordAsync, ViewpointAttachment_DelViewpointAttachmentsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js";
import { ViewpointCitation_AddNewRecordAsync, ViewpointCitation_DelViewpointCitationsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointCitationWApi.js";
import { ViewpointVer_DelViewpointVersAsync, ViewpointVer_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointVerWApi.js";
import { Viewpoint_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js";
import { vViewpoint_GetObjLstAsync, vViewpoint_GetObjLstByPagerAsync, vViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { ViewpointType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { Viewpoint_DetailEx } from "./Viewpoint_DetailEx.js";
import { Viewpoint_EditEx } from "./Viewpoint_EditEx.js";
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
export class Viewpoint_QUDIEx extends ViewpointCRUD implements IShowList {
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

    BindGv(strType: string, strPara: string) {
        this.BindGv_vViewpoint();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vViewpoint":
                alert('该类没有绑定该函数：[this.BindGv_vViewpoint_Cache]！');
                //this.BindGv_vViewpoint_Cache();
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
        let objPage: Viewpoint_QUDIEx;
        if (ViewpointCRUD.objPage_CRUD == null) {
            ViewpointCRUD.objPage_CRUD = new Viewpoint_QUDIEx();
            objPage = <Viewpoint_QUDIEx>ViewpointCRUD.objPage_CRUD;
        }
        else {
            objPage = <Viewpoint_QUDIEx>ViewpointCRUD.objPage_CRUD;
        }
        const objPage_Edit: Viewpoint_EditEx = new Viewpoint_EditEx(objPage);
        const objPage_Detail: Viewpoint_DetailEx = new Viewpoint_DetailEx(objPage);
        let strMsg = '';
        const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
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
            case "UpdateRecordInTab":            //修改记录InTab
                strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
                if (IsNullOrEmpty(strKeyId) == true) {
                    const strMsg = "请选择需要修改的记录！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if (strCommandName == "UpdateRecordInTab") {
                    objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                }
                else {
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                }
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
            case "DetailInTab":   //删除记录InTab 

                objPage_Detail.btnDetailRecordInTab_Click(strKeyId);
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
                strMsg = '命令:' + strCommandName + "在函数(Viewpoint_QUDIExEx.btn_Click)中没有被处理！";
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
            if (clsPublocalStorage.userId != "") {

                //首次加载默认个人观点
                var strViewType = "01";
                $("#hidViewType").val(strViewType);

                ////读取session角色 来判断绑定不同数据列表
                //if (clsPublocalStorage.roleId == "00620001") {

                //    $("#btnDelRecord").show();
                //}
                //else {
                //    //学生00620003 教师 
                //    $("#btnDelRecord").hide();

                //}
                $("#hidUserId").val(clsPublocalStorage.userId);


                //1、为下拉框设置数据源,绑定列表数据
                const ddl_ViewpointTypeId = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId");
                const ddl_ViewpointTypeId_q = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId_q");
                ViewpointCRUD.sortvViewpointBy = "updDate Desc";
                
                //论文用户下拉框绑定
                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//观点查询区域
                const ddl_UserId_q = await clsDropDownList.BindDdl_UserIdInvViewpoint_Cache("ddlViewPointUserId_q", objUsers_Cond); // this.BindDdl_UserId("ddlUserId_q");

                //var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//论文查询区域
                const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域

                //文献类型；
                const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                //论文
                this.hidSortvRTPaperRelaBy = "updDate Desc";

                //var strWhereCond = await this.CombinevViewpointCondition();
                //const responseText = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                
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
                    BindDdl_ObjLst(ddlViewpointTypeId, arrViewpointTypeObjLst, clsViewpointTypeEN.con_ViewpointTypeId, clsViewpointTypeEN.con_ViewpointTypeName, "观点类型");
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
                var arrViewpointVObjLst: Array<clsViewpointVerEN> = [];
                const responseText1 = await ViewpointVer_GetObjLstAsync(strViewpointVWhereCond).then((jsonData) => {
                    arrViewpointVObjLst = <Array<clsViewpointVerEN>>jsonData;
                });
                var arrSelectedKeys: Array<string> =
                    arrViewpointVObjLst.map((x) => {
                        var strId = x.viewpointVId.toString();
                        //var strKey = strId.substring(3);
                        return strId;
                    });

                //更新总表3个参数 主键、子表类型、页面操作类型；
                var strSubViewpointId = strKeyId;
                const responseText7 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSubViewpointId, "04", "3", clsPublocalStorage.id_CurrEduCls);
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
                const responseText = ViewpointVer_DelViewpointVersAsync(arrViewpointVId).then((jsonData) => {
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
    public async btnQuery_Click() {
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


    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vViewpoint() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevViewpointCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        try {
            this.recCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: ViewpointCRUD.sortvViewpointBy,
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


            if (this.recCount >= 10) {
                $("#divPager1").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }


            ////换行符
            //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            ////动态显示对应的数据
            //var strhtml = "";
            //var strUserId = clsPublocalStorage.userId;
            //var strRoleId = clsPublocalStorage.roleId;
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
    //                BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvViewpointEN.con_UpdUser, clsvViewpointEN.con_UserName, "编辑用户");
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
    public async CombinevViewpointCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.viewpointName_q != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
            }
            if (this.viewpointTypeId_q != "" && this.viewpointTypeId_q != "0") {
                strWhereCond += ` And ${clsvViewpointEN.con_ViewpointTypeId} = '${this.viewpointTypeId_q}'`;
            }
            //if (this.Reason_q != "") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_Reason} like '% ${this.Reason_q}%'`;
            //}
            //if (this.userName_q != "") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_UserName} like '% ${this.userName_q}%'`;
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
                $("#btnDelRecord").hide();
                $("#btnCancelSubmit").show();
                ////可以查看所有；
                ////strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "') or updUser='" + strUserId + "'";
                ////strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "')";
                //strWhereCond += ` And ${clsvViewpointEN.con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;
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
                {
                    fldName: "reason",
                    colHeader: "理由",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "source",
                    colHeader: "来源",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "vpProposePeople",
                    colHeader: "观点提出人",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                {
                    fldName: "isSubmit",
                    colHeader: "是否提交",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "用户",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                {
                    fldName: "",
                    colHeader: "详情",
                    text: "详情", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        BindTab_V(o, arrvViewpointObjLst, arrDataColumn, "viewpointId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

   





    /* 函数功能:把界面上的属性数据传到类对象中
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
<param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
*/
    public PutDataToclsViewpointCitationClass(pobjViewpointCitationEN: clsViewpointCitationEN) {

        var strPaperId = $("#txtPaperId").val();
        var strViewpointId = $("#txtViewpointId").val();
        var strUserId = clsPublocalStorage.userId;
        pobjViewpointCitationEN.SetPaperId(strPaperId);// 论文编号
        pobjViewpointCitationEN.SetViewpointId(strViewpointId);// 观点Id
        pobjViewpointCitationEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjViewpointCitationEN.SetUpdUserId(strUserId);// 修改用户Id// 修改用户Id
        //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
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
        pobjViewpointAttachmentEN.SetViewpointId($("#txtViewpointId").val());// 观点Id

        var strfilePath = filePath;
        //判断地址不为空则执行截取操作
        if (strfilePath != "") {
            var index = strfilePath.lastIndexOf("\/");
            strfilePath = strfilePath.substring(index + 1, strfilePath.length);
            pobjViewpointAttachmentEN.SetFilePath(filePath);

            pobjViewpointAttachmentEN.SetViewpointAttachmentName(strfilePath);
        }
        pobjViewpointAttachmentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjViewpointAttachmentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班
        pobjViewpointAttachmentEN.SetUpdUserId(clsPublocalStorage.userId);// 修改用户Id


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


    /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
    public async CombineResearchTopicCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'

        var strViewpointId = $('#hidViewpointId').val();//观点
        var strTopicId = clsPrivateSessionStorage.topicId;//主题
        var strUserId = clsPublocalStorage.userId;

        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.topicName_q != "") {
            //    strWhereCond += ` And ${clsResearchTopicEN.con_TopicName} like '% ${this.topicName_q}%'`;
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
        const objPage_ResearchTopic = new Pub_ResearchTopicList();
        await objPage_ResearchTopic.Page_Load();
        //await objPage_ResearchTopic.BindGv_ResearchTopic();
    }
    //确定选择的主题 并添加到关系表中
    public btnOkInTab_Click(strkeyId: string) {
        //存放Id
        clsPrivateSessionStorage.topicId = strkeyId;
        //执行添加关系方法
        this.AddNewRecordSaveViewpointRela();
    }
    /* 添加新记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 */
    public async AddNewRecordSaveViewpointRela() {
        var strViewpointId = $('#hidViewpointId').val();//观点
        var strTopicId = clsPrivateSessionStorage.topicId;//主题
        var strUserId = clsPublocalStorage.userId;
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
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strUserId = clsPublocalStorage.userId;
        pobjRTViewpointRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTViewpointRelaEN.SetViewpointId(strViewpointId);// 观点Id
        pobjRTViewpointRelaEN.SetProposePeople(strUserId);// 提出人
        pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTViewpointRelaEN.SetUpdUser(strUserId);// 修改用户Id// 修改用户Id
        //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
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
   * 论文标题
  */
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
    }
    ///////////////////////论文列表条件
    public get userId_q(): string {
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
            if (this.userId_q != "" && this.userId_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.userId_q}'`;
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

    

    //选择论文

    //添加用户关系
    public async selectPaper_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.Page_Load();
         //await objPage_Paper.BindGv_vPaper();
    }
    //查询论列表
    public async btnPaperQuery_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.Page_Load();
         //await objPage_Paper.BindGv_vPaper();
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

    /*取消论文
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async CancelSubmitRecordSave(strKeyId: string) {
        const strThisFuncName = this.CancelSubmitRecordSave.name;

        //
        var objViewpointEN: clsViewpointEN = new clsViewpointEN();
        objViewpointEN.SetViewpointId(strKeyId);
        objViewpointEN.SetIsSubmit(false);
        //objPaperEN..submitter = clsPublocalStorage.userId;//提交人；
        objViewpointEN.sfUpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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

}