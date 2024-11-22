///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />

import { MajorDirectionPaperRelaCRUD } from "../PagesBase/GraduateEduPaper/MajorDirectionPaperRelaCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsXzMajorEN } from "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js";
import { clsMajorDirectionPaperRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js";
import { clsvMajorDirectionPaperRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvMajorDirectionPaperRelaEN.js";
import { XzMajor_GetObjLstAsync } from "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js";
import { MajorDirectionPaperRela_AddNewRecordAsync, MajorDirectionPaperRela_DelMajorDirectionPaperRelasAsync, MajorDirectionPaperRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js";
import { vMajorDirectionPaperRela_GetObjLstByPagerAsync, vMajorDirectionPaperRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js";
import { BindDdl_ObjLst, BindTab, BindTab_V, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList, GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
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
declare var window;
/* WApiXzMajorDirectionCRUD_TS 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class PaperAddXzmajorRela extends MajorDirectionPaperRelaCRUD {
    public mstrListDiv: string = "divDataLst";

    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public recCount = 0;

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
  */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            if (strUserId != "") {
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；


                //管理员 判断角色 
                if (strRoleId == "00620001") {

                    $("#btnDelRecord").show();
                }
                else {
                    //学生00620003 教师 
                    $("#btnDelRecord").hide();

                }
                $("#hidUserId").val(strUserId);
                //1、为下拉框设置数据源,绑定列表数据
                const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor("ddlid_XzMajor_q");
                this.hidSortvMajorDirectionPaperRelaBy = "updDate Desc";
                var strWhereCond = await this.CombinevMajorDirectionPaperRelaCondition();
                //this.recCount= await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    
                //});
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vMajorDirectionPaperRela();
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
                var strMsg: string = `根据条件获取不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async btnQuery_Click() {
        var strWhereCond = await this.CombinevMajorDirectionPaperRelaCondition();
        try {
            this.recCount = await vMajorDirectionPaperRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvMajorDirectionPaperRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vMajorDirectionPaperRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                var arrvMajorDirectionPaperRelaObjLst: Array<clsvMajorDirectionPaperRelaEN> = <Array<clsvMajorDirectionPaperRelaEN>>jsonData;
                this.BindTab_vMajorDirectionPaperRela(this.mstrListDiv, arrvMajorDirectionPaperRelaObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取不成功,${e}.`;
            alert(strMsg);
        }
    }
    public async CombinevMajorDirectionPaperRelaCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperId = $("#hidPaperId").val();//论文
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
            }
            if (this.majorDirectionName_q != "") {
                strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_MajorDirectionName} like '% ${this.majorDirectionName_q}%'`;
            }
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }

            //paperId
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_PaperId} = '${strPaperId}'`;
            }
            //if (this.IsQuotethesis_q == true) {
            //    strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_IsQuotethesis} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_IsQuotethesis} = '0'`;
            //}


            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            if (strUserId != "") {

                $("#hidUserId").val(strUserId);

                //判断角色 管理员
                if (strRoleId == "00620001") {

                    $("#btnDelRecord").show();
                }
                ////判断角色 教师
                //else if (objvUserRoleRelation.roleId == "00620002") {
                //    $("#btnDelRecord").hide();
                //    //可以查看所有；
                //}
                else {
                    $("#btnDelRecord").show();
                    //学生00620003
                    //查询的数据就已经是自己的数据，所以查看关系时候，不需要再做控制；
                    // strWhereCond += ` And updUser = '${objvUserRoleRelation.userId}'`;
                }
            }
            else {
                window.top.location.href = "../Web/Login";
                //window.location.href = "/GraduateStudyWebApp/WebApp/Login";
            }


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineMajorDirectionPaperRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vMajorDirectionPaperRela() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = await this.CombinevMajorDirectionPaperRelaCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvMajorDirectionPaperRelaObjLst: Array<clsvMajorDirectionPaperRelaEN> = [];
        try {
            this.recCount = await vMajorDirectionPaperRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvMajorDirectionPaperRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vMajorDirectionPaperRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvMajorDirectionPaperRelaObjLst = <Array<clsvMajorDirectionPaperRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvMajorDirectionPaperRelaObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //console.error(strMsg);
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vMajorDirectionPaperRela(strListDiv, arrvMajorDirectionPaperRelaObjLst);
            console.log("完成BindGv_vMajorDirectionPaperRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vMajorDirectionPaperRela对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrMajorDirectionPaperRelaObjLst">需要绑定的对象列表</param>
*/
    public async BindTab_vMajorDirectionPaperRela(divContainer: string, arrvMajorDirectionPaperRelaObjLst: Array<clsvMajorDirectionPaperRelaEN>) {
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
                    fldName: "majorDirectionName",
                    colHeader: "专业方向名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "MajorDirectionENName",
                    colHeader: "专业方向英文",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "researchQuestion",
                //    colHeader: "研究问题",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "keyword",
                //    colHeader: "关键字",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "literatureSources",
                //    colHeader: "文献来源",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "literatureLink",
                //    colHeader: "文献链接",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "uploadfileUrl",
                //    colHeader: "文件地址",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "isQuotethesis",
                //    colHeader: "是否引用论文",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "checker",
                //    colHeader: "审核人",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "isChecked",
                //    colHeader: "是否检查",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updUser",
                    colHeader: "修改人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
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
                //        btn1.className = "btn btn-outline-info";
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
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        BindTab_V(o, arrvMajorDirectionPaperRelaObjLst, arrDataColumn, "mId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    public btnokRecord_Click() {

        this.AddNewRecordSave();
    }
    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
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
                window.location.href = "../GraduateEduEx/PaperCRUD?paperTypeId=01";
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
        pobjMajorDirectionPaperRelaEN.SetMemo(this.memo);// 备注
    }





    /* 删除记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
*/
    public async btnDelRecord_Click() {
        try {
            var arrKeyIds = GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseText2 = await this.BindGv_vMajorDirectionPaperRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }
    /* 根据关键字列表删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
 */
    public async DelMultiRecord(arrmId: Array<string>) {

        try {
            const returnInt = await MajorDirectionPaperRela_DelMajorDirectionPaperRelasAsync(arrmId);
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
        this.BindGv_vMajorDirectionPaperRela();
    }
    /* 函数功能:从界面列表中根据某一个字段排序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     <param name = "strSortByFld">排序的字段</param>
   */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortvMajorDirectionPaperRelaBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvMajorDirectionPaperRelaBy.indexOf("Asc") >= 0) {
                this.hidSortvMajorDirectionPaperRelaBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvMajorDirectionPaperRelaBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvMajorDirectionPaperRelaBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vMajorDirectionPaperRela();
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
       * 设置排序字段-相当使用ViewState功能
      */
    public set hidSortvMajorDirectionPaperRelaBy(value: string) {
        $("#hidSortvMajorDirectionPaperRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvMajorDirectionPaperRelaBy(): string {
        return $("#hidSortvMajorDirectionPaperRelaBy").val();
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
  * 研究方向名
 */
    public get majorDirectionName_q(): string {
        return $("#txtMajorDirectionName_q").val();
    }
    /*
    * 论文标题
   */
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
    }
    /*
    * 专业流水号
   */
    public get id_XzMajor_q(): string {
        return $("#ddlid_XzMajor_q").val();
    }
}