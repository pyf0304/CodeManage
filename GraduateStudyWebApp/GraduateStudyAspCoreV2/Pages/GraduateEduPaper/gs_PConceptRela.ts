
/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiConceptCRUDEx
表名:Concept(01120602)
生成代码版本:2020.03.03.1
生成日期:2020/03/09 13:58:58
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
import { Public_Concept } from "../GraduateEduPublicPage/Public_Concept.js";
import { ConceptCRUD } from "../PagesBase/GraduateEduTopic/ConceptCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsgs_OriginalPaperLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js";
import { clsgs_PConcepRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PConcepRelaEN.js";
import { clsConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js";
import { clsvConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { gs_OriginalPaperLog_AddNewRecordAsync, gs_OriginalPaperLog_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js";
import { gs_PConcepRela_AddNewRecordAsync, gs_PConcepRela_GetRecCountByCondAsync, gs_PConcepRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PConcepRelaWApi.js";
import { Concept_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js";
import { vConcept_GetObjLstByPagerAsync, vConcept_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { BindTab, BindTabV2Where, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList, GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogThree(): void;
declare function RefreshWindow(): void;
declare function HideDialogSeven(): void;
declare var $;
declare var window;
/* WApiConceptCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_PConceptRela extends ConceptCRUD {
    //论文列表
    public mstrListDivPaper: string = "divConceptDataLst";
    
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortConceptBy: string = "conceptId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public recCount = 0;

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
*/
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {

            if (clsPublocalStorage.userId != "") {

                //const arrConcept_Cache = await vConcept_GetObjLstAsync("1=1");
                //1、为下拉框设置数据源,绑定列表数据

                //1、为下拉框设置数据源,绑定列表数据
                ConceptCRUD.sortConceptBy = "updDate Desc";
                //var objConcept_Cond = await this.CombineConceptConditionObj();
                //this.recCount = await vConcept_GetRecCountByCond_Cache(objConcept_Cond);
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_Concept_Cache();

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
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombineConceptCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        var strPaperId = $('#hidPaperId').val();
        var strConceptId = $("#hidConceptId").val();

        var strUserId = clsPublocalStorage.userId;

            //获取用户缓存
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

        var objConcept_Cond: clsConceptEN = new clsConceptEN();
        //只能查询提交的概念数据
        strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = 'true'`;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            var strPageType = $("#hidPageType").val();
            if (strPageType == "gs_TDR") {
                if ($("#txtViewpointName_q").val() != "") {
                    strWhereCond += ` And ${clsConceptEN.con_ConceptName} like '% ${$("#txtViewpointName_q").val()}%'`;
                }
                if ($("#txtViewUpdName_q").val() != "") {
                    var strUserName:string = $("#txtViewUpdName_q").val();
                    var objUser = arrUsers.find(x => x.userName == strUserName);
                    if (objUser != null) {
                        strWhereCond += " And ${clsvConceptEN.con_UpdUser} = '" + objUser.userId + "'";
                    }
                   
                    //strWhereCond += ` And ${clsvConceptEN.con_UpdUser} like '% ${$("#txtViewUpdName_q").val()}%'`;
                }

                //strWhereCond += ` And conceptId not in (select conceptId from RTConceptRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
            }
            else {

                if (this.conceptName_q != "") {
                    strWhereCond += ` And ${clsConceptEN.con_ConceptName} like '% ${this.conceptName_q}%'`;
                    objConcept_Cond.SetCondFldValue(clsConceptEN.con_ConceptName, this.conceptName_q, "like");
                }
                var txtConceptUpdName_q = $("#txtConceptUpdName_q").val();
                if (txtConceptUpdName_q != "") {
                    var objUser = arrUsers.find(x => x.userName == txtConceptUpdName_q);
                    if (objUser != null) {
                        strWhereCond += " And ${clsvConceptEN.con_UpdUser} = '" + objUser.userId + "'";
                        objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdUser, objUser.userId, "=");
                    }
                  
                   // strWhereCond += ` And ${clsvConceptEN.con_UserName} like '% ${txtConceptUpdName_q}%'`;
                    //objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UserName, txtConceptUpdName_q, "like");
                }


                //排除获取已存在的关系数据 根据当前用户；
                strWhereCond += ` And conceptId not in (select conceptId from gs_PConcepRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineConceptConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
*/
    public async BindGv_Concept_Cache() {
        var strListDiv: string = this.mstrListDivPaper;
        var strWhereCond= await this.CombineConceptCondition();

        // var strWhereCond = JSON.stringify(objConceptEN_Sim);
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvConceptObjLst: Array<clsvConceptEN> = [];
        try {
            //this.recCount = Concept_GetRecCountByCond(objConcept_Cond);
            this.recCount = await vConcept_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: ConceptCRUD.sortConceptBy,
                sortFun: (x, y) => { return 0; }
            };
            //  var arrConceptObjLst = Concept_GetObjLstByPager_Cache(objPagerPara);
            const responseObjLst = await vConcept_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvConceptObjLst = <Array<clsvConceptEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrConceptObjLst.length == 0) {
        //    var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=Concept)`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            //var strhtml = "";
            ////个人观点
            //strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';

            //strhtml += '<div><a href="#" title="当前论文相关概念">当前论文相关概念</a></div>';
            ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvConceptObjLst.length; i++) {
            //    //得到viewpointId；
            //    var strConceptId = arrvConceptObjLst[i].conceptId;
            //    v++;
            //    strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvConceptObjLst[i].conceptName + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + arrvConceptObjLst[i].conceptContent + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvConceptObjLst[i].userName;
            //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvConceptObjLst[i].updDate;
            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';

            //    ////评论
            //    //strhtml += '&nbsp;&nbsp;评论数:' + arrvConceptObjLst[i].appraiseCount;
            //    ////评分
            //    //strhtml += '&nbsp;&nbsp;综合评分:' + arrvConceptObjLst[i].score + '';
            //    //strhtml += '&nbsp;&nbsp;教师评分:' + arrvConceptObjLst[i].teaScore + '';
            //    //strhtml += '&nbsp;&nbsp;学生评分:' + arrvConceptObjLst[i].stuScore + '';

            //    //引用数
            //    strhtml += '&nbsp;&nbsp;被引用数:' + arrvConceptObjLst[i].citationCount;


            //    strhtml += '&nbsp;&nbsp;<button title="引用该相关概念" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkConceptInTab_Click("' + arrvConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>引用该相关概念</button>';



            //    strhtml += '</li>';



            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';
            var strHtml = await Public_Concept.BindList_vConcept("02", arrvConceptObjLst);
            //拼接；
            $("#divConceptDataLst").html(strHtml);

            if (arrvConceptObjLst.length > 10) {
                //$("#divPager2").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            //this.BindTab_Concept(strListDiv, arrConceptObjLst);
            console.log("完成BindGv_Concept!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示Concept对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrConceptObjLst">需要绑定的对象列表</param>
   */
    public async BindTab_Concept(divContainer: string, arrConceptObjLst: Array<clsConceptEN>) {
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
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "conceptName",
                    colHeader: "概念名称",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "conceptContent",
                    colHeader: "概念内容",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
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
                    colHeader: "编辑日期",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "编辑人",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnOkConceptInTab_Click('${strKeyId}');`);
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

        BindTabV2Where(o, arrConceptObjLst, arrDataColumn, "conceptId", "TopicConcept");
        //BindTab(o, arrConceptObjLst, arrDataColumn, "conceptId");
        if (arrConceptObjLst.length > 10) {
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }

    }


    //概念查询按钮
    public async btnConceptQuery_Click() {

        const responseObjList = await this.BindGv_Concept_Cache();
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
        this.BindGv_Concept_Cache();
    }

    //添加观点 展示观点列表数据
    public async btnAddConceptRela_Click() {
        const responseObjList = await this.BindGv_Concept_Cache();
    }
    //确定选择的观点 并添加到关系表中
    public btnOkConceptInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidConceptId").val(strkeyId)
        //执行添加关系方法
        this.AddNewRecordSave();
    }

    /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSave() {
        const strThisFuncName = this.AddNewRecordSave.name;
        this.DivName = "divAddNewRecordSave";
        var strPaperId = $('#hidPaperId').val();
        var strConceptId = $("#hidConceptId").val();
        var strPaperLogTypeId = $('#hidPaperLogTypeId').val();//流程日志参数
        var strUserId = clsPublocalStorage.userId;
        var objgs_PConcepRelaEN: clsgs_PConcepRelaEN = new clsgs_PConcepRelaEN();
        this.PutDataTogs_PConcepRelaClass(objgs_PConcepRelaEN);
        try {

            //同一主题 同一概念 只能添加一次；
            var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And conceptId = '" + strConceptId + "'";
            //var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And viewpointId = '" + strViewpointId + "'";
            const responseText = await gs_PConcepRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题同一个用户不能重复添加同一个观点！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            else {

                const responseText = await gs_PConcepRela_AddNewRecordAsync(objgs_PConcepRelaEN);
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
                    var strWhereCond2 = " 1 =1 and conceptId=" + strConceptId;
                    var intCitationCount = await gs_PConcepRela_GetRecCountByCondAsync(strWhereCond2);


                    var objConceptEN: clsConceptEN = new clsConceptEN();
                    objConceptEN.SetConceptId(strConceptId);
                    objConceptEN.SetCitationCount(intCitationCount);

                    objConceptEN.sfUpdFldSetStr = objConceptEN.updFldString;//设置哪些字段被修改(脏字段)
                    if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                        throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }

                    const responseText = await Concept_UpdateRecordAsync(objConceptEN).then((jsonData) => {
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
                    HideDialogSeven();
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
        pobjgs_OriginalPaperLogEN.SetPaperId(strPaperId);
        pobjgs_OriginalPaperLogEN.SetLogTypeId(strPaperLogTypeId);
        pobjgs_OriginalPaperLogEN.SetLogDescription( "添加子观点");
        //  $('#PaperLogTypeId').val("03");
        //switch (strPaperLogTypeId) {
        //    case "01":
        //        pobjgs_OriginalPaperLogEN.SetLogDescription( "添加子观点";
        //        break;
        //    case "02":
        //        pobjgs_OriginalPaperLogEN.SetLogDescription( "同伴建议";
        //        break;

        //    default:
        //        var strMsg = `没有数据处理！`;
        //        alert(strMsg);
        //        break;
        //}
        //pobjgs_OriginalPaperLogEN.SetLogDescription( "新建论文";
        pobjgs_OriginalPaperLogEN.SetUpdUser(clsPublocalStorage.userId);
        pobjgs_OriginalPaperLogEN.SetUpdDate(clsPubFun4Web.getNowDate());
    }



    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_PConcepRelaEN">数据传输的目的类对象</param>
   */
    public PutDataTogs_PConcepRelaClass(pobjgs_PConcepRelaEN: clsgs_PConcepRelaEN) {
        var strPaperId = $("#hidPaperId").val();
        var strConceptId = $("#hidConceptId").val();
        var strUserId = clsPublocalStorage.userId;

        pobjgs_PConcepRelaEN.SetPaperId(strPaperId);// 主题编号
        pobjgs_PConcepRelaEN.SetSectionId($("#ddlSectionId2").val());// 主题编号
        pobjgs_PConcepRelaEN.SetConceptId(strConceptId);// 概念Id
        pobjgs_PConcepRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjgs_PConcepRelaEN.SetUpdUser(strUserId);// 修改用户Id
        pobjgs_PConcepRelaEN.SetMemo(this.memo);// 备注

    }

    /* 概念
  */
    public async SortByConcept(strSortByFld: string) {
        if (ConceptCRUD.sortConceptBy.indexOf(strSortByFld) >= 0) {
            if (ConceptCRUD.sortConceptBy.indexOf("Asc") >= 0) {
                ConceptCRUD.sortConceptBy = `${strSortByFld} Desc`;
            }
            else {
                ConceptCRUD.sortConceptBy = `${strSortByFld} Asc`;
            }
        }
        else {
            ConceptCRUD.sortConceptBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = this.BindGv_Concept_Cache();
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
    * 概念内容
   */
    public set conceptContent(value: string) {
        $("#txtConceptContent").val(value);
    }
    /*
    * 概念内容
   */
    public get conceptContent(): string {
        return $("#txtConceptContent").val();
    }
    /*
    * 概念Id
   */
    public set conceptId(value: string) {
        $("#txtConceptId").val(value);
    }
    /*
    * 概念Id
   */
    public get conceptId(): string {
        return $("#txtConceptId").val();
    }
    /*
    * 概念名称
   */
    public set conceptName(value: string) {
        $("#txtConceptName").val(value);
    }
    /*
    * 概念名称
   */
    public get conceptName(): string {
        return $("#txtConceptName").val();
    }
    /*
    * 概念名称
   */
    public get conceptName_q(): string {
        return $("#txtConceptName_q").val();
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
    public set hidSortConceptBy(value: string) {
        $("#hidSortConceptBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortConceptBy(): string {
        return $("#hidSortConceptBy").val();
    }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return clsPublocalStorage.userId;
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
    * 是否提交
   */
    public get IsSubmit_q(): boolean {
        return $("#chkIsSubmit_q").prop("checked");
    }
    /*
    * 设置关键字的值
   */
    public set keyId(value: string) {
        $("#hidKeyId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get keyId(): string {
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
    * 设置操作类型：Add||Update||Detail
   */
    public set opType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public get opType(): string {
        return $("#hidOpType").val();
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
}