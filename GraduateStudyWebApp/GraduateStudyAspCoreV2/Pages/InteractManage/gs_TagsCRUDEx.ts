
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_TagsCRUDEx
表名:vgs_Tags(01120643)
生成代码版本:2020.05.28.1
生成日期:2020/06/02 01:10:24
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:互动管理
模块英文名:InteractManage
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { gs_TagsCRUD } from "../PagesBase/InteractManage/gs_TagsCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsvgs_TagsEN } from "../TS/L0_Entity/InteractManage/clsvgs_TagsEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { vgs_Tags_GetObjByTagsIdAsync, vgs_Tags_GetObjLstByPagerAsync, vgs_Tags_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsvgs_TagsWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { LiteratureType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { BindDdl_ObjLst, BindTab, BindTab_V, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function Alert1(strMsg): void;
declare function xadminopen(str1, str2): void;

declare var $;
declare var window;
/* gs_TagsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_TagsCRUDEx extends gs_TagsCRUD {
    public static mstrListDiv: string = "divDataLst";

    //论文列表

    public mstrListDivPaper: string = "divPaperDataLst";
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


                this.hidSortvgs_TagsBy = "updDate Desc";
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult1 = await this.BindGv_vgs_Tags();
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




    /****************************************************答疑邀请相关 End***************************************************/




    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public Combinevgs_TagsCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //strWhereCond += " and isPublic=1";
        strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsvgs_TagsEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }
            if (this.Tags_q != "") {
                strWhereCond += ` And ${clsvgs_TagsEN.con_TagsContent} like '% ${this.Tags_q}%'`;
            }
            if (this.updDate_q != "") {
                strWhereCond += ` And ${clsvgs_TagsEN.con_UpdDate} like '% ${this.updDate_q}%'`;
            }

            if ($('#hidTypeId').val() == "2") {
                
                strWhereCond += " and updUser='" + clsPublocalStorage.userId + "'";
            }
        }

        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinevgs_TagsCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    public async btnQuery_Click() {
        const gvResult = await this.BindGv_vgs_Tags();
    }

    /* 根据条件获取相应的对象列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vgs_Tags() {
        //var strListDiv: string = this.mstrListDiv;
        //var strWhereCond = await this.Combinevgs_TagsCondition();
        //var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //var arrvgs_TagsObjLst: Array<clsvgs_TagsEN> = [];

        //try {
        //    this.recCount = await vgs_Tags_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        
        //    });
        //    var objPagerPara: stuPagerPara = {
        //        pageIndex: intCurrPageIndex,
        //        pageSize: this.pageSize,
        //        whereCond: strWhereCond,
        //        orderBy: this.hidSortvgs_TagsBy
        //    };
        //    const responseObjLst = await vgs_Tags_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //        arrvgs_TagsObjLst = <Array<clsvgs_TagsEN>>jsonData;
        //    });
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `绑定GridView不成功,${e}.`;
        //    alert(strMsg);
        //}
        //if (arrvgs_TagsObjLst.length > 10) {
        //    $("#divPager").show();
        //}
        //try {
        //    this.BindTab_vgs_Tags(strListDiv, arrvgs_TagsObjLst);
        //    console.log("完成BindGv_vgs_Tags!");
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //    alert(strMsg);
        //}

        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.Combinevgs_TagsCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvgs_TagsObjLst: Array<clsvgs_TagsEN> = [];
        try {
            this.recCount = await vgs_Tags_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_TagsBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_Tags_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_TagsObjLst = <Array<clsvgs_TagsEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvgs_TagsObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {

            this.BindTab_vgs_Tags(strListDiv, arrvgs_TagsObjLst);

            console.log("完成BindGv_vgs_Tags!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vgs_Tags对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrvgs_TagsObjLst">需要绑定的对象列表</param>
   */
    public async BindTab_vgs_Tags(divContainer: string, arrvgs_TagsObjLst: Array<clsvgs_TagsEN>) {
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
                    fldName: "tagsContent",
                    colHeader: "标记内容",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "标记用户",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "标记日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "查看",
                    text: "查看", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnAnswer_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        BindTab_V(o, arrvgs_TagsObjLst, arrDataColumn, "tagsId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }




    public async btnAnswer_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText1 = vgs_Tags_GetObjByTagsIdAsync(strKeyId).then((jsonData) => {
                var objvgs_TagsEN: clsvgs_TagsEN = <clsvgs_TagsEN>jsonData;
                if (objvgs_TagsEN != null) {
                    var strPaperId = objvgs_TagsEN.paperId;
                    var strQuestionsId = strKeyId;
                    var strid_CurrEduCls = objvgs_TagsEN.id_CurrEduCls;
                    var strHref = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperId=" + strPaperId + "&questionsTypeId=03&id_CurrEduCls=" + strid_CurrEduCls;


                    xadminopen("Pdf论文标注", strHref);

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
  
    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: gs_TagsCRUDEx = new gs_TagsCRUDEx();
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
                    
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                objPage.btnDelRecord_Click();
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                var arrKeyIds = GetCheckedKeyIds();
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
/////////////论文部分/////////////////////////////////////////////////

    /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
   */
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面
        var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
        const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId", objUsers_Cond);//用户查询区域

        const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId", new clsLiteratureTypeEN);

        var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
        const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
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
    public async CombinevPaperCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strPaperTypeId = $("#hidPaperTypeId").val();
        var strTopicId: string = clsPrivateSessionStorage.topicId;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle != "") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle}%'`;
            }

            if (this.literatureTypeId != "" && this.literatureTypeId != "0") {
                strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId}'`;
            }
            //用户
            if (this.PaperUser != "" && this.PaperUser != "0") {
                strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.PaperUser}'`;
            }
            //只查询提交后的论文数据
            strWhereCond += ` And ${clsPaperEN.con_IsSubmit} = 'true'`;


            //获取论文条件 02代表 小组成员论文数据；
            //var strType = $("#hidstrType").val();
            //if (strType == "02") {
            //    //小组成员的论文数据；
            //    strWhereCond += ` And updUser in (select UserID from RTUserRela where topicId = '${strTopicId}')`;
            //    //排除获取已存在的关系数据
            //    strWhereCond += ` And paperId not in (select paperId from RTResearchResult where topicId = '${strTopicId}')`;
            //}
            //else {

            //    //排除获取已存在的关系数据
            //    strWhereCond += ` And paperId not in (select paperId from RTPaperRela where topicId = '${strTopicId}')`;
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
            if (this.paperTitle != "") {
                objvPaper_Cond.SetCondFldValue(clsPaperEN.con_PaperTitle, this.paperTitle, "like");
            }
            if (this.literatureTypeId != "" && this.literatureTypeId != "0") {
                objvPaper_Cond.SetCondFldValue(clsPaperEN.con_LiteratureTypeId, this.literatureTypeId, "=");
            }
            if (this.PaperUser != "" && this.PaperUser != "0") {
                objvPaper_Cond.SetCondFldValue(clsPaperEN.con_UpdUser, this.PaperUser, "=");
            }


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineUsersConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvPaper_Cond;
    }
    /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/


    ////确定选择的论文 并添加到关系表中
    //public async btnPaperRecordInTab_Click(strkeyId: string) {
    //    //存放Id
    //    $("#hidPaperId").val(strkeyId)

    //    //判断是否选择分配权限；没选择给出提示；
    //    //需要提示选择角色
    //    if (this.shareId != "" && this.shareId != "0") {

    //        const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
    //            var returnBool2: boolean = <boolean>jsonData;
    //            if (returnBool2 == true) {
    //                HideDialog();
    //                this.BindGv_vgs_Tags();
    //            }
    //        });
    //    }
    //    else {
    //        var strInfo: string = `请选择分配权限下拉框!`;

    //        //显示信息框
    //        alert(strInfo);
    //        return;
    //    }



    //}
    

    //////////////////////////////////////////////////////论文部分/////////////////////////////////////////////////

    /*
    * 论文标题
   */
    public get paperTitle(): string {
        return $("#txtPaperTitle").val();
    }
    ///////////////////////论文列表条件
    public get PaperUser(): string {
        return $("#ddlUserId").val();
    }
    /*
    * 文献类型Id
   */
    public get literatureTypeId(): string {
        return $("#ddlLiteratureTypeId").val();
    }

    /*
   * 设置排序字段-相当使用ViewState功能
  */
    public set hidSortvgs_TagsBy(value: string) {
        $("#hidSortvgs_TagsBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_TagsBy(): string {
        return $("#hidSortvgs_TagsBy").val();
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
 * 论文标题
*/
    public get Tags_q(): string {
        return $("#txtTags_q").val();
    }


    /*
    * 论文标题
   */
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
    }

    /*
  * 修改日期
 */
    public get updDate_q(): string {
        return $("#txtUpdDate_q").val();
    }
}