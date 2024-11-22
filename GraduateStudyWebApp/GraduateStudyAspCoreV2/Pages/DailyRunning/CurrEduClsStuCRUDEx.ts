
/*-- -- -- -- -- -- -- -- -- -- --
类名:CurrEduClsStuCRUDEx
表名:CurrEduClsStu(01120125)
生成代码版本:2020.05.09.1
生成日期:2020/05/11 16:30:20
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:日常运行
模块英文名:DailyRunning
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { CurrEduClsStuCRUD } from "../PagesBase/DailyRunning_Share/CurrEduClsStuCRUD.js";
import { clsvCurrEduClsEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js";
import { clsvCurrEduClsStuEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js";
import { vCurrEduClsStu_GetObjLstByPagerAsync, vCurrEduClsStu_GetRecCountByCondAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js";
import { vCurrEduCls_GetObjLstByPagerAsync, vCurrEduCls_GetRecCountByCondAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsWApi.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindTab, BindTab_V, GetFirstCheckedKeyId, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { CurrEduClsStu_EditEx } from "./CurrEduClsStu_EditEx.js";


declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;

declare function ShowDialogOne(): void;
declare function HideDialogOne(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* CurrEduClsStuCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class CurrEduClsStuCRUDEx extends CurrEduClsStuCRUD implements IShowList {

    //论文列表
    public mstrListDivCurrEduCls: string = "divCurrEduClsDataLst";
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvCurrEduClsStuBy: string = "id_EduClsStu";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_vCurrEduClsStu();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vCurrEduClsStu":
                alert('该类没有绑定该函数：[this.BindGv_vCurrEduClsStu_Cache]！');
                //this.BindGv_vCurrEduClsStu_Cache();
                break;
            default:
                strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
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
            CurrEduClsStuCRUD.CourseId_Static = clsPublocalStorage.courseId;
            //建立缓存
            //根据角色隐藏按钮 
            var strRoleId = clsPublocalStorage.roleId;
            if (strRoleId == "00620003") {
                $("#btnAddNewRecord").show();
               
            }
            else {
                $("#btnAddNewRecord").hide();
            }

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();
            
            CurrEduClsStuCRUD.sortvCurrEduClsStuBy = "eduClsName Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vCurrEduClsStu();
            $("#divLoading").hide();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }

  
    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        let objPage: CurrEduClsStuCRUDEx;
        if (CurrEduClsStuCRUD.objPage_CRUD == null) {
            CurrEduClsStuCRUD.objPage_CRUD = new CurrEduClsStuCRUDEx();
            objPage = <CurrEduClsStuCRUDEx>CurrEduClsStuCRUD.objPage_CRUD;
        }
        else {
            objPage = <CurrEduClsStuCRUDEx>CurrEduClsStuCRUD.objPage_CRUD;
        }
        const objPage_Edit: CurrEduClsStu_EditEx = new CurrEduClsStu_EditEx(objPage);
        const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
        let strMsg = '';

        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "QueryCurrEduCls":    //查询记录
                objPage.btnCurrEduClsQuery_Click();
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
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
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
                //objPage_Edit.btnUnDelRecordBySign_Click();
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
            case "AddCurrEduCls":            //加入教学班
                objPage.selectCurrEduCls_Click();
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
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vCurrEduClsStu() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevCurrEduClsStuCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvCurrEduClsStuObjLst: Array<clsvCurrEduClsStuEN> = [];
        try {
            this.recCount = await vCurrEduClsStu_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: CurrEduClsStuCRUD.sortvCurrEduClsStuBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vCurrEduClsStu_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvCurrEduClsStuObjLst = <Array<clsvCurrEduClsStuEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        try {
            this.BindTab_vCurrEduClsStu(strListDiv, arrvCurrEduClsStuObjLst);
            console.log("完成BindGv_vCurrEduClsStu!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vCurrEduCls对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrCurrEduClsObjLst">需要绑定的对象列表</param>
*/
    public async BindTab_vCurrEduCls(divContainer: string, arrvCurrEduClsObjLst: Array<clsvCurrEduClsEN>) {
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
                    fldName: "currEduClsId",
                    colHeader: "教学班Id",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "eduClsName",
                    colHeader: "教学班",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "courseCode",
                //    colHeader: "课程代码",
                //    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "courseName",
                //    colHeader: "课程",
                //    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "collegeName",
                    colHeader: "学院",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "schoolYear",
                    colHeader: "学年",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "schoolTerm",
                    colHeader: "学期",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "modifyDate",
                //    colHeader: "日期",
                //    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "modifyUserID",
                //    colHeader: "编辑人",
                //    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
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
                        btn1.setAttribute("onclick", `btnCurrEduClsInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
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
        BindTab_V(o, arrvCurrEduClsObjLst, arrDataColumn, "id_CurrEduCls", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /* 函数功能:在数据 列表中跳转到某一页
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
   */
    //public IndexPageTwo(intPageIndex) {
    //    if (intPageIndex == 0) {
    //        intPageIndex = this.objPager.pageCount;
    //    }
    //    console.log("跳转到" + intPageIndex + "页");
    //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
    //    this.BindGv_vCurrEduCls();
    //}




    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 <returns>条件串(strWhereCond)</returns>
*/
    public async CombinevCurrEduClsCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.currEduClsId != "") {
                strWhereCond += ` And ${clsvCurrEduClsEN.con_CurrEduClsId} like '% ${this.currEduClsId}%'`;
            }
            if (this.eduClsName != "") {
                strWhereCond += ` And ${clsvCurrEduClsEN.con_EduClsName} like '% ${this.eduClsName}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vCurrEduCls() {
        var strListDiv: string = this.mstrListDivCurrEduCls;//教学班
        var strWhereCond = await this.CombinevCurrEduClsCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvCurrEduClsObjLst: Array<clsvCurrEduClsEN> = [];
        try {
            this.recCount = await vCurrEduCls_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvCurrEduClsBy,
                sortFun: (x, y) => { return 0; }
            };
            arrvCurrEduClsObjLst = await vCurrEduCls_GetObjLstByPagerAsync(objPagerPara);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvCurrEduClsObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vCurrEduCls(strListDiv, arrvCurrEduClsObjLst);
            console.log("完成BindGv_vCurrEduCls!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    //弹出列表数据；
    public async selectCurrEduCls_Click() {
        ShowDialogOne();
        const responseObjList = await this.BindGv_vCurrEduCls();
    }
    //查询列表
    public async btnCurrEduClsQuery_Click() {
        const responseObjList = await this.BindGv_vCurrEduCls();
    }

  
    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvCurrEduClsBy(value: string) {
        $("#hidSortvCurrEduClsBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvCurrEduClsBy(): string {
        return $("#hidSortvCurrEduClsBy").val();
    }
    /*
* 当前教学班Id
*/
    public get currEduClsId_q(): string {
        return $("#txtCurrEduClsId_q").val();
    }
    /*
* 教学班名称
*/
    public get eduClsName_q(): string {
        return $("#txteduClsName_q").val();
    }

    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 <returns>条件串(strWhereCond)</returns>
*/
    public async CombinevCurrEduClsStuCondition(): Promise<string>  {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.currEduClsId_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsStuEN.con_CurrEduClsId} like '% ${this.currEduClsId_q}%'`;
            }
            if (this.eduClsName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsStuEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
            }
            if (this.StuId_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsStuEN.con_StuID} like '% ${this.StuId_q}%'`;
            }

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            $("#hidUserId").val(strUserId);


            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

            }
            else if (strRoleId == "00620002") {
                //教师

                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                strWhereCond += " and stuID in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "')";
            }
            else {
                ////学生； 
                strWhereCond += ` And ${clsvCurrEduClsStuEN.con_StuID} = '${strUserId}'`;
                ////学生00620003

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsStuCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 显示vCurrEduClsStu对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrCurrEduClsStuObjLst">需要绑定的对象列表</param>
*/
    public async BindTab_vCurrEduClsStu(divContainer: string, arrvCurrEduClsStuObjLst: Array<clsvCurrEduClsStuEN>) {
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
                    fldName: "eduClsName",
                    colHeader: "教学班",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
               
                {
                    fldName: "courseName",
                    colHeader: "课程",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "stuID",
                    colHeader: "学生Id",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "stuName",
                    colHeader: "姓名",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "schoolTerm",
                //    colHeader: "学期",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "schoolYear",
                //    colHeader: "学年",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
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
        BindTab_V(o, arrvCurrEduClsStuObjLst, arrDataColumn, "id_EduClsStu", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }



   
    /*
* 教学班名称
*/
    public get eduClsName(): string {
        return $("#eduClsName_q").val();
    }
    /*
* 当前教学班Id
*/
    public get currEduClsId(): string {
        return $("#currEduClsId_q").val();
    }
    /*
* 课程名称
*/
    public get StuId_q(): string {
        return $("#txtStuID").val();
    }
}