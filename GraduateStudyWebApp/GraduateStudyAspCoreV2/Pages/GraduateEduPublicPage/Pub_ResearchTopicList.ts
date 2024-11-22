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
///// <reference path="../../scripts/typings/q/q.d.ts" />CloseWindowCloseWindow
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";


import { ResearchTopicCRUD } from "../PagesBase/GraduateEduTopic/ResearchTopicCRUD.js";
import { ViewpointCRUD } from "../PagesBase/GraduateEduTopic/ViewpointCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js";
import { clsViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { ResearchTopic_GetFirstObjAsync, ResearchTopic_GetObjLstByPagerAsync, ResearchTopic_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { RTViewpointRela_AddNewRecordAsync, RTViewpointRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js";
import { Viewpoint_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { ViewpointType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { BindDdl_ObjLst, BindTab, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { AddViewpointEx } from "./AddViewpointEx.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogTwo(): void;
declare function HideDialogThree(): void;
declare function CloseWindow(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* Viewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Pub_ResearchTopicList extends ResearchTopicCRUD implements IShowList {
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

    BindGv(strType: string) {
        this.BindGv_ResearchTopic();
    }
    BindGv_Cache(strType: string) {
        switch (strType) {
            case "ge_InspectionResults":
                alert('该类没有绑定该函数：[this.BindGv_ge_InspectionResults4Func]！');
                //this.BindGv_ge_InspectionResults4Func();
                break;
            default:
                var strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
                alert(strMsg);
                break;
        }
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
    public async Page_Load() {
        const strThisFuncName = this.Page_Load.name;
        // 在此处放置用户代码以初始化页面
        try {
            const objPage_Add = new AddViewpointEx(this);
            if (clsPublocalStorage.userId != "") {

                if (clsPublocalStorage.id_CurrEduCls == "") {
                    const objResearchTopic = await ResearchTopic_GetFirstObjAsync(" topicId=" + clsPrivateSessionStorage.topicId);//通过主题Id获取教学班ID
                    if (objResearchTopic == null) {
                        const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                //const strThisFuncName = this.Page_Load.name;
                    clsPublocalStorage.id_CurrEduCls = objResearchTopic.id_CurrEduCls;

                }

                var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
                const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
                const ddl_ViewpointTypeId = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId");

                var userTypeId;
                var userTypeId = $("#hidUserTypeId").val();
                if (userTypeId == "01") {
                    userTypeId = "04";
                }
                else {
                    userTypeId = "05";
                }
                if ($("#hidViewpointId").val() != "") {
                    const UpdateRecord = await objPage_Add.UpdateRecord($("#hidViewpointId").val());

                    //if ($("#hidIsRecommend").val() != "") {
                    //    const RecommendRecord = await this.RecommendRecord($("#hidViewpointId").val());
                    //}

                    $("#divLoading").hide();
                }
                else {
                    objPage_Add.AddNewRecord();
                    //获取分享Id
                    const responseText = await gs_UserConfigEx_GetNewReturnShareIdEx(userTypeId, clsPublocalStorage.userId);
                    var strShareId: string = responseText;
                    //var returnBool: boolean = !!responseText2;
                    if (strShareId != "") {
                        this.shareId = strShareId;
                    }
                    $("#divLoading").hide();
                }



                //1、为下拉框设置数据源,绑定列表数据

                //const ddl_ViewpointTypeId_q = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId_q");
                ViewpointCRUD.sortvViewpointBy = "updDate Desc";
                this.hidSortResearchTopicBy = "updDate Desc";
                //论文
                //PaperCRUD.sortPaperBy = "updDate Desc";
                //用户下拉框绑定
                //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
                const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域
                //文献类型；
                const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");

                //论文
                this.hidSortvRTPaperRelaBy = "updDate Desc";

                //var strWhereCond = await this.CombinevViewpointCondition();
                //const responseText = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                
                //});
                //2、显示无条件的表内容在GridView中
                //const gvResult = await this.BindGv_vViewpoint();
                //获取传参的paperId
                var strPaperId = $("#hidRequestPaperId").val();
                if (strPaperId != "") {
                    $('#SelectPaper').hide();
                    //存放Id
                    $("#txtPaperId").val(strPaperId);
                }
                else {
                    $('#SelectPaper').show();
                }




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
    /* 为插入记录做准备工作
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
  */



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


    ////////////////////////////////////////////////////////////////////////////////// 添加主题关系部分

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_ResearchTopic() {
        var strListDiv: string = this.mstrListdivTopicDataLst;
        var strWhereCond = await this.CombineResearchTopicCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrResearchTopicObjLst: Array<clsResearchTopicEN> = [];
        try {
            this.recCount = await ResearchTopic_GetRecCountByCondAsync(strWhereCond);
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
        //console.error(strMsg);
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
    public async BindTab_ResearchTopic(divContainer: string, arrResearchTopicObjLst: Array<clsResearchTopicEN>) {
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
                    fldName: "topicName",
                    colHeader: "栏目主题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "topicContent",
                    colHeader: "主题内容",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "topicProposePeople",
                //    colHeader: "主题提出人",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "orderNum",
                //    colHeader: "序号",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updUser",
                    colHeader: "修改人",
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
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    fldName: "",
                //    colHeader: "修改",
                //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
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
        BindTab(o, arrResearchTopicObjLst, arrDataColumn, "topicId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
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
    
    //确定选择的主题 并添加到关系表中
    public btnOkInTab_Click(strkeyId: string) {
        //存放Id
        clsPrivateSessionStorage.topicId = strkeyId;
        //执行添加关系方法
        this.AddNewRecordSaveViewpointRela();
    }

    ///////////////////////////////////---------------------------------------------------------------------------添加主题观点关系

    /* 添加新记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 */
    public async AddNewRecordSaveViewpointRela() {
        const strThisFuncName = this.AddNewRecordSaveViewpointRela.name;

        var strViewpointId = $('#hidViewpointId').val();//观点

        var objRTViewpointRelaEN: clsRTViewpointRelaEN = new clsRTViewpointRelaEN();
        this.PutDataToRTViewpointRelaClass(objRTViewpointRelaEN);

        try {
            ////同一主题 同一观点 只能添加一次；
            //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId + "'";
            ////var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
            //const responseText = await RTViewpointRela_IsExistRecordAsync(strWhere);
            //var bolIsExist: boolean = responseText;
            //if (bolIsExist == true) {
            //    var strMsg: string = `同一观点不能重复添加同一个主题！`;
            //    alert(strMsg);
            //    return responseText;//一定要有一个返回值，否则会出错！
            //}

            const responseText2 = await RTViewpointRela_AddNewRecordAsync(objRTViewpointRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {

                //根据ID获取最大数；
                var strWhereCond2 = " 1 =1 and viewpointId=" + strViewpointId;
                var intCitationCount = await RTViewpointRela_GetRecCountByCondAsync(strWhereCond2);


                var objViewpointEN: clsViewpointEN = new clsViewpointEN();
                objViewpointEN.SetViewpointId(strViewpointId);
                objViewpointEN.SetCitationCount(intCitationCount);

                objViewpointEN.sfUpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }

                const responseText = await Viewpoint_UpdateRecordAsync(objViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {


                    }
                    else {
                        var strInfo: string = `操作不成功!`;
                        alert(strInfo);
                        console.log("操作不成功");
                    }

                });







                //var strInfo: string = `添加成功!`;
                //$('#lblResult40').val(strInfo);
                //HideDialogTwo();
                ////显示信息框
                //alert(strInfo);
                //window.location.href = "../GraduateEdu/ViewpointAdd?TopicRelaId=" + strViewpointId;


                ////执行之前需要判断是否有引用 ;有就添加论文、没有就添加附件；
                //if ($("#txtPaperId").val() == "") {
                //添加成功，则执行附件添加方法；
                //判断是否有返回的附件路径值
                //if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                //    var fileOne = $("#hdnFileOne").val();
                //    this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                //}
                //else {
                //    if ($("#hdnFileTwo").val() != "") {
                //        var fileTwo = $("#hdnFileTwo").val();
                //        this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                //    }
                //    else {
                //        if ($("#hdnFileThree").val() != "") {
                //            var fileThree = $("#hdnFileThree").val();
                //            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                //        }
                //    }

                //}
                //}
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
        pobjRTViewpointRelaEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjRTViewpointRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTViewpointRelaEN.SetViewpointId(strViewpointId);// 观点Id
        pobjRTViewpointRelaEN.SetProposePeople(strUserId);// 提出人
        pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTViewpointRelaEN.SetUpdUser(strUserId);// 修改用户Id// 修改用户Id
        pobjRTViewpointRelaEN.SetClassificationId("0000000000");// 分类为000000
        //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
    }
    /* 函数功能:从界面列表中根据某一个字段排序
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
    <param name = "strSortByFld">排序的字段</param>
  */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortResearchTopicBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortResearchTopicBy.indexOf("Asc") >= 0) {
                this.hidSortResearchTopicBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortResearchTopicBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortResearchTopicBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_ResearchTopic();
    }
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
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_ResearchTopic();
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
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
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
            if (this.readUser_q != "" && this.readUser_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.readUser_q}'`;
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