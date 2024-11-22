
import { PaperCRUD } from "../PagesBase/GraduateEduPaper/PaperCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperENEx } from "../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js";
import { clsRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js";
import { clsvRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js";
import { clsvRTPaperRelaENEx } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaENEx.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { Paper_GetObjByPaperIdAsync, Paper_GetRecCountByCondAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { RTPaperRela_GetObjBymIdAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js";
import { LiteratureType_GetObjLstAsync, LiteratureType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { vUsersSim_func } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { PaperEx_GetObjExLstByPagerAsync, PaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";

import { vRTPaperRelaEx_CopyToEx } from "../TS/L3_ForWApiEx/GraduateEduTopic/clsvRTPaperRelaExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { CheckControlExist, GetArray } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindDdl_ObjLst, BindTabV2Where, BindTabV2Where_V, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { Format } from "../TS/PubFun/clsString.js";

import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strDialogName): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(strDialogName): void;



declare function HideDialogThree(): void;
declare function ParticipateQA_Click(strKey): void;//参与答疑

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiRTPaperRela_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class PaperLstSel extends PaperCRUD {
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divEdit_Sel";  //编辑区的Id
    public static objPage_Edit: PaperLstSel;
    protected iShowList: IShowList;

    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvRTPaperRelaBy: string = "mId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";

    //主题自研论文关系
    public mstrListDivRtOriginalPaperRela: string = "divRtOriginalPaperRelaDataLst";

    //主题引用论文关系
    //public mstrListDivRtPaperRela: string = "divRtPaperRelaDataLst";
    public mstrListDivRtCitedPaperRela: string = "divRtCitedPaperRelaDataLst";

    public get pageSize(): number {
        return 10;
    }

    constructor(objShowList: IShowList) {
        super();
        this.iShowList = objShowList;
        PaperLstSel.objPage_Edit = this;
    }
    //添加论文关系
    //public async btnAddPaperRela_Click(strType: string) {
    //    //存放类型区分 论文相关条件；
    //    $("#hidstrType").val(strType);

    //    var objPaperLstSel = new PaperLstSel();
    //    const responseObjList = await objPaperLstSel.Page_Load();

    //}

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            this.divName4Pager = "divPager_PaperLst";
            this.divName4Query = "divQuery_PaperLstSel";
            if (clsPublocalStorage.userId != "") {
                //1、为下拉框设置数据源,绑定列表数据
                this.hidSortvRTPaperRelaBy = "updDate Desc";

                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vPaper();

                $("#hidUserId").val(clsPublocalStorage.userId);
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

    /*
     显示对话框
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
    */
    public ShowDialog_Paper(strOp) {
        //检查相关控件是否存在
        CheckControlExist(this.divName4Edit, "div", "divPaperList");
        CheckControlExist(this.divName4Edit, "h4", "myModalLabel");
        if (strOp === "Add") {
            $('#divPaperList').html('添加记录');
            //ViewInfo_EditEx.GetMaxStrId('#txtViewId');
        }
        else if (strOp === "Update") {
            $('#divPaperList').html('修改记录');
        }
        else if (strOp === "Detail") {
            $('#btnSubmit_ViewInfo').hide();
            $('#myModalLabel').html('详细信息');
        }
        ShowDialog('#divPaperList');
    }

    /*
     隐藏对话框
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
    */
    public HideDialog_Paper() {
        CheckControlExist(this.divName4Edit, "div", "divPaperList");
        HideDialog('#divPaperList');
    }

    public async btnAddPaperRela_Click() {
        //this.opType = "Add";
        try {
            this.divName4Pager = "divPager_PaperLst";
            this.divName4Query = "divQuery_PaperLstSel";
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                this.SetEventFunc();
                this.ShowDialog_Paper('');
                this.bolIsLoadEditRegion = true;  //
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                const responseText = await this.BindGv_vPaper();
            }
            else {
                this.ShowDialog_Paper('');
                const responseText = await this.BindGv_vPaper();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 函数功能:设置事件函数
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
   */
    public async SetEventFunc() {
        // 在此处放置用户代码以初始化页面
        try {
            var objDiv0 = document.getElementById('divPaperList');
            if (objDiv0 == undefined) return;
            var objDiv: HTMLDivElement = <HTMLDivElement>objDiv0;
            var objLst = objDiv.getElementsByTagName("button");
            //console.log("objLst", objLst);
            let arrElement = GetArray(objLst);

            //var btnUpdate4Dg = document.getElementById('btnUpdateRecord');
            var btnQuery = arrElement.find(x => x.id == 'btnQuery');
            if (btnQuery == null) return;


            btnQuery.addEventListener('click', e => { this.btnPaperQuery_Click(); });

        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
   */
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面
        const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN);
        var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
        const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域

    }
    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Edit(divName4Edit) {
        var strUrl: string = "./PaperLstSel";
        console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Edit).html(data);
                    resolve(true);
                    //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                    //clsEditObj.BindTab();
                },
                error: (e) => {
                    console.error(e);
                    reject(e);
                }
            });
        });
    };
    //相关论文
    public async liPaperClick() {
        try {
            //用户下拉框绑定
            //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
            var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
            const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域

            //文献类型；
            //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
            const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN);

            //主题论文
            this.hidSortvRTPaperRelaBy = "updDate Desc";

            const gvResultPaper = await this.BindGv_vPaper();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
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

    /// <summary>
    /// 把一个扩展类的部分属性进行函数转换
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
    /// </summary>
    /// <param name = "objzx_ConceptS">源对象</param>
    public async FuncMap(objvRTPaperRela: clsvRTPaperRelaENEx) {
        try {
            var vUsersSim_UserId = objvRTPaperRela.updUser;
            var vUsersSim_UserName = await vUsersSim_func(clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, vUsersSim_UserId, clsSysPara4WebApi.cmPrjId);
            objvRTPaperRela.userName = vUsersSim_UserName;
        }
        catch (e) {
            var strMsg: string = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 把同一个类的对象,复制到另一个对象
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
    /// </summary>
    /// <param name = "objzx_ConceptENS">源对象</param>
    /// <returns>目标对象=>clszx_ConceptEN:objzx_ConceptENT</returns>
    public CopyToEx(objzx_ConceptENS: clsvRTPaperRelaEN): clsvRTPaperRelaENEx {
        var objzx_ConceptENT = new clsvRTPaperRelaENEx();
        try {
            objzx_ConceptENT = vRTPaperRelaEx_CopyToEx(objzx_ConceptENS);
            return objzx_ConceptENT;
        }
        catch (e) {
            var strMsg: string = Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})",
                clsStackTrace.GetCurrClassFunction());
            alert(strMsg);
            return objzx_ConceptENT;
        }
    }

    public async btnParticipateQA_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText1 = RTPaperRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRTPaperRelaEN: clsRTPaperRelaEN = <clsRTPaperRelaEN>jsonData;
                if (objRTPaperRelaEN != null) {
                    var strPaperId = objRTPaperRelaEN.paperId;
                    ParticipateQA_Click(strPaperId);
                }
            })
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    //////////////////////////////////////////////////////论文部分//////////////////////////////////////////

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
                    var arrLiteratureTypeObjLst: Array<clsLiteratureTypeEN> = <Array<clsLiteratureTypeEN>>jsonData;
                    BindDdl_ObjLst(ddlLiteratureTypeId, arrLiteratureTypeObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombinevPaperCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strPaperTypeId = $("#hidPaperTypeId").val();
        var strTopicId: string = clsPrivateSessionStorage.topicId;
        //论文条件教学班
        //strWhereCond += ` And ${clsPaperEN.con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;

        //strWhereCond += ` And ${clsPaperEN.con_id_CurrEduCls} <> '00000050'`;

        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }
            if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
            }

            //if (clsPublocalStorage.eduClsTypeId == "0001") {
            //    strWhereCond += ` And ${clsPaperEN.con_UpdUser} in('${clsPublocalStorage.TopicUserList}')`;
            //} else {
            //    //用户
            //    if (this.readUser_q != "" && this.readUser_q != "0") {
            //        strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.readUser_q}'`;
            //    }
            //}
            //用户
            if (this.readUser_q != "" && this.readUser_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.readUser_q}'`;
            }

            var strPaperTypeId = $('#hidPaperTypeId').val();
            if (strPaperTypeId == "01") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTypeId} = '${strPaperTypeId}'`;
            } else if (strPaperTypeId == "02") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTypeId} = '${strPaperTypeId}'`;
            }

            //只查询提交后的论文数据
            //strWhereCond += ` And ${clsPaperEN.con_IsSubmit} = 'true'`;

            //获取论文条件 02代表 小组成员论文数据；
            var strType = $("#hidstrType").val();


            if (strType == "01") {

                //排除获取已存在的关系数据
                strWhereCond += ` And paperId not in (select paperId from RTPaperRela where topicId = '${strTopicId}')`;
            }
            else if (strType == "02") {
                //小组成员的论文数据；
                strWhereCond += ` And updUser in (select UserID from RTUserRela where topicId = '${strTopicId}')`;
                //排除获取已存在的关系数据
                strWhereCond += ` And paperId not in (select paperId from RTResearchResult where topicId = '${strTopicId}')`;
            }
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



        //if (this.bolIsInitShow == false)  //
        //{
        //    this.objPager.InitShow(this.divName4Pager);
        //    this.bolIsInitShow = true;  //
        //}
        //论文
        PaperCRUD.sortPaperBy = "updDate Desc";

        var strListDiv: string = this.mstrListDivPaper;
        var strWhereCond = await this.CombinevPaperCondition();
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
            const arrPaperExObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        try {

            this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
            console.log("完成BindGv_vPaper!");

            if ($("#hidstrType").val() == "03") {
                this.BindTab_vPaperQA(strListDiv, arrPaperExObjLst);
                console.log("完成BindGv_vQAPaper!");
            }

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
    public async BindTab_vPaper(divContainer: string, arrPaperExObjLst: Array<clsPaperENEx>) {
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
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "eduClsName",
                    colHeader: "教学班",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "periodical",
                    colHeader: "期刊",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "author",
                    colHeader: "作者",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "keyword",
                    colHeader: "关键字",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "提交日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                {
                    fldName: "userName",
                    colHeader: "用户",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        //btn1.setAttribute("onclick", `btnPaperRecordInTab_Click("${strKeyId}");`);
                        (function (strKeyId1) {
                            btn1.onclick = (function () {
                                PaperLstSel.btnReturnClick(strKeyId1);
                            });
                        })(strKeyId);

                        return btn1;
                    }
                },

            ];
        BindTabV2Where(o, arrPaperExObjLst, arrDataColumn, "paperId", "TopicPaper");
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }
    public static btnReturnClick(strKeyId: string) {
        PaperLstSel.objPage_Edit.HideDialog_Paper();
        PaperLstSel.objPage_Edit.iShowList.BindGv_Cache(clsRTPaperRelaEN._CurrTabName, strKeyId);
        console.log('btnReturnClick(strKeyId:string) ');
    }
    public async BindTab_vPaperQA(divContainer: string, arrPaperExObjLst: Array<clsPaperENEx>) {
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
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "periodical",
                    colHeader: "期刊",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "author",
                    colHeader: "作者",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "keyword",
                    colHeader: "关键字",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "用户",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "添加",
                    text: "添加", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnPaperQARecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },

            ];
        BindTabV2Where(o, arrPaperExObjLst, arrDataColumn, "paperId", "TopicPaper");
        //BindTab(o, arrPaperExObjLst, arrDataColumn, "paperId");
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    //查询论列表
    public async btnPaperQuery_Click() {
        const responseObjList = await this.BindGv_vPaper();
    }
    //确定选择的论文 并添加到关系表中
    public btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)

        //获取论文条件 02代表 小组成员论文数据；
        var strType = $("#hidstrType").val();
        if (strType == "01") {
            //执行添加关系方法
            //this.AddNewRecordSavePaperRela();//所有论文
        }
        else {

            //小组成员论文；
            //this.AddNewRecordSaveResearchResult();
        }
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
    /* 函数功能:在数据 列表中跳转到某一页 论文列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
<param name = "intPageIndex">页序号</param>
*/
    public IndexPageTwo(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_vPaper();
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

    /*
   * 获取当前页序号  -------论文
  */
    public get CurrPageIndexPaper(): number {
        return $("#hidCurrPageIndexPaper").val();
    }
    /*
    * 设置当前页序号-------论文
   */
    public set CurrPageIndexPaper(value: number) {
        $("#hidCurrPageIndexPaper").val(value);
    }


    /* 
   论文
  */
    public async SortByPaper(strSortByFld: string) {
        if (PaperCRUD.sortPaperBy.indexOf(strSortByFld) >= 0) {
            if (PaperCRUD.sortPaperBy.indexOf("Asc") >= 0) {
                PaperCRUD.sortPaperBy = `${strSortByFld} Desc`;
            }
            else {
                PaperCRUD.sortPaperBy = `${strSortByFld} Asc`;
            }
        }
        else {
            PaperCRUD.sortPaperBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vPaper();
    }






    //小组论文写作 公开
    public async btnIsPublicPaper_Click(strKeyId: string) {
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }
        this.PublicPaperRecord_pyf(strKeyId);
    }


    public async PublicPaperRecord_pyf(strPaperId: string) {

        //this.keyId = strPaperId;

        try {
            const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;

                //通过session 权限获取权限
                var strUserId = clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage.roleId;

                // //通过判断数据用户是否是当前登录用户；
                if (objPaperEN.updUser == clsPublocalStorage.userId) {

                    //判断数据是否已审核
                    if (objPaperEN.isSubmit == false) {

                        const responseText3 = this.PublicRecordSave1().then((jsonData) => {

                        });
                    }
                    else {
                        alert("当前数据已审核！");
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

    }

    /* 论文公开
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async PublicRecordSave1(): Promise<boolean> {
        const strThisFuncName = this.PublicRecordSave1.name;
        //
        var objPaperEN: clsPaperEN = new clsPaperEN();
        //objPaperEN.SetPaperId(this.keyId;
        //设置提交状态；
        objPaperEN.SetIsPublic(true);
        //this.PutDataToPaperClassAudit(objPaperEN);
        objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `操作成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //刷新缓存
                        //vPaper_ReFreshThisCache();
                        //刷新缓存
                        PaperEx_ReFreshThisCacheById_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
                        this.HideDialog_Paper();
                        //this.BindGv_vRTPaperRela();
                    }
                    else {
                        var strInfo: string = `操作不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("操作失败");
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









}