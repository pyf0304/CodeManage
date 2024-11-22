
import { Public_TopicObjective } from "../GraduateEduPublicPage/Public_TopicObjective.js";
import { RTTopicObjectiveRelaCRUD } from "../PagesBase/GraduateEduTopic/RTTopicObjectiveRelaCRUD.js";
import { TopicObjectiveCRUD } from "../PagesBase/GraduateEduTopic/TopicObjectiveCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsRTTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js";
import { clsTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js";
import { clsvRTTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTTopicObjectiveRelaEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { RTTopicObjectiveRela_AddNewRecordAsync, RTTopicObjectiveRela_DelRecordAsync, RTTopicObjectiveRela_GetObjBymIdAsync, RTTopicObjectiveRela_GetRecCountByCondAsync, RTTopicObjectiveRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTTopicObjectiveRelaWApi.js";
import { TopicObjective_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js";
import { vRTTopicObjectiveRela_GetObjLstByPagerAsync, vRTTopicObjectiveRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTTopicObjectiveRelaWApi.js";
import { vTopicObjective_GetObjLstByPagerAsync, vTopicObjective_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindTab, BindTabV2Where, BindTabV2Where_V, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { RTTopicObjectiveRela_EditEx } from "./RTTopicObjectiveRela_EditEx.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogThree(): void;
declare function HideDialogEight(): void;
declare var $;
declare var window;
/* WApiTopicObjective_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class ResearchTopicObjectiveEx extends RTTopicObjectiveRelaCRUD implements IShowList {
    //客观数据列表
    public mstrListDivObjective: string = "divObjectiveDataLst";
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvTopicObjectiveBy: string = "topicObjectiveId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 30;
    }

    //客观事实
    public mstrListTopicObjectiveDivPaper: string = "divRtTopicObjectiveDataLst";
    //客观依据

    public mstrListBasisTopicObjectiveDivPaper: string = "divBasisRtTopicObjectiveDataLst";

    BindGv(strType: string, strPara: string) {
        this.BindGv_vRTTopicObjectiveRela();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vRTTopicObjectiveRela":
                alert('该类没有绑定该函数：[this.BindGv_vRTTopicObjectiveRela_Cache]！');
                //this.BindGv_vRTTopicObjectiveRela_Cache();
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
        let objPage: ResearchTopicObjectiveEx;
        if (RTTopicObjectiveRelaCRUD.objPage_CRUD == null) {
            RTTopicObjectiveRelaCRUD.objPage_CRUD = new ResearchTopicObjectiveEx();
            objPage = <ResearchTopicObjectiveEx>RTTopicObjectiveRelaCRUD.objPage_CRUD;
        }
        else {
            objPage = <ResearchTopicObjectiveEx>RTTopicObjectiveRelaCRUD.objPage_CRUD;
        }
        const objPage_Edit: RTTopicObjectiveRela_EditEx = new RTTopicObjectiveRela_EditEx(objPage);
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
                strMsg = '命令:' + strCommandName + "在函数(ResearchTopicObjectiveExEx.btn_Click)中没有被处理！";
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
                ////建立缓存
                //
                //const arrvTopicObjective_Cache = await vTopicObjective_GetObjLstAsync("1=1");

                TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";

                ////用户下拉框绑定
                //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                ////文献类型；
                //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");

                //var strWhereCond = await this.CombinevTopicObjectiveCondition();
                //const responseText = await vTopicObjective_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                
                //});
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vTopicObjective();
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



    //客观事实
    public async liObjectiveFactClick() {
        try {
            //主题客观关系
            this.hidSortvRTTopicObjectiveRelaBy = "classificationId Asc,updDate Desc";
            //客观
            TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";

            const gvResultPaper = await this.BindGv_vRTTopicObjectiveRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取客观事实列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //客观依据
    public async liObjectiveBasisClick() {
        try {
            //主题客观关系
            this.hidSortvRTTopicObjectiveRelaBy = "classificationId Asc,updDate Desc";
            //客观
            TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";

            const gvResultPaper = await this.BasisBindGv_vRTTopicObjectiveRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取客观依据列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public async CombinevTopicObjectiveCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1=1";
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strUserId = clsPublocalStorage.userId;

        var txtObjUpdName_q = $("#txtObjUpdName_q").val();
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.objectiveName_q != "") {
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveName} like '% ${this.objectiveName_q}%'`;
            }

            if (clsPublocalStorage.eduClsTypeId == "0001") {
                $("#ddlCurrEduCls_q3").hide();
                $("#ddlPublicViewPoint").show();
                if ($("#ddlPublicViewPoint") == "1") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdUser} in('${clsPublocalStorage.TopicUserList}')`;
                }
                else {
                    strWhereCond += ` And ${clsvTopicObjectiveEN.con_ShareId} ='03'`;
                }
                
            } else {
                //用户
                if (txtObjUpdName_q != "") {
                    var strUserName = txtObjUpdName_q;
                    var objUser = arrUsers.find(x => x.userName == strUserName);
                    if (objUser != null) {
                        strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdUser} = '${objUser.userId}'`;
                    }

                }
            }

          
            if ($("#ddlCurrEduCls_q3").val() != "" && $("#ddlCurrEduCls_q3").val() != "0") {
                strWhereCond += " And id_CurrEduCls='" + $("#ddlCurrEduCls_q3").val() + "'";
            }
            else {
                strWhereCond += " And id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            }

            //根据类型来查询；
            //根据传入的hidObjectiveTypeId 来区分是事实或依据
            var strhidObjectvieTypeId = $("#hidObjectiveTypeId").val();
            if (strhidObjectvieTypeId != "") {
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectvieTypeId}'`;
            }

            //只能查询提交的客观数据
            strWhereCond += ` And ${clsvTopicObjectiveEN.con_IsSubmit} = 'true'`;

            //排除获取已存在的关系数据 根据当前用户；
            strWhereCond += ` And topicObjectiveId not in (select topicObjectiveId from vRTTopicObjectiveRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;




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
        var strListDiv: string = this.mstrListDivObjective;
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

            //this.BindTab_vTopicObjective(strListDiv, arrvTopicObjectiveObjLst);
            //var strPageType = $("#hidObjectiveTypeId").val();//页面参数
            //var strTitle = "";
            ////判断页面参数
            //if (strPageType == "01") {
            //    strTitle = "客观事实";
            //} else if (strPageType == "02") {
            //    //专家观点
            //    //$("#ListTitle").html("当前论文相关的专家观点");
            //    strTitle = "客观数据";
            //}
            //var strhtml = "";
            ////个人观点
            //strhtml += '<div class="info" id="infoFacts"><div class="title btn-5">';

            //strhtml += '<div><a href="#" title="' + strTitle + '">' + strTitle + '</a></div>';
            ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvTopicObjectiveObjLst.length; i++) {
            //    //得到viewpointId；
            //    var strTopicObjectiveId = arrvTopicObjectiveObjLst[i].topicObjectiveId;
            //    v++;
            //    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
            //    strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveName + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveContent + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].conclusion + '</span></li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvTopicObjectiveObjLst[i].userName;
            //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvTopicObjectiveObjLst[i].updDate;
            //    //引用数
            //    strhtml += '&nbsp;&nbsp;被引用数:' + arrvTopicObjectiveObjLst[i].citationCount;


            //    strhtml += '&nbsp;&nbsp;<button title="引用该' + strTitle + '" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkObjectiveInTab_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '") > <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';

            //    strhtml += '</li>';
            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';
            var strPageType = $("#hidObjectiveTypeId").val();//页面参数
            var strHtml = await Public_TopicObjective.BindList_vTopicObjective("02", strPageType, arrvTopicObjectiveObjLst)
            //拼接；
            $("#divObjectiveDataLst").html(strHtml);

            if (arrvTopicObjectiveObjLst.length > 10) {
                //$("#divPager3").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            console.log("完成BindGv_vTopicObjective!");
            //this.BindTab_vTopicObjective(strListDiv, arrvTopicObjectiveObjLst);
            //console.log("完成BindGv_vTopicObjective!");
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
                //{
                //    fldName: "paperTitle",
                //    colHeader: "论文标题",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
               
                {
                    fldName: "objectiveName",
                    colHeader: "客观名称",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                {
                    fldName: "objectiveContent",
                    colHeader: "客观内容",
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
                //{
                //    fldName: "isSubmit",
                //    colHeader: "是否提交",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "编辑人",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnOkObjectiveInTab_Click('${strKeyId}');`);
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
        //BindTab(o, arrvTopicObjectiveObjLst, arrDataColumn, "topicObjectiveId");
        BindTabV2Where_V(o, arrvTopicObjectiveObjLst, arrDataColumn, "topicObjectiveId", "TopicObjectiveFact");
        if (arrvTopicObjectiveObjLst.length > 10) {
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //this.objPager.recCount = this.recCount;
        //this.objPager.pageSize = this.pageSize;
        //this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    //概念查询按钮
    public async btnQueryObjective_Click() {
        //查询客观列表
        const responseObjList = await this.BindGv_vTopicObjective();
    }
    //分页数据
    /* 函数功能:在数据 列表中跳转到某一页 观点列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
 <param name = "intPageIndex">页序号</param>
*/
    public IndexPageSeven(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_vTopicObjective();
    }

    //添加客观关系弹出客观列表按钮
    public async btnAddTopicObjectiveRela_Click() {
        var strRoleId = clsPublocalStorage.roleId;
        if (strRoleId == "00620003") {
            const Ddl_CurrEduClsStu_q = await clsDropDownList.BindDdl_CurrEduClsStu("ddlCurrEduCls_q3");
        } else {
            const Ddl_CurrEduClsTea_q = await clsDropDownList.BindDdl_CurrEduClsTea("ddlCurrEduCls_q3");
        }
        const responseObjList = await this.BindGv_vTopicObjective();
    }



    public async SortByObjectiveFact(strSortByFld: string) {
        if (TopicObjectiveCRUD.sortvTopicObjectiveBy.indexOf(strSortByFld) >= 0) {
            if (TopicObjectiveCRUD.sortvTopicObjectiveBy.indexOf("Asc") >= 0) {
                TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Desc`;
            }
            else {
                TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Asc`;
            }
        }
        else {
            TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vTopicObjective();
    }




    //////////////////////////////////////客观事实关系//////////////////////////////////////
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public async CombinevRTTopicObjectiveRelaCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            var strClassificationId = $("#hidClassificationId").val();
            if (strClassificationId != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_ClassificationId} = '${strClassificationId}'`;
            }
            var strViewsId = $("#hidViewsId").val();
            if (strViewsId != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_mId} = ${strViewsId}`;
            }

            //查询客观事实
            strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_ObjectiveType} = '01'`;
            //读取session角色 来判断绑定不同数据列表
            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {
            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                // strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                //学生00620003

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTTopicObjectiveRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vRTTopicObjectiveRela() {
        var strListDiv: string = this.mstrListTopicObjectiveDivPaper;
        var strWhereCond = await this.CombinevRTTopicObjectiveRelaCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvRTTopicObjectiveRelaObjLst: Array<clsvRTTopicObjectiveRelaEN> = [];
        try {
            this.recCount = await vRTTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTTopicObjectiveRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTTopicObjectiveRelaObjLst = <Array<clsvRTTopicObjectiveRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        try {


            this.BindList_vRTTopicObjectiveRela("01", arrvRTTopicObjectiveRelaObjLst);
            console.log("完成BindGv_vRTTopicObjectiveRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    public async BindList_vRTTopicObjectiveRela(strType: string, arrvRTTopicObjectiveRelaObjLst: Array<clsvRTTopicObjectiveRelaEN>) {

        //var strUserId = clsPublocalStorage.userId;
        //var strTitle = "";
        ////判断页面参数
        //if (strPageType == "04") {
        //    strTitle = "客观事实";
        //} else if (strPageType == "05") {

        //    strTitle = "客观数据";
        //}
        //var strhtml = "";

        //strhtml += '<div class="info" id="infoFacts">';

        //strhtml += '<div class="title btn-5"><div style="float:left;"><a href="#" title="' + strTitle + '">' + strTitle + '</a></div></div>';

        //strhtml += '<ul class="artlist">';
        //var v = 0;//给内容加个序号
        //for (var i = 0; i < arrvRTTopicObjectiveRelaObjLst.length; i++) {
        //    //得到viewpointId；
        //    var strTopicObjectiveId = arrvRTTopicObjectiveRelaObjLst[i].topicObjectiveId;
        //    v++;
        //    var strObjectiveContent = arrvRTTopicObjectiveRelaObjLst[i].objectiveContent;
        //    var strConclusion = arrvRTTopicObjectiveRelaObjLst[i].conclusion;
        //    strObjectiveContent = strObjectiveContent.replace(/\r\n/g, this.strBr);
        //    strObjectiveContent = strObjectiveContent.replace(/\n/g, this.strBr);
        //    strConclusion = strConclusion.replace(/\r\n/g, this.strBr);
        //    strConclusion = strConclusion.replace(/\n/g, this.strBr);
        //    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
        //    strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst[i].objectiveName + '</span></li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + strObjectiveContent + '</span></li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + strConclusion + '</span></li>';

        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';

        //    if (arrvRTTopicObjectiveRelaObjLst[i].appraiseCount != 0) {
        //        //评论
        //        strhtml += '&nbsp;&nbsp;评论数：' + arrvRTTopicObjectiveRelaObjLst[i].appraiseCount;
        //    }
        //    if (arrvRTTopicObjectiveRelaObjLst[i].score != 0) {
        //        //评分
        //        strhtml += '&nbsp;&nbsp;综合评分：' + arrvRTTopicObjectiveRelaObjLst[i].score;
        //    }
        //    if (arrvRTTopicObjectiveRelaObjLst[i].teaScore != 0) {
        //        strhtml += '&nbsp;&nbsp;教师评分：' + arrvRTTopicObjectiveRelaObjLst[i].teaScore;
        //    }
        //    if (arrvRTTopicObjectiveRelaObjLst[i].stuScore != 0) {
        //        strhtml += '&nbsp;&nbsp;学生评分：' + arrvRTTopicObjectiveRelaObjLst[i].stuScore;
        //    }
        //    //引用数
        //    strhtml += '&nbsp;&nbsp;被引用数：' + arrvRTTopicObjectiveRelaObjLst[i].citationCount;
        //    if (arrvRTTopicObjectiveRelaObjLst[i].versionCount != 0) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvRTTopicObjectiveRelaObjLst[i].versionCount;
        //    }
        //    if (arrvRTTopicObjectiveRelaObjLst[i].isSubmit == true) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
        //    }
        //    else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
        //    }

        //    strhtml += '</li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';

        //    if (arrvRTTopicObjectiveRelaObjLst[i].objUserId == arrvRTTopicObjectiveRelaObjLst[i].updUser) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + arrvRTTopicObjectiveRelaObjLst[i].ObjUserName;
        //    } else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + arrvRTTopicObjectiveRelaObjLst[i].ObjUserName + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst[i].userName;
        //    }
        //    if (arrvRTTopicObjectiveRelaObjLst[i].objDate == arrvRTTopicObjectiveRelaObjLst[i].updDate) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvRTTopicObjectiveRelaObjLst[i].objDate;
        //    } else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvRTTopicObjectiveRelaObjLst[i].objDate + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst[i].updDate;
        //    }

        //    if (strUserId == arrvRTTopicObjectiveRelaObjLst[i].updUser) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelObjectiveRecordInTab_Click(' + arrvRTTopicObjectiveRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除引用</button>';
        //    }
        //    if (arrvRTTopicObjectiveRelaObjLst[i].isSubmit != true) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdObjective_Click("' + arrvRTTopicObjectiveRelaObjLst[i].topicObjectiveId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
        //    }
        //    //strhtml += '&nbsp;&nbsp;<button style="float:right;" title="删除' + strTitle + '" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelObjectiveRecordInTab_Click(' + arrvRTTopicObjectiveRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>删除' + strTitle + '</button>';
        //    if (arrvRTTopicObjectiveRelaObjLst[i].versionCount > 0 && arrvRTTopicObjectiveRelaObjLst[i].versionCount != null) {
        //        strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('" + strTitle + "历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTTopicObjectiveRelaObjLst[i].topicObjectiveId + "&Type=06')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
        //    }

        //    strhtml += '</li>';
        //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //}
        //strhtml += '</ul></div>';

        $("#hidPageType").val(strType);
        var strPageType = strType;//页面参数
        var strHtml = await Public_TopicObjective.BindList_vRTTopicObjectiveRela("06", strPageType, arrvRTTopicObjectiveRelaObjLst)

        if (strPageType == "01") {
            $("#divRtTopicObjectiveDataLst").html(strHtml);

            if (arrvRTTopicObjectiveRelaObjLst.length > 10) {
                $("#divPagerObjective").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        } else if (strPageType == "02") {
            $("#divBasisRtTopicObjectiveDataLst").html(strHtml);

            if (arrvRTTopicObjectiveRelaObjLst.length > 10) {
                $("#divPagerBasis").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        //拼接；

    }
    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvRTTopicObjectiveRelaBy(value: string) {
        $("#hidSortvRTTopicObjectiveRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvRTTopicObjectiveRelaBy(): string {
        return $("#hidSortvRTTopicObjectiveRelaBy").val();
    }

    /* 
在数据表里删除记录 删除客观事实
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelObjectiveRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            var strUserId = clsPublocalStorage.userId;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = RTTopicObjectiveRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRTTopicObjectiveEN: clsRTTopicObjectiveRelaEN = <clsRTTopicObjectiveRelaEN>jsonData;
                if (objRTTopicObjectiveEN != null) {
                    if (objRTTopicObjectiveEN.updUser == strUserId) {

                        if ($("#hidPageType").val() == "01") {
                            const responseText = this.DelObjectiveRecord(lngKeyId, "01");
                        } else if ($("#hidPageType").val() == "02") {
                            const responseText = this.DelObjectiveRecord(lngKeyId, "02");
                        }
                    }
                    else {

                        //成员
                        var strMsg = `您只能删除自己添加的数据！`;
                        alert(strMsg);
                        return;
                    }
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

    //删除客观依据
    public async btnDelBasisObjectiveRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            var strUserId = clsPublocalStorage.userId;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = RTTopicObjectiveRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRTTopicObjectiveBasisEN: clsRTTopicObjectiveRelaEN = <clsRTTopicObjectiveRelaEN>jsonData;
                if (objRTTopicObjectiveBasisEN != null) {
                    if (objRTTopicObjectiveBasisEN.updUser == strUserId) {
                        //01 客观依据
                        const responseText = this.DelObjectiveRecord(lngKeyId, "02");
                        // const responseText2 = await this.BindGv_vRTPaperRela();
                    }
                    else {

                        //成员
                        var strMsg = `您只能删除自己添加的数据！`;
                        alert(strMsg);
                        return;
                    }
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
根据关键字删除记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public async DelObjectiveRecord(lngmId: number, TypeId: string) {
        try {
            const responseText = await RTTopicObjectiveRela_DelRecordAsync(lngmId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                if (TypeId == "01") {
                    //客观事实
                    this.BindGv_vRTTopicObjectiveRela();
                }
                else {
                    //客观依据
                    this.BasisBindGv_vRTTopicObjectiveRela();

                }
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

    //////////////////////////////////////。。。。。。。。。。。。。。。。。。。客观依据关系
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public BasisCombinevRTTopicObjectiveRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_TopicId} = '${strTopicId}'`;
            }

            var strClassificationId = $("#hidClassificationId").val();
            if (strClassificationId != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_ClassificationId} = '${strClassificationId}'`;
            }
            var strViewsId = $("#hidViewsId").val();
            if (strViewsId != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_mId} = ${strViewsId}`;
            }


            //查询客观依据
            strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_ObjectiveType} = '02'`;
            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {

            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //     strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //      strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTTopicObjectiveRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /*  客观依据
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BasisBindGv_vRTTopicObjectiveRela() {
        var strListDiv: string = this.mstrListBasisTopicObjectiveDivPaper;
        var strWhereCond = this.BasisCombinevRTTopicObjectiveRelaCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvRTTopicObjectiveRelaObjLst: Array<clsvRTTopicObjectiveRelaEN> = [];
        try {
            this.recCount = await vRTTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTTopicObjectiveRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTTopicObjectiveRelaObjLst = <Array<clsvRTTopicObjectiveRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        try {
            this.BindList_vRTTopicObjectiveRela("02", arrvRTTopicObjectiveRelaObjLst);
            console.log("完成BindGv_vRTTopicObjectiveRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }




    /* 主题客观事实
*/
    public async SortByRTObjectiveFact(strSortByFld: string) {
        if (TopicObjectiveCRUD.sortvTopicObjectiveBy.indexOf(strSortByFld) >= 0) {
            if (TopicObjectiveCRUD.sortvTopicObjectiveBy.indexOf("Asc") >= 0) {
                TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Desc`;
            }
            else {
                TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Asc`;
            }
        }
        else {
            TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vRTTopicObjectiveRela();
    }



    /* 主题客观依据
*/
    public async SortByRTObjectiveBasis(strSortByFld: string) {
        if (TopicObjectiveCRUD.sortvTopicObjectiveBy.indexOf(strSortByFld) >= 0) {
            if (TopicObjectiveCRUD.sortvTopicObjectiveBy.indexOf("Asc") >= 0) {
                TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Desc`;
            }
            else {
                TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Asc`;
            }
        }
        else {
            TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BasisBindGv_vRTTopicObjectiveRela();
    }

}