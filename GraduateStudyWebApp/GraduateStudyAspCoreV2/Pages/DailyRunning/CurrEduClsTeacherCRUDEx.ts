
/*-- -- -- -- -- -- -- -- -- -- --
类名:CurrEduClsTeacherCRUDEx
表名:CurrEduClsTeacher(01120124)
生成代码版本:2020.05.09.1
生成日期:2020/05/11 16:30:22
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

import { CurrEduClsTeacherCRUD } from "../PagesBase/DailyRunning_Share/CurrEduClsTeacherCRUD.js";
import { clsCurrEduClsTeacherEN } from "../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsTeacherEN.js";
import { clsCurrEduClsTeacherENEx } from "../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsTeacherENEx.js";
import { clsvCurrEduClsTeacherEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsTeacherEN.js";
import { vCurrEduClsTeacher_GetObjLstByPagerAsync, vCurrEduClsTeacher_GetRecCountByCondAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindTab, BindTab_V, GetFirstCheckedKeyId, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { CurrEduClsTeacher_EditEx } from "./CurrEduClsTeacher_EditEx.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* CurrEduClsTeacherCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class CurrEduClsTeacherCRUDEx extends CurrEduClsTeacherCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvCurrEduClsTeacherBy: string = "id_EduClsTeacher";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_vCurrEduClsTeacher();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vCurrEduClsTeacher":
                alert('该类没有绑定该函数：[this.BindGv_vCurrEduClsTeacher_Cache]！');
                //this.BindGv_vCurrEduClsTeacher_Cache();
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
            //建立缓存

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            CurrEduClsTeacherCRUD.sortvCurrEduClsTeacherBy = "eduClsName Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vCurrEduClsTeacher();
            $("#divLoading").hide();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }


    /** 函数功能:为查询区绑定下拉框
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
    **/
    public async BindDdl4QueryRegion() {
        const strThisFuncName = this.BindDdl4QueryRegion.name;
        // 在此处放置用户代码以初始化页面


        //await this.SetDdl_SchoolTermInDiv();//查询区域

        //await this.SetDdl_SchoolYearInDiv();//查询区域
    }
    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        let objPage: CurrEduClsTeacherCRUDEx;
        if (CurrEduClsTeacherCRUD.objPage_CRUD == null) {
            CurrEduClsTeacherCRUD.objPage_CRUD = new CurrEduClsTeacherCRUDEx();
            objPage = <CurrEduClsTeacherCRUDEx>CurrEduClsTeacherCRUD.objPage_CRUD;
        }
        else {
            objPage = <CurrEduClsTeacherCRUDEx>CurrEduClsTeacherCRUD.objPage_CRUD;
        }
        const objPage_Edit: CurrEduClsTeacher_EditEx = new CurrEduClsTeacher_EditEx(objPage);
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
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage_Edit.btnUpdateRecord_Click(strKeyId);
                break;
            case "AddTeacher":            //添加教师进入教学班
                //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
                //if (strKeyId == "") {
                //    alert("请选择需要添加的记录！");
                //    return;
                //}
                objPage_Edit.btnAddNewRecord_Click();
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


    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 <returns>条件串(strWhereCond)</returns>
*/
    public async CombinevCurrEduClsTeacherCondition(): Promise<string>  {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.currEduClsId_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_CurrEduClsId} like '% ${this.currEduClsId_q}%'`;
            }
            if (this.eduClsName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
            }
            if (this.teacherID_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_TeacherID} like '% ${this.teacherID_q}%'`;
            }
            if (this.teacherName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_TeacherName} like '% ${this.teacherName_q}%'`;
            }
            //if (this.SchoolTerm_q != "" && this.SchoolTerm_q != "0") {
            //    strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_SchoolTerm} = '${this.SchoolTerm_q}'`;
            //}
            //if (this.schoolYear_q != "" && this.schoolYear_q != "0") {
            //    strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_SchoolYear} = '${this.schoolYear_q}'`;
            //}


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

                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_TeacherID} = '${strUserId}'`;
                //strWhereCond += " and TeaherID in (select TeaherID from vCurrEduClsTeacher where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "')";
            }
            else {

                ////学生00620003

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsTeacherCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }



    /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vCurrEduClsTeacher() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevCurrEduClsTeacherCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN> = [];
        try {
            this.recCount = await vCurrEduClsTeacher_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: CurrEduClsTeacherCRUD.sortvCurrEduClsTeacherBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vCurrEduClsTeacher_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvCurrEduClsTeacherObjLst = <Array<clsvCurrEduClsTeacherEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        try {
            this.BindTab_vCurrEduClsTeacher(strListDiv, arrvCurrEduClsTeacherObjLst);
            console.log("完成BindGv_vCurrEduClsTeacher!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vCurrEduClsTeacher对象的所有属性值
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    <param name = "divContainer">显示容器</param>
    <param name = "arrCurrEduClsTeacherObjLst">需要绑定的对象列表</param>
  */
    public async BindTab_vCurrEduClsTeacher(divContainer: string, arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN>) {
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
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "eduClsName",
                    colHeader: "教学班",
                    text: "", tdClass: "text-left",
                    sortBy: clsCurrEduClsTeacherENEx.con_EduClsName,
                    sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "courseName",
                    colHeader: "课程",
                    text: "", tdClass: "text-left",
                    sortBy: clsCurrEduClsTeacherENEx.con_CourseName, sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "teacherID",
                    colHeader: "教师Id",
                    text: "", tdClass: "text-left",
                    sortBy: clsCurrEduClsTeacherENEx.con_TeacherID,
                    sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "teacherName",
                    colHeader: "教师",
                    text: "", tdClass: "text-left",
                    sortBy: clsCurrEduClsTeacherENEx.con_TeacherName,
                    sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "collegeName",
                    colHeader: "学院",
                    text: "", tdClass: "text-left",
                    sortBy: clsCurrEduClsTeacherENEx.con_CollegeName,
                    sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "schoolTerm",
                    colHeader: "学期",
                    text: "", tdClass: "text-left",
                    sortBy: clsCurrEduClsTeacherEN.con_SchoolTerm,
                    sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "schoolYear",
                    colHeader: "学年",
                    text: "", tdClass: "text-left",
                    sortBy: clsCurrEduClsTeacherEN.con_SchoolYear,
                    sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "updDate",
                //    colHeader: "编辑日期",
                //    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "updUser",
                //    colHeader: "编辑人",
                //    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "",
                    colHeader: "修改",
                    text: "修改", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    fldName: "",
                    colHeader: "删除",
                    text: "删除", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        BindTab_V(o, arrvCurrEduClsTeacherObjLst, arrDataColumn, "id_EduClsTeacher", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }
}