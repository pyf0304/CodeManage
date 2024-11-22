
import { PaperCRUD } from "../PagesBase/GraduateEduPaper/PaperCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperENEx } from "../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js";
import { clsPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";

import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { PaperReadWrite_GetMaxStrIdAsync, PaperReadWrite_IsExistAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js";
import { Paper_GetObjByPaperIdAsync, Paper_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";

import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { clsPaperReadWriteWApiEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js";
import { PaperEx_GetObjExLstByPagerAsync } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { BindDdl_ObjLst, BindTab, BindTab_V, Redirect, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
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
/* PaperCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class CitingPaper extends PaperCRUD {
    public mstrListDiv: string = "divDataLst";
    /*public objPager: clsPager = new clsPager();*/
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


            //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
            //1、为下拉框设置数据源,绑定列表数据
            PaperCRUD.sortPaperBy = "paperTitle Asc";
            //var strWhereCond = await this.CombinePaperCondition();
            //this.recCount= await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {

            //});
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vPaper();
            this.AddNewRecord();




        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
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
                    var arrPaperObjLst: Array<clsLiteratureTypeEN> = <Array<clsLiteratureTypeEN>>jsonData;
                    BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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
    //添加相关方法
    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public AddNewRecord() {
        this.SetKeyReadOnly(true);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucPaperReadWriteB1.paperRWId = clsPaperReadWriteBL.GetMaxStrId_S();
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperReadWrite_GetMaxStrIdAsync().then((jsonData) => {
                    var returnString: string = jsonData.toString();
                    if (returnString == "") {
                        var strInfo: string = `获取表PaperReadWrite的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtPaperRWId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    /// <summary>
    /// 在用户自定义控件中，设置关键字的值，是否只读
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    /// </summary>
    /// <param name = "bolReadonly">是否只读</param>
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtPaperRWId').prop['ReadOnly'] = bolReadonly;
    }
    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.paperRWId = "";
        this.readerId = "";
        $('#ddlPaperId option[0]').attr("selected", true);
        this.researchQuestion = "";
        $('#ddlOperationTypeId option[0]').attr("selected", true);
        this.updDate = "";
        this.updUser = "";
        this.memo = "";
    }
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
                    const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            //HideDialog();
                            window.location.href = "../GraduateEdu/PaperReadWriteCRUD";
                            //this.BindGv_vPaperReadWrite();
                        }
                    });
                    break;
                //case "确认修改":
                //    //这是一个单表的修改的代码,由于逻辑层太简单,
                //    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                //        var returnBool: boolean = jsonData;
                //        if (returnBool == true) {
                //            HideDialog();
                //            this.BindGv_vPaperReadWrite();
                //        }
                //    });
                //    break;
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
    /* 添加新记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
  */
    public async AddNewRecordSave() {
        //this.DivName = "divAddNewRecordSave";
        var objPaperReadWriteEN: clsPaperReadWriteEN = new clsPaperReadWriteEN();
        this.PutDataToPaperReadWriteClass(objPaperReadWriteEN);
        try {
            const responseText = await PaperReadWrite_IsExistAsync(objPaperReadWriteEN.paperRWId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objPaperReadWriteEN.paperRWId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await clsPaperReadWriteWApiEx.AddNewRecordAsyncEx(objPaperReadWriteEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
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
        }
        return true;//一定要有一个返回值，否则会出错！
    }
    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
  */
    public PutDataToPaperReadWriteClass(pobjPaperReadWriteEN: clsPaperReadWriteEN) {
        pobjPaperReadWriteEN.SetPaperRWId(this.paperRWId);// 论文读写Id
        pobjPaperReadWriteEN.SetReaderId(clsPublocalStorage.userId);// 阅读者Id
        pobjPaperReadWriteEN.SetPaperId($("#hidPaperId").val());// 论文Id
        pobjPaperReadWriteEN.SetResearchQuestion(this.researchQuestion);// 研究问题

        pobjPaperReadWriteEN.SetOperationTypeId($("#hidReadWriteTypeId").val());// 操作类型ID
        pobjPaperReadWriteEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjPaperReadWriteEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id// 修改用户Id
        pobjPaperReadWriteEN.SetMemo(this.memo);// 备注
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

    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async btnQuery_Click() {
        var strWhereCond = await this.CombinePaperCondition();
        try {
            this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: PaperCRUD.sortPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const arrPaperExObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);
            this.BindTab_vPaper(this.mstrListDiv, arrPaperExObjLst);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombinePaperCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.paperTitle_q != "") {
            //    strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            //}

            //if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
            //    strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
            //}
            //if (this.IsChecked_q == true) {
            //    strWhereCond += ` And ${clsPaperEN.con_IsChecked} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsPaperEN.con_IsChecked} = '0'`;
            //}
            //if (this.IsQuotethesis_q == true) {
            //    strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '0'`;
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vPaper() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = await this.CombinePaperCondition();
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
            
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        if (arrPaperExObjLst.length == 0) {
            var strMsg: string = `根据条件获取的对象列表数为空！`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
            console.log("完成BindGv_vPaper!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 显示vPaper对象的所有属性值
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    <param name = "divContainer">显示容器</param>
    <param name = "arrPaperObjLst">需要绑定的对象列表</param>
  */
    public async BindTab_vPaper(divContainer: string, arrPaperExObjLst: Array<clsPaperENEx>) {
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
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "periodical",
                    colHeader: "期刊",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "author",
                    colHeader: "作者",
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
                //    fldName: "updDate",
                //    colHeader: "修改日期",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "updUser",
                //    colHeader: "修改用户Id",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "keyword",
                    colHeader: "关键字",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "literatureSources",
                    colHeader: "文献来源",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
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
                    fldName: "isQuotethesis",
                    colHeader: "是否引用论文",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "选择引用",
                    text: "选择", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnCitingPaper_Click('${strKeyId}');`);
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
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        BindTab(o, arrPaperExObjLst, arrDataColumn, "paperId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    /* 
   根据关键字选择相应的记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
    <param name = "sender">参数列表</param>
  */
    public async SelectRecord(strPaperId: string) {
        try {
            const responseText = await Paper_GetObjByPaperIdAsync(strPaperId);
            var objPaperEN: clsPaperEN = <clsPaperEN>responseText;
            console.log("完成SelectRecord!");
            Redirect("/Index/Main_vPaper");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_QueryLst)
 */
    public async QueryvPaperLst(strListDiv: string) {
        var strWhereCond = await this.CombinePaperCondition();
        //var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页

        try {
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: PaperCRUD.sortPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const arrPaperExObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);
            this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
            console.log("完成QueryvPaperLst!");

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
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
        this.BindGv_vPaper();
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
        const responseText2 = await this.BindGv_vPaper();
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

    /*
* 论文标题
*/
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
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
   * 用户Id
  */
    public get hidUserId(): string {
        return clsPublocalStorage.userId;
    }
    /*
    * 设置关键字的值
   */
    public set keyId(value: string) {
        $("#hidKeyId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get keyId(): string {
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
    * 操作类型ID
   */
    public set operationTypeId(value: string) {
        $("#ddlOperationTypeId").val(value);
    }
    /*
    * 操作类型ID
   */
    public get operationTypeId(): string {
        return $("#ddlOperationTypeId").val();
    }
    /*
    * 操作类型ID
   */
    public get operationTypeId_q(): string {
        return $("#ddlOperationTypeId_q").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set opType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 论文Id
   */
    public set paperId(value: string) {
        $("#ddlPaperId").val(value);
    }
    /*
    * 论文Id
   */
    public get paperId(): string {
        return $("#ddlPaperId").val();
    }

    /*
    * 论文读写Id
   */
    public set paperRWId(value: string) {
        $("#txtPaperRWId").val(value);
    }
    /*
    * 论文读写Id
   */
    public get paperRWId(): string {
        return $("#txtPaperRWId").val();
    }

    /*
    * 阅读者Id
   */
    public set readerId(value: string) {
        $("#txtReaderId").val(value);
    }
    /*
    * 阅读者Id
   */
    public get readerId(): string {
        return $("#txtReaderId").val();
    }
    /*
    * 研究问题
   */
    public set researchQuestion(value: string) {
        $("#txtResearchQuestion").val(value);
    }
    /*
    * 研究问题
   */
    public get researchQuestion(): string {
        return $("#txtResearchQuestion").val();
    }
    /*
    * 修改日期
   */
    public set updDate(value: string) {
        $("#txtUpdDate").val(value);
    }
    /*
    * 修改日期
   */
    public get updDate(): string {
        return $("#txtUpdDate").val();
    }
    /*
    * 修改用户Id
   */
    public set updUser(value: string) {
        $("#txtUpdUser").val(value);
    }
    /*
   * 修改用户Id
  */
    public get updUser(): string {
        return $("#txtUpdUser").val();
    }
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
   * 文献类型Id
  */
    public get literatureTypeId_q(): string {
        return $("#ddlLiteratureTypeId_q").val();
    } 0
}