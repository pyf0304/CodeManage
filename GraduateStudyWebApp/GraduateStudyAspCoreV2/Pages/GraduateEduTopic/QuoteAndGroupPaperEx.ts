
import { PaperCRUD } from "../PagesBase/GraduateEduPaper/PaperCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperENEx } from "../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { Paper_AddNewRecordAsync, Paper_DelPapersAsync, Paper_DelRecordAsync, Paper_GetMaxStrIdAsync, Paper_GetObjByPaperIdAsync, Paper_GetObjLstAsync, Paper_GetRecCountByCondAsync, Paper_IsExistAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vPaperReadWrite_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { PaperEx_CopyToEx, PaperEx_GetObjExLstByPagerAsync } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { arrSelectedKeys, BindDdl_ObjLst, BindTab, GetCheckedKeyIds, GetObjKeys, Redirect, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
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
/* PaperCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class QuoteAndGroupPaperEx extends PaperCRUD {
    public mstrListDiv: string = "divDataLst";

    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public recCount = 0;


    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucPaperB1.paperId = clsPaperBL.GetMaxStrId_S();
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetMaxStrIdAsync().then((jsonData) => {
                    var returnString: string = jsonData.toString();
                    if (returnString == "") {
                        var strInfo: string = `获取表Paper的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtPaperId').val(returnString);
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

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objPaperEN: clsPaperEN = new clsPaperEN();
        this.PutDataToPaperClass(objPaperEN);
        try {
            const responseText = await Paper_IsExistAsync(objPaperEN.paperId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objPaperEN.paperId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await Paper_AddNewRecordAsync(objPaperEN);
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
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vPaper() {
        var strListDiv: string = this.mstrListDiv;
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
            const arrPaperExObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);
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
                {
                    fldName: "researchQuestion",
                    colHeader: "研究问题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
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
                    colHeader: "修改用户Id",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
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
                {
                    fldName: "literatureLink",
                    colHeader: "文献链接",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "uploadfileUrl",
                    colHeader: "文件地址",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "checker",
                    colHeader: "审核人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "isChecked",
                    colHeader: "是否检查",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "isQuotethesis",
                    colHeader: "是否引用论文",
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
        BindTab(o, arrPaperExObjLst, arrDataColumn, "paperId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.opType = "Add";
        try {
            const responseText = await this.AddNewRecord();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
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
            var strKeyList;
            if (arrKeyIds.length == 0) return "";
            strKeyList = "";
            for (var i = 0; i < arrKeyIds.length; i++) {
                if (i == 0) strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                else strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
            }
            //
            var strWhereCond = " paperId in (" + strKeyList + ")";
            const responseText1 = await vPaperReadWrite_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.recCount = jsonData;
                if (this.recCount != 0) {
                    alert("请先删除该论文在论文写作或阅读数据！");
                    return "";
                }
                else {

                }

            });



            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseText2 = await this.BindGv_vPaper();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
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
            const responseText2 = await this.BindGv_vPaper();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    在数据表里详细信息记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
   */
    public async btnDetailRecordInTab_Click(strKeyId: string) {
        this.opType = "Detail";
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

    /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
   */
    public async btnExportExcel_Click() {
        var strWhereCond = " 1=1 ";
        try {
            const arrPaperObjLst = await Paper_GetObjLstAsync(strWhereCond);
            const arrPaperExObjLst = arrPaperObjLst.map( PaperEx_CopyToEx);
            this.BindTab_vPaper(this.mstrListDiv, arrPaperExObjLst);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
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
                            HideDialog();
                            this.BindGv_vPaper();
                        }
                    });
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_vPaper();
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

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
   */
    public async btnQuery_Click() {
        var strWhereCond = await this.CombinevPaperCondition();
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

    /* 
    在数据表里选择记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
   */
    public async btnSelectRecordInTab_Click1(strKeyId: string) {
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

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
   */
    public btnUpdateRecord_Click(strKeyId: string) {
        this.opType = "Update";
        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        this.UpdateRecord(strKeyId);
    }

    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public btnUpdateRecordInTab_Click(strKeyId: string) {
        this.opType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        this.UpdateRecord(strKeyId);
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.paperId = "";
        this.paperTitle = "";
        this.paperContent = "";
        this.periodical = "";
        this.author = "";
        this.researchQuestion = "";
        this.updDate = "";
        this.updUser = "";
        this.memo = "";
        this.keyword = "";
        this.literatureSources = "";
        this.literatureLink = "";
        this.uploadfileUrl = "";
        this.isQuotethesis = false;
        this.quoteId = "";
        this.isChecked = false;
        this.checker = "";
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombinevPaperCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strQuoteAndGroupId = $("#hidQuoteAndGroupId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }

            //如果假设为01 就是引用论文 02 就是本组论文
            if (strQuoteAndGroupId == "01") {
                strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '1'`; //引用论文
            }
            else {
                strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '0'`;//本组论文
            }
            if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
            }


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

    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public async DelMultiRecord(arrPaperId: Array<string>) {

        try {
            const returnInt = await Paper_DelPapersAsync(arrPaperId);
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

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public async DelRecord(strPaperId: string) {

        try {
            const returnInt = await Paper_DelRecordAsync(strPaperId);
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

    ///*
    //演示Session 操作
    //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
    //*/
    //public async Demo_Session() {
    //    try {
    //        //设置Session
    //        var strUserId = "TestUserId";
    //        await this.SetSessionAsync("userId", strUserId);
    //        //获取Session
    //        var strUserId_Value1 = await this.GetSessionAsync("userId");
    //        console.log('strUserId_Value1:' + strUserId_Value1);
    //        //获取Session方法2：直接读取页面中的hidUserId
    //        var strUserId_Value2 = this.hidUserId;
    //        console.log('strUserId_Value2:' + strUserId_Value2);
    //    }
    //    catch (e) {
    //        var strMsg: string = `演示Session不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //}

    /* 
    根据关键字详细信息记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
     <param name = "sender">参数列表</param>
   */
    public DetailRecord(strPaperId: string) {
        this.btnOKUpd = "";
        this.btnCancel = "关闭";
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;
                    this.GetDataFromPaperClass(objPaperEN);
                    console.log("完成DetailRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjPaperEN">表实体类对象</param>
   */
    public GetDataFromPaperClass(pobjPaperEN: clsPaperEN) {
        this.paperId = pobjPaperEN.paperId;// 论文Id
        this.paperTitle = pobjPaperEN.paperTitle;// 论文标题
        this.paperContent = pobjPaperEN.paperContent;// 主题内容
        this.periodical = pobjPaperEN.periodical;// 期刊
        this.author = pobjPaperEN.author;// 作者
        this.researchQuestion = pobjPaperEN.researchQuestion;// 研究问题
        this.updDate = pobjPaperEN.updDate;// 修改日期
        this.updUser = pobjPaperEN.updUser;// 修改用户Id
        this.memo = pobjPaperEN.memo;// 备注
        this.keyword = pobjPaperEN.keyword;// 关键字
        this.literatureSources = pobjPaperEN.literatureSources;// 文献来源
        this.literatureLink = pobjPaperEN.literatureLink;// 文献链接
        this.literatureTypeId = pobjPaperEN.literatureTypeId;//文献类型；
        $("#hdnpic").val(pobjPaperEN.uploadfileUrl);
        this.isQuotethesis = pobjPaperEN.isQuotethesis;// 是否引用论文
        this.quoteId = pobjPaperEN.quoteId;// 引用Id
        this.isChecked = pobjPaperEN.isChecked;// 是否检查
        this.checker = pobjPaperEN.checker;// 审核人
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjPaperEN">表实体类对象</param>
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

    /* 获取当前表关键字值的最大值,再加1,避免重复
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
   */
    public async GetMaxStrId(strKeyCtrlName) {
        this.DivName = "divGetMaxStrId";
        try {
            const responseText = await Paper_GetMaxStrIdAsync();
            var returnString: string = responseText.toString();
            if (returnString == "") {
                var strInfo: string = `获取表Paper的最大关键字为空，不成功，请检查!`;
                $('#lblResult35').val(strInfo);
                //显示信息框
                alert(strInfo);
                $(strKeyCtrlName).val(returnString);
            }
            else {
                var strInfo: string = `获取表Paper的最大关键字为：${returnString}!`;
                $('#lblResult35').val(strInfo);
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
                error: (e) => {
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
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

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            if (strUserId != "") {
                //1、为下拉框设置数据源,绑定列表数据
                PaperCRUD.sortPaperBy = "paperTitle Asc";

                ////把类型存入session 区分引用或本组
                //var strQuoteAndGroupId = $("#hidQuoteAndGroupId").val();
                //const bolIsSuccess = this.SetSessionAsync("QuoteAndGroupId", strQuoteAndGroupId);
                const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                //绑定编辑文献类型
                const ddl_LiteratureTypeId = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId");

                var strWhereCond = await this.CombinevPaperCondition();
                const responseText = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    this.recCount = jsonData;
                });




                //管理员 判断角色 
                if (strRoleId == "00620001") {

                    $("#btnDelRecord").show();
                }
                else {
                    //学生00620003 教师 
                    $("#btnDelRecord").hide();

                }
                //存放userId
                $("#hidUserId").val(strUserId);

                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vPaper();

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
    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjPaperEN">数据传输的目的类对象</param>
   */
    public PutDataToPaperClass(pobjPaperEN: clsPaperEN) {
        pobjPaperEN.SetPaperId(this.paperId);// 论文Id
        pobjPaperEN.SetPaperTitle(this.paperTitle);// 论文标题
        pobjPaperEN.SetPaperContent(this.paperContent);// 主题内容
        pobjPaperEN.SetPeriodical(this.periodical);// 期刊
        pobjPaperEN.SetAuthor(this.author);// 作者
        pobjPaperEN.SetResearchQuestion(this.researchQuestion);// 研究问题
        pobjPaperEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjPaperEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
        pobjPaperEN.SetMemo(this.memo);// 备注
        pobjPaperEN.SetKeyword(this.keyword);// 关键字
        pobjPaperEN.SetLiteratureSources(this.literatureSources);// 文献来源
        pobjPaperEN.SetLiteratureLink(this.literatureLink);// 文献链接
        pobjPaperEN.SetLiteratureTypeId(this.literatureTypeId);//文献类型
        pobjPaperEN.SetUploadfileUrl($("#hdnpic").val());
        pobjPaperEN.SetIsQuotethesis(this.isQuotethesis);// 是否引用论文
        pobjPaperEN.SetQuoteId(this.quoteId);// 引用Id
        pobjPaperEN.SetIsChecked(this.isChecked);// 是否检查
        pobjPaperEN.SetChecker(this.checker);// 审核人
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
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_QueryLst)
   */
    public async QueryvPaperLst(strListDiv: string) {
        var strWhereCond = await this.CombinevPaperCondition();
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

    /// <summary>
    /// 在用户自定义控件中，设置关键字的值，是否只读
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    /// </summary>
    /// <param name = "bolReadonly">是否只读</param>
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtPaperId').prop['ReadOnly'] = bolReadonly;
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

    /* 函数功能:把以该关键字的记录内容显示在界面上,
          在这里是把值传到表控件中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
     <param name = "strPaperId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(strPaperId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objPaperEN: clsPaperEN = new clsPaperEN();
        try {
            const responseText = await Paper_IsExistAsync(strPaperId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strPaperId}] 的记录不存在!`;
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
            const responseText = await Paper_GetObjByPaperIdAsync(strPaperId);
            objPaperEN = <clsPaperEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromPaperClass(objPaperEN);
    }

    /* 显示{0}对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
     <param name = "divContainer">显示容器</param>
     <param name = "objPaper">需要显示的对象</param>
   */
    public ShowPaperObj(divContainer: string, objPaper: clsPaperEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = GetObjKeys(objPaper);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objPaper[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
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

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public UpdateRecord(strPaperId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.keyId = strPaperId;
        var strUserId = clsPublocalStorage.userId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;

                    // //通过判断数据用户是否是当前登录用户；
                    if (objPaperEN.updUser == strUserId) {
                        ShowDialog('Update');
                        this.GetDataFromPaperClass(objPaperEN);
                        console.log("完成UpdateRecord!");
                        resolve(jsonData);
                    }
                    else {
                        alert("当前数据不是您所添加，不能修改！");
                        return;
                    }

                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 修改记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
   */
    public async UpdateRecordSave(): Promise<boolean> {
        const strThisFuncName = this.UpdateRecordSave.name;


        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId(this.keyId);
        this.PutDataToPaperClass(objPaperEN);
        objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `修改记录成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        var strInfo: string = `修改记录不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("完成UpdateRecordSave");
                    }
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        });
    }
    /*
    * 作者
   */
    public set author(value: string) {
        $("#txtAuthor").val(value);
    }
    /*
    * 作者
   */
    public get author(): string {
        return $("#txtAuthor").val();
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
    * 审核人
   */
    public set checker(value: string) {
        $("#txtChecker").val(value);
    }
    /*
    * 审核人
   */
    public get checker(): string {
        return $("#txtChecker").val();
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
    * 添加、修改用的层名
   */
    public set DivName(value: string) {
        $("#hidDivName").val(value);
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
    * 用户Id
   */
    public get hidUserId(): string {
        return clsPublocalStorage.userId;
    }
    /*
    * 是否检查
   */
    public set isChecked(value: boolean) {
        $("#chkIsChecked").val(value);
    }
    /*
    * 是否检查
   */
    public get isChecked(): boolean {
        return $("#chkIsChecked").prop("checked");
    }
    /*
    * 是否检查
   */
    public get IsChecked_q(): boolean {
        return $("#chkIsChecked_q").prop("checked");
    }
    /*
    * 是否引用论文
   */
    public set isQuotethesis(value: boolean) {
        $("#chkIsQuotethesis").val(value);
    }
    /*
    * 是否引用论文
   */
    public get isQuotethesis(): boolean {
        return $("#chkIsQuotethesis").prop("checked");
    }
    /*
    * 是否引用论文
   */
    public get IsQuotethesis_q(): boolean {
        return $("#chkIsQuotethesis_q").prop("checked");
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
    * 关键字
   */
    public set keyword(value: string) {
        $("#txtKeyword").val(value);
    }
    /*
    * 关键字
   */
    public get keyword(): string {
        return $("#txtKeyword").val();
    }
    /*
    * 文献链接
   */
    public set literatureLink(value: string) {
        $("#txtLiteratureLink").val(value);
    }
    /*
    * 文献链接
   */
    public get literatureLink(): string {
        return $("#txtLiteratureLink").val();
    }
    /*
    * 文献来源
   */
    public set literatureSources(value: string) {
        $("#txtLiteratureSources").val(value);
    }
    /*
    * 文献来源
   */
    public get literatureSources(): string {
        return $("#txtLiteratureSources").val();
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
    * 设置操作类型：Add||Update||Detail
   */
    public set opType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 主题内容
   */
    public set paperContent(value: string) {
        $("#txtPaperContent").val(value);
    }
    /*
    * 主题内容
   */
    public get paperContent(): string {
        return $("#txtPaperContent").val();
    }
    /*
    * 论文Id
   */
    public set paperId(value: string) {
        $("#txtPaperId").val(value);
    }
    /*
    * 论文Id
   */
    public get paperId(): string {
        return $("#txtPaperId").val();
    }

    /*
    * 论文标题
   */
    public set paperTitle(value: string) {
        $("#txtPaperTitle").val(value);
    }
    /*
    * 论文标题
   */
    public get paperTitle(): string {
        return $("#txtPaperTitle").val();
    }
    /*
    * 论文标题
   */
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
    }
    /*
    * 期刊
   */
    public set periodical(value: string) {
        $("#txtPeriodical").val(value);
    }
    /*
    * 期刊
   */
    public get periodical(): string {
        return $("#txtPeriodical").val();
    }
    /*
    * 引用Id
   */
    public set quoteId(value: string) {
        $("#txtQuoteId").val(value);
    }
    /*
    * 引用Id
   */
    public get quoteId(): string {
        return $("#txtQuoteId").val();
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
    * 文件地址
   */
    public set uploadfileUrl(value: string) {
        $("#txtUploadfileUrl").val(value);
    }
    /*
    * 文件地址
   */
    public get uploadfileUrl(): string {
        return $("#txtUploadfileUrl").val();
    }
    /*
  * 文献类型
 */
    public set literatureTypeId(value: string) {
        $("#ddlLiteratureTypeId").val(value);
    }
    /*
    * 文献类型
   */
    public get literatureTypeId(): string {
        return $("#ddlLiteratureTypeId").val();
    }

    /*
    * 文献类型Id
   */
    public get literatureTypeId_q(): string {
        return $("#ddlLiteratureTypeId_q").val();
    }
}