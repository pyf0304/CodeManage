
/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiTopicObjective_QUDI_TSEx
表名:TopicObjective(01120613)
生成代码版本:2020.03.20.1
生成日期:2020/03/23 16:53:03
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
import { Public_TopicObjective } from "../GraduateEduPublicPage/Public_TopicObjective.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsgs_OriginalPaperLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js";
import { clsgs_PTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PTopicObjectiveRelaEN.js";
import { clsTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { gs_OriginalPaperLog_AddNewRecordAsync, gs_OriginalPaperLog_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js";
import { gs_PTopicObjectiveRela_AddNewRecordAsync, gs_PTopicObjectiveRela_GetRecCountByCondAsync, gs_PTopicObjectiveRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PTopicObjectiveRelaWApi.js";
import { TopicObjective_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js";
import { vTopicObjective_GetObjLstByPagerAsync, vTopicObjective_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogThree(): void;
declare function HideDialogEight(): void;
declare function RefreshWindow(): void;
declare var $;
declare var window;
/* WApiTopicObjective_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_PObjectiveRela implements clsOperateList{
    //客观数据列表
    public mstrListDivObjective: string = "divObjectiveDataLst";
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            if (clsPubSessionStorage.GetSession_UserId() != "") {
                ////建立缓存
                //
                //const arrvTopicObjective_Cache = await vTopicObjective_GetObjLstAsync("1=1");

                this.hidSortvTopicObjectiveBy = "updDate Desc";

                ////用户下拉框绑定
                //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                ////文献类型；
                //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");

                //var strWhereCond = this.CombinevTopicObjectiveCondition();
                //const responseText = await vTopicObjective_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
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


    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public async CombinevTopicObjectiveCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
        var strPaperId = $('#hidPaperId').val();
        var strUserId = clsPubSessionStorage.GetSession_UserId();

        var txtObjUpdName_q = $("#txtObjUpdName_q").val();
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //只能查询提交的客观数据
            strWhereCond += ` And ${clsvTopicObjectiveEN.con_IsSubmit} = 'true'`;


            var strPageType = $("#hidPageType").val();
            if (strPageType == "gs_TDR") {
                if ($("#txtViewpointName_q").val() != "") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveName} like '% ${$("#txtViewpointName_q").val()}%'`;
                }
                if ($("#txtViewUpdName_q").val() != "") {
                    var strUserName = $("#txtViewUpdName_q").val();
                    var objUser = arrUsers.find(x => x.userName == strUserName);
                    if (objUser != null) {
                        strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdUser} = '${objUser.userId}'`;
                    }
                   
                }
                var strhidObjectvieTypeId = $("#hidObjectiveTypeId").val();
                if (strhidObjectvieTypeId != "") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectvieTypeId}'`;
                }
                //strWhereCond += ` And topicObjectiveId not in (select topicObjectiveId from RTTopicObjectiveRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
            }
            else {
                if (this.ObjectiveName_q != "") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveName} like '% ${this.ObjectiveName_q}%'`;
                }
                if (txtObjUpdName_q != "") {
                    var strUserName = txtObjUpdName_q;
                    var objUser = arrUsers.find(x => x.userName == strUserName);
                    if (objUser != null) {
                        strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdUser} = '${objUser.userId}'`;
                    }
                }
                //根据类型来查询；
                //根据传入的hidObjectiveTypeId 来区分是事实或依据
                var strhidObjectvieTypeId = $("#hidObjectiveTypeId").val();
                if (strhidObjectvieTypeId != "") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectvieTypeId}'`;
                }
                //排除获取已存在的关系数据 根据当前用户；
                strWhereCond += ` And topicObjectiveId not in (select topicObjectiveId from gs_PTopicObjectiveRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;

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
        var strListDiv: string = this.mstrListDivObjective;
        var strWhereCond = await this.CombinevTopicObjectiveCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN> = [];
        try {
            const responseRecCount = await vTopicObjective_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvTopicObjectiveBy,
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

            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';

            //    ////评论
            //    //strhtml += '&nbsp;&nbsp;评论数:' + arrvTopicObjectiveObjLst[i].appraiseCount;
            //    ////评分
            //    //strhtml += '&nbsp;&nbsp;综合评分:' + arrvTopicObjectiveObjLst[i].score + '';
            //    //strhtml += '&nbsp;&nbsp;教师评分:' + arrvTopicObjectiveObjLst[i].teaScore + '';
            //    //strhtml += '&nbsp;&nbsp;学生评分:' + arrvTopicObjectiveObjLst[i].stuScore + '';


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
                this.objPager.RecCount = this.RecCount;
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
    public BindTab_vTopicObjective(divContainer: string, arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN>) {
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
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "paperTitle",
                //    ColHeader: "论文标题",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                
                {
                    FldName: "objectiveName",
                    ColHeader: "客观名称",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },

                {
                    FldName: "objectiveContent",
                    ColHeader: "客观内容",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "objectiveTypeName",
                    ColHeader: "客观类型名称",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "isSubmit",
                //    ColHeader: "是否提交",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "编辑人",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定", TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnOkObjectiveInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    ColHeader: "修改",
                //    Text: "修改",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        //clsCommonFunc4Web.BindTabV2(o, arrvTopicObjectiveObjLst, arrDataColumn, "topicObjectiveId");
        clsCommonFunc4Web.BindTabV2Where(o, arrvTopicObjectiveObjLst, arrDataColumn, "topicObjectiveId", "TopicObjectiveFact");
        if (arrvTopicObjectiveObjLst.length > 10) {
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //this.objPager.RecCount = this.RecCount;
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
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        this.BindGv_vTopicObjective();
    }

    //添加客观关系弹出客观列表按钮
    public async btnAddTopicObjectiveRela_Click() {

        const responseObjList = await this.BindGv_vTopicObjective();
    }



    //确定选择的客观观点 并添加到关系表中
    public btnOkObjectiveInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidObjectiveId").val(strkeyId)
        //执行添加关系方法
        this.AddNewRecordSave();
    }
    /* 添加新记录，保存函数
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSave() {
        var strObjectiveId = $("#hidObjectiveId").val()
        var strPaperId = $('#hidPaperId').val();
        var strPaperLogTypeId = $('#hidPaperLogTypeId').val();//流程日志参数
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        this.DivName = "divAddNewRecordSave";
        var objgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN = new clsgs_PTopicObjectiveRelaEN();
        this.PutDataTogs_PTopicObjectiveRelaClass(objgs_PTopicObjectiveRelaEN);
        try {
            //同一主题 同一客观事实 数据 只能添加一次；
            var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And topicObjectiveId = '" + strObjectiveId + "'";
            //var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And viewpointId = '" + strViewpointId + "'";
            const responseText = await gs_PTopicObjectiveRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题同一用户不能重复添加同一个客观事实数据！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            else {
                const responseText = await gs_PTopicObjectiveRela_AddNewRecordAsync(objgs_PTopicObjectiveRelaEN);
                var returnBool: boolean = !!responseText;
                if (returnBool == true) {
                    var strInfo: string = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);

                    //查询 论文、日志类型是否存在；
                    var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And logTypeId = '" + strPaperLogTypeId + "'";
                    const responseText6 = await gs_OriginalPaperLog_IsExistRecordAsync(strWhere);
                    var bolIsExist: boolean = responseText6;
                    if (bolIsExist == true) {

                        return responseText6;//一定要有一个返回值，否则会出错！
                    }
                    else {
                        //添加论文日志；
                        const responseText7 = await this.Addgs_OriginalPaperLogSave().then((jsonData) => {


                        });
                    }


                    //根据ID获取最大数；
                    var strWhereCond2 = " 1 =1 and topicObjectiveId=" + strObjectiveId;
                    var intCitationCount = await gs_PTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond2);


                    var objTopicObjectiveEN: clsTopicObjectiveEN = new clsTopicObjectiveEN();
                    objTopicObjectiveEN.topicObjectiveId = strObjectiveId;
                    objTopicObjectiveEN.citationCount = intCitationCount;

                    objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString;//设置哪些字段被修改(脏字段)
                    if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                        throw "关键字不能为空!";
                    }

                    const responseText = await TopicObjective_UpdateRecordAsync(objTopicObjectiveEN).then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {


                        }
                        else {
                            var strInfo: string = `操作不成功!`;
                            alert(strInfo);
                            console.log("操作不成功");
                        }

                    });

                    //显示信息框
                    alert(strInfo);
                    HideDialogEight();
                    RefreshWindow();
                }
                else {
                    var strInfo: string = `添加记录不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
            }

            return responseText;//一定要有一个返回值，否则会出错！
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
    //添加论文流程日志
    public async Addgs_OriginalPaperLogSave() {


        var objgs_OriginalPaperLogEN: clsgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN();
        this.PutDataTogs_OriginalPaperLog(objgs_OriginalPaperLogEN);

        try {
            const responseText2 = await gs_OriginalPaperLog_AddNewRecordAsync(objgs_OriginalPaperLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                console.log("添加新建论文日志成功");

            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加日志记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }
    public async PutDataTogs_OriginalPaperLog(pobjgs_OriginalPaperLogEN: clsgs_OriginalPaperLogEN) {
        var strPaperId = $("#hidPaperId").val();
        var strPaperLogTypeId = $('#hidPaperLogTypeId').val();//流程日志参数
        ////通过区分 是小组讨论还是同伴建议
        //var strPaperLogTypeId = $('#hidCommentTypeId').val();
        pobjgs_OriginalPaperLogEN.paperId = strPaperId;
        pobjgs_OriginalPaperLogEN.logTypeId = strPaperLogTypeId;
        pobjgs_OriginalPaperLogEN.logDescription = "添加子观点";
        //$('#PaperLogTypeId').val("02");
        //switch (strPaperLogTypeId) {
        //    case "01":
        //        pobjgs_OriginalPaperLogEN.logDescription = "添加子观点";
        //        break;
        //    case "02":
        //        pobjgs_OriginalPaperLogEN.logDescription = "同伴建议";
        //        break;

        //    default:
        //        var strMsg = `没有数据处理！`;
        //        alert(strMsg);
        //        break;
        //}
        //pobjgs_OriginalPaperLogEN.logDescription = "新建论文";
        pobjgs_OriginalPaperLogEN.updUser = clsPubSessionStorage.GetSession_UserId();
        pobjgs_OriginalPaperLogEN.updDate = clsPubFun4Web.getNowDate();
    }
    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjgs_PTopicObjectiveRelaEN">数据传输的目的类对象</param>
*/
    public PutDataTogs_PTopicObjectiveRelaClass(pobjgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN) {
        var strPaperId = $("#hidPaperId").val();
        var strObjectiveId = $("#hidObjectiveId").val();
        var strUserId = clsPubSessionStorage.GetSession_UserId();


        pobjgs_PTopicObjectiveRelaEN.paperId = strPaperId;// 主题编号
        pobjgs_PTopicObjectiveRelaEN.sectionId = $("#ddlSectionId3").val();// 论文章节id
        pobjgs_PTopicObjectiveRelaEN.topicObjectiveId = strObjectiveId;// 客观Id
        pobjgs_PTopicObjectiveRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjgs_PTopicObjectiveRelaEN.updUser = strUserId;// 修改人
        pobjgs_PTopicObjectiveRelaEN.memo = this.memo;// 备注
    }

    public async SortByObjectiveFact(strSortByFld: string) {
        if (this.hidSortvTopicObjectiveBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvTopicObjectiveBy.indexOf("Asc") >= 0) {
                this.hidSortvTopicObjectiveBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvTopicObjectiveBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvTopicObjectiveBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vTopicObjective();
    }



    /*
    * 设置取消按钮的标题
   */
    public set btnCancel(value: string) {
        $("#btnCancel").html(value);
    }
    /*
    * 设置确定按钮的标题
   */
    public set btnOKUpd(value: string) {
        $("#btnOKUpd").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnOKUpd(): string {
        return $("#btnOKUpd").html();
    }
    /*
    * 结论
   */
    public set conclusion(value: string) {
        $("#txtconclusion").val(value);
    }
    /*
    * 结论
   */
    public get conclusion(): string {
        return $("#txtconclusion").val();
    }
    /*
    * 获取当前页序号
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
    /*
    * 添加、修改用的层名
   */
    public set DivName(value: string) {
        $("#hidDivName").val(value);
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvTopicObjectiveBy(value: string) {
        $("#hidSortvTopicObjectiveBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvTopicObjectiveBy(): string {
        return $("#hidSortvTopicObjectiveBy").val();
    }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return clsPubSessionStorage.GetSession_UserId();
    }
    /*
    * 是否提交
   */
    public set isSubmit(value: boolean) {
        $("#chkIsSubmit").val(value);
    }
    /*
    * 是否提交
   */
    public get isSubmit(): boolean {
        return $("#chkIsSubmit").prop("checked");
    }
    /*
    * 设置关键字的值
   */
    public set KeyId(value: string) {
        $("#hidKeyId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get KeyId(): string {
        return $("#hidKeyId").val();
    }
    /*
    * 备注
   */
    public set memo(value: string) {
        $("#txtMemo").val(value);
    }
    /*
    * 备注
   */
    public get memo(): string {
        return $("#txtMemo").val();
    }
    /*
    * 客观内容
   */
    public set objectiveContent(value: string) {
        $("#txtObjectiveContent").val(value);
    }
    /*
    * 客观内容
   */
    public get objectiveContent(): string {
        return $("#txtObjectiveContent").val();
    }
    /*
    * 客观名称
   */
    public set objectiveName(value: string) {
        $("#txtObjectiveName").val(value);
    }
    /*
    * 客观名称
   */
    public get objectiveName(): string {
        return $("#txtObjectiveName").val();
    }
    /*
    * 客观名称
   */
    public get ObjectiveName_q(): string {
        return $("#txtObjectiveName_q").val();
    }
    /*
    * 客观类型
   */
    public set objectiveType(value: string) {
        $("#txtObjectiveType").val(value);
    }
    /*
    * 客观类型
   */
    public get objectiveType(): string {
        return $("#txtObjectiveType").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set OpType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public get OpType(): string {
        return $("#hidOpType").val();
    }
    /*
    * 来源Id
   */
    public set sourceId(value: string) {
        $("#txtSourceId").val(value);
    }
    /*
    * 来源Id
   */
    public get sourceId(): string {
        return $("#txtSourceId").val();
    }
    /*
    * 客观Id
   */
    public set topicObjectiveId(value: string) {
        $("#txtTopicObjectiveId").val(value);
    }
    /*
    * 客观Id
   */
    public get topicObjectiveId(): string {
        return $("#txtTopicObjectiveId").val();
    }
    /*
    * 修改日期
   */
    public set updDate(value: string) {
        $("#txtUpdDate").val(value);
    }
    /*
    * 修改日期
   */
    public get updDate(): string {
        return $("#txtUpdDate").val();
    }
    /*
    * 修改用户Id
   */
    public set updUser(value: string) {
        $("#txtUpdUser").val(value);
    }
    /*
    * 修改用户Id
   */
    public get updUser(): string {
        return $("#txtUpdUser").val();
    }
}
