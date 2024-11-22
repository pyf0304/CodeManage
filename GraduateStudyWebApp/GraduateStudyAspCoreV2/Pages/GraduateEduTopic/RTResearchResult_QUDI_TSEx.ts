
/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiRTResearchResult_QUDI_TSEx
表名:RTResearchResult(01120620)
生成代码版本:2020.04.08.1
生成日期:2020/04/10 14:19:10
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
//
//import * as QQ from "q";
import { RTResearchResultCRUD } from "../PagesBase/GraduateEduTopic/RTResearchResultCRUD.js";
import { clsvRTResearchResultEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTResearchResultEN.js";
import { vRTResearchResult_GetObjLstByPagerAsync, vRTResearchResult_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTResearchResultWApi.js";
import { BindTab, BindTab_V, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiRTResearchResult_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class RTResearchResult_QUDI_TSEx extends RTResearchResultCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvRTResearchResultBy: string = "mId";
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
         
                RTResearchResultCRUD.sortvRTResearchResultBy = "updDate Desc";
            var strWhereCond = await this.CombinevRTResearchResultCondition();
            const responseText = await vRTResearchResult_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.recCount = jsonData;
            });
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
            //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vRTResearchResult();

            
                //$('#lnkUserName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');

                $("#hidUserId").val(clsPublocalStorage.userId);
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


    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombinevRTResearchResultCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.userName_q != "") {
                strWhereCond += ` And ${clsvRTResearchResultEN.con_UserName} like '% ${this.userName_q}%'`;
            }
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsvRTResearchResultEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }
            if (this.topicName_q != "") {
                strWhereCond += ` And ${clsvRTResearchResultEN.con_TopicName} like '% ${this.topicName_q}%'`;
            }

        

            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                // $("#btnDelRecord").show();

            }
            else if (strRoleId == "00620002") {
                //教师
                // $("#btnDelRecord").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //学生； 
                // $("#btnDelRecord").show();
                strWhereCond += ` And ${clsvRTResearchResultEN.con_UpdUser} = '${strUserId}'`;
                //学生00620003

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTResearchResultCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vRTResearchResult() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevRTResearchResultCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvRTResearchResultObjLst: Array<clsvRTResearchResultEN> = [];
        try {
            this.recCount = await vRTResearchResult_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: RTResearchResultCRUD.sortvRTResearchResultBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTResearchResult_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTResearchResultObjLst = <Array<clsvRTResearchResultEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvRTResearchResultObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vRTResearchResult(strListDiv, arrvRTResearchResultObjLst);
            console.log("完成BindGv_vRTResearchResult!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 显示vRTResearchResult对象的所有属性值
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    <param name = "divContainer">显示容器</param>
    <param name = "arrRTResearchResultObjLst">需要绑定的对象列表</param>
  */
    public async BindTab_vRTResearchResult(divContainer: string, arrvRTResearchResultObjLst: Array<clsvRTResearchResultEN>) {
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
                    fldName: "paperContent",
                    colHeader: "主题内容",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "topicName",
                    colHeader: "栏目主题",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "topicContent",
                //    colHeader: "主题内容",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "topicProposePeople",
                //    colHeader: "主题提出人",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "periodical",
                    colHeader: "期刊",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "author",
                    colHeader: "作者",
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
                    fldName: "userName",
                    colHeader: "编辑人",
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
        BindTab_V(o, arrvRTResearchResultObjLst, arrDataColumn, "mId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }






//    //////////////////////////////////////////////////////////////////////////////////
//    /* 把所有的查询控件内容组合成一个条件串
//  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
//   <returns>条件串(strWhereCond)</returns>
// */
//    public async CombinevRTResearchResultCondition():Promise<string> {
//        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//        //例如 1 = 1 && userName = '张三'
//        var strWhereCond: string = " 1 = 1 ";
//        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//        try {
//            if (this.userName_q != "") {
//                strWhereCond += ` And ${clsvRTResearchResultEN.con_UserName} like '% ${this.userName_q}%'`;
//            }
//            if (this.paperTitle_q != "") {
//                strWhereCond += ` And ${clsvRTResearchResultEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
//            }
//            if (this.topicName_q != "") {
//                strWhereCond += ` And ${clsvRTResearchResultEN.con_TopicName} like '% ${this.topicName_q}%'`;
//            }

//            //读取session角色 来判断绑定不同数据列表
//            //获取用户角色来判断显示不同的列表数据；

//            var strUserId = clsPublocalStorage.userId;
//            var strRoleId = clsPublocalStorage.roleId;

//            //判断角色 
//            //管理员
//            if (strRoleId == "00620001") {

//            }
//            else if (strRoleId == "00620002") {

//                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
//                strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";

//            }
//            else {
//                strWhereCond += ` And ${clsvRTResearchResultEN.con_UpdUser} = '${strUserId}'`;
//                //学生00620003

//            }
//        }
//        catch (objException) {
//            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTResearchResultCondition)时出错!请联系管理员!${objException}`;
//            throw strMsg;
//        }
//        return strWhereCond;
//    }

//    /* 根据条件获取相应的对象列表
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
//  */
//    public async BindGv_vRTResearchResult() {
//        var strListDiv: string = this.mstrListResearchResultDivPaper;
//        var strWhereCond = await this.CombinevRTResearchResultCondition();
//        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
//        var arrvRTResearchResultObjLst: Array<clsvRTResearchResultEN> = [];
//        try {
//            this.recCount = await vRTResearchResult_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {

//            });
//            var objPagerPara: stuPagerPara = {
//                pageIndex: intCurrPageIndex,
//                pageSize: this.pageSize,
//                whereCond: strWhereCond,
//                orderBy: this.hidSortvRTResearchResultBy,
//                sortFun: (x, y) => { return 0; }
//            };
//            const responseObjLst = await vRTResearchResult_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
//                arrvRTResearchResultObjLst = <Array<clsvRTResearchResultEN>>jsonData;
//            });
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `绑定GridView不成功,${e}.`;
//            alert(strMsg);
//        }
//        try {
//            this.BindTab_vRTResearchResult(strListDiv, arrvRTResearchResultObjLst);
//            console.log("完成BindGv_vRTResearchResult!");
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 显示vRTResearchResult对象的所有属性值
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
//    <param name = "divContainer">显示容器</param>
//    <param name = "arrRTResearchResultObjLst">需要绑定的对象列表</param>
//  */
//    public async BindTab_vRTResearchResult(divContainer: string, arrvRTResearchResultObjLst: Array<clsvRTResearchResultEN>) {
//        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
//        if (o == null) {
//            alert(`${divContainer}不存在！`);
//            return;
//        }
//        var arrDataColumn: Array<clsDataColumn> =
//            [
//                {
//                    fldName: "",
//                    colHeader: "",
//                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "CheckBox",
//                    orderNum: 1,
//                    funcName: () => { }
//                },

//                {
//                    fldName: "paperTitle",
//                    colHeader: "论文标题",
//                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "periodical",
//                    colHeader: "期刊",
//                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "author",
//                    colHeader: "作者",
//                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "updDate",
//                    colHeader: "修改日期",
//                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "userName",
//                    colHeader: "编辑人",
//                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "",
//                    colHeader: "删除",
//                    text: "删除", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Button",
//                    orderNum: 1,
//                    funcName: (strKeyId: string, strText: string) => {
//                        var btn1: HTMLElement = document.createElement("button");
//                        btn1.innerText = strText;
//                        btn1.className = "btn btn-outline-info btn-sm";
//                        btn1.setAttribute("onclick", `btnDelResearchResultRecordInTab_Click('${strKeyId}');`);
//                        return btn1;
//                    }
//                },
//            ];
//        BindTab(o, arrvRTResearchResultObjLst, arrDataColumn, "mId");
//        if (arrvRTResearchResultObjLst.length > 10) {
//            this.objPager.recCount = this.recCount;
//            this.objPager.pageSize = this.pageSize;
//            this.objPager.ShowPagerV2(this, this.divName4Pager);
//        }

//    }
//    /* 
//   在数据表里删除记录
//   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
//  */
//    public async btnDelResearchResultRecordInTab_Click(strKeyId: string) {
//        try {
//            if (strKeyId == "") {
//                alert("请选择需要删除的记录！");
//                return "";
//            }
//            var lngKeyId = Number(strKeyId);
//            const responseText = await this.DelRecordResearchResult(lngKeyId);
//            const responseBindGv = await this.BindGv_vRTResearchResult();
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `删除记录不成功. ${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 
//   根据关键字删除记录
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
//  */
//    public async DelRecordResearchResult(lngmId: number) {
//        try {
//            const responseText = await RTResearchResult_DelRecordAsync(lngmId);
//            var returnInt: number = responseText;
//            if (returnInt > 0) {
//                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
//                //显示信息框
//                alert(strInfo);
//            }
//            else {
//                var strInfo: string = `删除记录不成功!`;
//                //显示信息框
//                alert(strInfo);
//            }
//            console.log("完成DelRecord!");
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `删除记录不成功. ${e}.`;
//            alert(strMsg);
//        }
//    }
//    //分页数据
//    /* 函数功能:在数据 列表中跳转到某一页 观点列表
// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
// <param name = "intPageIndex">页序号</param>
//*/
//    public IndexPageNine(intPageIndex) {
//        if (intPageIndex == 0) {
//            intPageIndex = this.objPager.pageCount;
//        }
//        console.log("跳转到" + intPageIndex + "页");
//        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
//        this.BindGv_vRTResearchResult();
//    }

//    /*
//* 设置排序字段-相当使用ViewState功能 --------------------研究结果
//*/
//    public set hidSortvRTResearchResultBy(value: string) {
//        $("#hidSortvRTResearchResultBy").val(value);
//    }
//    /*
//    * 设置排序字段
//   */
//    public get hidSortvRTResearchResultBy(): string {
//        return $("#hidSortvRTResearchResultBy").val();
//    }


//    /* 研究结果
//  */
//    public async SortByResearchResult(strSortByFld: string) {
//        if (this.hidSortvRTResearchResultBy.indexOf(strSortByFld) >= 0) {
//            if (this.hidSortvRTResearchResultBy.indexOf("Asc") >= 0) {
//                this.hidSortvRTResearchResultBy = `${strSortByFld} Desc`;
//            }
//            else {
//                this.hidSortvRTResearchResultBy = `${strSortByFld} Asc`;
//            }
//        }
//        else {
//            this.hidSortvRTResearchResultBy = `${strSortByFld} Asc`;
//        }
//        const responseBindGv = await this.BindGv_vRTResearchResult();
//    }




}