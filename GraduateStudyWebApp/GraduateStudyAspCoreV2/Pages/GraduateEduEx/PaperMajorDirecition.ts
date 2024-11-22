//
//import * as QQ from "q";

import { clsvXzMajorDirectionEN } from "../TS/L0_Entity/BaseInfo_Share/clsvXzMajorDirectionEN.js";
import { BindDdl_ObjLst, BindTab, BindTab_V, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

import { clsXzMajorEN } from "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js";
import { clsMajorDirectionPaperRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js";
import { clsvMajorDirectionPaperRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvMajorDirectionPaperRelaEN.js";

import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { vXzMajorDirection_GetObjLstByPagerAsync, vXzMajorDirection_GetRecCountByCondAsync } from "../TS/L3_ForWApi/BaseInfo_Share/clsvXzMajorDirectionWApi.js";
import { XzMajor_GetObjLstAsync } from "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { clsPager } from "../TS/PubFun/clsPager.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { MajorDirectionPaperRela_AddNewRecordAsync, MajorDirectionPaperRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js";
import { vMajorDirectionPaperRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js";
import { PaperCRUD } from "../PagesBase/GraduateEduPaper/PaperCRUD.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsGeneralTab } from "../TS/PubFun/clsGeneralTab.js";
import { MajorDirectionPaperRelaCRUD } from "../PagesBase/GraduateEduPaper/MajorDirectionPaperRelaCRUD.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { PaperEx_GetObjExLstByPagerAsync } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { Paper_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { clsPaperENEx } from "../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogOne(): void;

declare function setTextboxio(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;

declare var $;
declare var window;
/* PaperMajorDirecition 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class PaperMajorDirecition extends MajorDirectionPaperRelaCRUD {
    public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperBy: string = "paperId";

    //public objPager: clsPager = new clsPager();
    //专业方向
    public mstrListDivMajorDirection: string = "divMajorDirectionDataLst";

    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 20;
    }

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            //查询文献类型绑定；
            if (clsPublocalStorage.userId != "") {
               // const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
                const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域
                //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN);

                //绑定 专业下拉框
                const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor("ddlid_XzMajor_q");

                PaperCRUD.sortPaperBy = "paperTitle Asc";
                this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";
                var strWhereCond = await this.CombinevPaperCondition();
                this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond);

                //2、显示无条件的表内容在GridView中
                //const gvResult = await this.BindGv_vPaper();



                var strUserId = clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage.roleId;

                $("#hidUserId").val(strUserId);
                //判断角色
                //管理员
                if (strRoleId == "00620001") {

                }
                else if (strRoleId == "00620002") {

                }
                else {

                    //如果是学生则 不可以选择用户下拉框
                    //$("#ddlUserId_q").disabled = false;
                    $("#ddlUserId_q").attr("disabled", "disabled");
                }
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                const gvResult = await this.BindGv_vPaperLoad();
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


    /// <summary>
    /// 为下拉框获取数据,从表:[XzMajor]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_id_XzMajor(ddlid_XzMajor: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlid_XzMajor);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = XzMajor_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrXzMajorObjLst: Array<clsXzMajorEN> = <Array<clsXzMajorEN>>jsonData;
                    BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "专业");
                    console.log("完成BindDdl_id_XzMajor!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }


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
                    var arrPaperObjLst: Array<clsLiteratureTypeEN> = <Array<clsLiteratureTypeEN>>jsonData;
                    BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "");
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
    /* 根据条件获取相应论文数据
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vPaperLoad() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevPaperCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrPaperExObjLst: Array<clsPaperENEx> = [];

        try {
            this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: PaperCRUD.sortPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            arrPaperExObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);

                //组合新的数据
                this.GetNewArrayList(arrPaperExObjLst);

        
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        try {
            //this.BindTab_vPaper(strListDiv, arrPaperExObjLst);

            console.log("完成BindGv_vPaper!");
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
    public async CombinevPaperCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }
            //if (this.updDate_q != "") {
            //    strWhereCond += ` And ${clsPaperEN.con_UpdDate} like '% ${this.updDate_q}%'`;
            //}
            //if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
            //    strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
            //}

            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            if (strUserId != "") {
             

                $("#hidUserId").val(strUserId);
                //判断角色
                //管理员
                if (strRoleId == "00620001") {

                    //$("#btnDelRecord").show();
                    //$("#btnAudit").show();

                }
                else if (strRoleId == "00620002") {

                    //$("#btnDelRecord").hide();
                    //$("#btnAudit").show();
                    //可以查看所属教学班下面的学生数据；
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";

                }
                else {
                    //$("#btnDelRecord").hide();
                    //$("#btnAudit").hide();
                    //学生00620003
                    //只能查看自己的数据；或公开的数据；
                    strWhereCond += ` And updUser = '${strUserId}'`;
                }
            }
            else {
                window.top.location.href = "../Web/Login";
            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 函数功能:在数据 列表中跳转到某一页
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
  */
    public async IndexPage(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_vPaperLoad();
    }
    /* 函数功能:从界面列表中根据某一个字段排序
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
    <param name = "strSortByFld">排序的字段</param>
  */
    public async SortBy(strSortByFld: string) {
        if (PaperCRUD.sortPaperBy.indexOf(strSortByFld) >= 0) {
            if (PaperCRUD.sortPaperBy.indexOf("Asc") >= 0) {
                PaperCRUD.sortPaperBy = `${strSortByFld} Desc`;
            }
            else {
                PaperCRUD.sortPaperBy = `${strSortByFld} Asc`;
            }
        }
        else {
            PaperCRUD.sortPaperBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vPaperLoad();
    }



    //查看专业关系；
    public async btnMajorDirection_Click() {
        const responseObjList = await this.BindGv_vXzMajorDirection();
    }
    /* 查询专业方向条件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
*/
    public async btnQueryMajorDirection_Click() {
        var strWhereCond = await this.CombinevXzMajorDirectionCondition();
        try {
            this.recCount = await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvXzMajorDirectionBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                var arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN> = <Array<clsvXzMajorDirectionEN>>jsonData;
                this.BindTab_vXzMajorDirection(this.mstrListDivMajorDirection, arrvXzMajorDirectionObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取记录列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 根据条件获取相应的记录对象的列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vXzMajorDirection() {
        var strListDiv: string = this.mstrListDivMajorDirection;
        var strWhereCond = await this.CombinevXzMajorDirectionCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN> = [];
        try {
            this.recCount = await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvXzMajorDirectionBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvXzMajorDirectionObjLst = <Array<clsvXzMajorDirectionEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            this.BindTab_vXzMajorDirection(strListDiv, arrvXzMajorDirectionObjLst);
            console.log("完成BindGv_vXzMajorDirection!");
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
    public CombinevXzMajorDirectionCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strPaperId = $("#hidPaperId").val();//论文
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                strWhereCond += ` And ${clsvXzMajorDirectionEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
            }
            if (this.majorDirectionName_q != "") {
                strWhereCond += ` And ${clsvXzMajorDirectionEN.con_MajorDirectionName} like '% ${this.majorDirectionName_q}%'`;
            }

            strWhereCond += ` And  majorDirectionId not in (select majorDirectionId from MajorDirectionPaperRela where  paperId = '${strPaperId}')`;
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineXzMajorDirectionCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 显示vXzMajorDirection对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrXzMajorDirectionObjLst">需要绑定的对象列表</param>
*/
    public async BindTab_vXzMajorDirection(divContainer: string, arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN>) {
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
                    fldName: "majorDirectionId",
                    colHeader: "研究方向Id",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业名称",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirectionName",
                    colHeader: "研究方向名",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "MajorDirectionENName",
                    colHeader: "研究方向英文名",
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
                    fldName: "updUser",
                    colHeader: "修改人",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        BindTab_V(o, arrvXzMajorDirectionObjLst, arrDataColumn, "majorDirectionId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    //用来选择专业记录方法；
    public btnOkInTab_Click(strKeyId: string) {
        $('#hidMajorDirectionId').val(strKeyId);//专业方向
        this.AddNewRecordSaveMajorDirection();
    }
    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSaveMajorDirection() {
        var strMajorDirectionId = $('#hidMajorDirectionId').val();//专业方向
        var strPaperId = $("#hidPaperId").val();//论文
        var strUserId = clsPublocalStorage.userId;

        var objMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN = new clsMajorDirectionPaperRelaEN();
        this.PutDataToMajorDirectionPaperRelaClass(objMajorDirectionPaperRelaEN);
        try {

            //同一论文不能重复添加同一个专业方向；
            var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And majorDirectionId = '" + strMajorDirectionId + "'";
            const responseText = await MajorDirectionPaperRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一论文不能重复添加同一个专业方向！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }


            const responseText2 = await MajorDirectionPaperRela_AddNewRecordAsync(objMajorDirectionPaperRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                HideDialogOne();
                //window.location.href = "../GraduateEduEx/PaperCRUD?paperTypeId=01";
                window.location.href = "../GraduateEduEx/PaperAddXzmajorRela?paperId=" + strPaperId;
            }
            else {
                var strInfo: string = `添加记录不成功!`;
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
    <param name = "pobjMajorDirectionPaperRelaEN">数据传输的目的类对象</param>
  */
    public PutDataToMajorDirectionPaperRelaClass(pobjMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN) {
        var strMajorDirectionId = $("#hidMajorDirectionId").val();
        var strViewpointId = $("#hidPaperId").val();
        var strUserId = clsPublocalStorage.userId;

        pobjMajorDirectionPaperRelaEN.SetMajorDirectionId(strMajorDirectionId);// 研究方向Id
        pobjMajorDirectionPaperRelaEN.SetPaperId(strViewpointId);// 论文Id
        pobjMajorDirectionPaperRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjMajorDirectionPaperRelaEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        //pobjMajorDirectionPaperRelaEN.SetMemo(this.memo;// 备注
    }

    /*
 * 获取年月日
 */
    public getNowDate(): string {
        const date = new Date();
        let month: string | number = date.getMonth() + 1;
        let strDate: string | number = date.getDate();
        if (month <= 9) {
            month = "0" + month;
        }
        if (strDate <= 9) {
            strDate = "0" + strDate;
        }

        return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
    }



    /*
   * 专业流水号
  */
    public get id_XzMajor_q(): string {
        return $("#ddlid_XzMajor_q").val();
    }
    /*
    * 研究方向名
   */
    public get majorDirectionName_q(): string {
        return $("#txtMajorDirectionName_q").val();
    }
    /* 函数功能:在数据 列表中跳转到某一页
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
  */
    public IndexPageOne(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_vXzMajorDirection();
    }
    /*
   * 设置排序字段-相当使用ViewState功能
  */
    public set hidSortvXzMajorDirectionBy(value: string) {
        $("#hidSortvXzMajorDirectionBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvXzMajorDirectionBy(): string {
        return $("#hidSortvXzMajorDirectionBy").val();
    }

    //组合获取新的数据源，通过论文 和专业方向；
    public async GetNewArrayList(arrPaperExObjLst: Array<clsPaperENEx>) {

        var strListDiv = this.divName4List;
        var strWhereCond = await this.CombinevPaperCondition();
        var strWhereCond1 = this.CombinevXzMajorDirectionCondition();

        // var arrPaperExObjLst: Array<clsPaperENEx> = [];
        var arrvMajorDirectionPaperRelaObjLst: Array<clsvMajorDirectionPaperRelaEN> = [];
        //新对象列表
        var arrPaperMajorObjList: Array<PaperMajor> = [];
        try {

            //const responseText = vPaper_GetObjLstAsync(strWhereCond).then((jsonData) => {
            //    arrPaperExObjLst = <Array<clsPaperEN>>jsonData;
            //});
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
            const responseText1 = vMajorDirectionPaperRela_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrvMajorDirectionPaperRelaObjLst = <Array<clsvMajorDirectionPaperRelaEN>>jsonData;

                //根据数据源组合新对象
                //1.循环论文
                var objPaperMajor: PaperMajor;
                for (var i = 0; i < arrPaperExObjLst.length; i++) {
                    //new
                    objPaperMajor = new PaperMajor();
                    //得到相关数据；
                    objPaperMajor.paperId = arrPaperExObjLst[i].paperId;
                    objPaperMajor.paperTitle = arrPaperExObjLst[i].paperTitle;
                    objPaperMajor.updDate = arrPaperExObjLst[i].updDate;
                    objPaperMajor.updUser = arrPaperExObjLst[i].updUser;
                    var objUser = arrUsers.find(x => x.userId == arrPaperExObjLst[i].updUser);
                    if (objUser != null) {
                        objPaperMajor.userName = objUser.userName;
                    }
                    //2得到专业方向；
                    //3比对得到剩下的数据
                    arrvMajorDirectionPaperRelaObjLst = arrvMajorDirectionPaperRelaObjLst.filter(x => x.paperId == arrPaperExObjLst[i].paperId);
                    //4循环的插入数据表
                    var k = 0;
                    for (var j = 0; j < arrvMajorDirectionPaperRelaObjLst.length; j++) {
                        k++;
                        //5专业方向
                        objPaperMajor.MajorDecription += k + "." + arrvMajorDirectionPaperRelaObjLst[j].majorDirectionName + "</br>";
                    }
                    //6存入对象列表；
                    arrPaperMajorObjList.push(objPaperMajor);

                }

                try {
                    this.BindTab_PaperMajor(strListDiv, arrPaperMajorObjList);

                    console.log("完成BindGv_PaperMajor!");
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
                    alert(strMsg);
                }

            });


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }


    }


    /* 显示vPaper对象的所有属性值
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    <param name = "divContainer">显示容器</param>
    <param name = "arrPaperObjLst">需要绑定的对象列表</param>
  */
    public async BindTab_PaperMajor(divContainer: string, arrPaperExObjLst: Array<PaperMajor>) {
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
                    fldName: "MajorDecription",
                    colHeader: "专业方向",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "日期",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "用户",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
            ];
        BindTab(o, arrPaperExObjLst, arrDataColumn, "paperId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

}




//新建类存放数据；
export class PaperMajor extends clsGeneralTab{
  

    private mstrPaperId: string = "";    //论文Id
    private mstrPaperTitle: string = "";    //论文标题
    private mstrUpdDate: string = "";    //修改日期
    private mstrUpdUser: string = "";    //修改用户Id
    private mstrMajorDecription: string = "";//专业方向；
    private mstrUserName: string = "";//用户名
    ////论文id
    //public paperId: string,
    ////论文标题
    //public paperTitle: string,
    ////专业方向名
    //public MajorDecription: string,
    ////时间
    //public updDate: string,
    ////人
    //public updUser: string


    /// <summary>
    /// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public get paperId() {
        return this.mstrPaperId;
    };
    /// <summary>
    /// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public set paperId(value: string) {
        this.mstrPaperId = value;
    };

    /// <summary>
    /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public get paperTitle() {
        return this.mstrPaperTitle;
    };
    /// <summary>
    /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public set paperTitle(value: string) {
        this.mstrPaperTitle = value;
    };


    /// <summary>
    /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public get updDate() {
        return this.mstrUpdDate;
    };
    /// <summary>
    /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public set updDate(value: string) {
        this.mstrUpdDate = value;
    };

    /// <summary>
    /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public get updUser() {
        return this.mstrUpdUser;
    };
    /// <summary>
    /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public set updUser(value: string) {
        this.mstrUpdUser = value;
    };
    /// <summary>
    /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public get userName() {
        return this.mstrUserName;
    };
    /// <summary>
    /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public set userName(value: string) {
        this.mstrUserName = value;
    };

    /// <summary>
    /// 专业方向
    public get MajorDecription() {
        return this.mstrMajorDecription;
    };
    /// <summary>
    /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
    /// </summary>
    public set MajorDecription(value: string) {
        this.mstrMajorDecription = value;
    };
}