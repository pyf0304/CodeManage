
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
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsgs_OriginalPaperLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js";
import { clsvRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js";
import { clsvRTPaperRelaENEx } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaENEx.js";
import { clsqa_QuestionsEN } from "../TS/L0_Entity/InteractManage/clsqa_QuestionsEN.js";
import { clsvqa_AnswerEN } from "../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { gs_OriginalPaperLog_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js";
import { Paper_GetObjByPaperIdAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { RTPaperRela_AddNewRecordAsync, RTPaperRela_DelRecordAsync, RTPaperRela_GetObjBymIdAsync, RTPaperRela_GetObjLstAsync, RTPaperRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js";
import { vRTPaperRela_GetObjBymIdAsync, vRTPaperRela_GetObjLstByPagerAsync, vRTPaperRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js";
import { qa_Questions_GetObjLstAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_QuestionsWApi.js";
import { vqa_Answer_GetObjLstAsync } from "../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js";
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
import { RTPaperRela_QUDI } from "./RTPaperRela_QUDI.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
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
export class RTPaperRela_QUDIEx extends RTPaperRela_QUDI implements IShowList {
    public divName4Pager_Paper = "divPagerPaper";
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
    //public divName4Pager_PaperLst: string = "divPager_PaperLst";
    //public bolIsInitShow_PaperLst: boolean = false;
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        alert('该类没有绑定该函数：[this.BindGv_vViewInfo]！');
        //this.BindGv_vViewInfo();
    }
    BindGv_Cache(strType: string, strPara: string) {
        alert(strType);
        if (clsString.IsNullOrEmpty(strType) == false) {

            this.btnPaperRecordInTab_Click(strType);
        }
        else {
            var strMsg = clsString.Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
            console.error(strMsg);
            alert(strMsg);

        }
    }

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            this.divName4Pager = "divPager_TopicPaperLst";
            if (clsPubSessionStorage.GetSession_UserId() != "") {
                //1、为下拉框设置数据源,绑定列表数据
                //const ddl_TopicId = await this.BindDdl_TopicId("ddlTopicId");
                //const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId");
                this.hidSortvRTPaperRelaBy = "updDate Desc";
                var strWhereCond = this.CombinevRTPaperRelaCondition();
                const responseText = await vRTPaperRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager_Paper);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vRTPaperRela();

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


    //相关论文
    public async liPaperClick() {
        try {
            //用户下拉框绑定
            //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
            //var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
            //const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域

            ////文献类型；
            ////const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
            //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN);
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager_Paper);
                this.bolIsInitShow = true;  //
            }
            //主题论文
            this.hidSortvRTPaperRelaBy = "updDate Desc";

            const gvResultPaper = await this.BindGv_vRTPaperRela();
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

  
    /* 显示vRTPaperRela对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrRTPaperRelaObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vRTPaperRela(divContainer: string, arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN>) {
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
                    FldName: "topicName",
                    ColHeader: "栏目主题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "topicProposePeople",
                    ColHeader: "主题提出人",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
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
                    FldName: "author",
                    ColHeader: "作者",
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
                    FldName: "userName",
                    ColHeader: "用户名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
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
                    ColHeader: "详情",
                    Text: "详情", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
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
        clsCommonFunc4Web.BindTabV2(o, arrvRTPaperRelaObjLst, arrDataColumn, "mId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager_Paper);
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















    ////////////////////////////////////////////////////////////////////////////////////主题论文关系
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public CombinevRTPaperRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = $("#hidTopicRelaId").val();
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTPaperRelaEN.con_TopicId} = '${strTopicId}'`;
            }

            //判断角色 
            //管理员
            if (clsPubSessionStorage.GetSession_RoleId() == "00620001") {
            }
            else if (clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //   strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //  strWhereCond += ` And ${clsvRTPaperRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                //学生00620003
            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTPaperRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vRTPaperRela() {
        var strPaperTypeId = $('#hidPaperTypeId').val();
        var strListDiv: string = "";
        var strWhereCond = this.CombinevRTPaperRelaCondition();

        if (strPaperTypeId == "01") {
            strListDiv = this.mstrListDivRtCitedPaperRela;
            strWhereCond += " and paperTypeId='" + strPaperTypeId + "'";
        }
        else {
            strListDiv = this.mstrListDivRtOriginalPaperRela;
            strWhereCond += " and paperTypeId='" + strPaperTypeId + "'";
        }



        var intCurrPageIndex = this.CurrPageIndexPaper;//获取当前页
        var arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN> = [];
        var arrvRTPaperRelaENExObjLst: Array<clsvRTPaperRelaENEx> = [];
        try {
            const responseRecCount = await vRTPaperRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;

                //如果记录数小于10,
                if (this.RecCount < 10) {
                    $("#divPagerPaper").attr("style", "display:none;");
                }

            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: 50,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTPaperRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTPaperRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTPaperRelaObjLst = <Array<clsvRTPaperRelaEN>>jsonData;
            });

            arrvRTPaperRelaENExObjLst = arrvRTPaperRelaObjLst.map(this.CopyToEx);
            for (var objInFor of arrvRTPaperRelaENExObjLst) {
                const conFuncMap = await this.FuncMap(objInFor);
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            if (strPaperTypeId == "01") {

                //this.BindTab_vRTPaperRela(strListDiv, arrvRTPaperRelaENExObjLst);
                this.BindTab_vRTPaperRelaList1(arrvRTPaperRelaENExObjLst);

            } else {

                ///获取论文步骤状态
                var strWhere = "1=1";
                var arrvgs_OriginalPaperLogLst: Array<clsgs_OriginalPaperLogEN> = [];

                const responseObjLst1 = await gs_OriginalPaperLog_GetObjLstAsync(strWhere).then((jsonData) => {
                    arrvgs_OriginalPaperLogLst = <Array<clsgs_OriginalPaperLogEN>>jsonData;
                });
                //获取用户缓存；
                var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

                this.BindTab_vRTPaperRelaList(arrvRTPaperRelaObjLst, arrvgs_OriginalPaperLogLst, arrUsers);
            }
            console.log("完成BindGv_vRTPaperRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    //绑定主题论文关系表
    public async BindTab_vRTPaperRelaList1(arrvRTPaperRelaENExObjLst: Array<clsvRTPaperRelaENEx>) {
        try {
            //var strPaperTypeId = $('#hidPaperTypeId').val();
            var strId_CurrEduCls = $("#hidId_CurrEduCls").val();
            //var strWhereCond1 = "id_CurrEduCls='" + strId_CurrEduCls + "' and paperTypeId='" + strPaperTypeId + "'";
            var strWhereCond2 = "id_CurrEduCls='" + strId_CurrEduCls + "'";
            var arrRTPaperRelaObjLst0: Array<clsRTPaperRelaEN> = [];
            var arrRTPaperRelaObjLst: Array<clsRTPaperRelaEN> = [];
            const responseObjLst1 = await RTPaperRela_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrRTPaperRelaObjLst0 = <Array<clsRTPaperRelaEN>>jsonData;
            });

            //var strWhereCond = "id_CurrEduCls='" + $("#hidId_CurrEduCls").val() + "'";
            var arrqa_QuestionsObjLst0: Array<clsqa_QuestionsEN> = [];
            var arrqa_QuestionsObjLst: Array<clsqa_QuestionsEN> = [];
            const responseObjLst2 = await qa_Questions_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrqa_QuestionsObjLst0 = <Array<clsqa_QuestionsEN>>jsonData;
            });

            //var strWhereCond = "id_CurrEduCls='" + $("#hidId_CurrEduCls").val() + "'";
            var arrvqa_AnswerObjLst0: Array<clsvqa_AnswerEN> = [];
            var arrvqa_AnswerObjLst1: Array<clsvqa_AnswerEN> = [];
            var arrvqa_AnswerObjLst2: Array<clsvqa_AnswerEN> = [];
            //var arrvqa_AnswerObjLst: Array<clsvqa_AnswerEN> = [];
            const responseObjLst3 = await vqa_Answer_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvqa_AnswerObjLst0 = <Array<clsvqa_AnswerEN>>jsonData;
            });

            var strTopicId = $("#hidTopicRelaId").val();
            //arrvqa_AnswerObjLst = arrvqa_AnswerObjLst0.filter(x => x.topicId == strTopicId);
            var strUserId = clsPubSessionStorage.GetSession_UserId();

            //获取用户缓存数据
            //var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            var strhtml = "";
            for (var j = 0; j < arrvRTPaperRelaENExObjLst.length; j++) {

                var intNum: number = j + 1;

                var strmId = arrvRTPaperRelaENExObjLst[j].mId;
                var strPaperId = arrvRTPaperRelaENExObjLst[j].paperId;

                arrRTPaperRelaObjLst = arrRTPaperRelaObjLst0.filter(x => x.paperId == strPaperId);
                arrqa_QuestionsObjLst = arrqa_QuestionsObjLst0.filter(x => x.paperId == strPaperId);

                arrvqa_AnswerObjLst1 = arrvqa_AnswerObjLst0.filter(x => x.paperId == strPaperId);
                arrvqa_AnswerObjLst2 = arrvqa_AnswerObjLst1.filter(x => x.topicId == strTopicId);

                strhtml += '<tr>';
                strhtml += '<td>' + intNum + '</td>';
                strhtml += '<td>' + arrvRTPaperRelaENExObjLst[j].paperTitle + '</td>';
                strhtml += '<td>' + arrvRTPaperRelaENExObjLst[j].author + '</td>';
                strhtml += '<td>' + arrvRTPaperRelaENExObjLst[j].updDate + '</td>';

                //var objUser = arrUsers.find(x => x.userId == arrvRTPaperRelaENExObjLst[j].updUser);
                //if (objUser != null) {
                //    strhtml += '<td>' + objUser.userName + '</td>';
                //} else {
                //    strhtml += '<td>' + objUser.userName + '</td>';
                //}
                strhtml += '<td>' + arrvRTPaperRelaENExObjLst[j].userName + '</td>';
                //引用小组数
                //问题数
                //本小组回答数
                //共回答数
                strhtml += '<td>';
                strhtml += '<span id="QuoteNum" class="badge badge-pill badge-primary" title="引用数">' + arrRTPaperRelaObjLst.length + '</span>';
                strhtml += '&nbsp;<span id="QNum" class="badge badge-pill badge-warning" title="问题数">' + arrqa_QuestionsObjLst.length + '</span>';
                strhtml += '&nbsp;<span id="TopicANum" class="badge badge-pill badge-info" title="本主题回答数">' + arrvqa_AnswerObjLst2.length + '</span>';
                strhtml += '&nbsp;<span id="AllANum" class="badge badge-pill badge-success" title="共回答数">' + arrvqa_AnswerObjLst1.length + '</span>';
                strhtml += '</td>';

                strhtml += '<td>';
                //编辑
                //strhtml += '<button title="回答教师问题" class="layui-btn layui-btn layui-btn-xs" onclick=btnParticipateQA_Click("' + strmId + '")><i class="layui-icon">&#xe6b2;</i></button>';
                strhtml += '<button title="回答教师问题" class="layui-btn layui-btn layui-btn-xs" onclick=ParticipateQA_Click("' + strPaperId + '")><i class="layui-icon">&#xe6b2;</i></button>';
                //删除
                if (arrvRTPaperRelaENExObjLst[j].updUser == strUserId) {
                    strhtml += '<button title="删除论文引用" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelPaperRelaRecordInTab_Click("' + strmId + '")><i class="layui-icon">&#xe640;</i></button>';
                }
                strhtml += '</td>';

                strhtml += '</tr>';

            }
            $("#tbPaperRelaDataLst").html(strhtml);
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager_Paper);
        }
        catch (e) {
            var strMsg: string = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace.GetCurrClassFunction()})`;
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







    public BindTab_vRTPaperRelaList(arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN>, arrvgs_OriginalPaperLogLst: Array<clsgs_OriginalPaperLogEN>, arrUsers: Array<clsvUsersSimEN>) {
        var strUserId = clsPubSessionStorage.GetSession_UserId();

        //论文流程日志
        var arrgs_OriginalLst: Array<clsgs_OriginalPaperLogEN> = [];
        var strTopicId = $("#hidTopicRelaId").val();

        var strhtml: string = '';
        strhtml += '<div class="info" id="infoPaper"><div class="title btn-2"><a href="#" title="小组论文写作">小组论文写作</a></div><ul class="artlist">';
        var p = 0;//给内容加个序号
        for (var i = 0; i < arrvRTPaperRelaObjLst.length; i++) {

            p++;
            var strPaperId = arrvRTPaperRelaObjLst[i].paperId;
            //strhtml += p + "." + arrvRTPaperRelaObjLst[i].paperTitle + "&nbsp;&nbsp;所属主题：" + arrvRTPaperRelaObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>";
            strhtml += '<li><span class="rowtit color2">' + p + '.[标题]：</span><span class="abstract-text">' + arrvRTPaperRelaObjLst[i].paperTitle + '作者：' + arrvRTPaperRelaObjLst[i].author + '</span>';
            //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">编辑人：</span><span class="abstract-text">' + arrvRTPaperRelaObjLst[i].userName + '</span>';
            //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">编辑时间：</span><span class="abstract-text">' + arrvRTPaperRelaObjLst[i].updDate + '</span></li>';
            //strhtml += "<span class=\"colorRed\" style=\"padding-left:50px;\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvRTPaperRelaObjLst2[i].paperId + "')\">pdf查看</span></li>";
            //<a href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvRTPaperRelaObjLst[i].paperId + "')\">pdf查看</a>

            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
            var objUser = arrUsers.find(x => x.userId == arrvRTPaperRelaObjLst[i].updUser)
            if (objUser != null) {
                strhtml += '&nbsp;&nbsp;&nbsp;引用人：' + objUser.userName;
            }


            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;引用时间：' + arrvRTPaperRelaObjLst[i].updDate;

            if (arrvRTPaperRelaObjLst[i].versionCount != 0) {
                strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvRTPaperRelaObjLst[i].versionCount;
            }

            var result = "";
            //var result = Math.max(...lists.map(x => x.id));  arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
            //获取id比较得到论文步骤日志；
            arrgs_OriginalLst = arrvgs_OriginalPaperLogLst.filter(x => x.paperId == strPaperId);
            arrgs_OriginalLst = arrgs_OriginalLst.sort(x => x[clsgs_OriginalPaperLogEN.con_LogTypeId]);
            for (var j = 0; j < arrgs_OriginalLst.length; j++) {
                if (j + 1 == arrgs_OriginalLst.length) {
                    result = arrgs_OriginalLst[j].logTypeId;
                }
            }

            if (strUserId == arrvRTPaperRelaObjLst[i].updUser) {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelViewPointRelaRecordInTab_Click(' + arrvRTPaperRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
            }
            //日志8个流程
            if (arrgs_OriginalLst.length == 8) {
                //等于7 说明步骤流程已经完成，那么可以提交
                strhtml += '&nbsp;&nbsp;<button  style="float:right;" title="数据提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmitPaper_Click("' + arrvRTPaperRelaObjLst[i].paperId + '")> <i class="layui-icon" >&#xe642;</i>数据提交</button>';
                strhtml += '&nbsp;&nbsp;<button  style="float:right;" title="是否公开" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsPublicPaper_Click("' + arrvRTPaperRelaObjLst[i].paperId + '")> <i class="layui-icon" >&#xe642;</i>数据公开</button>';
            }
            if (arrvRTPaperRelaObjLst[i].versionCount > 0 && arrvRTPaperRelaObjLst[i].versionCount != null) {
                strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('小组论文历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTPaperRelaObjLst[i].paperId + "&Type=10')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            }
            ////添加论文节
            //strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('添加论文节', '../ParameterTable/Section_QUDI_TS?paperId=" + arrvRTPaperRelaObjLst[i].paperId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加论文节</button >";

            //论文写作
            strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('论文写作', '../GraduateEduPaper/gs_PaperParagraph?paperId=" + arrvRTPaperRelaObjLst[i].paperId + "&topicId=" + $("#hidTopicRelaId").val() + "')\",'', '', true> <i class=\"layui-icon\" >&#xe642;</i>论文写作</button >";
            //测试静态树
            //   strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('测试静态树', '../GraduateEduPaper/TestTree?paperId=" + arrvRTPaperRelaObjLst[i].paperId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>测试静态树</button >";
            strhtml += '</li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[流程步骤]：';

            //判断数据是否提交，如果提交，那么所有的按钮都置灰；
            if (arrvRTPaperRelaObjLst[i].isSubmit == true) {
                strhtml += '<div class="layui-btn-group">';
                //论文思路
                strhtml += "&nbsp;&nbsp;&nbsp<button disabled=\"disabled\" id=\"btnAddFirst" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文思路', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=02&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文思路</button >";
                strhtml += '&nbsp;&nbsp;<button disabled="disabled" id="btnAddSubviewpointPaper' + p + '" title="添加论文观点" class="layui-btn-xs layui-btn layui-btn-disabled" onclick=btnAddNewPaperViewpointRela_Click("' + arrvRTPaperRelaObjLst[i].paperId + '") > <i class="layui-icon" >&#xe642;</i>添加论文观点</button>';
                //论文流程步骤

                strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnAddFirstPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文初稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=04&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文初稿</button >";
                strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnGroupDiscuss" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('小组讨论', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=01&PaperLogTypeId=05&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>小组讨论</button >";
                strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnUpdatePaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文修改稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=06&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文修改稿</button >";
                strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnCompanionProposal" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('同伴建议', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=02&PaperLogTypeId=07&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>同伴建议</button >";
                strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnEndPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文终稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=08&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文终稿</button >";
            }
            else {
                var logTypeId = result.toString();
                switch (logTypeId) {
                    case "01":
                        strhtml += '<div class="layui-btn-group">';
                        //论文思路
                        strhtml += "&nbsp;&nbsp;&nbsp<button id=\"btnAddFirst" + p + "\" class=\"layui-btn layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文思路', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=02&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文思路</button >";
                        strhtml += '&nbsp;&nbsp;<button disabled="disabled" id="btnAddSubviewpointPaper' + p + '" title="添加论文观点" class="layui-btn-xs layui-btn layui-btn-disabled" onclick=btnAddNewPaperViewpointRela_Click("' + arrvRTPaperRelaObjLst[i].paperId + '") > <i class="layui-icon" >&#xe642;</i>添加论文观点</button>';
                        //论文流程步骤
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnAddFirstPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文初稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=04&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文初稿</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnGroupDiscuss" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('小组讨论', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=01&PaperLogTypeId=05&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>小组讨论</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnUpdatePaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文修改稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=06&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文修改稿</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnCompanionProposal" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('同伴建议', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=02&PaperLogTypeId=07&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>同伴建议</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnEndPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文终稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=08&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文终稿</button >";

                        break;
                    case "02":
                        strhtml += '<div class="layui-btn-group">';
                        //论文思路
                        strhtml += "&nbsp;&nbsp;&nbsp<button id=\"btnAddFirst" + p + "\" class=\"layui-btn layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文思路', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=02&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文思路</button >";
                        strhtml += '&nbsp;&nbsp;&nbsp<button id="btnAddSubviewpointPaper' + p + '" title="添加论文观点" class="layui-btn-xs layui-btn layui-btn-normal" onclick=btnAddNewPaperViewpointRela_Click("' + arrvRTPaperRelaObjLst[i].paperId + '") > <i class="layui-icon" >&#xe642;</i>添加论文观点</button>';
                        //论文流程步骤
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnAddFirstPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文初稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=04&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文初稿</button >";
                        strhtml += "&nbsp;&nbsp;<button  disabled=\"disabled\" id=\"btnGroupDiscuss" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('小组讨论', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=01&PaperLogTypeId=05&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>小组讨论</button >";
                        strhtml += "&nbsp;&nbsp;<button  disabled=\"disabled\" id=\"btnUpdatePaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文修改稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=06&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文修改稿</button >";
                        strhtml += "&nbsp;&nbsp;<button  disabled=\"disabled\" id=\"btnCompanionProposal" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('同伴建议', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=02&PaperLogTypeId=07&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>同伴建议</button >";
                        strhtml += "&nbsp;&nbsp;<button  disabled=\"disabled\" id=\"btnEndPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文终稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=08&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文终稿</button >";
                        strhtml += '</div>';

                        break;
                    case "03":
                        strhtml += '<div class="layui-btn-group">';
                        //论文思路
                        strhtml += "&nbsp;&nbsp;&nbsp<button id=\"btnAddFirst" + p + "\" class=\"layui-btn layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文思路', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=02&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文思路</button >";
                        strhtml += '&nbsp;&nbsp;&nbsp<button id="btnAddSubviewpointPaper' + p + '" title="添加论文观点" class="layui-btn-xs layui-btn layui-btn-normal" onclick=btnAddNewPaperViewpointRela_Click("' + arrvRTPaperRelaObjLst[i].paperId + '") > <i class="layui-icon" >&#xe642;</i>添加论文观点</button>';
                        //论文流程步骤
                        strhtml += "&nbsp;&nbsp;<button id=\"btnAddFirstPaper" + p + "\" class=\"layui-btn layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文初稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=04&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文初稿</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnGroupDiscuss" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('小组讨论', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=01&PaperLogTypeId=05&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>小组讨论</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnUpdatePaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文修改稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=06&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文修改稿</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnCompanionProposal" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('同伴建议', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=02&PaperLogTypeId=07&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>同伴建议</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnEndPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文终稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=08&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文终稿</button >";

                        break;
                    case "04":
                        strhtml += '<div class="layui-btn-group">';
                        //论文思路
                        strhtml += "&nbsp;&nbsp;&nbsp<button id=\"btnAddFirst" + p + "\" class=\"layui-btn layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文思路', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=02&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文思路</button >";

                        strhtml += '&nbsp;&nbsp;&nbsp<button id="btnAddSubviewpointPaper' + p + '" title="添加论文观点" class="layui-btn-xs layui-btn layui-btn-normal" onclick=btnAddNewPaperViewpointRela_Click("' + arrvRTPaperRelaObjLst[i].paperId + '") > <i class="layui-icon" >&#xe642;</i>添加论文观点</button>';
                        //论文流程步骤
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnAddFirstPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文初稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=04&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文初稿</button >";
                        strhtml += "&nbsp;&nbsp;<button id=\"btnGroupDiscuss" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('小组讨论', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=01&PaperLogTypeId=05&pubParentId=" + strTopicId + "','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>小组讨论</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnUpdatePaper" + p + "\" class=\"layui-btn-disabled layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文修改稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=06&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文修改稿</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnCompanionProposal" + p + "\" class=\"layui-btn-disabled layui-btn layui-btn-xs\" onclick=\" xadmin.open('同伴建议', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=02&PaperLogTypeId=07&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>同伴建议</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnEndPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文终稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=08&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文终稿</button >";

                        break;
                    case "05":
                        strhtml += '<div class="layui-btn-group">';
                        //论文思路
                        strhtml += "&nbsp;&nbsp;&nbsp<button id=\"btnAddFirst" + p + "\" class=\"layui-btn layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文思路', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=02&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文思路</button >";

                        strhtml += '&nbsp;&nbsp;&nbsp<button id="btnAddSubviewpointPaper' + p + '" title="添加论文观点" class="layui-btn-xs layui-btn layui-btn-normal" onclick=btnAddNewPaperViewpointRela_Click("' + arrvRTPaperRelaObjLst[i].paperId + '") > <i class="layui-icon" >&#xe642;</i>添加论文观点</button>';
                        //论文流程步骤
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnAddFirstPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文初稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=04&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文初稿</button >";
                        strhtml += "&nbsp;&nbsp;<button id=\"btnGroupDiscuss" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('小组讨论', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=01&PaperLogTypeId=05&pubParentId=" + strTopicId + "','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>小组讨论</button >";
                        strhtml += "&nbsp;&nbsp;<button id=\"btnUpdatePaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn\" onclick=\" xadmin.open('论文修改稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=06&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文修改稿</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\"  id=\"btnCompanionProposal" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('同伴建议', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=02&PaperLogTypeId=07&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>同伴建议</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnEndPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文终稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=08&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文终稿</button >";

                        break;
                    case "06":
                        strhtml += '<div class="layui-btn-group">';
                        //论文思路
                        strhtml += "&nbsp;&nbsp;&nbsp<button id=\"btnAddFirst" + p + "\" class=\"layui-btn layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文思路', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=02&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文思路</button >";

                        strhtml += '&nbsp;&nbsp;&nbsp<button id="btnAddSubviewpointPaper' + p + '" title="添加论文观点" class="layui-btn-xs layui-btn layui-btn-normal" onclick=btnAddNewPaperViewpointRela_Click("' + arrvRTPaperRelaObjLst[i].paperId + '") > <i class="layui-icon" >&#xe642;</i>添加论文观点</button>';
                        //论文流程步骤
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnAddFirstPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文初稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=04&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文初稿</button >";
                        strhtml += "&nbsp;&nbsp;<button id=\"btnGroupDiscuss" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('小组讨论', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=01&PaperLogTypeId=05&pubParentId=" + strTopicId + "','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>小组讨论</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnUpdatePaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文修改稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=06&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文修改稿</button >";
                        strhtml += "&nbsp;&nbsp;<button id=\"btnCompanionProposal" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('同伴建议', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=02&PaperLogTypeId=07&pubParentId=" + strTopicId + "','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>同伴建议</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnEndPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文终稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=08&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文终稿</button >";


                        break;
                    case "07":
                        strhtml += '<div class="layui-btn-group">';
                        //论文思路
                        strhtml += "&nbsp;&nbsp;&nbsp<button id=\"btnAddFirst" + p + "\" class=\"layui-btn layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文思路', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=02&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文思路</button >";

                        strhtml += '&nbsp;&nbsp;&nbsp<button id="btnAddSubviewpointPaper' + p + '" title="添加论文观点" class="layui-btn-xs layui-btn layui-btn-normal" onclick=btnAddNewPaperViewpointRela_Click("' + arrvRTPaperRelaObjLst[i].paperId + '") > <i class="layui-icon" >&#xe642;</i>添加论文观点</button>';
                        //论文流程步骤
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnAddFirstPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文初稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=04&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文初稿</button >";
                        strhtml += "&nbsp;&nbsp;<button id=\"btnGroupDiscuss" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('小组讨论', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=01&PaperLogTypeId=05&pubParentId=" + strTopicId + "','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>小组讨论</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnUpdatePaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文修改稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=06&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文修改稿</button >";
                        strhtml += "&nbsp;&nbsp;<button id=\"btnCompanionProposal" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('同伴建议', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=02&PaperLogTypeId=07&pubParentId=" + strTopicId + "','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>同伴建议</button >";
                        strhtml += "&nbsp;&nbsp;<button id=\"btnEndPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('论文终稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=08&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文终稿</button >";


                        break;
                    case "08":
                        strhtml += '<div class="layui-btn-group">';
                        //论文思路
                        strhtml += "&nbsp;&nbsp;&nbsp<button id=\"btnAddFirst" + p + "\" class=\"layui-btn layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文思路', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=02&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文思路</button >";

                        strhtml += '&nbsp;&nbsp;&nbsp<button id="btnAddSubviewpointPaper' + p + '" title="添加论文观点" class="layui-btn-xs layui-btn layui-btn-normal" onclick=btnAddNewPaperViewpointRela_Click("' + arrvRTPaperRelaObjLst[i].paperId + '") > <i class="layui-icon" >&#xe642;</i>添加论文观点</button>';
                        //论文流程步骤
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnAddFirstPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文初稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=04&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文初稿</button >";
                        strhtml += "&nbsp;&nbsp;<button id=\"btnGroupDiscuss" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('小组讨论', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=01&PaperLogTypeId=05&pubParentId=" + strTopicId + "','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>小组讨论</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnUpdatePaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文修改稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=06&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文修改稿</button >";
                        strhtml += "&nbsp;&nbsp;<button id=\"btnCompanionProposal" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('同伴建议', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=02&PaperLogTypeId=07&pubParentId=" + strTopicId + "','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>同伴建议</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnEndPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文终稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=08&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文终稿</button >";


                        break;
                    default:
                        strhtml += '<div class="layui-btn-group">';
                        //论文思路
                        strhtml += "&nbsp;&nbsp;&nbsp<button id=\"btnAddFirst" + p + "\" class=\"layui-btn layui-btn layui-btn-xs\" onclick=\" xadmin.open('论文思路', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=02&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文思路</button >";

                        strhtml += '&nbsp;&nbsp;&nbsp<button disabled=\"disabled\" id="btnAddSubviewpointPaper' + p + '" title="添加论文观点" class="layui-btn-xs layui-btn layui-btn-disabled" onclick=btnAddNewPaperViewpointRela_Click("' + arrvRTPaperRelaObjLst[i].paperId + '") > <i class="layui-icon" >&#xe642;</i>添加论文观点</button>';
                        //论文流程步骤
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnAddFirstPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文初稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=03&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文初稿</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnGroupDiscuss" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('小组讨论', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=01&PaperLogTypeId=04&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>小组讨论</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnUpdatePaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文修改稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=05&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文修改稿</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnCompanionProposal" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('同伴建议', '../GraduateEduPaper/gs_PaperDiscuss?Key=" + strPaperId + "&Type=02&PaperLogTypeId=06&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>同伴建议</button >";
                        strhtml += "&nbsp;&nbsp;<button disabled=\"disabled\" id=\"btnEndPaper" + p + "\" class=\"layui-btn-xs layui-btn layui-btn-disabled\" onclick=\" xadmin.open('论文终稿', '../GraduateEduPublicPage/AddOriginalPaper?paperId=" + strPaperId + "&PaperLogTypeId=07&topicId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>论文终稿</button >";

                        break;
                }
            }
            strhtml += '</li>';
        }
        strhtml += '</ul></div>';

        $("#divRtOriginalPaperRelaDataLst").html(strhtml);

        if (this.RecCount > 10) {
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager_Paper);
        }

    }

    public async btnDelPaperRelaRecordInTab_Click(strKeyId: string) {
        try {

            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            // 只有删除的数据也当前登录用户一致时，才可以删除；


            var strUserId = $("#hidUserId").val();
            //var strTopicId = $("#hidTopicRelaId").val();
            //var strWhereCond = ` 1=1 And ${clsRTUserRelaEN.con_TopicId} = '${strTopicId}' And ${clsRTUserRelaEN.con_UserId} ='${strUserId}'`;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = RTPaperRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRPaperEN: clsRTPaperRelaEN = <clsRTPaperRelaEN>jsonData;
                if (objRPaperEN != null) {
                    if (objRPaperEN.updUser == strUserId) {
                        const responseText = this.DelPaperRelaRecord(lngKeyId);
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
    public DelPaperRelaRecord(lngmId: number) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTPaperRela_DelRecordAsync(lngmId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        this.BindGv_vRTPaperRela();
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


    //分页数据
    /* 函数功能:在数据 列表中跳转到某一页 观点列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
 <param name = "intPageIndex">页序号</param>
*/
    public IndexPageFive(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager_Paper);
        this.BindGv_vRTPaperRela();
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
        this.objPager.ShowPagerV2(this, this.divName4Pager_Paper);
    }

 
 
    //确定选择的论文 并添加到关系表中
    public btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)
        console.error('btnPaperRecordInTab_Click');
        //获取论文条件 02代表 小组成员论文数据；
        var strType = $("#hidstrType").val();
        //if (strType == "01") {
            //执行添加关系方法
            this.AddNewRecordSavePaperRela();//所有论文
        //}
        //else {

        //    //小组成员论文；
        //    //this.AddNewRecordSaveResearchResult();
        //}
    }
    /* 添加新记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSavePaperRela() {
        var strTopicId = $('#hidTopicRelaId').val();
        var strPaperId = $("#hidPaperId").val();
        var strUserId = $("#hidUserId").val();
        var objRTPaperRelaEN: clsRTPaperRelaEN = new clsRTPaperRelaEN();
        this.PutDataToRTPaperRelaClass(objRTPaperRelaEN);

        try {
            // 同一主题 同一论文 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And paperId = '" + strPaperId + "'";
            const responseText = await RTPaperRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个论文！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await RTPaperRela_AddNewRecordAsync(objRTPaperRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加成功!`;
                $('#lblResult40').val(strInfo);

                HideDialogThree();
                //显示信息框
                alert(strInfo);
                this.BindGv_vRTPaperRela();
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
    //public async SortByPaper(strSortByFld: string) {
    //    if (this.hidSortvPaperBy.indexOf(strSortByFld) >= 0) {
    //        if (this.hidSortvPaperBy.indexOf("Asc") >= 0) {
    //            this.hidSortvPaperBy = `${strSortByFld} Desc`;
    //        }
    //        else {
    //            this.hidSortvPaperBy = `${strSortByFld} Asc`;
    //        }
    //    }
    //    else {
    //        this.hidSortvPaperBy = `${strSortByFld} Asc`;
    //    }
    //    var objPaperLstSel = new PaperLstSel();
    //    const responseObjList = await objPaperLstSel.BindGv_vPaper();
    //}
    /* 
    主题论文
*/
    public async SortByRTPaper(strSortByFld: string) {
        if (this.hidSortvRTPaperRelaBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvRTPaperRelaBy.indexOf("Asc") >= 0) {
                this.hidSortvRTPaperRelaBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvRTPaperRelaBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvRTPaperRelaBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vRTPaperRela();
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
                        HideDialog();
                        this.BindGv_vRTPaperRela();
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
                        HideDialog();
                        this.BindGv_vRTPaperRela();
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