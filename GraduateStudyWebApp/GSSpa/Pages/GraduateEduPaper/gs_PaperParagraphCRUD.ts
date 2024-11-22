
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_PaperParagraphCRUD
表名:gs_PaperParagraph(01120744)
生成代码版本:2020.09.24.1
生成日期:2020/09/27 16:02:34
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsgs_PaperParagraphEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js";
import { clsvgs_PaperParagraphEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js";
import { gs_PaperParagraph_AddNewRecordAsync, gs_PaperParagraph_Delgs_PaperParagraphsAsync, gs_PaperParagraph_DelRecordAsync, gs_PaperParagraph_DownMoveAsync, gs_PaperParagraph_GetMaxStrIdAsync, gs_PaperParagraph_GetObjByParagraphIdAsync, gs_PaperParagraph_GetObjLstByParagraphIdLstAsync, gs_PaperParagraph_GoBottomAsync, gs_PaperParagraph_GoTopAsync, gs_PaperParagraph_ReOrderAsync, gs_PaperParagraph_UpMoveAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js";
import { vgs_PaperParagraph_GetObjLstAsync, vgs_PaperParagraph_GetObjLstByPagerAsync, vgs_PaperParagraph_GetObjLstByPager_Cache, vgs_PaperParagraph_GetRecCountByCondAsync, vgs_PaperParagraph_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { clsOrderByData } from "../TS/PubFun/clsOrderByData.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_PaperParagraph(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_PaperParagraph(): void;
/*
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
*/
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
/*
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
*/
declare var strCurrPrjId;
declare var $;
/* gs_PaperParagraphCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class gs_PaperParagraphCRUD implements clsOperateList{
    public mstrListDiv: string = "divDataLst";//列表区数据列表层id
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public bolIsLoadDetailRegion: boolean = false;  //记录是否导入详细信息区的变量
    public divName4Edit: string = "divEdit";  //编辑区的Id
    public divName4Detail: string = "divDetail";  //详细信息区的Id
    
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

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvgs_PaperParagraphBy = "paragraphTypeName Asc";
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
   */
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvgs_PaperParagraphBy = "paragraphTypeName Asc";
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }


    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
   */
    public async btnQuery_Click() {
        const responseBindGv = await this.BindGv_vgs_PaperParagraph();
    }

    /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
   */
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面
    }


    /*
    重序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
    */
    public async btnReOrder_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSectionId: string = gs_PaperParagraphCRUD.SectionId_OrderNum;
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            var jsonObject =
            {
                "sectionId": strSectionId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await gs_PaperParagraph_ReOrderAsync(objOrderByData);
            //gs_PaperParagraph_ReFreshCache();
        }
        catch (e) {
            var strMsg: string = `重序出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vgs_PaperParagraph();
    }

    /*
    置底
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoBottum_Click)
    */
    public async btnGoBottum_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSectionId: string = gs_PaperParagraphCRUD.SectionId_OrderNum;
        var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert("请选择需要置底的记录！");
            return "";
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "sectionId": strSectionId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await gs_PaperParagraph_GoBottomAsync(objOrderByData);
            //gs_PaperParagraph_ReFreshCache();
        }
        catch (e) {
            var strMsg: string = `置底出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        var strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /*
    移动记录序号时的预检查函数
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
    */
    public PreCheck4Order(): boolean {
        var strSectionId: string = gs_PaperParagraphCRUD.SectionId_OrderNum;
        if (strSectionId == "") {
            var strMsg = `请输入sectionId!`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return false;
        }
        return true;
    }

    /*
    下移
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
    */
    public async btnDownMove_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSectionId: string = gs_PaperParagraphCRUD.SectionId_OrderNum;
        var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert(`请选择需要下移的记录!`);
            return;
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "sectionId": strSectionId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await gs_PaperParagraph_DownMoveAsync(objOrderByData);
            //gs_PaperParagraph_ReFreshCache();
        }
        catch (e) {
            var strMsg: string = `下移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        var strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /*
    上移
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
    */
    public async btnUpMove_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSectionId: string = gs_PaperParagraphCRUD.SectionId_OrderNum;
        var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert(`请选择需要上移的记录!`);
            return;
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "sectionId": strSectionId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await gs_PaperParagraph_UpMoveAsync(objOrderByData);
            //gs_PaperParagraph_ReFreshCache();
        }
        catch (e) {
            var strMsg: string = `上移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        var strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /* 置顶
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoTop_Click)
    */
    public async btnGoTop_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSectionId: string = gs_PaperParagraphCRUD.SectionId_OrderNum;
        var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert("请选择需要置顶的记录！");
            return "";
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "sectionId": strSectionId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await gs_PaperParagraph_GoTopAsync(objOrderByData);
            //gs_PaperParagraph_ReFreshCache();
        }
        catch (e) {
            var strMsg: string = `置顶出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        var strListDiv: string = this.mstrListDiv;
        var strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /*
     添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
    */
    public async btnCopyRecord_Click() {
        try {
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要克隆的记录！");
                return "";
            }
            const responseText = await this.CopyRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `复制记录不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
   */
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelRecord(strKeyId);
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    在数据表里选择记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
   */
    public async btnSelectRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            this.SelectRecord(strKeyId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `选择记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public async DelRecord(strParagraphId: string) {
        try {
            const responseText = await gs_PaperParagraph_DelRecordAsync(strParagraphId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_PaperParagraph_ReFreshCache();
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

    /* 
    根据关键字选择相应的记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
     <param name = "sender">参数列表</param>
   */
    public async SelectRecord(strParagraphId: string) {
        try {
            const responseText = await gs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId);
            var objgs_PaperParagraphEN: clsgs_PaperParagraphEN = <clsgs_PaperParagraphEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_vgs_PaperParagraph");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }

    /* 删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
   */
    public async btnDelRecord_Click() {
        try {
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
   */
    public async btnExportExcel_Click() {
        var strWhereCond = " 1=1 ";
        try {
            const responseText = await vgs_PaperParagraph_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrvgs_PaperParagraphObjLst: Array<clsvgs_PaperParagraphEN> = <Array<clsvgs_PaperParagraphEN>>jsonData;
                this.BindTab_vgs_PaperParagraph(this.mstrListDiv, arrvgs_PaperParagraphObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `导出Excel不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public Combinevgs_PaperParagraphCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.ParagraphContent_q != "") {
                strWhereCond += ` And ${clsvgs_PaperParagraphEN.con_ParagraphContent} like '% ${this.ParagraphContent_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0009)在组合查询条件(Combinegs_PaperParagraphCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public Combinevgs_PaperParagraphConditionObj(): clsvgs_PaperParagraphEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvgs_PaperParagraph_Cond: clsvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.ParagraphContent_q != "") {
                strWhereCond += ` And ${clsvgs_PaperParagraphEN.con_ParagraphContent} like '% ${this.ParagraphContent_q}%'`;
                objvgs_PaperParagraph_Cond.SetCondFldValue(clsvgs_PaperParagraphEN.con_ParagraphContent, this.ParagraphContent_q, "like");
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0010)在组合查询条件对象(Combinegs_PaperParagraphConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvgs_PaperParagraph_Cond;
    }

    /* 显示vgs_PaperParagraph对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrgs_PaperParagraphObjLst">需要绑定的对象列表</param>
   */
    public BindTab_vgs_PaperParagraph(divContainer: string, arrvgs_PaperParagraphObjLst: Array<clsvgs_PaperParagraphEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paragraphTypeName",
                    SortBy: "paragraphTypeName",
                    ColHeader: "段落类型",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "paragraphContent",
                    SortBy: "paragraphContent",
                    ColHeader: "段落内容",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "voteCount",
                    SortBy: "voteCount",
                    ColHeader: "点赞计数",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "commentCount",
                    SortBy: "commentCount",
                    ColHeader: "评论数",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "versionCount",
                    SortBy: "versionCount",
                    ColHeader: "版本统计",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
                {
                    FldName: "createDate",
                    SortBy: "createDate",
                    ColHeader: "建立日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: () => { }
                },
                {
                    FldName: "createUser",
                    SortBy: "createUser",
                    ColHeader: "建立用户",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 8,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 9,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 10,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "修改",
                    Text: "修改",
                    TdClass: "text-left",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "删除",
                    Text: "删除",
                    TdClass: "text-left",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('DelRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvgs_PaperParagraphObjLst, arrDataColumn, "paragraphId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /* 函数功能:在数据 列表中跳转到某一页
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
   */
    public async IndexPage(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        const responseBindGv = await this.BindGv_vgs_PaperParagraph();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vgs_PaperParagraph() {
        if (this.hidSortvgs_PaperParagraphBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortvgs_PaperParagraphBy)为空，请检查！(In BindGv_vgs_PaperParagraph)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.Combinevgs_PaperParagraphCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvgs_PaperParagraphObjLst: Array<clsvgs_PaperParagraphEN> = [];
        try {
            const responseRecCount = await vgs_PaperParagraph_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_PaperParagraphBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_PaperParagraph_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_PaperParagraphObjLst = <Array<clsvgs_PaperParagraphEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
        if (arrvgs_PaperParagraphObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vgs_PaperParagraph(strListDiv, arrvgs_PaperParagraphObjLst);
            console.log("完成BindGv_vgs_PaperParagraph!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            //console.trace();
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
   */
    public async BindGv_vgs_PaperParagraph_Cache() {
        if (this.hidSortvgs_PaperParagraphBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortvgs_PaperParagraphBy)为空，请检查！(In BindGv_vgs_PaperParagraph_Cache)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var objvgs_PaperParagraph_Cond = this.Combinevgs_PaperParagraphConditionObj();
        var strWhereCond = JSON.stringify(objvgs_PaperParagraph_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvgs_PaperParagraphObjLst: Array<clsvgs_PaperParagraphEN> = [];
        try {
            this.RecCount = await vgs_PaperParagraph_GetRecCountByCond_Cache(objvgs_PaperParagraph_Cond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_PaperParagraphBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrvgs_PaperParagraphObjLst = await vgs_PaperParagraph_GetObjLstByPager_Cache(objPagerPara);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
            return;
        }
        if (arrvgs_PaperParagraphObjLst.length == 0) {
            var strKey: string = `${clsgs_PaperParagraphEN._CurrTabName}`;
            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vgs_PaperParagraph(strListDiv, arrvgs_PaperParagraphObjLst);
            console.log("完成BindGv_vgs_PaperParagraph!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:从界面列表中根据某一个字段排序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     <param name = "strSortByFld">排序的字段</param>
   */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortvgs_PaperParagraphBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvgs_PaperParagraphBy.indexOf("Asc") >= 0) {
                this.hidSortvgs_PaperParagraphBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvgs_PaperParagraphBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvgs_PaperParagraphBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vgs_PaperParagraph();
    }

    /* 复制记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
   */
    public async CopyRecord(arrParagraphId: Array<string>) {
        try {
            const responseText = await gs_PaperParagraph_GetObjLstByParagraphIdLstAsync(arrParagraphId);
            console.log('responseText=');
            console.log(responseText);
            var intCount: number = 0;
            var arrgs_PaperParagraphObjLst: Array<clsgs_PaperParagraphEN> = <Array<clsgs_PaperParagraphEN>>responseText;
            for (let objInFor of arrgs_PaperParagraphObjLst) {
                const strMaxStrId = await gs_PaperParagraph_GetMaxStrIdAsync();
                console.log('strMaxStrId=' + strMaxStrId);
                objInFor.paragraphId = strMaxStrId;
                const responseText2 = await gs_PaperParagraph_AddNewRecordAsync(objInFor);
                console.log('responseText2=');
                console.log(responseText2);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
                    var strInfo: string = `克隆记录成功!`;
                    intCount++;
                }
                else {
                    var strInfo: string = `克隆记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
            }
            var strInfo: string = `共克隆了${intCount}条记录!`;
            alert(strInfo);
            console.log('完成！');
        }
        catch (e) {
            var strMsg: string = `复制记录不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }

    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public async DelMultiRecord(arrParagraphId: Array<string>) {
        try {
            const responseText = await gs_PaperParagraph_Delgs_PaperParagraphsAsync(arrParagraphId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_PaperParagraph_ReFreshCache();
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelMultiRecord!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 显示{0}对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
     <param name = "divContainer">显示容器</param>
     <param name = "objgs_PaperParagraph">需要显示的对象</param>
   */
    public Showgs_PaperParagraphObj(divContainer: string, objgs_PaperParagraph: clsgs_PaperParagraphEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_PaperParagraph);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objgs_PaperParagraph[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjgs_PaperParagraphEN">表实体类对象</param>
    <returns>列表的第一个关键字值</returns>
   */
    public GetFirstKey(): string {
        if (arrSelectedKeys.length == 1) {
            return arrSelectedKeys[0];
        }
        else {
            alert(`请选择一个关键字！目前选择了:${arrSelectedKeys.length}个关键字。`);
            return "";
        }
    }

    /*
    设置Session
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
    <param name = "Key">关键字</param>
    <param name = "Value">值</param>
    */
    public SetSessionAsync(Key: string, Value: string): Promise<void> {
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl_Session_SetString,
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key,
                    Value: Value
                },
                success: function (data) {
                    var strKey = data.key;
                    var strValue = data.value;
                    console.log('strKey, strValue=' + strKey + strValue);
                }
            });
        });
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
    /*
    * 获取当前页序号(Used In BindGv_)
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvgs_PaperParagraphBy(value: string) {
        $("#hidSortvgs_PaperParagraphBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_PaperParagraphBy(): string {
        return $("#hidSortvgs_PaperParagraphBy").val();
    }
    /*
    * 段落内容 (Used In CombineCondition())
   */
    public get ParagraphContent_q(): string {
        return $("#txtParagraphContent_q").val();
    }
    /*
    * sectionId (Used In btnReOrder_Click())
   */
    public static get SectionId_OrderNum(): string {
        return $("#txtSectionId_OrderNum").val();
    }
    /*
    * sectionId (Used In btnReOrder_Click())
   */
    public static set SectionId_OrderNum(value: string) {
        $("#txtSectionId_OrderNum").val(value);
    }
}