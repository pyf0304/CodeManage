
import { PaperCRUD } from "../PagesBase/GraduateEduPaper/PaperCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperDownloadLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperENEx } from "../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js";
import { clsgs_PaperTypeEN } from "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { PaperDownloadLog_AddNewRecordAsync, PaperDownloadLog_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js";
import { Paper_GetRecCountByCondAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { gs_PaperType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js";
import { LiteratureType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { PaperEx_BindTab_Paper, PaperEx_GetObjExLstByPagerAsync, PaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { BindDdl_ObjLst } from "../TS/PubFun/clsCommFunc4Web.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogOne(): void;

declare function setTextboxio(): void;

declare function doDownLoad(filepath, filename): void;
declare function layui_Alert(iconKey, strMsg): void;
declare var $;
declare var window;
/* Paper_QUDI_Direction 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Paper_QUDI_Direction extends PaperCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrsortPaperBy: string = "paperId";


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
            this.divName4Pager = "divPager_Direction";
            this.divName4Query = "divQuery";
            this.divName4DataList = "divDataLstDirection";
            if (clsPublocalStorage.userId != "") {
                //加载页面所需数据源到缓存

                $("#hidUserId").val(clsPublocalStorage.userId);
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                const gvResult = await this.BindGv_Paper();

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
 
 

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombinePaperCondition(): Promise<string> {
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
  

    public CombinePaperConditionobj(): clsPaperEN {
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

    //绑定本方向
    public async BindGv_Paper() {
        //var strListDiv: string = this.mstrListDivDirection;
        var strWhereCond = await this.CombinePaperCondition();

        //通过登录的用户得到用户专业


        var strMajorDirectionId = clsPublocalStorage.majorDirectionId;

        strWhereCond += ` and paperId in (select paperId from MajorDirectionPaperRela where majorDirectionId = '${strMajorDirectionId}')`;



        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrPaperExObjLst: Array<clsPaperENEx> = [];
        try {

            this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond);

            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: PaperCRUD.sortPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            arrPaperExObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);
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
            const gvResultPaper = await PaperEx_BindTab_Paper(this.divName4DataList, arrPaperExObjLst, this);

            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
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

        const gvResult = await this.BindGv_Paper();

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
                    this.BindGv_Paper();
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
      
}