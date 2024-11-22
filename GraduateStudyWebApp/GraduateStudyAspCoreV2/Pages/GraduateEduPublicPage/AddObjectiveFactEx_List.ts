
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";

import { clsObjectiveAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js";
import { clsTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";

import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

import { TopicObjectiveCRUD } from "../PagesBase/GraduateEduTopic/TopicObjectiveCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { ObjectiveAttachment_AddNewRecordAsync, ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js";
import { ResearchTopic_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { TopicObjective_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js";
import { vTopicObjective_GetObjLstByPagerAsync, vTopicObjective_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { BindDdl_ObjLst, BindTab_V, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { AddObjectiveFactEx } from "./AddObjectiveFactEx.js";
import { Pub_PaperList } from "./Pub_PaperList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogThree(): void;
declare function CloseWindow(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiTopicObjective_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class AddObjectiveFactEx_List extends TopicObjectiveCRUD implements IShowList {
    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvTopicObjectiveBy: string = "topicObjectiveId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string) {
        this.BindGv_vTopicObjective_Cache();
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

            const objPage_Edit = new AddObjectiveFactEx(this);

            if (clsPublocalStorage.userId != "") {

                //通过主题Id获取教学班ID
                if (clsPublocalStorage.id_CurrEduCls == "") {
                    const objResearchTopic = await ResearchTopic_GetFirstObjAsync(" topicId=" + clsPrivateSessionStorage.topicId);
                    if (objResearchTopic == null) {
                        const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                        //const strThisFuncName = this.ShowData.name;
                    }
                    clsPublocalStorage.id_CurrEduCls = objResearchTopic.id_CurrEduCls;
                } 

                //const arrvTopicObjective_Cache = await vTopicObjective_GetObjLstAsync("1=1");

                var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
                const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
                if ($("#hidObjectiveId").val() != "") {
                    const UpdateRecord = await objPage_Edit.UpdateRecord($("#hidObjectiveId").val());
                     $("#divLoading").hide();
                }
                else {
                    objPage_Edit.AddNewRecord();
                    var configTypeId;
                    var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
                    if (strhidObjectiveTypeId=="01") {
                        configTypeId = "07";
                    }
                    else {
                        configTypeId = "08";
                    }
                    //获取分享Id
                    const responseText = await gs_UserConfigEx_GetNewReturnShareIdEx(configTypeId, clsPublocalStorage.userId);
                    var strShareId: string = responseText;
                    //var returnBool: boolean = !!responseText2;
                    if (strShareId != "") {
                        this.shareId = strShareId;
                    }
                    $("#divLoading").hide();
                }
                ////建立缓存
                //

                TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";
               
                //用户下拉框绑定
                //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
                const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域
                //文献类型；
                const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");

              
                //var strWhereCond = await this.CombinevTopicObjectiveCondition();
                //const responseText = await vTopicObjective_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                
                //});
                ////2、显示无条件的表内容在GridView中
                //const gvResult = await this.BindGv_vTopicObjective();
                //$('#divEditRegion').modal('show');
                //ShowDialog("Add");
                //进来默认添加界面设置；

                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；


                //获取传参的paperId
                var strPaperId = $("#hidRequestPaperId").val();
                if (strPaperId != "") {
                    $('#SelectPaper').hide();
                    //存放Id
                    $("#txtSourceId").val(strPaperId);
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
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
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


    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 <returns>条件串(strWhereCond)</returns>
*/
    public async CombinevTopicObjectiveCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.objectiveName_q != "") {
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveName} like '% ${this.objectiveName_q}%'`;
            }

            //判断客观类型 区分是客观事实、客观依据
            var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
            if (strhidObjectiveTypeId != "") {
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectiveTypeId}'`;
            }


            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；

            //$('#lnkUserName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

            }
            else if (strRoleId == "00620002") {

                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //学生； 
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdUser} = '${strUserId}'`;
                //学生00620003

                // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${objvUserRoleRelation.userId}'`;
            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineTopicObjectiveCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vTopicObjective() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevTopicObjectiveCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN> = [];
        try {
            this.recCount = await vTopicObjective_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: TopicObjectiveCRUD.sortvTopicObjectiveBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vTopicObjective_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvTopicObjectiveObjLst = <Array<clsvTopicObjectiveEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvTopicObjectiveObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vTopicObjective(strListDiv, arrvTopicObjectiveObjLst);
            console.log("完成BindGv_vTopicObjective!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vTopicObjective对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrTopicObjectiveObjLst">需要绑定的对象列表</param>
   */
    public async BindTab_vTopicObjective(divContainer: string, arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN>) {
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
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
               
                {
                    fldName: "objectiveName",
                    colHeader: "客观名称",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "objectiveType",
                    colHeader: "客观类型",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "objectiveTypeName",
                    colHeader: "客观类型名称",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "isSubmit",
                    colHeader: "是否提交",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updUser",
                    colHeader: "修改用户Id",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
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
        BindTab_V(o, arrvTopicObjectiveObjLst, arrDataColumn, "topicObjectiveId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    //////////////////////////////添加数据


    public Clear() {

        $("#hdnFileOne").val("");
        $("#hdnFileTwo").val("");
        $("#hdnFileThree").val("");
    }


    //////////////////////////////////////////////////////////////////////附件添加
    //添加上传论文附件方法
    public async AddNewRecordobjPaperSubAttachmentENSave(filePath: string, strfileNum: string) {
        var objObjectiveAttachmentEN: clsObjectiveAttachmentEN = new clsObjectiveAttachmentEN();
        this.PutDataToPaperAttachmentClass(objObjectiveAttachmentEN, filePath);
        try {
            const responseText2 = await ObjectiveAttachment_AddNewRecordAsync(objObjectiveAttachmentEN);
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
    public PutDataToPaperAttachmentClass(pobjObjectiveAttachmentEN: clsObjectiveAttachmentEN, filePath: string) {
        pobjObjectiveAttachmentEN.SetTopicObjectiveId($("#txtTopicObjectiveId").val());// 概念Id

        var strfilePath = filePath;
        //判断地址不为空则执行截取操作
        if (strfilePath != "") {
            var index = strfilePath.lastIndexOf("\/");
            strfilePath = strfilePath.substring(index + 1, strfilePath.length);
            pobjObjectiveAttachmentEN.SetFilePath(filePath);

            pobjObjectiveAttachmentEN.SetObjectiveAttachmentName(strfilePath);
        }
        pobjObjectiveAttachmentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期

        pobjObjectiveAttachmentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班
        pobjObjectiveAttachmentEN.SetUpdUserId(clsPublocalStorage.userId);// 修改用户Id


    }
    ///////////////////////////////////////////////////////////////////数据提交；
    //客观提交审核
    public async btnIsSubmit_Click(strKeyId: string) {

        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        //this.SubmitRecord(strKeyId);

    }
  
    ///////////////////////////////////////////////////////////////////删除数据控制；
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
            var strWhereCond = " topicObjectiveId in (" + strKeyList + ")";
            var arrTopicObjectiveObjLst: Array<clsTopicObjectiveEN> = [];
            const responseText1 = await TopicObjective_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrTopicObjectiveObjLst = <Array<clsTopicObjectiveEN>>jsonData;
                //查询是否有提交的数据
                arrTopicObjectiveObjLst = arrTopicObjectiveObjLst.filter(x => x.isSubmit == true);
                if (arrTopicObjectiveObjLst.length > 0) {
                    alert("包含有已提交数据，不能删除！");
                    return "";
                }
            });

            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vTopicObjective();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }
    ////////////////////////////////////////////////////修改数据


    //删除观点附件
    /* 
根据关键字删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public DelRecordByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync(strWhere).then((jsonData) => {
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

 
    //选择论文弹出列表数据；
    public async selectPaper_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.BindGv_vPaper();
    }
    //查询论文列表
    public async btnPaperQuery_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.BindGv_vPaper();
    }
    //确定选择的论文 并添加到关系表中
    public btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)

        $("#txtSourceId").val(strkeyId);
        //设置只读属性；
        $("#txtSourceId").attr("disabled", "disabled");
        //$("#txtPaperId").val(strkeyId);
        ////设置只读属性；
        //$("#txtPaperId").attr("disabled", "disabled");
        //关闭列表
        HideDialogThree();

    }


    /*
  * 文献类型
 */
    public set objectiveType(value: string) {
        $("#ddlObjectiveType").val(value);
    }
    /*
    * 文献类型
   */
    public get objectiveType(): string {
        return $("#ddlObjectiveType").val();
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