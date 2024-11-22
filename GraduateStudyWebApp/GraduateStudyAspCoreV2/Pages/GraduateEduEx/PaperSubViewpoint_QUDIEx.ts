
import { PaperSubViewpoint_EditEx } from "../GraduateEduPaper/PaperSubViewpoint_EditEx.js";
import { PaperSubViewpointCRUD } from "../PagesBase/GraduateEduPaper/PaperSubViewpointCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperDownloadLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js";
import { clsPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";
import { clsPaperSubAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js";
import { clsPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js";
import { clsSectionEN } from "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsvPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js";
import { clsvPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { clsExplainTypeEN } from "../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js";
import { clsSubViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js";
import { PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { PaperDownloadLog_AddNewRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js";
import { PaperSubAttachment_DelPaperSubAttachmentsByCondAsync, PaperSubAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js";
import { PaperSubViewpoint_DownMoveAsync, PaperSubViewpoint_ReOrderAsync, PaperSubViewpoint_UpdateRecordAsync, PaperSubViewpoint_UpMoveAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js";
import { Section_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js";
import { vPaperReadWrite_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { vPaperSubViewpoint_GetObjLstByPagerAsync, vPaperSubViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { ExplainType_GetObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js";
import { SubViewpointType_GetObjLstAsync, SubViewpointType_GetObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js";
import { PaperSubViewpointEx_DelRecordAsyncEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsPaperSubViewpointExWApi.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindDdl_ObjLst } from "../TS/PubFun/clsCommFunc4Web.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsOrderByData } from "../TS/PubFun/clsOrderByData.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { Paper_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialog3(): void;
//declare function tbody(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var strAddressAndPort;
declare function doDownLoad(filepath, filename): void;

declare var $;
declare var window;
/* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class PaperSubViewpoint_QUDIEx extends PaperSubViewpointCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 50;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_vPaperSubViewpoint();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vPaperSubViewpoint":
                //alert('该类没有绑定该函数：[this.BindGv_vPaperSubViewpoint_Cache]！');
                this.btnReOrder_Click();
                this.BindGv_vPaperSubViewpoint();
                //this.BindGv_vPaperSubViewpoint_Cache();
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
        let objPage: PaperSubViewpoint_QUDIEx;
        if (PaperSubViewpointCRUD.objPage_CRUD == null) {
            PaperSubViewpointCRUD.objPage_CRUD = new PaperSubViewpoint_QUDIEx();
            objPage = <PaperSubViewpoint_QUDIEx>PaperSubViewpointCRUD.objPage_CRUD;
        }
        else {
            objPage = <PaperSubViewpoint_QUDIEx>PaperSubViewpointCRUD.objPage_CRUD;
        }
        const objPage_Edit: PaperSubViewpoint_EditEx = new PaperSubViewpoint_EditEx(objPage);
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
                strMsg = '命令:' + strCommandName + "在函数(PaperSubViewpointCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }



    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            if (strUserId != "") {
                //1、为下拉框设置数据源,绑定列表数据
                var strWhereCond1 = this.CombinevPaperSubViewpointCondition1();
                var objvPaperReadWrite: clsvPaperReadWriteEN = new clsvPaperReadWriteEN;
                const responseObjLst = await vPaperReadWrite_GetFirstObjAsync(strWhereCond1).then((jsonData) => {
                    objvPaperReadWrite = <clsvPaperReadWriteEN>jsonData;
                });

                const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId", objvPaperReadWrite.paperId);
                const ddl_SectionId_q = await this.BindDdl_SectionId("ddlSectionId_q", objvPaperReadWrite.paperId);

                const ddl_SubViewpointTypeId_q = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId_q");
                //const ddl_ExplainTypeId_q = await this.BindDdl_ExplainTypeId("ddlExplainTypeId_q");
                const ddl_SubViewpointTypeId = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId");
                const ddl_ExplainTypeId = await this.BindDdl_ExplainTypeId("ddlExplainTypeId");

                //PaperSubViewpointCRUD.sortvPaperSubViewpointBy = "subViewpointTypeName Asc";

                //var strWhereCond = await this.CombinevPaperSubViewpointCondition();

                //this.recCount= await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    
                //});
                //2、显示无条件的表内容在GridView中
                const gvResult0 = await this.GetReadWriteData(objvPaperReadWrite);

                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                const gvResult = await this.BindGv_vPaperSubViewpoint();
                //tbody();

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

    //

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
                    BindDdl_ObjLst(ddlSubViewpointTypeId, arrSubViewpointTypeObjLst, clsSubViewpointTypeEN.con_SubViewpointTypeId, clsSubViewpointTypeEN.con_SubViewpointTypeName, "子观点类型");
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
    /// <summary>
    /// 为下拉框获取数据,从表:[ExplainType]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_ExplainTypeId(ddlExplainTypeId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlExplainTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlExplainTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                //const responseText = ExplainType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                const responseText = ExplainType_GetObjLst_Cache().then((jsonData) => {
                    var arrExplainTypeObjLst: Array<clsExplainTypeEN> = <Array<clsExplainTypeEN>>jsonData;
                    BindDdl_ObjLst(ddlExplainTypeId, arrExplainTypeObjLst, clsExplainTypeEN.con_ExplainTypeId, clsExplainTypeEN.con_ExplainTypeName, "说明类型");
                    console.log("完成BindDdl_ExplainTypeId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    public async DetailRecord() {

        //this.keyId = strPaperRWId;
        var strWhereCond = await this.CombinevPaperSubViewpointCondition1();
        return new Promise((resolve, reject) => {
            try {
                const responseText = vPaperReadWrite_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                    var objvPaperReadWriteEN: clsvPaperReadWriteEN = <clsvPaperReadWriteEN>jsonData;
                    this.GetReadWriteData(objvPaperReadWriteEN);
                    console.log("完成Detail!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }


    public GetReadWriteData(pobjvPaperReadWriteEN: clsvPaperReadWriteEN) {

        $("#hidPaperId").val(pobjvPaperReadWriteEN.paperId);//论文ID

        $("#txtPaperTitle").html(pobjvPaperReadWriteEN.paperTitle);//论文标题
        $("#txtKeyword").html(pobjvPaperReadWriteEN.keyword);//关键字Id
        $("#txtPeriodical").html(pobjvPaperReadWriteEN.periodical);//
        $("#txtAuthor").html(pobjvPaperReadWriteEN.author);//作者
        $("#txtResearchQuestion").html(pobjvPaperReadWriteEN.researchQuestion);//研究问题
        $("#txtPaperContent").html(pobjvPaperReadWriteEN.paperContent);//论文内容

        $("#hidIsSubmit").val(pobjvPaperReadWriteEN.isSubmit);//是否提交


        console.log($("#hidIsSubmit").val());
        //$("#txtMemo").html(pobjvPaperReadWriteEN.memo);//备注
        this.DetailRecordDownload(pobjvPaperReadWriteEN.paperId);
    }

    public async DetailRecordDownload(strPaperId: string) {

        const strThisFuncName = this.DetailRecordDownload.name;
        //this.keyId = strPaperRWId;
        var strWhereCond = " paperId ='" + strPaperId + "'";

        try {
            const objvPaperEN = await Paper_GetFirstObjAsync(strWhereCond);
            if (objvPaperEN == null) {
                const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }

            if (objvPaperEN.attachmentCount > 0) {
                $("#btnDownLoadFile").show();
                $("#lblDownLoadFile").hide();

            } else {
                $("#btnDownLoadFile").hide();
                $("#lblDownLoadFile").show();
            }

            console.log("完成Detail!");

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }

    }


    public CombinevPaperSubViewpointCondition1(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperRWId = $("#hidPaperRWId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {

            if (strPaperRWId != "") {
                strWhereCond += ` And ${clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    public CombinevPaperSubViewpointCondition2(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {

            if (this.subViewpointTypeId_q != "" && this.subViewpointTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.subViewpointTypeId_q}'`;
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
        var strPaperRWId = $("#hidPaperRWId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.sectionId_q != "" && this.sectionId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SectionId} = '${this.sectionId_q}'`;
            }
            if (strPaperRWId != "") {
                strWhereCond += ` And ${clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
            }
            if (this.subViewpointTypeId_q != "" && this.subViewpointTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.subViewpointTypeId_q}'`;
            }

            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            if (strUserId != "") {

                $("#hidUserId").val(strUserId);
                //判断角色 教师

                if (strRoleId == "00620001") {

                    //$("#btnDelRecord").show();
                }
                else if (strRoleId == "00620002") {

                    //可以查看所有；
                }
                else {

                    strWhereCond += " And updUser = '" + strUserId + "'";
                    //学生00620003
                    //只能查看自己的数据；或公开的数据；
                    //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;

                    //strWhereCond += ` And updUser = '${objvUserRoleRelation.userId}'`;
                }
            }
            else {
                window.top.location.href = "../Web/Login";
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
        var strPaperRWId = $("#hidPaperRWId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.sectionId_q != "" && this.sectionId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SectionId} = '${this.sectionId_q}'`;
            }
            if (strPaperRWId != "") {
                strWhereCond += ` And ${clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
            }

            strWhereCond += " order by orderNum Asc";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    public CombinevPaperSubViewpointCondition5(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        return strWhereCond;
    }
    public async BindGv_vPaperSubViewpoint() {
        //var strListDiv: string = this.mstrListDiv;


        var strWhereCond2 = this.CombinevPaperSubViewpointCondition2();
        var strWhereCond3 = this.CombinevPaperSubViewpointCondition3();
        var strWhereCond4 = this.CombinevPaperSubViewpointCondition4();
        var strWhereCond5 = this.CombinevPaperSubViewpointCondition5();

        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页


        var arrSectionObjLst: Array<clsSectionEN> = [];



        var arrSubViewpointTypeObjLst: Array<clsSubViewpointTypeEN> = [];

        var arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN> = [];

        var arrvPaperSubViewpointObjLst2: Array<clsvPaperSubViewpointEN> = [];

        //获取图片
        var arrPaperSubAttachmentObjLst: Array<clsPaperSubAttachmentEN> = [];
        var arrPaperSubAttachmentObjLst2: Array<clsPaperSubAttachmentEN> = [];

        try {

            //const responseText1 = Section_GetObjLstAsync(strWhereCond4).then((jsonData) => {
            //    arrSectionObjLst = <Array<clsSectionEN>>jsonData;


            //});



            const responseText2 = SubViewpointType_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrSubViewpointTypeObjLst = <Array<clsSubViewpointTypeEN>>jsonData;
            });
            this.recCount = await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond3);
            PaperSubViewpointCRUD.sortvPaperSubViewpointBy = "orderNum Asc";
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond3,
                orderBy: PaperSubViewpointCRUD.sortvPaperSubViewpointBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst3 = await vPaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperSubViewpointObjLst2 = <Array<clsvPaperSubViewpointEN>>jsonData;
            });

            const responseRecCount4 = await PaperSubAttachment_GetObjLstAsync(strWhereCond5).then((jsonData) => {
                arrPaperSubAttachmentObjLst2 = <Array<clsPaperSubAttachmentEN>>jsonData;
            });



            var strhtml = "";
            //$('#divTwo li').remove();
            var cateid: number = 0;
            var cateid_: number = 0;

            var intJ: number = 0;


            $('#tbList tr').remove();

            for (var j = 0; j < arrSubViewpointTypeObjLst.length; j++) {
                cateid++;
                intJ++;
                var fid: number = 0;
                var strsubTypeId: string = arrSubViewpointTypeObjLst[j].subViewpointTypeId;
                //先创建子模块类型
                //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';

                strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>' + cateid + '</td><td></td><td><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></td><td></td><td></td><td class="td-manage">';

                if ($("#hidIsSubmit").val() == "true") {
                    strhtml += '</td></tr>';
                } else {
                    strhtml += '<button class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click("' + strsubTypeId + '");><i class="layui-icon">&#xe642;</i>添加子栏目</button>';
                    strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnReOrder_Click("' + strsubTypeId + '")><i class="layui-icon">&#xe642;</i>重序</button>';
                    strhtml += '</td></tr>';
                }


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
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '"><td>' + cateid + '</td><td>' + arrvPaperSubViewpointObjLst[k].sectionName + '</td><td>&nbsp;&nbsp;&nbsp;&nbsp;' + intK + '.<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].rwTitle + '】' + arrvPaperSubViewpointObjLst[k].subViewpointContent + '';

                    //根据子观点id 得到附件


                    arrPaperSubAttachmentObjLst = arrPaperSubAttachmentObjLst2.filter(x => x.subViewpointId == strSubViewpointId);

                    for (var y = 0; y < arrPaperSubAttachmentObjLst.length; y++) {
                        var strAddressAndPortfull = strAddressAndPort + arrPaperSubAttachmentObjLst[y].filePath;
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" style="margin-left: 10px; " alt="" id="txtImgPath' + arrPaperSubAttachmentObjLst[y].paperSubAttachmentId + '"/>';
                    }



                    if (arrvPaperSubViewpointObjLst[k].explainContent != "") {
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].explainTypeName + '】' + arrvPaperSubViewpointObjLst[k].explainContent + '';
                    }

                    //if (arrvPaperSubViewpointObjLst[k].literatureSourcesId != "") {


                    //else {

                    //    strhtml += '</td><td><input id="txt_OrderNum' + cateid + '" type="text" class="layui-input x-sort" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click(' + strSubViewpointId + ',"txt_OrderNum' + cateid + '");></td><td>' + arrvPaperSubViewpointObjLst[k].userName + '</td><td>' + arrvPaperSubViewpointObjLst[k].updDate + '</td><td class="td-manage"><button class="layui-btn layui-btn layui-btn-xs" onclick="btnUpdateRecordInTab_Click(' + strSubViewpointId + ')"><i class="layui-icon">&#xe642;</i>编辑</button><button class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelRecordInTab_Click(' + strSubViewpointId + ')" href="javascript:;"><i class="layui-icon">&#xe640;</i>删除</button><button class="layui-btn layui-btn layui-btn-xs" onclick="btnUpMoveEx_Click(' + strSubViewpointId + ')" href="javascript:;"><i class="iconfont">&#xe6a5;</i>上移</button><button class="layui-btn layui-btn layui-btn-xs" onclick="btnDownMove_Click(' + strSubViewpointId + ')" href="javascript:;"><i class="iconfont">&#xe6a6;</i>下移</button></td></tr>';
                    //}

                    strhtml += '</td><td><input id="txt_OrderNum' + cateid + '" type="text" class="layui-input x-sort" style="width:40px;" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click("' + strSubViewpointId + '","txt_OrderNum' + cateid + '");>';
                    //上移
                    strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnUpMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '") href="javascript:;"><i class="iconfont">&#xe6a5;</i></button>';
                    //下移
                    strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnDownMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '") href="javascript:;"><i class="iconfont">&#xe6a6;</i></button>';

                    strhtml += '</td><td>' + arrvPaperSubViewpointObjLst[k].updDate + '</td><td class="td-manage">';

                    if ($("#hidIsSubmit").val() == "true") {
                        strhtml += '' + arrvPaperSubViewpointObjLst[k].okCount + '&nbsp;&nbsp;<img src="../img/vote.png" width = "20px" height = "20px" title = "点赞数" >';
                        strhtml += '&nbsp;&nbsp;评论数：<a href="#" onclick=btnShowAppraise_Click("' + strSubViewpointId + '")>' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</a>';
                        if (arrvPaperSubViewpointObjLst[k].score == null) {
                            strhtml += '&nbsp;&nbsp;评分：0'
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;评分：' + arrvPaperSubViewpointObjLst[k].score + '';
                        }

                        //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = "btnAddAppraise_Click(' + strSubViewpointId + ')" > <i class="layui-icon" >&#xe642; </i>添加评论</button >';


                    } else {
                        strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strSubViewpointId + '")><i class="layui-icon">&#xe642;</i>编辑</button>';
                        strhtml += '<button class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strSubViewpointId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i>删除</button>';


                    }






                    //if (clsPublocalStorage.userId == arrvPaperSubViewpointObjLst[k].updUser && arrvPaperSubViewpointObjLst[k].IsPublicEx == false) {


                    //} else {
                    //    if (arrvPaperSubViewpointObjLst[k].literatureSourcesId == null || arrvPaperSubViewpointObjLst[k].literatureSourcesId == "") {

                    //        strhtml += '</td><td>' + arrvPaperSubViewpointObjLst[k].orderNum + '</td><td>' + arrvPaperSubViewpointObjLst[k].userName + '</td><td>' + arrvPaperSubViewpointObjLst[k].updDate + '</td><td class="td-manage">' + arrvPaperSubViewpointObjLst[k].okCount + '&nbsp;&nbsp;<a href="#" onclick="btnAddLikeLog_Click(' + strSubViewpointId + ')"><img src="../img/vote.png" width="20px" height="20px"  title="点赞"></a>&nbsp;&nbsp;评论数：<a href="#" onclick="btnShowAppraise_Click(' + strSubViewpointId + ')">' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</a>&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick="btnAddAppraise_Click(' + strSubViewpointId + ')"><i class="layui-icon">&#xe642;</i>添加评论</button></td></tr>';
                    //    }
                    //    else {


                    strhtml += '</td></tr>';

                    //}
                    //}


                    //}

                }



            }
            //拼接；
            $("#tbList").append(strhtml);

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



    /*查询*/
    public async btnQueryEx_Click() {

        try {
            const gvResult = await this.BindGv_vPaperSubViewpoint();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    /*
   重序
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
   */
    public async btnReOrder_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = $("#hidSubViewpointTypeId").val();
        var strPaperRWId: string = $("#hidPaperRWId").val();
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_ReOrderAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `重序出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
    }




    //public async btnUpMoveEx_Click(strKeyId: string) {
    //    if (this.PreCheck4Order() == false) return;
    //    var strSubViewpointTypeId: string = this.subViewpointTypeId;
    //    var strPaperRWId: string = $("#hidPaperRWId").val();
    //    var arrKeyIds = strKeyId;

    //    try {
    //        var objOrderByData: clsOrderByData = new clsOrderByData();
    //        objOrderByData.KeyIdLst.push(arrKeyIds);
    //        var jsonObject =
    //        {
    //            "subViewpointTypeId": strSubViewpointTypeId,
    //            "paperRWId": strPaperRWId,
    //        };
    //        var jsonStr: string = JSON.stringify(jsonObject);
    //        objOrderByData.ClassificationFieldValueLst = jsonStr;
    //        const responseRederBy = await PaperSubViewpoint_UpMoveAsync(objOrderByData);
    //    }
    //    catch (e) {
    //        var strMsg: string = `上移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
    //        alert(strMsg);
    //        return;
    //    }
    //    const responseBindGv = await this.BindGv_vPaperSubViewpoint();
    //}

    /*
    上移
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
    */
    public async btnUpMove_Click() {
        if ($('#hidOrderNum').val() == 0) {
            const responseOrder = await this.btnReOrder_Click();
        }
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = $("#hidSubViewpointTypeId").val();
        var strPaperRWId: string = $("#hidPaperRWId").val();
        var arrKeyIds = $("#hidKeyId").val();
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_UpMoveAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `上移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        //var strListDiv: string = this.mstrListDiv;
        //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }


    //public async btnDownMove_Click(strKeyId: string) {
    //    if (this.PreCheck4Order() == false) return;
    //    var strSubViewpointTypeId: string = this.subViewpointTypeId;
    //    var strPaperRWId: string = $("#hidPaperRWId").val();
    //    var arrKeyIds = strKeyId;
    //    try {
    //        var objOrderByData: clsOrderByData = new clsOrderByData();
    //        //objOrderByData.KeyIdLst = arrKeyIds;
    //        objOrderByData.KeyIdLst.push(arrKeyIds);
    //        var jsonObject =
    //        {
    //            "subViewpointTypeId": strSubViewpointTypeId,
    //            "paperRWId": strPaperRWId,
    //        };
    //        var jsonStr: string = JSON.stringify(jsonObject);
    //        objOrderByData.ClassificationFieldValueLst = jsonStr;
    //        const responseRederBy = await PaperSubViewpoint_DownMoveAsync(objOrderByData);
    //    }
    //    catch (e) {
    //        var strMsg: string = `下移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
    //        alert(strMsg);
    //        return;
    //    }
    //    const responseBindGv = await this.BindGv_vPaperSubViewpoint();

    //}

    /*
    下移
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
    */
    public async btnDownMove_Click() {
        if ($('#hidOrderNum').val() == 0) {
            const responseOrder = await this.btnReOrder_Click();
        }
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = $("#hidSubViewpointTypeId").val();
        var strPaperRWId: string = $("#hidPaperRWId").val();
        var arrKeyIds = $("#hidKeyId").val();
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_DownMoveAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `下移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        //const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        //var strListDiv: string = this.mstrListDiv;
        //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /* 在数据表里修改排序记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
  */
    public async btnUpdateOrderNum_Click(strKeyId: string, strOrderNum: string) {
        const strThisFuncName = this.btnUpdateOrderNum_Click.name;
        //var lngKeyId = Number(strKeyId);

        var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
        objPaperSubViewpointEN.SetSubViewpointId(strKeyId);
        objPaperSubViewpointEN.SetOrderNum(Number($("#" + strOrderNum + "").val()));
        objPaperSubViewpointEN.sfUpdFldSetStr = objPaperSubViewpointEN.updFldString;//设置哪些字段被修改(脏字段)

        if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
            throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubViewpoint_UpdateRecordAsync(objPaperSubViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //var strInfo: string = `修改排序号成功!`;
                        //$('#lblResult44').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);
                        const responseBindGv = this.BindGv_vPaperSubViewpoint();

                    }
                    else {
                        //var strInfo: string = `修改排序号不成功!`;
                        //$('#lblResult44').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);
                        //console.log("完成UpdateRecordSave");
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
                    BindDdl_ObjLst(ddlSectionId, arrSectionObjLst, clsSectionEN.con_SectionId, clsSectionEN.con_SectionName, "论文节");
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



    /*
    * 论文读写Id
   */
    // public set paperRWId(value: string) {
    //     $("#hidPaperRWId").val(value);
    // }
    // /*
    // * 论文读写Id
    //*/
    // public get paperRWId(): string {
    //     return $("#hidPaperRWId").val();
    // }


    //添加点赞
    //public async btnAddLikeLog_Click() {
    //    //this.DivName = "divAddNewRecordSave";
    //    var objPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN();

    //    //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

    //    objPaperSubViewpointLikeLogEN.SetSubViewpointId($("#hidSubViewpointId").val();
    //    objPaperSubViewpointLikeLogEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
    //    objPaperSubViewpointLikeLogEN.SetUpdUser(clsPublocalStorage.userId;// 修改用户Id
    //    var strWhereCond = " 1 =1 and updUser='" + objPaperSubViewpointLikeLogEN.updUser + "' and subViewpointId=" + objPaperSubViewpointLikeLogEN.subViewpointId;
    //    try {
    //        const responseText = await PaperSubViewpointLikeLog_IsExistRecordAsync(strWhereCond);
    //        var bolIsExist: boolean = responseText;
    //        if (bolIsExist == true) {
    //            var strMsg: string = `您已经点赞过这条观点了，请给其他观点点赞一下吧！`;
    //            alert(strMsg);
    //            return responseText;//一定要有一个返回值，否则会出错！
    //        }

    //        const responseText2 = await PaperSubViewpointLikeLog_AddNewRecordAsync(objPaperSubViewpointLikeLogEN);
    //        var returnBool: boolean = !!responseText2;
    //        if (returnBool == true) {
    //            var strInfo: string = `点赞成功!`;
    //            $('#lblResult40').val(strInfo);
    //            //显示信息框
    //            alert(strInfo);

    //            this.BindGv_vPaperSubViewpoint();
    //        }
    //        else {
    //            var strInfo: string = `点赞不成功!`;
    //            $('#lblResult40').val(strInfo);
    //            //显示信息框
    //            alert(strInfo);
    //            this.BindGv_vPaperSubViewpoint();
    //        }
    //        return responseText2;//一定要有一个返回值，否则会出错！
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `点赞不成功,${e}.`;
    //        alert(strMsg);
    //    }

    //    return true;//一定要有一个返回值，否则会出错！
    //}


    public async btnIsDisplay_Click() {
        if (this.IsDisplay == "显示论文") {
            this.IsDisplay = "隐藏论文";
            $("#tabwucPaperReadWrite").show();
        }
        else if (this.IsDisplay == "隐藏论文") {
            this.IsDisplay = "显示论文";
            $("#tabwucPaperReadWrite").hide();
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
            //var lngKeyId = Number(strKeyId);
            const responseText = await this.DelRecord(strKeyId);
            const responseText2 = await this.BindGv_vPaperSubViewpoint();
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
    public async DelRecord(strSubViewpointId: string) {

        try {
            const returnInt = await PaperSubViewpointEx_DelRecordAsyncEx(strSubViewpointId);
            if (returnInt > 0) {

                //删除子观点时，需要同时去删除附件；
                //根据Id删除附件
                var strwhere = "subViewpointId ='" + strSubViewpointId + "'";
                this.DelAttactmentRecordByWhere(strwhere);



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

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }

    }

    /* 
根据关键字删除记录 附件
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public DelAttactmentRecordByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubAttachment_DelPaperSubAttachmentsByCondAsync(strWhere).then((jsonData) => {
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


    //下载文件
    public btnDownLoadFile_Click() {

        this.GetPaperAttachmentRecord();
        this.btnAddDownload_Click();
    }


    public GetPaperAttachmentRecord() {
        var strPapeId = $("#hidPaperId").val();
        //this.keyId = strPaperRWId;
        var strWhereCond = ` ${clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
        var arrPaperAttachmentObjLst: Array<clsPaperAttachmentEN> = [];
        try {
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

    //添加下载量
    public async btnAddDownload_Click() {
        //this.DivName = "divAddNewRecordSave";
        var objPaperDownloadLogEN: clsPaperDownloadLogEN = new clsPaperDownloadLogEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objPaperDownloadLogEN.SetPaperId($("#hidPaperId").val());
        objPaperDownloadLogEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        objPaperDownloadLogEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
        var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + objPaperDownloadLogEN.paperId;
        try {
            //const responseText = await PaperDownloadLog_IsExistRecordAsync(strWhereCond);
            //var bolIsExist: boolean = responseText;
            //if (bolIsExist == true) {
            //    //var strMsg: string = `您已经收藏过这条论文了！`;
            //    //alert(strMsg);
            //    return responseText;//一定要有一个返回值，否则会出错！
            //}

            const responseText2 = await PaperDownloadLog_AddNewRecordAsync(objPaperDownloadLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //var strInfo: string = `收藏成功!`;
                //$('#lblResult40').val(strInfo);
                ////显示信息框
                //alert(strInfo);

                //this.BindGv_vPaperSubViewpoint();
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




    /*
   * 设置上传文件
   */
    public set Uploadfile(value: string) {
        $("#txtUploadfile").val(value);
    }
    /*
    * 获取上传文件
    */
    public get Uploadfile(): string {
        return $("#txtUploadfile").val();
    }


    /*
   * 设置是否隐藏显示
   */
    public set IsDisplay(value: string) {
        $("#btnIsDisplay").html(value);
    }
    /*
    * 获取是否隐藏显示
    */
    public get IsDisplay(): string {
        return $("#btnIsDisplay").html();
    }

    /*
   移动记录序号时的预检查函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
   */
    public PreCheck4Order(): boolean {
        var strSubViewpointTypeId: string = this.SubViewpointTypeId_OrderNum;
        if (strSubViewpointTypeId == "") {
            var strMsg = `请输入subViewpointTypeId!`;
            alert(strMsg);
            return false;
        }
        var strPaperRWId: string = this.PaperRWId_OrderNum;
        if (strPaperRWId == "") {
            var strMsg = `请输入paperRWId!`;
            alert(strMsg);
            return false;
        }
        return true;
    }
    /*
   * 论文读写Id
  */
    public get paperRWId(): string {
        return $("#txtPaperRWId").val();
    }
    /*
    * paperRWId
   */
    public get PaperRWId_OrderNum(): string {
        return $("#txtPaperRWId_OrderNum").val();
    }
    /*
    * 论文读写Id
   */
    public get PaperRWId_q(): string {
        return $("#txtPaperRWId_q").val();
    }

    /*
  * subViewpointTypeId
 */
    public get SubViewpointTypeId_OrderNum(): string {
        return $("#ddlSubViewpointTypeId_OrderNum").val();
    }
}