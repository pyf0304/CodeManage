
/*-- -- -- -- -- -- -- -- -- -- --
类名:CurrEduClsCRUD
表名:CurrEduCls(01120123)
生成代码版本:2020.05.09.1
生成日期:2020/05/11 16:30:23
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:日常运行
模块英文名:DailyRunning
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsCurrEduClsEN } from "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js";

import { clsXzClgEN } from "../TS/L0_Entity/BaseInfo/clsXzClgEN.js";
import { clscc_CourseEN } from "../TS/L0_Entity/CourseLearning/clscc_CourseEN.js";
import { clsvCurrEduClsEN } from "../TS/L0_Entity/DailyRunning/clsvCurrEduClsEN.js";
import { clsvCurrEduClsENEx } from "../TS/L0_Entity/DailyRunning/clsvCurrEduClsENEx.js";
import { clsSchoolTermEN } from "../TS/L0_Entity/SysPara/clsSchoolTermEN.js";
import { clsSchoolYearEN } from "../TS/L0_Entity/SysPara/clsSchoolYearEN.js";
import { clsXzGradeBaseEN } from "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js";
import { CurrEduCls_AddNewRecordAsync, CurrEduCls_AddNewRecordWithMaxIdAsync, CurrEduCls_DelCurrEduClssAsync, CurrEduCls_DelRecordAsync, CurrEduCls_GetMaxStrIdAsync, CurrEduCls_GetObjByid_CurrEduClsAsync, CurrEduCls_IsExistAsync, CurrEduCls_UpdateRecordAsync } from "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
//import { clszx_TextExWApi } from "../TS/L3_ForWApiEx/ZXCourseware/clszx_TextExWApi.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { XzClg_BindDdl_id_XzCollegeInDiv_Cache } from "../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js";
import { cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache } from "../TS/L3_ForWApi/CourseLearning/clscc_CourseTypeWApi.js";
import { vCurrEduCls_GetObjLstByPagerAsync, vCurrEduCls_GetRecCountByCondAsync } from "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsWApi.js";
import { SchoolTerm_BindDdl_SchoolTermInDiv_Cache } from "../TS/L3_ForWApi/SysPara/clsSchoolTermWApi.js";
import { SchoolYear_BindDdl_SchoolYearInDiv_Cache } from "../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js";
import { XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache } from "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js";
import { vUsersSim_func } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { vCurrEduClsEx_CopyToEx } from "../TS/L3_ForWApiEx/DailyRunning/clsvCurrEduClsExWApi.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(): void;
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
/* CurrEduClsCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class CurrEduClsList implements clsOperateList {
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divEdit";  //记录是否导入编辑区的变量
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;
    BindGv(strType: string, strPara: string) {
        //this.BindGv_vgs_TeachingDate();
        this.BindGv_vCurrEduCls();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "vgs_TeachingDate":
                alert('该类没有绑定该函数：[this.BindGv_vgs_TeachingDate_Cache]！');
                //this.BindGv_vgs_TeachingDate_Cache();
                break;
        }
    }
    /*
   按钮单击,用于调用Js函数中btn_Click
  (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
  */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: CurrEduClsList = new CurrEduClsList();
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage.btnAddNewRecord_Click();
                break;
            //case "SetUpDate":            //修改记录
            //    var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            //    if (strKeyId == "") {
            //        alert("请选择需要设置的记录！");
            //        return;
            //    }
            //    objPage.btnSetUpDateRecord_Click();
            //    break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage.btnUpdateRecord_Click(strKeyId);
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
                var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
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
            //建立缓存

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvCurrEduClsBy = "currEduClsId Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vCurrEduCls();
            $("#divLoading").hide();
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
    public CombinevCurrEduClsCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.CurrEduClsId_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsEN.con_CurrEduClsId} like '% ${this.CurrEduClsId_q}%'`;
            }
            if (this.eduClsName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
            }
            //获取当前登陆者的角色；
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();
            //判断角色
            //管理员
            if (strRoleId == "00620001") {

            }
            else if (strRoleId == "00620002") {
                strWhereCond += " And id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId+"' And isEffective='1')";
            }
            else {
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
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevCurrEduClsCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvCurrEduClsObjLst: Array<clsvCurrEduClsEN> = [];
        var arrvCurrEduClsExObjLst: Array<clsvCurrEduClsENEx> = [];
        try {
            const responseRecCount = await vCurrEduCls_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvCurrEduClsBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vCurrEduCls_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvCurrEduClsObjLst = <Array<clsvCurrEduClsEN>>jsonData;
            });


            arrvCurrEduClsExObjLst = arrvCurrEduClsObjLst.map(this.CopyToEx);
            for (var objInFor of arrvCurrEduClsExObjLst) {
                const conFuncMap = await this.FuncMap(objInFor);
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }

        try {
            this.BindTab_vCurrEduCls(strListDiv, arrvCurrEduClsExObjLst);
            console.log("完成BindGv_vCurrEduCls!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    ///// <summary>
    ///// 把同一个类的对象,复制到另一个对象
    ///// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
    ///// </summary>
    ///// <param name = "objvCurrEduClsENS">源对象</param>
    ///// <returns>目标对象=>clsvCurrEduClsEN:objvCurrEduClsENT</returns>
    public CopyToEx(objvCurrEduClsENS: clsvCurrEduClsEN): clsvCurrEduClsENEx {
        var objvCurrEduClsENT = new clsvCurrEduClsENEx();
        try {
            objvCurrEduClsENT = vCurrEduClsEx_CopyToEx(objvCurrEduClsENS);
            return objvCurrEduClsENT;
        }
        catch (e) {
            var strMsg: string = clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})",
                clsStackTrace.GetCurrClassFunction());
            alert(strMsg);
            return objvCurrEduClsENT;
        }
    }
    /// <summary>
    /// 把一个扩展类的部分属性进行函数转换
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
    /// </summary>
    /// <param name = "objvCurrEduClsS">源对象</param>
    public async FuncMap(objvCurrEduCls: clsvCurrEduClsENEx) {
        try {
            {
                var vUsersSim_UserId = objvCurrEduCls.modifyUserID;
                var vUsersSim_UserName = await vUsersSim_func(clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, vUsersSim_UserId);
                objvCurrEduCls.userName = vUsersSim_UserName;
            };

        }
        catch (e) {
            var strMsg: string = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
        }
    }
    /* 显示vCurrEduCls对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrCurrEduClsObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vCurrEduCls(divContainer: string, arrvCurrEduClsObjLst: Array<clsvCurrEduClsENEx>) {
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
                    FldName: "currEduClsId",
                    ColHeader: "教学班Id",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClsName",
                    ColHeader: "教学班",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "courseCode",
                //    ColHeader: "课程代码",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "courseName",
                    ColHeader: "课程",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "collegeName",
                    ColHeader: "学院",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "schoolYear",
                    ColHeader: "学年",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "schoolTerm",
                    ColHeader: "学期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "memo",
                    ColHeader: "时间范围",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    SortBy: "userName",
                    ColHeader: "编辑人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 21,
                    FuncName: () => { }
                },
                //{
                //    FldName: "",
                //    ColHeader: "确定推送",
                //    Text: "确定推送", TdClass: "text-left", SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnPushEduClsTextInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvCurrEduClsObjLst, arrDataColumn, "id_CurrEduCls");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Edit(divName4Edit) {
        var strUrl: string = "./WA_CurrEduCls_Edit/";
        console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Edit).html(data);
                    resolve(true);
                    //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                    //clsEditObj.BindTab();
                },
                error: (e) => {
                    console.error(e);
                    reject(e);
                }
            });
        });
    };

   // /* 函数功能:页面导入,当页面开始运行时所发生的事件
   //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
   //*/
   // public async Page_Load_Cache() {
   //     // 在此处放置用户代码以初始化页面
   //     try {

   //         // 为查询区绑定下拉框
   //         const gvBindDdl = await this.BindDdl4QueryRegion();

   //         this.hidSortvCurrEduClsBy = "currEduClsId Asc";
   //         //2、显示无条件的表内容在GridView中
   //         const gvResult = await this.BindGv_vCurrEduCls_Cache();
   //     }
   //     catch (e) {
   //         var strMsg: string = `页面启动不成功,${e}.`;
   //         alert(strMsg);
   //     }
   // }


    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
   */
    public async btnQuery_Click() {
        //var strWhereCond = this.CombinevCurrEduClsCondition();
        //try {
        //    const responseRecCount = await vCurrEduCls_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //        this.RecCount = jsonData;
        //    });
        //    var objPagerPara: stuPagerPara = {
        //        pageIndex: 1,
        //        pageSize: this.pageSize,
        //        whereCond: strWhereCond,
        //        orderBy: this.hidSortvCurrEduClsBy
        //    };
        //    const responseObjLst = await vCurrEduCls_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //        var arrvCurrEduClsObjLst: Array<clsvCurrEduClsEN> = <Array<clsvCurrEduClsEN>>jsonData;
        //        this.BindTab_vCurrEduCls(this.mstrListDiv, arrvCurrEduClsObjLst);
        //    });
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `查询不成功,${e}.`;
        //    alert(strMsg);
        //}
        const gvResult = await this.BindGv_vCurrEduCls();
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.OpType = "Add";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
                ShowDialog('Add');
                const responseText = await this.AddNewRecord();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
   */
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面
        var objcc_Course_Cond: clscc_CourseEN = new clscc_CourseEN();//编辑区域
        var objXzClg_Cond: clsXzClgEN = new clsXzClgEN();//编辑区域
        var objXzGradeBase_Cond: clsXzGradeBaseEN = new clsXzGradeBaseEN();//编辑区域
        var objSchoolYear_Cond: clsSchoolYearEN = new clsSchoolYearEN();//编辑区域
        var objSchoolTerm_Cond: clsSchoolTermEN = new clsSchoolTermEN();//编辑区域
        const ddlCourseId = await cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache(this.divName4List, "ddlCourseId");//编辑区域
        const ddlid_XzCollege = await XzClg_BindDdl_id_XzCollegeInDiv_Cache(this.divName4List, "ddlid_XzCollege");//编辑区域
        const ddlid_GradeBase = await XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache(this.divName4List, "ddlid_GradeBase");//编辑区域
        const ddlSchoolYear = await SchoolYear_BindDdl_SchoolYearInDiv_Cache(this.divName4List, "ddlSchoolYear");//编辑区域
        const ddlSchoolTerm = await SchoolTerm_BindDdl_SchoolTermInDiv_Cache(this.divName4List, "ddlSchoolTerm");//编辑区域
    }


    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
   */
    public async btnAddNewRecordWithMaxId_Click() {
        this.OpType = "AddWithMaxId";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecordWithMaxId();
            }
            else {
                ShowDialog('Add');
                const responseText = this.AddNewRecordWithMaxId();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
   */
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面
    }


    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public async btnUpdateRecordInTab_Click(strKeyId: string) {
        this.OpType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            ShowDialog('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog('Update');
            this.UpdateRecord(strKeyId);
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
            const responseBindGv = await this.BindGv_vCurrEduCls();
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
    在数据表里详细信息记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
   */
    public async btnDetailRecordInTab_Click(strKeyId: string) {
        this.OpType = "Detail";
        try {
            if (strKeyId == "") {
                alert("请选择需要详细信息的记录！");
                return "";
            }
            this.DetailRecord(strKeyId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `详细信息记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public async DelRecord(strid_CurrEduCls: string) {
        try {
            const responseText = await CurrEduCls_DelRecordAsync(strid_CurrEduCls);
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

    /* 
    根据关键字详细信息记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
     <param name = "sender">参数列表</param>
   */
    public async DetailRecord(strid_CurrEduCls: string) {
        this.btnOKUpd = "";
        this.btnCancel = "关闭";
        try {
            const responseText = await CurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
            var objCurrEduClsEN: clsCurrEduClsEN = <clsCurrEduClsEN>responseText;
            this.GetDataFromCurrEduClsClass(objCurrEduClsEN);
            console.log("完成DetailRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字选择相应的记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
     <param name = "sender">参数列表</param>
   */
    public async SelectRecord(strid_CurrEduCls: string) {
        try {
            const responseText = await CurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
            var objCurrEduClsEN: clsCurrEduClsEN = <clsCurrEduClsEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_vCurrEduCls");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
   */
    public async btnUpdateRecord_Click(strKeyId: string) {
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            ShowDialog('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog('Update');
            this.UpdateRecord(strKeyId);
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
            const responseBindGv = await this.BindGv_vCurrEduCls();
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
    //public async btnExportExcel_Click() {
    //    var strWhereCond = " 1=1 ";
    //    try {
    //        const responseText = await vCurrEduCls_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //            var arrvCurrEduClsObjLst: Array<clsvCurrEduClsEN> = <Array<clsvCurrEduClsEN>>jsonData;
    //            this.BindTab_vCurrEduCls(this.mstrListDiv, arrvCurrEduClsObjLst);
    //        });
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `导出Excel不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //}

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnOKUpd;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    if (this.OpType == "AddWithMaxId") {
                        const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            var returnKeyId: string = <string>jsonData;
                            if (clsString.IsNullOrEmpty(returnKeyId) == false) {
                                HideDialog();
                                this.BindGv_vCurrEduCls();
                            }
                        });
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vCurrEduCls();
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In CurrEduClsCRUD.btnOKUpd_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_vCurrEduCls();
                        }
                    });
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevCurrEduClsConditionObj(): clsvCurrEduClsEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvCurrEduCls_Cond: clsvCurrEduClsEN = new clsvCurrEduClsEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.CurrEduClsId_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsEN.con_CurrEduClsId} like '% ${this.CurrEduClsId_q}%'`;
                objvCurrEduCls_Cond.SetCondFldValue(clsvCurrEduClsEN.con_CurrEduClsId, this.CurrEduClsId_q, "like");
            }
            if (this.eduClsName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
                objvCurrEduCls_Cond.SetCondFldValue(clsvCurrEduClsEN.con_EduClsName, this.eduClsName_q, "like");
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineCurrEduClsConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvCurrEduCls_Cond;
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
        this.BindGv_vCurrEduCls();
    }

   
    /* 函数功能:从界面列表中根据某一个字段排序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     <param name = "strSortByFld">排序的字段</param>
   */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortvCurrEduClsBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvCurrEduClsBy.indexOf("Asc") >= 0) {
                this.hidSortvCurrEduClsBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvCurrEduClsBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvCurrEduClsBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vCurrEduCls();
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
    }

    /* 获取当前表关键字值的最大值,再加1,避免重复
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
   */
    public async GetMaxStrId(strKeyCtrlName) {
        this.DivName = "divGetMaxStrId";
        try {
            const responseText = await CurrEduCls_GetMaxStrIdAsync();
            var returnString: string = responseText.toString();
            if (returnString == "") {
                var strInfo: string = `获取表CurrEduCls的最大关键字为空，不成功，请检查!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                $(strKeyCtrlName).val(returnString);
            }
            else {
                var strInfo: string = `获取表CurrEduCls的最大关键字为：${returnString}!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                $(strKeyCtrlName).val(returnString);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public async AddNewRecord() {
        //this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucCurrEduClsB1.id_CurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
        try {
            const responseText = await CurrEduCls_GetMaxStrIdAsync();
            var returnString: string = responseText;
            if (returnString == "") {
                var strInfo: string = `获取表CurrEduCls的最大关键字为空，不成功，请检查!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                $('#txtid_CurrEduCls').val(returnString);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        //this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucCurrEduClsB1.id_CurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjCurrEduClsEN">数据传输的目的类对象</param>
   */
    public PutDataToCurrEduClsClass(pobjCurrEduClsEN: clsCurrEduClsEN) {
        pobjCurrEduClsEN.currEduClsId = this.currEduClsId;// 教学班Id
        pobjCurrEduClsEN.eduClsName = this.eduClsName;// 教学班名称
        pobjCurrEduClsEN.courseId = this.courseId;// 课程
        pobjCurrEduClsEN.id_XzCollege = this.id_XzCollege;// 学院
        pobjCurrEduClsEN.id_GradeBase = this.id_GradeBase;// 年级
        pobjCurrEduClsEN.isEffective = this.isEffective;// 是否有效
        pobjCurrEduClsEN.schoolYear = this.schoolYear;// 学年
        pobjCurrEduClsEN.schoolTerm = this.schoolTerm;// 学期
        pobjCurrEduClsEN.memo = this.memo;// 备注
        pobjCurrEduClsEN.modifyUserID = clsPubSessionStorage.GetSession_UserId().toString();// 修改人
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objCurrEduClsEN: clsCurrEduClsEN = new clsCurrEduClsEN();
        this.PutDataToCurrEduClsClass(objCurrEduClsEN);
        try {
            const responseText = await CurrEduCls_IsExistAsync(objCurrEduClsEN.id_CurrEduCls);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objCurrEduClsEN.id_CurrEduCls}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await CurrEduCls_AddNewRecordAsync(objCurrEduClsEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
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

    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
   */
    public async AddNewRecordWithMaxIdSave() {
        this.DivName = "divAddNewRecordWithMaxIdSave";
        var objCurrEduClsEN: clsCurrEduClsEN = new clsCurrEduClsEN();
        this.PutDataToCurrEduClsClass(objCurrEduClsEN);
        try {
            const responseText2 = await CurrEduCls_AddNewRecordWithMaxIdAsync(objCurrEduClsEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
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

    /* 函数功能:把以该关键字的记录内容显示在界面上,
          在这里是把值传到表控件中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
     <param name = "strid_CurrEduCls">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(strid_CurrEduCls: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objCurrEduClsEN: clsCurrEduClsEN = new clsCurrEduClsEN();
        try {
            const responseText = await CurrEduCls_IsExistAsync(strid_CurrEduCls);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strid_CurrEduCls}] 的记录不存在!`;
                //$('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
            }
        }
        catch (e) {
            var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
            alert(strMsg);
        }
        try {
            const responseText = await CurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
            objCurrEduClsEN = <clsCurrEduClsEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromCurrEduClsClass(objCurrEduClsEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjCurrEduClsEN">表实体类对象</param>
   */
    public GetDataFromCurrEduClsClass(pobjCurrEduClsEN: clsCurrEduClsEN) {
        this.currEduClsId = pobjCurrEduClsEN.currEduClsId;// 教学班Id
        this.eduClsName = pobjCurrEduClsEN.eduClsName;// 教学班名称
        this.courseId = pobjCurrEduClsEN.courseId;// 课程
        this.id_XzCollege = pobjCurrEduClsEN.id_XzCollege;// 学院
        this.id_GradeBase = pobjCurrEduClsEN.id_GradeBase;// 年级
        this.isEffective = pobjCurrEduClsEN.isEffective;// 是否有效
        this.schoolYear = pobjCurrEduClsEN.schoolYear;// 学年
        this.schoolTerm = pobjCurrEduClsEN.schoolTerm;// 学期
        this.memo = pobjCurrEduClsEN.memo;// 备注
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strid_CurrEduCls: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = strid_CurrEduCls;
        try {
            const responseText = await CurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
            var objCurrEduClsEN: clsCurrEduClsEN = <clsCurrEduClsEN>responseText;
            this.GetDataFromCurrEduClsClass(objCurrEduClsEN);
            console.log("完成UpdateRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 修改记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
   */
    public async UpdateRecordSave() {
        this.DivName = "divUpdateRecordSave";
        var objCurrEduClsEN: clsCurrEduClsEN = new clsCurrEduClsEN();
        objCurrEduClsEN.id_CurrEduCls = this.KeyId;
        this.PutDataToCurrEduClsClass(objCurrEduClsEN);
        objCurrEduClsEN.sf_UpdFldSetStr = objCurrEduClsEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objCurrEduClsEN.id_CurrEduCls == "" || objCurrEduClsEN.id_CurrEduCls == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await CurrEduCls_UpdateRecordAsync(objCurrEduClsEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }

    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public async DelMultiRecord(arrid_CurrEduCls: Array<string>) {
        try {
            const responseText = await CurrEduCls_DelCurrEduClssAsync(arrid_CurrEduCls);
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
     <param name = "objCurrEduCls">需要显示的对象</param>
   */
    public ShowCurrEduClsObj(divContainer: string, objCurrEduCls: clsCurrEduClsEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objCurrEduCls);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objCurrEduCls[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjCurrEduClsEN">表实体类对象</param>
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
    演示Session 操作
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
    */
    public async Demo_Session() {
        try {
            //设置Session
            var strUserId = "TestUserId";
            await this.SetSessionAsync("userId", strUserId);
            //获取Session
            var strUserId_Value1 = await this.GetSessionAsync("userId");
            console.log('strUserId_Value1:' + strUserId_Value1);
            //获取Session方法2：直接读取页面中的hidUserId
            var strUserId_Value2 = this.hidUserId;
            console.log('strUserId_Value2:' + strUserId_Value2);
        }
        catch (e) {
            var strMsg: string = `演示Session不成功,${e}.`;
            alert(strMsg);
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
    获取Session 关键字的值
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetSessionAsync)
    <param name = "Key">关键字</param>
     <return>值</return>
    */
    public GetSessionAsync(Key: string): Promise<string> {
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl_Session_GetString,
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key,
                },
                success: function (data) {
                    var strKey = data.key;
                    var strValue = data.value;
                    console.log('strKey, strValue=' + strKey + strValue);
                    resolve(data);
                },
                error: function (result) {
                    console.log(result);
                    console.log(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问网络不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }

    //确定推送
    //public async btnPushEduClsTextInTab_Click(strKeyId: string) {
    //    //获取课文Id；
    //    var strTextId = $('#hidTextId').val();
    //    var strId_CurrEduCls = strKeyId;
    //    var strUpdUser = clsPubSessionStorage.GetSession_UserId();
    //    try {
    //        //var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
    //        if (strKeyId == "") {
    //            alert("请选择需要推送的记录！");
    //            return "";
    //        }
    //        //推送前查询该教学班是否已经有推送记录；
    //        var strWhere = "pushTypeId = '01' And requesTypeId = '03' And tableKey= '" + strTextId + "' And id_CurrEduCls = '" + strId_CurrEduCls + "'";
    //        const responseTextOne = await sys_RequestPush_GetFirstObjAsync(strWhere);
    //        var objsys_RequestPushEN: clssys_RequestPushEN = <clssys_RequestPushEN>responseTextOne;
    //        if (objsys_RequestPushEN != null) {
    //            var strInfo: string = `当前数据已经有推送`;
    //            //显示信息框
    //            alert(strInfo);
    //            return;
    //        }
    //        else {

    //            const responseText = await zx_TextEx_RequestPushDataToEduClsAsync(strTextId, strId_CurrEduCls, strUpdUser);
    //            var bolIs: boolean = responseText;
    //            if (bolIs == true) {
    //                var strMsg: string = `推送成功！`;
    //                alert(strMsg);
    //            }
    //            else {
    //                var strMsg: string = `推送失败！`;
    //                alert(strMsg);

    //            }
    //        }

           
           
    //        $("#divLoading").hide();
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `推送记录不成功,${e}.`;
    //        alert(strMsg);
    //        return false;
    //    }

    //}

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
    * 课程Id
   */
    public set courseId(value: string) {
        $("#ddlCourseId").val(value);
    }
    /*
    * 课程Id
   */
    public get courseId(): string {
        return $("#ddlCourseId").val();
    }
    /*
    * 当前教学班Id
   */
    public set currEduClsId(value: string) {
        $("#txtCurrEduClsId").val(value);
    }
    /*
    * 当前教学班Id
   */
    public get currEduClsId(): string {
        return $("#txtCurrEduClsId").val();
    }
    /*
    * 当前教学班Id
   */
    public get CurrEduClsId_q(): string {
        return $("#txtCurrEduClsId_q").val();
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
    /*
    * 获取当前页序号
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 添加、修改用的层名
   */
    public set DivName(value: string) {
        $("#hidDivName").val(value);
    }
    /*
    * 教学班名称
   */
    public set eduClsName(value: string) {
        $("#txteduClsName").val(value);
    }
    /*
    * 教学班名称
   */
    public get eduClsName(): string {
        return $("#txteduClsName").val();
    }
    /*
    * 教学班名称
   */
    public get eduClsName_q(): string {
        return $("#txteduClsName_q").val();
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
    * 用户Id
   */
    public get hidUserId(): string {
        return $("#hidUserId").val();
    }
    /*
    * 年级流水号
   */
    public set id_GradeBase(value: string) {
        $("#ddlid_GradeBase").val(value);
    }
    /*
    * 年级流水号
   */
    public get id_GradeBase(): string {
        return $("#ddlid_GradeBase").val();
    }
    /*
    * 学院流水号
   */
    public set id_XzCollege(value: string) {
        $("#ddlid_XzCollege").val(value);
    }
    /*
    * 学院流水号
   */
    public get id_XzCollege(): string {
        return $("#ddlid_XzCollege").val();
    }
    /*
    * 是否有效
   */
    public set isEffective(value: boolean) {
        $("#chkIsEffective").val(value);
    }
    /*
    * 是否有效
   */
    public get isEffective(): boolean {
        return $("#chkIsEffective").prop("checked");
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
    * 修改人
   */
    public get modifyUserID(): string {
        return $("#txtModifyUserID").val();
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
    * 学期
   */
    public set schoolTerm(value: string) {
        $("#ddlSchoolTerm").val(value);
    }
    /*
    * 学期
   */
    public get schoolTerm(): string {
        return $("#ddlSchoolTerm").val();
    }
    /*
    * 学年
   */
    public set schoolYear(value: string) {
        $("#ddlSchoolYear").val(value);
    }
    /*
    * 学年
   */
    public get schoolYear(): string {
        return $("#ddlSchoolYear").val();
    }
}