
/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiRTPaperRela_QUDI_TSEx
表名:RTPaperRela(01120581)
生成代码版本:2020.02.19.1
生成日期:2020/02/20 09:46:19
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
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js";
import { clsvRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js";
import { clsvRTPaperRelaENEx } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaENEx.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { Paper_GetObjByPaperIdAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vPaper_GetObjLstByPagerAsync, vPaper_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js";
import { RTPaperRela_GetObjBymIdAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js";
import { vRTPaperRela_GetObjBymIdAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js";
import { LiteratureType_GetObjLstAsync, LiteratureType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { vUsersSim_func, vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { vPaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js";
import { vRTPaperRelaEx_CopyToEx } from "../TS/L3_ForWApiEx/GraduateEduTopic/clsvRTPaperRelaExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
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
export class PaperLstSel extends Paper_QUDI_TS {
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
            if (clsPubSessionStorage.GetSession_UserId() != "") {
                //1、为下拉框设置数据源,绑定列表数据
                this.hidSortvRTPaperRelaBy = "updDate Desc";
              
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vPaper();

                $("#hidUserId").val(clsPubSessionStorage.GetSession_UserId());
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
        clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divPaperList");
        clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "h4", "myModalLabel");
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
        clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divPaperList");
        HideDialog('#divPaperList');
    }

    public async btnAddPaperRela_Click() {
        this.OpType = "Add";
        try {
            this.divName4Pager = "divPager_PaperLst";
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
            let arrElement = clsCommonFunc4Web.GetArray(objLst);

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
            clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
            console.log("完成BindDdl_LiteratureTypeId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }


    /* 根据关键字获取相应的记录的对象
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
<param name = "sender">参数列表</param>
*/
    public async RtPaperRelaDetailRecord(lngmId: number) {
        //获取用户缓存数据
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
        this.KeyId = lngmId.toString();
        return new Promise((resolve, reject) => {
            try {
                const responseText = vRTPaperRela_GetObjBymIdAsync(lngmId).then((jsonData) => {
                    var objRTPaperRelaEN: clsvRTPaperRelaEN = <clsvRTPaperRelaEN>jsonData;
                    // //显示当前数据；
                    $("#txtTopicNameDetail").html(objRTPaperRelaEN.topicName);
                    $("#txtTopicContentDetail").html(objRTPaperRelaEN.topicContent);

                    $("#txtTopicProposePeopleDetail").html(objRTPaperRelaEN.topicProposePeople);
                    $("#txtPaperTitleDetail").html(objRTPaperRelaEN.paperTitle);
                    $("#txtPaperContentDetail").html(objRTPaperRelaEN.paperContent);
                    $("#txtAuthorDetail").html(objRTPaperRelaEN.author);
                    $("#txtPeriodicalDetail").html(objRTPaperRelaEN.periodical);
                    var objUser = arrUsers.find(x => x.userId == objRTPaperRelaEN.updUser);
                    if (objUser != null) {
                        $("#txtUserNameDetail").html(objUser.userName);
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








    /// <summary>
    /// 把一个扩展类的部分属性进行函数转换
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
    /// </summary>
    /// <param name = "objzx_ConceptS">源对象</param>
    public async FuncMap(objvRTPaperRela: clsvRTPaperRelaENEx) {
        try {
            var vUsersSim_UserId = objvRTPaperRela.updUser;
            var vUsersSim_UserName = await vUsersSim_func(clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, vUsersSim_UserId);
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
            var strMsg: string = clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})",
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
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrLiteratureTypeObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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
    public CombinevPaperCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strPaperTypeId = $("#hidPaperTypeId").val();
        var strTopicId: string = $("#hidTopicRelaId").val();
        //论文条件教学班
        //strWhereCond += ` And ${clsvPaperEN.con_id_CurrEduCls} = '${$("#hidId_CurrEduCls").val()}'`;

        //strWhereCond += ` And ${clsvPaperEN.con_id_CurrEduCls} <> '00000050'`;

        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperTitle_q != "") {
                strWhereCond += ` And ${clsvPaperEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
            }
            if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
            }

            //if (clsPublocalStorage.eduClsTypeId == "0001") {
            //    strWhereCond += ` And ${clsvPaperEN.con_UpdUser} in('${clsPublocalStorage.TopicUserList}')`;
            //} else {
            //    //用户
            //    if (this.ReadUser_q != "" && this.ReadUser_q != "0") {
            //        strWhereCond += ` And ${clsvPaperEN.con_UpdUser} = '${this.ReadUser_q}'`;
            //    }
            //}
            //用户
            if (this.ReadUser_q != "" && this.ReadUser_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_UpdUser} = '${this.ReadUser_q}'`;
            }

            var strPaperTypeId = $('#hidPaperTypeId').val();
            if (strPaperTypeId == "01") {
                strWhereCond += ` And ${clsvPaperEN.con_PaperTypeId} = '${strPaperTypeId}'`;
            } else if (strPaperTypeId == "02") {
                strWhereCond += ` And ${clsvPaperEN.con_PaperTypeId} = '${strPaperTypeId}'`;
            }

            //只查询提交后的论文数据
            //strWhereCond += ` And ${clsvPaperEN.con_IsSubmit} = 'true'`;

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
        this.hidSortvPaperBy = "updDate Desc";

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

            if ($("#hidstrType").val() == "03") {
                this.BindTab_vPaperQA(strListDiv, arrvPaperObjLst);
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
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClsName",
                    ColHeader: "教学班",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "periodical",
                    ColHeader: "期刊",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    ColHeader: "作者",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "keyword",
                    ColHeader: "关键字",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "提交日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },

                {
                    FldName: "userName",
                    ColHeader: "用户",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
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
        clsCommonFunc4Web.BindTabV2Where(o, arrvPaperObjLst, arrDataColumn, "paperId", "TopicPaper");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }
    public static btnReturnClick(strKeyId:string) {
        PaperLstSel.objPage_Edit.HideDialog_Paper();
        PaperLstSel.objPage_Edit.iShowList.BindGv_Cache(clsRTPaperRelaEN._CurrTabName, strKeyId);
        console.log('btnReturnClick(strKeyId:string) ');
    }
    public BindTab_vPaperQA(divContainer: string, arrvPaperObjLst: Array<clsvPaperEN>) {
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
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "periodical",
                    ColHeader: "期刊",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    ColHeader: "作者",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "keyword",
                    ColHeader: "关键字",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "用户",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "添加",
                    Text: "添加", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnPaperQARecordInTab_Click("${strKeyId}");`);
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

    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjRTPaperRelaEN">数据传输的目的类对象</param>
*/
    public PutDataToRTPaperRelaClass(pobjRTPaperRelaEN: clsRTPaperRelaEN) {
        var strTopicId = $("#hidTopicRelaId").val();
        var strPaperId = $("#hidPaperId").val();
        var strUserId = $("#hidUserId").val();
        pobjRTPaperRelaEN.topicId = strTopicId;// 主题编号
        pobjRTPaperRelaEN.paperId = strPaperId;// 论文Id
        pobjRTPaperRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjRTPaperRelaEN.updUser = strUserId;// 修改人
        pobjRTPaperRelaEN.memo = this.memo;// 备注
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
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        this.BindGv_vPaper();
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


    public async btnIsSubmitPaper_Click(strKeyId: string) {
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }
        this.SubmitPaperRecord(strKeyId);
    }

    public async SubmitPaperRecord(strPaperId: string) {

        this.KeyId = strPaperId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;

                    //通过session 权限获取权限
                    var strUserId = clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage.GetSession_RoleId();

                    // //通过判断数据用户是否是当前登录用户；
                    if (objPaperEN.updUser == clsPubSessionStorage.GetSession_UserId()) {
                        //判断数据是否已审核
                        if (objPaperEN.isSubmit == false) {
                            const responseText3 = this.SubmitPaperRecordSave().then((jsonData) => {

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
        });
    }

    /* 论文审核
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public SubmitPaperRecordSave(): Promise<boolean> {
        //this.DivName = "divUpdateRecordSave";
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.paperId = this.KeyId;
        //设置提交状态；
        objPaperEN.isSubmit = true;
        //this.PutDataToPaperClassAudit(objPaperEN);
        objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw "关键字不能为空!";
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
                        vPaperEx_ReFreshThisCacheById_CurrEduCls(clsPublocalStorage.Getid_CurrEduCls());
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


    //小组论文写作 公开
    public async btnIsPublicPaper_Click(strKeyId: string) {
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }
        this.PublicPaperRecord(strKeyId);
    }


    public async PublicPaperRecord(strPaperId: string) {

        this.KeyId = strPaperId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;

                    //通过session 权限获取权限
                    var strUserId = clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage.GetSession_RoleId();

                    // //通过判断数据用户是否是当前登录用户；
                    if (objPaperEN.updUser == clsPubSessionStorage.GetSession_UserId()) {

                        //判断数据是否已审核
                        if (objPaperEN.isSubmit == false) {

                            const responseText3 = this.PublicRecordSave().then((jsonData) => {

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
        });
    }

    /* 论文公开
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public PublicRecordSave(): Promise<boolean> {
        //this.DivName = "divUpdateRecordSave";
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.paperId = this.KeyId;
        //设置提交状态；
        objPaperEN.isPublic = true;
        //this.PutDataToPaperClassAudit(objPaperEN);
        objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw "关键字不能为空!";
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
                        vPaperEx_ReFreshThisCacheById_CurrEduCls(clsPublocalStorage.Getid_CurrEduCls());
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