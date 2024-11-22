
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
import { gs_PaperAttention_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { PaperCollectionLog_AddNewRecordAsync, PaperCollectionLog_GetObjLstAsync, PaperCollectionLog_GetRecCountByCondAsync, PaperCollectionLog_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js";
import { PaperDownloadLog_AddNewRecordAsync, PaperDownloadLog_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js";
import { Paper_GetRecCountByCondAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vPaperCount_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCountWApi.js";
import { SysVote_GetObjLstAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { gs_PaperType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js";
import { LiteratureType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { PaperEx_GetObjExLstByPagerAsync, PaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { BindDdl_ObjLst } from "../TS/PubFun/clsCommFunc4Web.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogOne(): void;

declare function doDownLoad(filepath, filename): void;
declare function layui_Alert(iconKey, strMsg): void;
declare var $;
declare var window;
/* Paper_List 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Paper_List extends PaperCRUD {
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
            if (clsPublocalStorage.userId != "") {
                //加载页面所需数据源到缓存
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                //绑定编辑文献类型

                PaperCRUD.sortPaperBy = "updDate Desc";
                this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";


                $("#hidUserId").val(clsPublocalStorage.userId);

                const gvResult = await this.BindGv_vPaper();

                this.objPager.recCount = this.recCount;
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

            var objgs_PaperType_Cond: clsgs_PaperTypeEN = new clsgs_PaperTypeEN();
            var arrObjLst_Sel: Array<clsgs_PaperTypeEN> = await gs_PaperType_GetSubObjLst_Cache(objgs_PaperType_Cond);

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
        try {
            $("#divLoading").show();
            const gvResultPaper = await this.BindGv_vPaper();
            this.objPager.recCount = this.recCount;
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
            this.objPager.recCount = this.recCount;
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
            this.objPager.recCount = this.recCount;
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
            this.objPager.recCount = this.recCount;
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
                PaperCRUD.sortPaperBy = "updDate Desc";
                const gvResult = await this.BindGv_vPaper();

            }
            else if (this.PaperSort == "2") {
                PaperCRUD.sortPaperBy = "paperTitle Asc";
                const gvResult = await this.BindGv_vPaper();
            }
            else if (this.PaperSort == "3") {
                PaperCRUD.sortPaperBy = "appraiseCount Desc";
                const gvResult = await this.BindGv_vPaper();
            }
            else if (this.PaperSort == "4") {
                PaperCRUD.sortPaperBy = "score Desc";
                const gvResult = await this.BindGv_vPaper();
            }
            else if (this.PaperSort == "5") {
                PaperCRUD.sortPaperBy = "pcount Desc";
                const gvResult = await this.BindGv_vPaper();
            }
            else if (this.PaperSort == "6") {
                PaperCRUD.sortPaperBy = "downloadCount Desc";
                const gvResult = await this.BindGv_vPaper();
            }
            else if (this.PaperSort == "7") {
                PaperCRUD.sortPaperBy = "okCount Desc";
                const gvResult = await this.BindGv_vPaper();
            }
            this.objPager.recCount = this.recCount;
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
    //                var arrXzMajorObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>jsonData;
    //                BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsPaperEN.con_id_XzMajor, clsPaperEN.con_MajorName, "专业");
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
            if ($("#hidTabPaper").val() == "2") {
                strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            }
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }
            if (this.updDate_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_UpdDate} like '% ${this.updDate_q}%'`;
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


    /* 修改记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
  */
    //public btnUpdateRecord_Click_pyf(strKeyId: string) {
    //    this.opType = "Update";
    //    //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
    //    if (strKeyId == "") {
    //        alert("请选择需要修改的记录！");
    //        return;
    //    }
    //    this.UpdateRecord(strKeyId);
    //}




    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vPaper() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevPaperCondition();
        var strid_CurrEducls = clsPublocalStorage.id_CurrEduCls;

        //var strWhereCond2: string = "";
        //var objvPaper_Cond: clsPaperEN = this.CombinevPaperConditionobj();

        ////objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");

        //strWhereCond2 = JSON.stringify(objvPaperEN_Sim);

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

            const arrvPaperObjLst0 = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            if (strid_CurrEducls == "00000050") {
                //arrPaperExObjLst = arrvPaperObjLst0.filter(x => x.id_CurrEduCls != "00000050");

                //const gvResultPaper = await this.BindList_vPaper("1", arrPaperExObjLst);
                const gvResultPaper = await this.BindList_vPaper("1", arrvPaperObjLst0);
            }
            else {
                const gvResultPaper = await this.BindList_vPaper("1", arrvPaperObjLst0);
            }

            $("#divPager").show();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定论文视图对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    //绑定个性化论文列表
    public async BindList_vPaper(strTypeId: string, arrPaperExObjLst: Array<clsPaperENEx>) {

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


            for (var i = 0; i < arrPaperExObjLst.length; i++) {



                var objCount = arrvPaperCountObjLst.find(x => x.paperId == arrPaperExObjLst[i].paperId);//使用find必须通过if判断不能为空后才能调用属性

                if (objCount != null) {

                    strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';
                    //strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + arrPaperExObjLst[i].paperId + '">' + arrPaperExObjLst[i].paperTitle + '</a>';
                    //判断引用论文，自研论文
                    if (arrPaperExObjLst[i].paperTypeId == "02") {
                        //自研论文
                        strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(原创论文)', '../GraduateEduEx/PaperDetail?paperId=" + arrPaperExObjLst[i].paperId + "')\"><span class='text-info'>" + arrPaperExObjLst[i].paperTitle + "(" + arrPaperExObjLst[i].paperTypeName + ")</a>";

                    }
                    else {
                        strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(引用论文)', '../GraduateEduEx/PaperDetail?paperId=" + arrPaperExObjLst[i].paperId + "')\">" + arrPaperExObjLst[i].paperTitle + "(" + arrPaperExObjLst[i].paperTypeName + ")</a>";
                    }


                    //if (objCount.attachmentCount > 0) {
                    //    strhtml += "<span class=\"btn-2\" style=\"padding-left:50px;\"><a style=\"font-size:15px; color:#f98c51\" href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrPaperExObjLst[i].paperId + "')\">pdf查看</a></span>";
                    //}

                    strhtml += '<span class="btn-2" style="padding-left:50px;"><a style="font-size:15px; color:#f98c51" href="#" onclick=PaperSubVer_Click("' + arrPaperExObjLst[i].paperId + '")>pdf论文子观点查看</a></span>';

                    //只有自研论文才有历史版本
                    if (arrPaperExObjLst[i].paperTypeId == "02") {
                        if (arrPaperExObjLst[i].versionCount > 0 && arrPaperExObjLst[i].versionCount != null) {
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('自研论文历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrPaperExObjLst[i].paperId + "&Type=10')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                        }
                    }


                    strhtml += '</h6>';
                    strhtml += '<div class="baseinfo"><span><a href="#">' + arrPaperExObjLst[i].author + '</a></span><span><a href="#">' + arrPaperExObjLst[i].literatureSources + '</a></span>';
                    strhtml += '<span>' + arrPaperExObjLst[i].periodical + '</span><em>' + arrPaperExObjLst[i].keyword + '</em>';
                    strhtml += '</div>';
                    strhtml += '<div class="abstract">' + arrPaperExObjLst[i].paperContent + '</div>';
                    strhtml += '<div class="opts"><ul class="opts-count">';
                    strhtml += '<li>评论数:<em>' + objCount.appraiseCount + '</em></li><li>综合评分:<em>' + objCount.score + '</em></li>';
                    if (objCount.teaScore != null) {
                        strhtml += '<li>教师评分:<em>' + objCount.teaScore + '</em></li>';
                    }
                    if (objCount.stuScore != null) {
                        strhtml += '<li>学生评分:<em>' + objCount.stuScore + '</em></li>';
                    }
                    strhtml += '<li>读写数:<em>' + objCount.pcount + '</em></li><li>浏览量:<em>' + arrPaperExObjLst[i].browseNumber + '</em></li>';
                    //strhtml += '<li>:<em>' + arrPaperExObjLst[i].pcount + '</em></li>';
                    var objUser = arrUsers.find(x => x.userId == arrPaperExObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<li class="date">编辑用户：' + objUser.userName + '</li><li class="date">发表日期：' + arrPaperExObjLst[i].updDate + '</li></ul>';
                    }

                    strhtml += '<ul class="opts-btn">';


                    var objAttention = arrgs_PaperAttentionObjLst.find(x => x.paperId == arrPaperExObjLst[i].paperId);

                    if (objAttention == null) {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + arrPaperExObjLst[i].paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px;"></i><b>关注</b></a></li>';

                    } else {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + arrPaperExObjLst[i].paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px; color: #1E9FFF;"></i><b>已关注</b></a></li>';

                    }

                    var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrPaperExObjLst[i].paperId);

                    //if (objLike == null) {
                    //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan" href="javascript:void(0)" onclick=btnAddVote_Click("' + arrPaperExObjLst[i].paperId + '","' + arrPaperExObjLst[i].updUser + '")><i></i>点赞</a></li>';
                    //    //console.log("null!");
                    //} else {
                    //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan_" href="javascript:void(0)" onclick=btnAddVote_Click("' + arrPaperExObjLst[i].paperId + '","' + arrPaperExObjLst[i].updUser + '")><i></i>已点赞</a></li>';
                    //    //console.log(objLike.paperId);
                    //}
                    if (objLike == null) {
                        strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + arrPaperExObjLst[i].paperId + '","' + arrPaperExObjLst[i].updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; "></i>点赞</a></li>';
                        //console.log("null!");
                    } else {
                        strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + arrPaperExObjLst[i].paperId + '","' + arrPaperExObjLst[i].updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; color: #1E9FFF;"></i>已点赞</a></li>';
                        //console.log(objLike.paperId);
                    }


                    var objCollection = arrPaperCollectionLogObjLst.find(x => x.paperId == arrPaperExObjLst[i].paperId);
                    //var objSysVoteObjLst: Array<clsvSysVoteEN> = [];
                    //objSysVoteObjLst = arrvSysVoteObjLst.filter(x => x.updUser == "2020/02/18");



                    //if (objCollection == null) {
                    //    strhtml += '<li class="btn-collect"><a class="icon-collect" href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrPaperExObjLst[i].paperId + '")><i></i><b>收藏</b></a></li>';
                    //    //console.log("null!");
                    //} else {
                    //    strhtml += '<li class="btn-collect"><a class="icon-collect_" href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrPaperExObjLst[i].paperId + '")><i></i><b>已收藏</b></a></li>';
                    //    //console.log(objCollection.paperId);
                    //}
                    if (objCollection == null) {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrPaperExObjLst[i].paperId + '")><i class="layui-icon layui-icon-rate" style="font-size: 22px; "></i><b>收藏</b></a></li>';
                        //console.log("null!");
                    } else {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrPaperExObjLst[i].paperId + '")><i class="layui-icon layui-icon-rate-solid" style="font-size: 22px; color: #1E9FFF;"></i><b>已收藏</b></a></li>';
                        //console.log(objCollection.paperId);
                    }


                    //if (objCount.attachmentCount > 0) {
                    //    strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click("' + arrPaperExObjLst[i].paperId + '")><i></i><b>点击下载</b></a></li>';
                    //} else {
                    //    strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
                    //}
                    if (objCount.attachmentCount > 0) {
                        strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile"  href="#" onclick=btnDownLoadFile_Click("' + arrPaperExObjLst[i].paperId + '")> <i class="layui-icon layui-icon-download-circle" style="font-size: 24px; "></i><b>点击下载</b></a></li>';
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
        var strWhereCond = await this.CombinevPaperCondition();

        //通过登录的用户得到用户专业

        var strid_XzMajor = clsPublocalStorage.id_XzMajor;

        //strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where id_XzMajor= '${strid_XzMajor}')`;

        strWhereCond += " and  id_XzMajor= '" + strid_XzMajor + "'";

        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrPaperExObjLst: Array<clsPaperENEx> = [];
        try {
            //this.recCount= await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            //    
            //});
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize, 
                whereCond: strWhereCond,
                orderBy: PaperCRUD.sortPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const arrPaperExObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);
            ////绑定方向论文
            //const gvResultDirection = await this.BindGv_vPaperDirection();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取本专业的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrPaperExObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //console.error(strMsg);
        //    alert(strMsg);
        //    return;
        //}
        try {
            //this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
            const gvResultPaper = await this.BindList_vPaper("2", arrPaperExObjLst);
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
        var strWhereCond = await this.CombinevPaperCondition();

        //通过登录的用户得到用户专业


        var strid_XzMajor = clsPublocalStorage.id_XzMajor;

        strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId in (select majorDirectionId from XzMajorDirection where id_XzMajor= '${strid_XzMajor}'))`;



        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrPaperExObjLst: Array<clsPaperENEx> = [];
        try {
            //this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            //    
            //});
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: PaperCRUD.sortPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const arrPaperExObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取本方向的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrPaperExObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //console.error(strMsg);
        //    alert(strMsg);
        //    return;
        //}
        try {
            //this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
            const gvResultPaper = await this.BindList_vPaper("3", arrPaperExObjLst);
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
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);

        const gvResult = await this.BindGv_vPaper();

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

   

    //添加收藏
    public async btnAddCollection_Click(strPaperId: string) {
        const strThisFuncName = this.btnAddCollection_Click.name;
        var objPaperCollectionLogEN: clsPaperCollectionLogEN = new clsPaperCollectionLogEN();

        objPaperCollectionLogEN.SetPaperId(strPaperId);
        objPaperCollectionLogEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        objPaperCollectionLogEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
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
                objPaperEN.SetPaperId(strPaperId);
                objPaperEN.SetCollectionCount(intCollectionCount);

                objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
        //this.keyId = strPaperRWId;
        var strWhereCond = ` ${clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
        var arrPaperAttachmentObjLst: Array<clsPaperAttachmentEN> = [];
        try {
            var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
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
    //                BindDdl_ObjLst(ddlMajorDirectionId, arrXzMajorDirectionObjLst, clsXzMajorDirectionEN.con_MajorDirectionId, clsXzMajorDirectionEN.con_MajorDirectionName, "专业方向");
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