
/*-- -- -- -- -- -- -- -- -- -- --
类名:SysSocialRelationsCRUDEx
表名:SysSocialRelations(01120644)
生成代码版本:2020.05.18.1
生成日期:2020/05/22 19:00:05
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { Public_SysSocialRelations } from "../GraduateEduPublicPage/Public_SysSocialRelations.js";

import { SysSocialRelationsCRUDEx } from "../GraduateEduTopic/SysSocialRelationsCRUDEx.js";
import { SysSocialRelationsCRUD } from "../PagesBase/GraduateEduTopic/SysSocialRelationsCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsvRTSysSocialRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTSysSocialRelaEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { RTSysSocialRela_DelRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js";
import { vRTSysSocialRela_GetObjLstByPagerAsync, vRTSysSocialRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js";
import { vSysSocialRelations_GetObjLstByPagerAsync, vSysSocialRelations_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindTab, BindTab_V, GetFirstCheckedKeyId, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { SysSocialRelations_EditEx_Research } from "./SysSocialRelations_EditEx_Research.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogTen(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* SysSocialRelationsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class ResearchTopicSysSocialRelaEx extends SysSocialRelationsCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvSysSocialRelationsBy: string = "socialId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    //社会关系
    public mstrListSysSocialRelaDivPaper: string = "divRtSysSocialRelaLst";

    BindGv(strType: string, strPara: string) {
        this.BindGv_vSysSocialRelations();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vSysSocialRelations":
                alert('该类没有绑定该函数：[this.BindGv_vSysSocialRelations_Cache]！');
                //this.BindGv_vSysSocialRelations_Cache();
                break;
            default:
                strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
                alert(strMsg);
                break;
        }
    }
    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        let objPage: ResearchTopicSysSocialRelaEx;
        if (SysSocialRelationsCRUD.objPage_CRUD == null) {
            SysSocialRelationsCRUD.objPage_CRUD = new SysSocialRelationsCRUDEx();
            objPage = <ResearchTopicSysSocialRelaEx>SysSocialRelationsCRUD.objPage_CRUD;
        }
        else {
            objPage = <ResearchTopicSysSocialRelaEx>SysSocialRelationsCRUD.objPage_CRUD;
        }
        const objPage_Edit: SysSocialRelations_EditEx_Research = new SysSocialRelations_EditEx_Research(objPage);
        const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
        let strMsg = '';
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage_Edit.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage_Edit.btnUpdateRecord_Click(strKeyId);
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                objPage.btnDelRecord_Click();
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
                strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
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
                //建立缓存

                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();

                SysSocialRelationsCRUD.sortvSysSocialRelationsBy = "fullName Asc";
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vSysSocialRelations();

                $("#divLoading").hide();
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


    //社会关系；
    public async liSysSocialRelationsClick() {
        try {
            //主题社会关系
            this.hidSortvRTSysSocialRelaBy = "classificationId Asc,updDate Desc";

            const gvResultPaper = await this.BindGv_vRTSysSocialRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取客观依据列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vSysSocialRelations() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevSysSocialRelationsCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN> = [];
        try {
            this.recCount = await vSysSocialRelations_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: SysSocialRelationsCRUD.sortvSysSocialRelationsBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vSysSocialRelations_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvSysSocialRelationsObjLst = <Array<clsvSysSocialRelationsEN>>jsonData;
            });

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvSysSocialRelationsObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            //this.BindTab_vSysSkill(strListDiv, arrvSysSkillObjLst);
            //var strhtml = "";
            ////个人观点
            //strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';

            //strhtml += '<div><a href="#" title="当前相关社会关系">当前相关社会关系</a></div>';
            ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvSysSocialRelationsObjLst.length; i++) {
            //    //得到socialId；
            //    var strSocialId = arrvSysSocialRelationsObjLst[i].socialId;
            //    v++;
            //    strhtml += '<li><span class="rowtit color4">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].fullName + '</span>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[国籍]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].nationality + '</span>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[工作单位]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].workUnit + '</span>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[专业]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].major + '</span></li>';


            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[成就]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].achievement + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[详细说明]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].detailedDescription + '</span></li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvSysSocialRelationsObjLst[i].updUser;
            //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvSysSocialRelationsObjLst[i].updDate;
            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';


            //    //引用数
            //    strhtml += '&nbsp;&nbsp;被引用数:' + arrvSysSocialRelationsObjLst[i].citationCount;


            //    strhtml += '&nbsp;&nbsp;<button title="引用相关关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkRTSysSocialRelaInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>引用该相关关系</button>';



            //    strhtml += '</li>';



            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';

            var strHtml = await Public_SysSocialRelations.BindList_vSysSocialRelations("02", arrvSysSocialRelationsObjLst);
            //拼接；
            $("#divSysSocialRelationsDataLst").html(strHtml);
            
            if (arrvSysSocialRelationsObjLst.length > 10) {
                //$("#divPagerSysSocialRela").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            console.log("完成BindGv_vSysSocialRelations!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombinevSysSocialRelationsCondition(): Promise<string>  {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strUserId = clsPublocalStorage.userId;
        var strWhereCond: string = " 1=1";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.fullName_q != "") {
                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_FullName} like '% ${this.fullName_q}%'`;
            }
            //if (this.achievement_q != "") {
            //    strWhereCond += ` And ${clsvSysSocialRelationsEN.con_Achievement} like '% ${this.achievement_q}%'`;
            //}
            if (this.levelId_q != "" && this.levelId_q != "0") {
                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_LevelId} = '${this.levelId_q}'`;
            }

            if (clsPublocalStorage.eduClsTypeId == "0001") {
                $("#ddlCurrEduCls_q5").hide();
                $("#ddlPublicViewPoint").show();
                if ($("#ddlPublicViewPoint") == "1") {
                    strWhereCond += ` And ${clsvSysSocialRelationsEN.con_UpdUser} in('${clsPublocalStorage.TopicUserList}')`;
                }
                else {
                    strWhereCond += ` And ${clsvSysSocialRelationsEN.con_ShareId} ='03'`;
                }
            }


            if ($("#ddlCurrEduCls_q5").val() != "" && $("#ddlCurrEduCls_q5").val() != "0") {
                strWhereCond += " And id_CurrEduCls='" + $("#ddlCurrEduCls_q5").val() + "'";
            }
            else {
                strWhereCond += " And id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            }
            //只能查询提交的技能数据
            strWhereCond += ` And ${clsvSysSocialRelationsEN.con_IsSubmit} = 'true'`;
            
            //排除获取已存在的关系数据 根据当前用户；
            strWhereCond += ` And socialId not in (select socialId from RTSysSocialRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;
          
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSysSocialRelationsCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 显示vSysSocialRelations对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrSysSocialRelationsObjLst">需要绑定的对象列表</param>
*/
    public async BindTab_vSysSocialRelations(divContainer: string, arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN>) {
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
                    fldName: "fullName",
                    colHeader: "姓名",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "nationality",
                    colHeader: "国籍",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "workUnit",
                    colHeader: "工作单位",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "major",
                    colHeader: "专业",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "achievement",
                    colHeader: "成就",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "detailedDescription",
                    colHeader: "详细说明",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "levelName",
                    colHeader: "级别名称",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updUser",
                    colHeader: "修改人",
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
                    fldName: "isSubmit",
                    colHeader: "是否提交",
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
        BindTab_V(o, arrvSysSocialRelationsObjLst, arrDataColumn, "socialId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }
//查询技能
    public async btnQuerySysSocialRelations_Click() {

        const responseObjList = await this.BindGv_vSysSocialRelations();
    }




    /////////////////////////////////////////////////////社会关系////////////////////////////////////////////////
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 <returns>条件串(strWhereCond)</returns>
*/
    public CombinevRTSysSocialRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTSysSocialRelaEN.con_TopicId} = '${strTopicId}'`;
            }

            var strClassificationId = $("#hidClassificationId").val();
            if (strClassificationId != "") {
                strWhereCond += ` And ${clsvRTSysSocialRelaEN.con_ClassificationId} = '${strClassificationId}'`;
            }

            var strViewsId = $("#hidViewsId").val();
            if (strViewsId != "") {
                strWhereCond += ` And ${clsvRTSysSocialRelaEN.con_mId} = ${strViewsId}`;
            }

            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {

            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
            }
            else {
                //学生； 
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTSysSocialRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vRTSysSocialRela() {
        var strListDiv: string = this.mstrListSysSocialRelaDivPaper;
        var strWhereCond = await this.CombinevRTSysSocialRelaCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvRTSysSocialRelaObjLst: Array<clsvRTSysSocialRelaEN> = [];
        //var arrvUsersObjLst: Array<clsvUsersSimEN> = [];
        try {
            this.recCount = await vRTSysSocialRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTSysSocialRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTSysSocialRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTSysSocialRelaObjLst = <Array<clsvRTSysSocialRelaEN>>jsonData;
            });

            //arrvUsersObjLst = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        try {

            //this.BindTab_vRTSysSocialRela(arrvRTSysSocialRelaObjLst, arrvUsersObjLst);
            var strHtml = await Public_SysSocialRelations.BindList_vRTSysSocialRela("06", arrvRTSysSocialRelaObjLst);

            //拼接；
            $("#divSysSocialRelaDataLst").html(strHtml);

            if (arrvRTSysSocialRelaObjLst.length > 10) {
                // $("#divSysSocialRelationsDataLst").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            console.log("完成BindGv_vRTSysSocialRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    //public async BindTab_vRTSysSocialRela(arrvRTSysSocialRelaObjLst: Array<clsvRTSysSocialRelaEN>, arrvUsersObjLst: Array<clsvUsersSimEN>) {
    //    var strhtml = "";
    //    var strUserId = clsPublocalStorage.userId;//获取当前登录ID 
    //    strhtml += '<div class="info" id="infoSysSocialRela"><div class="title btn-4">';

    //    strhtml += '<div style="float:left;"><a href="#" title="相关社会关系">相关社会关系</a></div>';

    //    strhtml += '</div><ul class="artlist">';
    //    var v = 0;//给内容加个序号
    //    for (var i = 0; i < arrvRTSysSocialRelaObjLst.length; i++) {
    //        //得到socialId；
    //        var strSocialId = arrvRTSysSocialRelaObjLst[i].socialId;
    //        v++;
    //        strhtml += '<li><span class="rowtit color4">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].fullName + '</span>';
    //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[国籍]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].nationality + '</span>';
    //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[工作单位]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].workUnit + '</span>';
    //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[专业]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].major + '</span></li>';

    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[成就]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].achievement + '</span></li>';
    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[详细说明]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].detailedDescription + '</span></li>';
    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
    //        if (arrvRTSysSocialRelaObjLst[i].okCount != 0) {
    //            strhtml += '点赞数：' + arrvRTSysSocialRelaObjLst[i].okCount + '&nbsp;&nbsp';
    //        }
    //        if (arrvRTSysSocialRelaObjLst[i].appraiseCount != 0) {
    //            //评论
    //            strhtml += '&nbsp;&nbsp;评论数：' + arrvRTSysSocialRelaObjLst[i].appraiseCount;
    //        }
    //        if (arrvRTSysSocialRelaObjLst[i].score != 0) {
    //            //评分
    //            strhtml += '&nbsp;&nbsp;综合评分：' + arrvRTSysSocialRelaObjLst[i].score;
    //        }
    //        if (arrvRTSysSocialRelaObjLst[i].teaScore != 0) {
    //            strhtml += '&nbsp;&nbsp;教师评分：' + arrvRTSysSocialRelaObjLst[i].teaScore;
    //        }
    //        if (arrvRTSysSocialRelaObjLst[i].stuScore != 0) {
    //            strhtml += '&nbsp;&nbsp;学生评分：' + arrvRTSysSocialRelaObjLst[i].stuScore;
    //        }
    //        //引用数
    //        strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvRTSysSocialRelaObjLst[i].citationCount;

    //        if (arrvRTSysSocialRelaObjLst[i].versionCount != 0) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvRTSysSocialRelaObjLst[i].versionCount;
    //        }
    //        if (arrvRTSysSocialRelaObjLst[i].isSubmit == true) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
    //        }
    //        else {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
    //        }

    //        strhtml += '</li>';
    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';


    //        //获取引用人；编辑人、用户名称
    //        //var arrUsers: Array<clsvUsersSimEN> = await Users_GetObjLstAsync("1=1");
    //        var arrvUsers: Array<clsvUsersSimEN> = [];
    //        var UpdUserName;//编辑人
    //        var CacitionUserName;//引用人
    //        //获取技能引用人；
    //        arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvRTSysSocialRelaObjLst[i].updUser);//技能引用人
    //        for (var j = 0; j < arrvUsers.length; j++) {
    //            CacitionUserName = arrvUsers[j].userName;
    //            break;
    //        }
    //        //获取技能编辑人；
    //        arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvRTSysSocialRelaObjLst[i].socialUpdUser);//技能编辑人
    //        for (var j = 0; j < arrvUsers.length; j++) {
    //            UpdUserName = arrvUsers[j].userName;
    //            break;
    //        }
    //        if (arrvRTSysSocialRelaObjLst[i].socialUpdUser == arrvRTSysSocialRelaObjLst[i].updUser) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + UpdUserName;
    //        } else {
    //            strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
    //        }
    //        if (arrvRTSysSocialRelaObjLst[i].socialUpdDate == arrvRTSysSocialRelaObjLst[i].updDate) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvRTSysSocialRelaObjLst[i].socialUpdDate;
    //        } else {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvRTSysSocialRelaObjLst[i].socialUpdDate + '&nbsp;/&nbsp;' + arrvRTSysSocialRelaObjLst[i].updDate;
    //        }

    //        if (strUserId == arrvRTSysSocialRelaObjLst[i].updUser) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelRTSysSocialRelaRecordInTab_Click(' + arrvRTSysSocialRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
    //        }
    //        if (arrvRTSysSocialRelaObjLst[i].isSubmit != true) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdSyssocial_Click("' + arrvRTSysSocialRelaObjLst[i].socialId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
    //        }

    //        //strhtml += '&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除相关引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelRTSysSocialRelaRecordInTab_Click(' + arrvRTSysSocialRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除相关引用</button>';
    //        if (arrvRTSysSocialRelaObjLst[i].versionCount > 0 && arrvRTSysSocialRelaObjLst[i].versionCount != null) {
    //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('相关技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTSysSocialRelaObjLst[i].socialId + "&Type=09')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
    //        }
    //        strhtml += '</li>';

    //        strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
    //    }
    //    strhtml += '</ul></div>';

    //    //拼接；
    //    $("#divSysSocialRelaDataLst").html(strhtml);

    //    if (arrvRTSysSocialRelaObjLst.length > 10) {
    //        // $("#divSysSocialRelationsDataLst").show();
    //        this.objPager.recCount = this.recCount;
    //        this.objPager.pageSize = this.pageSize;
    //        this.objPager.ShowPagerV2(this, this.divName4Pager);
    //    }
    //}

    /* 函数功能:在数据 列表中跳转到某一页
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
<param name = "intPageIndex">页序号</param>
*/
    //public IndexPageEleven(intPageIndex) {
    //    if (intPageIndex == 0) {
    //        intPageIndex = this.objPager.pageCount;
    //    }
    //    console.log("跳转到" + intPageIndex + "页");
    //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
    //    this.BindGv_vRTSysSocialRela();
    //}


    /* 
在数据表里删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelRTSysSocialRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelRTSysSocialRelaRecord(lngKeyId);
            const responseBindGv = await this.BindGv_vRTSysSocialRela();
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
    public async DelRTSysSocialRelaRecord(lngmId: number) {
        try {
            const responseText = await RTSysSocialRela_DelRecordAsync(lngmId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
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


    //添加技能
    public async btnAddRTSysSocialRelaInTab_Click() {
        // 为查询区绑定下拉框
        const gvBindDdl = await this.BindDdl4QueryRegion();
        var strRoleId = clsPublocalStorage.roleId;
        if (strRoleId == "00620003") {
            const Ddl_CurrEduClsStu_q = await clsDropDownList.BindDdl_CurrEduClsStu("ddlCurrEduCls_q5");
        } else {
            const Ddl_CurrEduClsTea_q = await clsDropDownList.BindDdl_CurrEduClsTea("ddlCurrEduCls_q5");
        }
        const responseObjList = await this.BindGv_vSysSocialRelations();
    }
    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvRTSysSocialRelaBy(value: string) {
        $("#hidSortvRTSysSocialRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvRTSysSocialRelaBy(): string {
        return $("#hidSortvRTSysSocialRelaBy").val();
    }

}