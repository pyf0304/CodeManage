/*-- -- -- -- -- -- -- -- -- -- --
类名:Paper_QUDI_TS
表名:Paper(01120535)
生成代码版本:2019.12.06.1
生成日期:2019/12/25 17:35:15
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { Paper_QUDI_TS } from "../GraduateEduPaper/Paper_QUDI_TS.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsOperationTypeEN } from "../TS/L0_Entity/SysPara/clsOperationTypeEN.js";
import { PaperReadWrite_GetMaxStrIdAsync, PaperReadWrite_GetRecCountByCondAsync, PaperReadWrite_IsExistAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js";
import { Paper_GetObjByPaperIdAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vPaperReadWrite_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { vPaper_GetObjLstByPagerAsync, vPaper_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { OperationType_GetObjLstAsync } from "../TS/L3_ForWApi/SysPara/clsOperationTypeWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { clsPaperReadWriteWApiEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPager } from "../TS/PubFun/clsPager.js";
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
declare function CloseWindow(): void;
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
/* Paper_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class PaperReadWriteAdd extends Paper_QUDI_TS {
    public mstrListDiv: string = "divDataLst";
    public objPager: clsPager = new clsPager();
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    public RecCount = 0;



    /* 函数功能:页面导入,当页面开始运行时所发生的事件
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
  */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPubSessionStorage.GetSession_UserId() != "") {

                const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                //绑定下拉框；
                var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
                const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
                //  const ddl_OperationTypeId = await this.BindDdl_OperationTypeId("ddlOperationTypeId");
                //1、为下拉框设置数据源,绑定列表数据
                this.hidSortvPaperBy = "paperTitle Asc";
             

                $("#hidUserId").val(clsPubSessionStorage.GetSession_UserId());
                const gvResult = await this.BindGv_vPaper();
                this.AddNewRecord();
                //获取分享Id
                const responseText = await gs_UserConfigEx_GetNewReturnShareIdEx("02", clsPubSessionStorage.GetSession_UserId());
                var strShareId: string = responseText;
                //var returnBool: boolean = !!responseText2;
                if (strShareId != "") {
                    this.shareId = strShareId;
                }

                //$("#hidUserId").val(objvUserRoleRelation.userId);
                $("#divLoading").hide();
            }
            else {
                window.top.location.href = "../Web/Index";
            }



        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    public BindDdl_OperationTypeId(ddlOperationTypeId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlOperationTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlOperationTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = OperationType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrOperationTypeObjLst: Array<clsOperationTypeEN> = <Array<clsOperationTypeEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlOperationTypeId, arrOperationTypeObjLst, clsOperationTypeEN.con_OperationTypeId, clsOperationTypeEN.con_OperationTypeName, "操作类型");
                    console.log("完成BindDdl_OperationTypeId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
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
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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
                        $('#hidPaperRWId').val(returnString); 
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
        this.isPublic = false;
        // $('#ddlOperationTypeId option[0]').attr("selected", true);
        this.updDate = "";
        this.updUser = "";
        this.memo = "";
    }
    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
  */
    public async btnOKUpd_Click() {
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
        var strCommandText: string = this.btnOKUpd;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    const responseText2 = await this. AddNewRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            //HideDialog();
                            vPaperReadWrite_ReFreshThisCache(strid_CurrEducls);


                            //var strReadWriteTypeId = $('#hidReadWriteTypeId').val();
                            //if (strReadWriteTypeId == "01") {
                            //    window.location.href = "../GraduateEduEx/PaperReadList?ReadWriteTypeId=" + strReadWriteTypeId;
                            //}
                            //else if (strReadWriteTypeId == "02") {
                            //    window.location.href = "../GraduateEduEx/PaperReadWrite_QUDI?ReadWriteTypeId=" + strReadWriteTypeId;
                            //}

                            CloseWindow();
                            //this.BindGv_vPaperReadWrite();
                        }
                        else {

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

            $("#btnOKUpd").attr("disabled", false);
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
        objPaperReadWriteEN.createDate = clsPubFun4Web.getNowDate_ymd();
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

                //添加成功后把数据同步到总表
                var strPaperRWId = $('#hidPaperRWId').val();
                const responseText2 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strPaperRWId, "02", "1", this.Id_CurrEduCls);
                var returnBool2: boolean = !!responseText2;
                if (returnBool2 == true) {
                    console.log("论文读写数据总表同步成功；");
                }
                else {
                    console.log("论文读写数据总表同步失败；");
                }



                //添加记录的同时并记录论文的读写数
                var strPaperId = $('#txtPaperRWId').val();
                var strWhereCond2 = " 1 =1 and paperId=" + strPaperId;
                var intRWCount = await PaperReadWrite_GetRecCountByCondAsync(strWhereCond2);

                var objPaperEN: clsPaperEN = new clsPaperEN();
                objPaperEN.paperId = strPaperId;
                objPaperEN.pcount = intRWCount;

                objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    throw "关键字不能为空!";
                }

                const responseText3 = await Paper_UpdateRecordAsync(objPaperEN);
                var returnBool2: boolean = !!responseText3;
                if (returnBool2 == true) {
                    var strInfo: string = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("添加统计数量成功");
                }
                else {
                    var strInfo: string = `添加统计数量不成功!`;
                    alert(strInfo);
                    console.log("添加统计数量不成功");
                }
                //const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                //    var returnBool: boolean = jsonData;
                    

                //});
                //添加记录的同时并记录论文的读写数

            }


            else {
                var strInfo: string = `添加不成功!同一用户同一论文只能添加一次`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //var strInfo: string = `添加记录不成功!`;
                //$('#lblResult40').val(strInfo);
                ////显示信息框
                //alert(strInfo);
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            //var strMsg: string = `添加记录不成功,${e}.`;
            var strMsg: string = `添加记录不成功,论文不能重复添加`;
            alert(strMsg);
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }
    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
  */
    public PutDataToPaperReadWriteClass(pobjPaperReadWriteEN: clsPaperReadWriteEN) {
        pobjPaperReadWriteEN.paperRWId = this.paperRWId;// 论文读写Id
        pobjPaperReadWriteEN.readerId = $("#hidUserId").val();// 阅读者Id
        pobjPaperReadWriteEN.paperId = $("#hidPaperId").val();// 论文Id
        pobjPaperReadWriteEN.researchQuestion = this.researchQuestion;// 研究问题
        pobjPaperReadWriteEN.isPublic = this.isPublic;//是否公开；
        pobjPaperReadWriteEN.shareId = this.shareId;
        pobjPaperReadWriteEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        pobjPaperReadWriteEN.operationTypeId = $("#hidReadWriteTypeId").val();// 操作类型ID
        pobjPaperReadWriteEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjPaperReadWriteEN.updUser = $("#hidUserId").val();// 修改用户Id// 修改用户Id
        pobjPaperReadWriteEN.memo = this.memo;// 备注
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
    public async btnQuery_Click(strListDiv: string) {
        var strWhereCond = this.CombinevPaperCondition();
        try {
            const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                var arrvPaperObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
                this.BindTab_vPaper(this.mstrListDiv, arrvPaperObjLst);
            });
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
    public CombinevPaperCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperTitle_q != "") {
                strWhereCond += ` And ${clsvPaperEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
            }
           

            if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
            }
            //if (this.IsChecked_q == true) {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsChecked} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsChecked} = '0'`;
            //}
            //if (this.IsQuotethesis_q == true) {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsQuotethesis} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsQuotethesis} = '0'`;
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
        var strWhereCond = this.CombinevPaperCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperObjLst: Array<clsvPaperEN> = [];
        try {
            const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperObjLst = <Array<clsvPaperEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvPaperObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
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
    public BindTab_vPaper(divContainer: string, arrvPaperObjLst: Array<clsvPaperEN>) {
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
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "periodical",
                    ColHeader: "期刊",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    ColHeader: "作者",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "researchQuestion",
                //    ColHeader: "研究问题",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},

                {
                    FldName: "keyword",
                    ColHeader: "关键字",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "literatureSources",
                    ColHeader: "文献来源",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "literatureLink",
                    ColHeader: "文献链接",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "uploadfileUrl",
                //    ColHeader: "文件地址",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "checker",
                //    ColHeader: "审核人",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "isChecked",
                //    ColHeader: "是否检查",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "isQuotethesis",
                    ColHeader: "是否引用论文",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "updUser",
                //    ColHeader: "修改用户Id",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "",
                //    ColHeader: "修改",
                //    Text: "修改",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvPaperObjLst, arrDataColumn, "paperId");
        this.objPager.RecCount = this.RecCount;
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
            clsCommonFunc4Web.Redirect("/Index/Main_vPaper");
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
    public QueryvPaperLst(strListDiv: string) {
        var strWhereCond = this.CombinevPaperCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        return new Promise((resolve, reject) => {
            try {
                var objPagerPara: stuPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseText = vPaper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                    var arrvPaperObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
                    this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
                    console.log("完成QueryvPaperLst!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
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
        this.BindGv_vPaper();
    }
    /* 函数功能:从界面列表中根据某一个字段排序
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
    <param name = "strSortByFld">排序的字段</param>
  */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortvPaperBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvPaperBy.indexOf("Asc") >= 0) {
                this.hidSortvPaperBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvPaperBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvPaperBy = `${strSortByFld} Asc`;
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
    public get PaperTitle_q(): string {
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
        return $("#hidUserId").val();
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
    // /*
    // * 操作类型ID
    //*/
    // public set operationTypeId(value: string) {
    //     $("#ddlOperationTypeId").val(value);
    // }
    // /*
    // * 操作类型ID
    //*/
    // public get operationTypeId(): string {
    //     return $("#ddlOperationTypeId").val();
    // }
    /*
    * 操作类型ID
   */
    public get OperationTypeId_q(): string {
        return $("#ddlOperationTypeId_q").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set OpType(value: string) {
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
    public get LiteratureTypeId_q(): string {
        return $("#ddlLiteratureTypeId_q").val();
    }
    /*
   * 是否公开
  */
    public set isPublic(value: boolean) {
        $("#chkIsPublic").val(value);
    }
    /*
    * 是否公开
   */
    public get isPublic(): boolean {
        return $("#chkIsPublic").prop("checked");
    }
    /*
 * 分享
 */
    public set shareId(value: string) {
        $("#ddlShareId").val(value);
    }
    /*
    * 分享
    */
    public get shareId(): string {
        return $("#ddlShareId").val();
    }

    /*
    * 教学班ID
   */
    public set Id_CurrEduCls(value: string) {
        $("#hidId_CurrEduCls").val(value);
    }
    /*
    * 教学班
   */
    public get Id_CurrEduCls(): string {
        return $("#hidId_CurrEduCls").val();
    }
}