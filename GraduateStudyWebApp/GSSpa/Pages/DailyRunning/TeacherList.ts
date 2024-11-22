
/*-- -- -- -- -- -- -- -- -- -- --
类名:spaTeacherInfoCRUD
表名:TeacherInfo(01120093)
生成代码版本:2020.08.20.1
生成日期:2020/08/28 00:07:07
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:基本信息维护
模块英文名:BaseInfo
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsTeacherInfoEN } from "../TS/L0_Entity/BaseInfo/clsTeacherInfoEN.js";
//import { clsTeacherInfoEN } from "../TS/L0_Entity/BaseInfo/clsTeacherInfoEN.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsCurrEduClsTeacherEN } from "../TS/L0_Entity/DailyRunning/clsCurrEduClsTeacherEN.js";
import { TeacherInfo_AddNewRecordAsync, TeacherInfo_DelRecordAsync, TeacherInfo_DelTeacherInfosAsync, TeacherInfo_GetObjByid_TeacherAsync, TeacherInfo_GetObjLstByid_TeacherLstAsync, TeacherInfo_GetObjLstByPagerAsync, TeacherInfo_GetObjLstByPager_Cache, TeacherInfo_GetRecCountByCondAsync, TeacherInfo_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/BaseInfo/clsTeacherInfoWApi.js";
import { CurrEduClsTeacher_AddNewRecordAsync, CurrEduClsTeacher_IsExistRecordAsync } from "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsTeacherWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_TeacherInfo(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_TeacherInfo(): void;
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
declare function CloseWindow(): void;
declare var strCurrPrjId;
declare var $;
/* spaTeacherInfoCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class TeacherList implements clsOperateList implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortTeacherInfoBy: string = "id_Teacher";


    BindGv(strType: string, strPara: string) {
        this.BindGv_TeacherInfo();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "TeacherInfo":
                alert('该类没有绑定该函数：[this.BindGv_TeacherInfo_Cache]！');
                //this.BindGv_TeacherInfo_Cache();
                break;
        }
    }

  
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



    /*
   按钮单击,用于调用Js函数中btn_Click
  (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
  */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: TeacherList = new TeacherList();
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
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
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
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
                var strMsg = '命令:' + strCommandName + "在函数(TeacherListEx.btn_Click)中没有被处理！";
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
  
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortTeacherInfoBy = "teacherName Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_TeacherInfo();
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

            this.hidSortTeacherInfoBy = "teacherName Asc";
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_TeacherInfo();
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
        const responseBindGv = await this.BindGv_TeacherInfo();
    }

    /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
   */
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面
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
            const responseBindGv = await this.BindGv_TeacherInfo();
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
            const responseBindGv = await this.BindGv_TeacherInfo();
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
    public async DelRecord(strid_Teacher: string) {
        try {
            const responseText = await TeacherInfo_DelRecordAsync(strid_Teacher);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //TeacherInfo_ReFreshCache();
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
    public async SelectRecord(strid_Teacher: string) {
        try {
            const responseText = await TeacherInfo_GetObjByid_TeacherAsync(strid_Teacher);
            var objTeacherInfoEN: clsTeacherInfoEN = <clsTeacherInfoEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_TeacherInfo");
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
            const responseBindGv = await this.BindGv_TeacherInfo();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

   // /* 根据条件获取相应的对象列表
   //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
   //*/
   // public async btnExportExcel_Click() {
   //     var strWhereCond = " 1=1 ";
   //     try {
   //         const responseText = await TeacherInfo_GetObjLstAsync(strWhereCond).then((jsonData) => {
   //             var arrTeacherInfoObjLst: Array<clsTeacherInfoEN> = <Array<clsTeacherInfoEN>>jsonData;
   //             this.BindTab_TeacherInfo(this.mstrListDiv, arrTeacherInfoObjLst);
   //         });
   //     }
   //     catch (e) {
   //         console.error('catch(e)=');
   //         console.error(e);
   //         var strMsg: string = `导出Excel不成功,${e}.`;
   //         alert(strMsg);
   //     }
   // }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombineTeacherInfoCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0009)在组合查询条件(CombineTeacherInfoCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombineTeacherInfoConditionObj(): clsTeacherInfoEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objTeacherInfo_Cond: clsTeacherInfoEN = new clsTeacherInfoEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0010)在组合查询条件对象(CombineTeacherInfoConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objTeacherInfo_Cond;
    }

    /* 显示TeacherInfo对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrTeacherInfoObjLst">需要绑定的对象列表</param>
   */
    public BindTab_TeacherInfo(divContainer: string, arrTeacherInfoObjLst: Array<clsTeacherInfoEN>) {
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
                    FldName: "teacherID",
                    SortBy: "teacherID",
                    ColHeader: "教师Id",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "teacherName",
                    SortBy: "teacherName",
                    ColHeader: "教师姓名",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnCurrEduClsInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    SortBy: "",
                //    ColHeader: "修改",
                //    Text: "修改",
                //    TdClass: "text-left",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    FldName: "",
                //    SortBy: "",
                //    ColHeader: "删除",
                //    Text: "删除",
                //    TdClass: "text-left",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btn_Click('DelRecordInTab', '${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrTeacherInfoObjLst, arrDataColumn, "id_Teacher");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    //确定选择 并添加到关系表中
    public async btnCurrEduClsInTab_Click(strkeyId: string) {

        const response = await this.AddNewRecordSaveCurrEduClsTeacher(strkeyId);

    }
    /* 添加新记录，保存函数
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSaveCurrEduClsTeacher(strid_Teacher: string) {
       // this.DivName = "divAddNewRecordSave";
        var strCurrEduClsId = $('#hidCurrEduClsId').val();
        var strId_Teacher = strid_Teacher;
        var objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
        const responseText = await this.PutDataToCurrEduClsTeacher(objCurrEduClsTeacherEN, strid_Teacher);
        try {
            //同一用户，同一主题 同一观点 只能添加一次；
            var strWhere = " 1 = 1 And id_CurrEduCls = '" + strCurrEduClsId + "' And Id_Teacher = '" + strId_Teacher + "'";
            //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
            const responseText = await CurrEduClsTeacher_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经加入过该教学班了！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await CurrEduClsTeacher_AddNewRecordAsync(objCurrEduClsTeacherEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
                //关闭列表
                CloseWindow();
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult46').val(strInfo);
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
 <param name = "pobjCurrEduClsTeacherEN">数据传输的目的类对象</param>
*/
    public async PutDataToCurrEduClsTeacher(pobjCurrEduClsTeacherEN: clsCurrEduClsTeacherEN, strid_Teacher: string) {

        var strCurrEduClsId = $('#hidCurrEduClsId').val();

        pobjCurrEduClsTeacherEN.id_CurrEduCls = strCurrEduClsId;// 教学班


        //获取用户，通过用户Id 查询学生表数据得到学生流水号；
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var strid_TeacherInfo: string = "";
        var strSchoolTeam: string = "";
        var strSchoolYear: string = "";
        //var strWhereCond = `1=1 And ${clsTeacherInfoEN.con_StuID} = '${strUserId}'`;

        //const responseText = await TeacherInfo_GetFirstObjAsync(strWhereCond).then((jsonData) => {
        //    var objTeacherInfoEN: clsTeacherInfoEN = <clsTeacherInfoEN>jsonData;
        //    if (objTeacherInfoEN != null) {
        //        strid_TeacherInfo = objTeacherInfoEN.id_TeacherInfo;

        //    }
        //})

        pobjCurrEduClsTeacherEN.id_Teacher = strid_Teacher;// 老
        //pobjCurrEduClsTeacherEN.schoolTerm = this.schoolTerm;// 学期
        //pobjCurrEduClsTeacherEN.schoolYear = this.schoolYear;// 学年
        pobjCurrEduClsTeacherEN.updDate = clsPubFun4Web.getNowDate_ymd();// 
        pobjCurrEduClsTeacherEN.updUser = strUserId;//
       // pobjCurrEduClsTeacherEN.memo = this.memo;// 备注
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
        const responseBindGv = await this.BindGv_TeacherInfo();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_TeacherInfo() {
        if (this.hidSortTeacherInfoBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortTeacherInfoBy)为空，请检查！(In BindGv_TeacherInfo)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombineTeacherInfoCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrTeacherInfoObjLst: Array<clsTeacherInfoEN> = [];
        try {
            const responseRecCount = await TeacherInfo_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortTeacherInfoBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await TeacherInfo_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrTeacherInfoObjLst = <Array<clsTeacherInfoEN>>jsonData;
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
        try {
            this.BindTab_TeacherInfo(strListDiv, arrTeacherInfoObjLst);
            console.log("完成BindGv_TeacherInfo!");
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
    public async BindGv_TeacherInfo_Cache() {
        if (this.hidSortTeacherInfoBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortTeacherInfoBy)为空，请检查！(In BindGv_TeacherInfo_Cache)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var objTeacherInfo_Cond = this.CombineTeacherInfoConditionObj();
        var strWhereCond = JSON.stringify(objTeacherInfo_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrTeacherInfoObjLst: Array<clsTeacherInfoEN> = [];
        try {
            this.RecCount = await TeacherInfo_GetRecCountByCond_Cache(objTeacherInfo_Cond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortTeacherInfoBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrTeacherInfoObjLst = await TeacherInfo_GetObjLstByPager_Cache(objPagerPara);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
            return;
        }
        if (arrTeacherInfoObjLst.length == 0) {
            var strKey: string = `${clsTeacherInfoEN._CurrTabName}`;
            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_TeacherInfo(strListDiv, arrTeacherInfoObjLst);
            console.log("完成BindGv_TeacherInfo!");
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
        if (this.hidSortTeacherInfoBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortTeacherInfoBy.indexOf("Asc") >= 0) {
                this.hidSortTeacherInfoBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortTeacherInfoBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortTeacherInfoBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_TeacherInfo();
    }

    /// <summary>
    /// 在用户自定义控件中，设置关键字的值，是否只读
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    /// </summary>
    /// <param name = "bolReadonly">是否只读</param>
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtid_Teacher').prop['ReadOnly'] = bolReadonly;
    }

    /* 复制记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
   */
    public async CopyRecord(arrid_Teacher: Array<string>) {
        try {
            const responseText = await TeacherInfo_GetObjLstByid_TeacherLstAsync(arrid_Teacher);
            console.log('responseText=');
            console.log(responseText);
            var intCount: number = 0;
            var arrTeacherInfoObjLst: Array<clsTeacherInfoEN> = <Array<clsTeacherInfoEN>>responseText;
            for (let objInFor of arrTeacherInfoObjLst) {
                const responseText2 = await TeacherInfo_AddNewRecordAsync(objInFor);
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
    public async DelMultiRecord(arrid_Teacher: Array<string>) {
        try {
            const responseText = await TeacherInfo_DelTeacherInfosAsync(arrid_Teacher);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //TeacherInfo_ReFreshCache();
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
     <param name = "objTeacherInfo">需要显示的对象</param>
   */
    public ShowTeacherInfoObj(divContainer: string, objTeacherInfo: clsTeacherInfoEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objTeacherInfo);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objTeacherInfo[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjTeacherInfoEN">表实体类对象</param>
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
    public set hidSortTeacherInfoBy(value: string) {
        $("#hidSortTeacherInfoBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortTeacherInfoBy(): string {
        return $("#hidSortTeacherInfoBy").val();
    }
}