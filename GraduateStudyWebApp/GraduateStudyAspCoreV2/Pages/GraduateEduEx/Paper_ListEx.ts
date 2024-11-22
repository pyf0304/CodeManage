
import { gs_PaperAttention_EditEx } from "../GraduateEduPaper/gs_PaperAttention_EditEx.js";
import { PaperCRUD } from "../PagesBase/GraduateEduPaper/PaperCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsgs_PaperAttentionEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperCollectionLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js";
import { clsPaperDownloadLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperENEx } from "../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js";
import { clsvPaperCountEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperCountEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsgs_PaperTypeEN } from "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { XzMajorDirection_BindDdl_MajorDirectionIdByid_XzMajorInDiv_Cache, XzMajorDirection_GetObjByMajorDirectionId_Cache, XzMajorDirection_GetObjLst_Cache } from "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js";
import { gs_PaperAttention_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { PaperCollectionLog_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js";
import { PaperDownloadLog_AddNewRecordAsync, PaperDownloadLog_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js";
import { Paper_GetObjByPaperIdAsync, Paper_GetRecCountByCondAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vPaperCount_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCountWApi.js";
import { SysVote_GetObjLstAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { gs_PaperType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js";
import { LiteratureType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { PaperCollectionLogEx_btnAddCollection_Click } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperCollectionLogExWApi.js";
import { PaperEx_BindList_Paper, PaperEx_GetObjExLstByPagerAsync, PaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { SysVoteEx_btnAddVote_Click_PaperId } from "../TS/L3_ForWApiEx/InteractManage/clsSysVoteExWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { GetCheckedKeyIdsInDiv, GetSelectObjInDiv, GetSelectValueInDiv, SetSpanHtmlByIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindDdl_ObjLst } from "../TS/PubFun/clsCommFunc4Web.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { Paper_ListEx_AllPaper } from "./Paper_ListEx_AllPaper.js";
import { Paper_ListEx_CurrEduCls } from "./Paper_ListEx_CurrEduCls.js";
import { Paper_ListEx_Direction } from "./Paper_ListEx_Direction.js";
import { Paper_ListEx_Major } from "./Paper_ListEx_Major.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogOne(): void;

declare function setTextboxio(): void;

declare function doDownLoad(filepath, filename): void;
declare function layui_Alert(iconKey, strMsg): void;
declare var $;
declare var window;
/* Paper_ListEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Paper_ListEx extends PaperCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrsortPaperBy: string = "paperId";
    public static CurrTabName: string = "AllPaper";


    //专业方向
    public mstrListDivMajorDirection: string = "divMajorDirectionDataLst";

    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_Paper();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "QxUsers":
                alert('该类没有绑定该函数：[this.BindGv_QxUsers_Cache]！');
                //this.BindGv_QxUsers_Cache();
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
        let objPage: Paper_ListEx = new Paper_ListEx();
        //if (PaperCRUD.objPage_CRUD == null) {
        //    PaperCRUD.objPage_CRUD = new Paper_ListEx();
        //    objPage = <Paper_ListEx>PaperCRUD.objPage_CRUD;
        //}
        //else {
        //    objPage = <Paper_ListEx>PaperCRUD.objPage_CRUD;
        //}
        const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
        let strMsg = '';
        switch (strCommandName) {
            case "MajorDirection":    //查询记录
                objPage.liMajorDirection_Click();
                break;

            case "CurrEduCls":    //查询记录
                objPage.liCurrEduCls_Click();
                break;
            case "AllPaper":    //查询记录
                objPage.liAllPaper_Click();
                break;
            case "Major":    //查询记录
                objPage.liMajor_Click();
                break;
                
            case "AddCollection":    //查询记录
                objPage.btnAddCollection_Click(strKeyId);
                break;
            case "AddVote":    //查询记录
                objPage.btnAddVote_Click(strKeyId);
                break;
            case "AddAttention":    //查询记录
                objPage.btnAddAttention_Click(objPage, strKeyId);
                break;
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
                strMsg = '命令:' + strCommandName + "在函数(Paper_ListExEx.btn_Click)中没有被处理！";
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
            this.divName4Query = "divQuery";
            if (clsPublocalStorage.userId != "") {
                this.SetEventFunc();
                //加载页面所需数据源到缓存
                // 为查询区绑定下拉框
                await this.BindDdl4QueryRegion();
                await XzMajorDirection_BindDdl_MajorDirectionIdByid_XzMajorInDiv_Cache(this.divName4Query, "ddlMajorDirectionId_SetFldValue", clsPublocalStorage.id_XzMajor);

                //绑定编辑文献类型
                this.SetMajorDirectionName(clsPublocalStorage.id_XzMajor);
                SetSpanHtmlByIdInDiv(this.divName4List, "spnMajorName", Format("[{0}]", clsPublocalStorage.majorName));

                PaperCRUD.sortPaperBy = "updDate Desc";
                this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";

                $("#hidUserId").val(clsPublocalStorage.userId);
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                const objPage = new Paper_ListEx_AllPaper();
                await objPage.Page_Load();
                //this.objPager.recCount = this.recCount;
                //this.objPager.pageSize = this.pageSize;
                //this.objPager.ShowPagerV2(this, this.divName4Pager);

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
        var strid_CurrEducls = clsPublocalStorage.id_CurrEduCls;
        PaperEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEducls);
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

            BindDdl_ObjLst(ddlgs_PaperTypeId, arrObjLst_Sel, clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN.con_PaperTypeName, "论文类型");
            console.log("完成BindDdl_gs_PaperType_Cache!");


        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

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
            BindDdl_ObjLst(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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
    public async btnQuery_Click() {
        const strThisFuncName = this.btnQuery_Click.name;
        try {
            $("#divLoading").show();
            let objPage_Sub;
            switch (Paper_ListEx.CurrTabName) {
                case "AllPaper":
                    objPage_Sub = new Paper_ListEx_AllPaper();
                    await objPage_Sub.Page_Load();
                    break;
                case "CurrEduCls":
                    objPage_Sub = new Paper_ListEx_CurrEduCls();
                    await objPage_Sub.Page_Load();
                    break;
                case "Major":
                    objPage_Sub = new Paper_ListEx_Major();
                    await objPage_Sub.Page_Load();
                    break;
                case "Direction":
                    objPage_Sub = new Paper_ListEx_Direction();
                    await objPage_Sub.Page_Load();
                    break;
                default:
                    strMsg = '当前Tab:' + Paper_ListEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                    alert(strMsg);

                    break;
            }

            //const gvResultPaper = await this.BindGv_Paper0();
            //this.objPager.recCount = this.recCount;
            //this.objPager.pageSize = this.pageSize;
            //this.objPager.ShowPagerV2(this, this.divName4Pager);
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
    public async liAllPaper_Click() {
        try {
            Paper_ListEx.CurrTabName = "AllPaper";
            const objPage = new Paper_ListEx_AllPaper();
            await objPage.Page_Load();

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
    public async liCurrEduCls_Click() {
        try {
            Paper_ListEx.CurrTabName = "CurrEduCls";
            const objPage = new Paper_ListEx_CurrEduCls();
            await objPage.Page_Load();

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
    public async liMajor_Click() {
        try {
            Paper_ListEx.CurrTabName = "Major";
            //绑定专业论文
            const objPage = new Paper_ListEx_Major();
            objPage.Page_Load();
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
    public async liMajorDirection_Click() {
        try {
            Paper_ListEx.CurrTabName = "Direction";
            //绑定方向论文
            const objPage = new Paper_ListEx_Direction();
            objPage.Page_Load();
    
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
                PaperCRUD.sortPaperBy = "updDate Desc";
            }
            else if (this.PaperSort == "2") {
                PaperCRUD.sortPaperBy = "paperTitle Asc";
            }
            else if (this.PaperSort == "3") {
                PaperCRUD.sortPaperBy = "appraiseCount Desc";
            }
            else if (this.PaperSort == "4") {
                PaperCRUD.sortPaperBy = "score Desc";
            }
            else if (this.PaperSort == "5") {
                PaperCRUD.sortPaperBy = "pcount Desc";
            }
            else if (this.PaperSort == "6") {
                PaperCRUD.sortPaperBy = "downloadCount Desc";
            }
            else if (this.PaperSort == "7") {
                PaperCRUD.sortPaperBy = "okCount Desc";
            }
            this.btnQuery_Click();

        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }


    }



    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombinevPaperCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

        try {
            //if ($("#hidTabPaper").val() == "1") {
            //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            //}
            //if ($("#hidTabPaper").val() == "2") {
            //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            //}
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '%${this.paperTitle_q}%'`;
            }
            if (this.updDate_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_UpdDate} like '%${this.updDate_q}%'`;
            }
            if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
            }
            if (this.User_q != "" && this.User_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.User_q}'`;
            }
            //论文类型
            if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTypeId} = '${this.PaperTypeId_q}'`;
            }


            //if (this.User_q != "" && this.User_q != "0") {
            //    strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.User_q}'`;
            //}
            //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
            //    strWhereCond += ` And ${clsPaperEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;

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
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombinevPaperCondition_EduCLs(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

        try {
            //if ($("#hidTabPaper").val() == "1") {
            //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            //}
            //if ($("#hidTabPaper").val() == "2") {
            //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            //}
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '%${this.paperTitle_q}%'`;
            }
            if (this.updDate_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_UpdDate} like '%${this.updDate_q}%'`;
            }
            if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
            }
            if (this.User_q != "" && this.User_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.User_q}'`;
            }
            //论文类型
            if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTypeId} = '${this.PaperTypeId_q}'`;
            }


            //if (this.User_q != "" && this.User_q != "0") {
            //    strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.User_q}'`;
            //}
            //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
            //    strWhereCond += ` And ${clsPaperEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;

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


    public CombinevPaperConditionobj(): clsPaperEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        //var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";

        var objvPaper_Cond: clsPaperEN = new clsPaperEN();

        //objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_CurrEduCls, clsPublocalStorage.id_CurrEduCls, "=");
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle_q != "") {
                objvPaper_Cond.SetCondFldValue(clsPaperEN.con_PaperTitle, this.paperTitle_q, "like");
            }
            if (this.updDate_q != "") {
                objvPaper_Cond.SetCondFldValue(clsPaperEN.con_UpdDate, this.updDate_q, "like");
            }
            if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                objvPaper_Cond.SetCondFldValue(clsPaperEN.con_LiteratureTypeId, this.literatureTypeId_q, "=");
            }
            if (this.User_q != "" && this.User_q != "0") {
                objvPaper_Cond.SetCondFldValue(clsPaperEN.con_UpdUser, this.User_q, "=");
            }
            //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
            //    objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");
            //}
            //论文类型
            if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                objvPaper_Cond.SetCondFldValue(clsPaperEN.con_PaperTypeId, this.PaperTypeId_q, "=");
            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineUsersConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvPaper_Cond;
    }


    //  /* 修改记录
    // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
    //*/
    //  public btnUpdateRecord_Click(strKeyId: string) {
    //      this.opType = "Update";
    //      //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
    //      if (strKeyId == "") {
    //          alert("请选择需要修改的记录！");
    //          return;
    //      }
    //      this.UpdateRecord(strKeyId);
    //  }




    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vPaperBak() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevPaperCondition();
        var strid_CurrEducls = clsPublocalStorage.id_CurrEduCls;

        //var strWhereCond2: string = "";
        //var objvPaper_Cond: clsPaperEN = this.CombinevPaperConditionobj();

        ////objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");


        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvPaperObjLst0: Array<clsPaperENEx> = [];
        var arrPaperExObjLst: Array<clsPaperENEx> = [];
        var objPagerPara: stuPagerPara = {
            pageIndex: intCurrPageIndex,
            pageSize: this.pageSize,
            whereCond: strWhereCond,
            orderBy: PaperCRUD.sortPaperBy,
            sortFun: (x, y) => { return 0; }
        };

        try {

            //this.recCount = await vPaper_GetRecCountByCond_Cache(objvPaper_Cond, strid_CurrEducls);
            //console.log("完成计数!");
            //arrvPaperObjLst0 = await vPaper_GetObjLstByPager_Cache(objPagerPara, strid_CurrEducls);
            //console.log("完成对象列表获取!");


            this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond);
            //const responseText = await vPaper_GetObjLstByPager_WA_CacheAsync(objPagerPara);
            //arrPaperExObjLst = <Array<clsPaperEN>>responseText;

            arrvPaperObjLst0 = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrPaperExObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //console.error(strMsg);
        //    alert(strMsg);
        //    return;
        //}
        try {
            if (strid_CurrEducls == "00000050")//私有空间
            {
                //arrPaperExObjLst = arrvPaperObjLst0.filter(x => x.id_CurrEduCls != "00000050");

                //const gvResultPaper = await this.BindList_vPaper("1", arrPaperExObjLst);
                const gvResultPaper = await this.BindList_vPaperBak("1", arrvPaperObjLst0);
            }
            else {
                const gvResultPaper = await this.BindList_vPaperBak("1", arrvPaperObjLst0);
            }

            $("#divPager").show();
            //if (arrPaperExObjLst.length >= 10) {

            //    $("#divPager").show();
            //    this.objPager.recCount = this.recCount;
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
    public async BindGv_Paper00() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevPaperCondition();
        var strid_CurrEducls = clsPublocalStorage.id_CurrEduCls;

        //var strWhereCond2: string = "";
        //var objvPaper_Cond: clsPaperEN = this.CombinevPaperConditionobj();

        ////objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");


        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrPaperObjLst0: Array<clsPaperENEx> = [];
        var arrPaperObjLst: Array<clsPaperENEx> = [];
        var objPagerPara: stuPagerPara = {
            pageIndex: intCurrPageIndex,
            pageSize: this.pageSize,
            whereCond: strWhereCond,
            orderBy: PaperCRUD.sortPaperBy,
            sortFun: (x, y) => { return 0; }
        };

        try {

            //this.recCount = await vPaper_GetRecCountByCond_Cache(objvPaper_Cond, strid_CurrEducls);
            //console.log("完成计数!");
            //arrvPaperObjLst0 = await vPaper_GetObjLstByPager_Cache(objPagerPara, strid_CurrEducls);
            //console.log("完成对象列表获取!");


            this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond);
            //const responseText = await vPaper_GetObjLstByPager_WA_CacheAsync(objPagerPara);
            //arrPaperExObjLst = <Array<clsPaperEN>>responseText;

            arrPaperObjLst0 = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrPaperExObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //console.error(strMsg);
        //    alert(strMsg);
        //    return;
        //}
        try {
            if (strid_CurrEducls == "00000050")//私有空间
            {
                //arrPaperExObjLst = arrvPaperObjLst0.filter(x => x.id_CurrEduCls != "00000050");

                //const gvResultPaper = await this.BindList_vPaper("1", arrPaperExObjLst);
                const gvResultPaper = await PaperEx_BindList_Paper("1","", arrPaperObjLst0);
            }
            else {
                const gvResultPaper = await PaperEx_BindList_Paper("1", "", arrPaperObjLst0);
            }

            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
            $("#divPager").show();
            //if (arrPaperExObjLst.length >= 10) {

            //    $("#divPager").show();
            //    this.objPager.recCount = this.recCount;
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
    public async BindList_vPaperBak(strTypeId: string, arrPaperExObjLst: Array<clsPaperENEx>) {

        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        var arrPaperCollectionLogObjLst: Array<clsPaperCollectionLogEN> = [];
        var arrgs_PaperAttentionObjLst: Array<clsgs_PaperAttentionEN> = [];


        var arrvPaperCountObjLst: Array<clsvPaperCountEN> = [];
        var strhtml = "";
        var strWhereCond1 = " 1 =1 and updUser='" + clsPublocalStorage.userId + "' and voteTypeId='01'";
        var strWhereCond2 = " 1 =1 and updUser='" + clsPublocalStorage.userId + "'";

        //var strWhereCond3 = " 1 =1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        var strWhereCond3 = await this.CombinevPaperCondition();

        try {

            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            arrSysVoteObjLst = await SysVote_GetObjLstAsync(strWhereCond1);

            arrPaperCollectionLogObjLst = await PaperCollectionLog_GetObjLstAsync(strWhereCond2);

            arrvPaperCountObjLst = await vPaperCount_GetObjLstAsync(strWhereCond3);

            arrgs_PaperAttentionObjLst = await gs_PaperAttention_GetObjLstAsync(strWhereCond2);


            for (var i = 0; i < arrPaperExObjLst.length; i++) {
                const objvPaperEx = arrPaperExObjLst[i];


                var objCount = arrvPaperCountObjLst.find(x => x.paperId == objvPaperEx.paperId);//使用find必须通过if判断不能为空后才能调用属性

                if (objCount != null) {

                    strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';
                    //strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + objPaperEx.paperId + '">' + objPaperEx.paperTitle + '</a>';
                    //判断引用论文，自研论文
                    if (objvPaperEx.paperTypeId == "02") {
                        //自研论文
                        strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(原创论文)', '../GraduateEduEx/PaperDetail?paperId=" + objvPaperEx.paperId + "')\"><span class='text-info'>" + objvPaperEx.paperTitle + "(" + objvPaperEx.paperTypeName + ")</a>";

                    }
                    else {
                        strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(引用论文)', '../GraduateEduEx/PaperDetail?paperId=" + objvPaperEx.paperId + "')\">" + objvPaperEx.paperTitle + "(" + objvPaperEx.paperTypeName + ")</a>";
                    }


                    //if (objCount.attachmentCount > 0) {
                    //    strhtml += "<span class=\"btn-2\" style=\"padding-left:50px;\"><a style=\"font-size:15px; color:#f98c51\" href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + objPaperEx.paperId + "')\">pdf查看</a></span>";
                    //}

                    strhtml += '<span class="btn-2" style="padding-left:50px;"><a style="font-size:15px; color:#f98c51" href="#" onclick=PaperSubVer_Click("' + objvPaperEx.paperId + '")>pdf论文子观点查看</a></span>';

                    //只有自研论文才有历史版本
                    if (objvPaperEx.paperTypeId == "02") {
                        if (objvPaperEx.versionCount > 0 && objvPaperEx.versionCount != null) {
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('自研论文历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + objvPaperEx.paperId + "&Type=10')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                        }
                    }


                    strhtml += '</h6>';
                    strhtml += '<div class="baseinfo"><span><a href="#">' + objvPaperEx.author + '</a></span><span><a href="#">' + objvPaperEx.literatureSources + '</a></span>';
                    strhtml += '<span>' + objvPaperEx.periodical + '</span><em>' + objvPaperEx.keyword + '</em>';
                    strhtml += '</div>';
                    strhtml += '<div class="abstract">' + objvPaperEx.paperContent + '</div>';
                    strhtml += '<div class="opts"><ul class="opts-count">';
                    strhtml += '<li>评论数:<em>' + objCount.appraiseCount + '</em></li><li>综合评分:<em>' + objCount.score + '</em></li>';
                    if (objCount.teaScore != null) {
                        strhtml += '<li>教师评分:<em>' + objCount.teaScore + '</em></li>';
                    }
                    if (objCount.stuScore != null) {
                        strhtml += '<li>学生评分:<em>' + objCount.stuScore + '</em></li>';
                    }
                    strhtml += '<li>读写数:<em>' + objCount.pcount + '</em></li><li>浏览量:<em>' + objvPaperEx.browseNumber + '</em></li>';
                    //strhtml += '<li>:<em>' + objPaperEx.pcount + '</em></li>';
                    var objUser = arrUsers.find(x => x.userId == objvPaperEx.updUser);
                    if (objUser != null) {
                        strhtml += '<li class="date">编辑用户：' + objUser.userName + '</li><li class="date">发表日期：' + objvPaperEx.updDate + '</li></ul>';
                    }

                    strhtml += '<ul class="opts-btn">';


                    var objAttention = arrgs_PaperAttentionObjLst.find(x => x.paperId == objvPaperEx.paperId);

                    if (objAttention == null) {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + objvPaperEx.paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px;"></i><b>关注</b></a></li>';

                    } else {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + objvPaperEx.paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px; color: #1E9FFF;"></i><b>已关注</b></a></li>';

                    }

                    var objLike = arrSysVoteObjLst.find(x => x.tableKey == objvPaperEx.paperId);

                    //if (objLike == null) {
                    //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan" href="javascript:void(0)" onclick=btnAddVote_Click("' + objPaperEx.paperId + '","' + objPaperEx.updUser + '")><i></i>点赞</a></li>';
                    //    //console.log("null!");
                    //} else {
                    //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan_" href="javascript:void(0)" onclick=btnAddVote_Click("' + objPaperEx.paperId + '","' + objPaperEx.updUser + '")><i></i>已点赞</a></li>';
                    //    //console.log(objLike.paperId);
                    //}
                    if (objLike == null) {
                        strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + objvPaperEx.paperId + '","' + objvPaperEx.updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; "></i>点赞</a></li>';
                        //console.log("null!");
                    } else {
                        strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + objvPaperEx.paperId + '","' + objvPaperEx.updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; color: #1E9FFF;"></i>已点赞</a></li>';
                        //console.log(objLike.paperId);
                    }


                    var objCollection = arrPaperCollectionLogObjLst.find(x => x.paperId == objvPaperEx.paperId);
                    //var objSysVoteObjLst: Array<clsvSysVoteEN> = [];
                    //objSysVoteObjLst = arrvSysVoteObjLst.filter(x => x.updUser == "2020/02/18");



                    //if (objCollection == null) {
                    //    strhtml += '<li class="btn-collect"><a class="icon-collect" href="javascript:void(0)" onclick=btnAddCollection_Click("' + objPaperEx.paperId + '")><i></i><b>收藏</b></a></li>';
                    //    //console.log("null!");
                    //} else {
                    //    strhtml += '<li class="btn-collect"><a class="icon-collect_" href="javascript:void(0)" onclick=btnAddCollection_Click("' + objPaperEx.paperId + '")><i></i><b>已收藏</b></a></li>';
                    //    //console.log(objCollection.paperId);
                    //}
                    if (objCollection == null) {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + objvPaperEx.paperId + '")><i class="layui-icon layui-icon-rate" style="font-size: 22px; "></i><b>收藏</b></a></li>';
                        //console.log("null!");
                    } else {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + objvPaperEx.paperId + '")><i class="layui-icon layui-icon-rate-solid" style="font-size: 22px; color: #1E9FFF;"></i><b>已收藏</b></a></li>';
                        //console.log(objCollection.paperId);
                    }


                    //if (objCount.attachmentCount > 0) {
                    //    strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click("' + objPaperEx.paperId + '")><i></i><b>点击下载</b></a></li>';
                    //} else {
                    //    strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
                    //}
                    if (objCount.attachmentCount > 0) {
                        strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile"  href="#" onclick=btnDownLoadFile_Click("' + objvPaperEx.paperId + '")> <i class="layui-icon layui-icon-download-circle" style="font-size: 24px; "></i><b>点击下载</b></a></li>';
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


    /* 函数功能:在数据 列表中跳转到某一页
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
   <param name = "intPageIndex">页序号</param>
 */
    public async IndexPage(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);

        const gvResult = await this.BindGv_Paper00();

        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);


    }

    /* 函数功能:在数据 列表中跳转到某一页
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
   <param name = "intPageIndex">页序号</param>
 */
    public IndexPageOne(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
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
        return clsPublocalStorage.userId;
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
    //public get readUser_q(): string {
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

    //添加点赞
  

   

    //添加下载量
    public async btnAddDownload_Click(strPaperId: string) {
        const strThisFuncName = this.btnAddDownload_Click.name;
        //this.DivName = "divAddNewRecordSave";
        var objPaperDownloadLogEN: clsPaperDownloadLogEN = new clsPaperDownloadLogEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objPaperDownloadLogEN.SetPaperId(strPaperId);
        objPaperDownloadLogEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        objPaperDownloadLogEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
        var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + strPaperId;
        try {

            const responseText2 = await PaperDownloadLog_AddNewRecordAsync(objPaperDownloadLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {

                var strWhereCond2 = " paperId=" + strPaperId;
                var intDownloadCount = await PaperDownloadLog_GetRecCountByCondAsync(strWhereCond2);
                var objPaperEN: clsPaperEN = new clsPaperEN();
                objPaperEN.SetPaperId(strPaperId);
                objPaperEN.SetDownloadCount(intDownloadCount);

                objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }
                var returnBool = await Paper_UpdateRecordAsync(objPaperEN);

                if (returnBool == true) {
                    //const gvResult = await this.BindGv_Paper();
                    this.BindGv_Paper00();
                }
                else {
                    var strInfo: string = `添加下载量不成功!`;
                    alert(strInfo);
                    console.log("添加下载量不成功");
                }

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
    public async GetPaperAttachmentRecord(strPaperId: string) {
        var strPapeId = strPaperId;
        //this.keyId = strPaperRWId;
        var strWhereCond = ` ${clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
        var arrPaperAttachmentObjLst: Array<clsPaperAttachmentEN> = [];
        try {
            var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
            arrPaperAttachmentObjLst = await PaperAttachment_GetObjLstAsync(strWhereCond);
            for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {

                var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
            }
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


    //添加收藏
    public async btnAddAttention_Click(objPage: Paper_ListEx, strPaperId: string) {
        const strThisFuncName = this.btnAddAttention_Click.name;
        try {
            const objPage_Edit = new gs_PaperAttention_EditEx(objPage);
            const returnBool = await objPage_Edit.btnAttention_Click(strPaperId);
            let objPage_Sub;
            if (returnBool == true) {
                switch (Paper_ListEx.CurrTabName) {
                    case "AllPaper":
                        objPage_Sub = new Paper_ListEx_AllPaper();
                        await objPage_Sub.Page_Load();
                        break;
                    case "CurrEduCls":
                        objPage_Sub = new Paper_ListEx_CurrEduCls();
                        await objPage_Sub.Page_Load();
                        break;
                    case "Major":
                        objPage_Sub = new Paper_ListEx_Major();
                        await objPage_Sub.Page_Load();
                        break;
                    case "Direction":
                        objPage_Sub = new Paper_ListEx_Direction();
                        await objPage_Sub.Page_Load();
                        break;
                    default:
                        strMsg = '当前Tab:' + Paper_ListEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                        alert(strMsg);

                        break;
                }


            }
            else {
                var strInfo: string = `收藏不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return returnBool;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `关注不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }
    
    public async btnAddCollection_Click(strPaperId: string) {
        const strThisFuncName = this.btnAddAttention_Click.name;
        try {
            
            const returnBool = await PaperCollectionLogEx_btnAddCollection_Click(strPaperId, clsPublocalStorage.userId);
            let objPage_Sub;
            if (returnBool == true) {
                switch (Paper_ListEx.CurrTabName) {
                    case "AllPaper":
                        objPage_Sub = new Paper_ListEx_AllPaper();
                        await objPage_Sub.Page_Load();
                        break;
                    case "CurrEduCls":
                        objPage_Sub = new Paper_ListEx_CurrEduCls();
                        await objPage_Sub.Page_Load();
                        break;
                    case "Major":
                        objPage_Sub = new Paper_ListEx_Major();
                        await objPage_Sub.Page_Load();
                        break;
                    case "Direction":
                        objPage_Sub = new Paper_ListEx_Direction();
                        await objPage_Sub.Page_Load();
                        break;
                    default:
                        strMsg = '当前Tab:' + Paper_ListEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                        alert(strMsg);

                        break;
                }


            }
            else {
                var strInfo: string = `收藏不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return returnBool;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `关注不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }

    public async btnAddVote_Click(strPaperId: string) {
        const strThisFuncName = this.btnAddAttention_Click.name;
        try {
            const objPaper = await Paper_GetObjByPaperIdAsync(strPaperId);
            if (objPaper == null) {
                const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const returnBool = await SysVoteEx_btnAddVote_Click_PaperId(strPaperId, clsPublocalStorage.userId, objPaper.updUser);
            let objPage_Sub;
            if (returnBool == true) {
                switch (Paper_ListEx.CurrTabName) {
                    case "AllPaper":
                        objPage_Sub = new Paper_ListEx_AllPaper();
                        await objPage_Sub.Page_Load();
                        break;
                    case "CurrEduCls":
                        objPage_Sub = new Paper_ListEx_CurrEduCls();
                        await objPage_Sub.Page_Load();
                        break;
                    case "Major":
                        objPage_Sub = new Paper_ListEx_Major();
                        await objPage_Sub.Page_Load();
                        break;
                    case "Direction":
                        objPage_Sub = new Paper_ListEx_Direction();
                        await objPage_Sub.Page_Load();
                        break;
                    default:
                        strMsg = '当前Tab:' + Paper_ListEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                        alert(strMsg);

                        break;
                }


            }
            else {
                var strInfo: string = `收藏不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return returnBool;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `关注不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }
    public async SetMajorDirectionName(strid_XzMajor: string) {
        let arrObjLst_Sel = await XzMajorDirection_GetObjLst_Cache(strid_XzMajor);
        if (arrObjLst_Sel == null) return;
        arrObjLst_Sel = arrObjLst_Sel.filter(x => x.id_XzMajor == strid_XzMajor);

        for (var i = 0; i < arrObjLst_Sel.length; i++) {
            if (i == 0) {
                let strMajorDirectionName;
                if (IsNullOrEmpty(clsPublocalStorage.majorDirectionId) == true) {
                    strMajorDirectionName = Format("<span class='text-nowrap'><span class='font-weight-bold'>[{0}]</span>方向论文</span>", arrObjLst_Sel[i].majorDirectionName);
                    $("#aMajorDirectionName").html(strMajorDirectionName);
                }
                else {
                    strMajorDirectionName = Format("<span class='text-nowrap'><span class='font-weight-bold'>[{0}]</span>方向论文</span>", clsPublocalStorage.majorDirectionName);
                    $("#aMajorDirectionName").html(strMajorDirectionName);
                }
            }
        }
    }
    /** 函数功能:设置事件函数
   * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
   **/
    public async SetEventFunc() {
        const strThisFuncName = this.SetEventFunc.name;
        // 在此处放置用户代码以初始化页面
        try {
            //没有定义相关事件
            const ddlMajorDirectionId_SetFldValue: HTMLSelectElement = GetSelectObjInDiv(this.divName4Query, 'ddlMajorDirectionId_SetFldValue');
            ddlMajorDirectionId_SetFldValue.addEventListener('change', e => { this.ddlMajorDirectionId_SetFldValue_SelectedIndexChanged(ddlMajorDirectionId_SetFldValue); });

        }
        catch (e) {
            const strMsg = Format("设置事件函数不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 函数功能:系统生成的Change事件函数
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript+<>c__DisplayClass13_0:<Gen_WApi_Ts_GeneEventFuncEx>b__1)
*/
    public async ddlMajorDirectionId_SetFldValue_SelectedIndexChanged(ddlMajorDirectionId_SetFldValue: HTMLSelectElement) {
        const strThisFuncName = this.ddlMajorDirectionId_SetFldValue_SelectedIndexChanged.name;
        const strMajorDirectionId = GetSelectValueInDiv(this.divName4Query, "ddlMajorDirectionId_SetFldValue");
        if (IsNullOrEmpty(strMajorDirectionId) == true) return;
        clsPublocalStorage.majorDirectionId = strMajorDirectionId;
        const objXzMajorDirection = await XzMajorDirection_GetObjByMajorDirectionId_Cache(strMajorDirectionId, clsPublocalStorage.id_XzMajor);
        if (objXzMajorDirection == null) {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        clsPublocalStorage.majorDirectionName = objXzMajorDirection.majorDirectionName;
        const strMajorDirectionName = Format("<span class='text-nowrap'><span class='font-weight-bold'>[{0}]</span>方向论文</span>", objXzMajorDirection.majorDirectionName);
        $("#aMajorDirectionName").html(strMajorDirectionName);
        const objPage = new Paper_ListEx_Direction();
        await objPage.Page_Load();
    }


}