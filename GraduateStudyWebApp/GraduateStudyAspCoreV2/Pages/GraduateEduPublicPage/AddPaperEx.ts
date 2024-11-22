//import { clsPaperAttachmentWApi } from "../TS/L3_ForWApi/GraduateEduPaper/
//import * as QQ from "q";


import { PaperCRUD } from "../PagesBase/GraduateEduPaper/PaperCRUD.js";
import { Paper_Edit } from "../PagesBase/GraduateEduPaper/Paper_Edit.js";

import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsXzMajorEN } from "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js";
import { clsgs_PaperAttentionEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
import { clsgs_PaperGroupEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { clsgs_PaperVerEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js";
import { clsMajorDirectionPaperRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js";
import { clsgs_PaperStatusEN } from "../TS/L0_Entity/ParameterTable/clsgs_PaperStatusEN.js";
import { clsgs_PaperTypeEN } from "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { XzMajor_GetObjLstAsync } from "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js";
import { gs_PaperAttention_AddNewRecordAsync, gs_PaperAttention_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { gs_PaperGroup_AddNewRecordWithReturnKeyAsync, gs_PaperGroup_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js";
import { gs_PaperVer_AddNewRecordAsync, gs_PaperVer_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { MajorDirectionPaperRela_AddNewRecordAsync, MajorDirectionPaperRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js";
import { PaperAttachment_AddNewRecordAsync, PaperAttachment_DelPaperAttachmentsByCondAsync, PaperAttachment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { Paper_AddNewRecordAsync, Paper_AddNewRecordWithReturnKeyAsync, Paper_GetMaxStrIdAsync, Paper_GetObjByPaperIdAsync, Paper_GetRecCountByCondAsync, Paper_IsExistAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { ResearchTopic_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { RTPaperRela_AddNewRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js";
import { gs_PaperStatus_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsgs_PaperStatusWApi.js";
import { gs_PaperType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { LiteratureType_GetObjLstAsync, LiteratureType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { PaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { BindDdl_ObjLst } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";

import { Pub_PaperList } from "./Pub_PaperList.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogOne(): void;
declare function CloseWindow(): void;
declare function setTextboxio(): void;
declare function layui_Alert(iconKey, strMsg): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* AddPaperEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class AddPaperEx extends Paper_Edit {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperBy: string = "paperId";


    //专业方向
    public mstrListDivMajorDirection: string = "divMajorDirectionDataLst";

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
        const strThisFuncName = this.Page_Load.name;
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPublocalStorage.userId != "") {

                //通过主题Id获取教学班ID
                if (clsPublocalStorage.id_CurrEduCls == "") {
                    const objResearchTopic = await ResearchTopic_GetFirstObjAsync(" topicId=" + clsPrivateSessionStorage.topicId);
                    if (objResearchTopic == null) {
                        const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                        //const strThisFuncName = this.Page_Load.name;
                    }
                    clsPublocalStorage.id_CurrEduCls = objResearchTopic.id_CurrEduCls;
                } 

                //加载页面所需数据源到缓存
                const arrLiteratureType_Cache = await LiteratureType_GetObjLstAsync("1=1");

                //绑定论文类型下拉框
                const ddl_PaperTypeId_q = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId");

                //论文状态
                const ddl_PaperStatusId_q = await this.BindDdl_gs_PaperStatus_Cache("ddlPaperStatusId");

                //绑定编辑文献类型
                const ddl_LiteratureTypeId = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId", new clsLiteratureTypeEN);

                var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
                const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4Edit, "ddlShareId");

                PaperCRUD.sortPaperBy = "updDate Desc";
                //this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";
                var strUserId = clsPublocalStorage.userId;
                $('#hidUserId').val(strUserId);

                this.AddNewRecord();
                //获取分享Id
                const responseText = await gs_UserConfigEx_GetNewReturnShareIdEx("01", clsPublocalStorage.userId);
                var strShareId: string = responseText;
                //var returnBool: boolean = !!responseText2;
                if (strShareId != "") {
                    this.shareId = strShareId;
                }
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
    //论文类型
    public async BindDdl_gs_PaperType_Cache(ddlgs_PaperTypeId: string) {
        var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlgs_PaperTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlgs_PaperTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }

        try {

            var arrObjLst_Sel: Array<clsgs_PaperTypeEN> = await gs_PaperType_GetObjLstAsync(strWhereCond);

            BindDdl_ObjLst(ddlgs_PaperTypeId, arrObjLst_Sel, clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN.con_PaperTypeName, "论文类型");
            console.log("完成BindDdl_gs_PaperType_Cache!");


        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }
    //论文状态
    public async BindDdl_gs_PaperStatus_Cache(ddlgs_PaperStatusId: string) {
        var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlgs_PaperStatusId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlgs_PaperStatusId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }

        try {

            var arrObjLst_Sel: Array<clsgs_PaperStatusEN> = await gs_PaperStatus_GetObjLstAsync(strWhereCond);

            BindDdl_ObjLst(ddlgs_PaperStatusId, arrObjLst_Sel, clsgs_PaperStatusEN.con_PaperStatusId, clsgs_PaperStatusEN.con_PaperStatusName, "论文状态");
            console.log("完成BindDdl_gs_PaperStatus_Cache!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }
    /* 为插入记录做准备工作
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
  */
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_Paper = "确认添加";
        this.btnCancel_Paper = "取消添加";
        this.Clear();
        //去掉提交按钮不可用状态
        $('#btnOKUpd').attr("disabled", false);

        this.Disabled_false();
        //因为是添加 只显示基本信息；
        $("#liextendEdit").attr("style", "display:block;");
      
    }


    //论文类型下拉框事件

    public ddlPaperTypeChange() {
        //判断下拉框是否有值，且值是否等于
        if (this.paperTypeId != "" && this.paperTypeId != "0") {
            if (this.paperTypeId == "01") {
                //引用论文
                $("#ddlPaperStatusId").attr("disabled", true);
            }
            else {

                //原创论文
                $("#ddlPaperStatusId").attr("disabled", false);
            }
        }
    }

    ////专业下拉框绑定
    //public BindDdl_id_XzMajorNum(ddlid_XzMajor: string, strWhereCond: string = "1=1") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlid_XzMajor);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = vPaperEx_GetMajorNumObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrXzMajorObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>jsonData;
    //                BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsPaperEN.con_id_XzMajor, clsPaperEN.con_MajorName, "专业");
    //                console.log("完成BindDdl_id_XzMajor!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}
    public async BindDdl_LiteratureTypeId_Cache(ddlLiteratureTypeId: string, objLiteratureType_Cond: clsLiteratureTypeEN) {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlLiteratureTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }

        try {

            var arrObjLst_Sel: Array<clsLiteratureTypeEN> = await LiteratureType_GetSubObjLst_Cache(objLiteratureType_Cond);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsLiteratureTypeEN.con_LiteratureTypeId]);
            BindDdl_ObjLst(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
            console.log("完成BindDdl_LiteratureTypeId!");

            //const responseText = LiteratureType_GetObjLst_WA_CacheAsync().then((jsonData) => {
            //    var arrPaperObjLst: Array<clsLiteratureTypeEN> = <Array<clsLiteratureTypeEN>>jsonData;
            //    BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
            //    console.log("完成BindDdl_LiteratureTypeId!");
            //    resolve(jsonData);
            //});
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }


    /* 查询
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async btnQuery_Click(strListDiv: string) {
        try {
            const objPage_Paper = new Pub_PaperList();
            await objPage_Paper.BindGv_vPaper();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    /* 所有论文
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async liAllPaper_Click(strListDiv: string) {
        try {
            const objPage_Paper = new Pub_PaperList();
            await objPage_Paper.BindGv_vPaper();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
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
                    BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "");
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

  
    /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    //public async BindGv_vPaperLoad() {
    //    var strListDiv: string = this.divName4DataList;
    //    var strWhereCond = await this.CombinevPaperCondition();
    //    /*var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页*/
    //    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
    //    var arrPaperExObjLst: Array<clsPaperENEx> = [];
    //    try {
    //        this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
    
    //        });
    //        var objPagerPara: stuPagerPara = {
    //            pageIndex: intCurrPageIndex,
    //            pageSize: this.pageSize,
    //            whereCond: strWhereCond,
    //            orderBy: PaperCRUD.sortPaperBy,
    //            sortFun: (x, y) => { return 0; }
    //        };
    //        const responseObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara).then((jsonData) => {
    //            arrPaperExObjLst = <Array<clsPaperEN>>jsonData;
    //        });



    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //    //if (arrPaperExObjLst.length == 0) {
    //    //    var strMsg: string = `根据条件获取的对象列表数为空！`;
    //    //console.error(strMsg);
    //    //    alert(strMsg);
    //    //    return;
    //    //}
    //    try {
    //        this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
    //        console.log("完成BindGv_vPaper!");
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
    //        alert(strMsg);
    //    }
    //}


    /* 删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
  */
    //public async btnDelRecord_Click() {
    //    try {
    //        var arrKeyIds = GetCheckedKeyIds();
    //        if (arrKeyIds.length == 0) {
    //            alert("请选择需要删除的记录！");
    //            return "";
    //        }
    //        var strKeyList;
    //        if (arrKeyIds.length == 0) return "";
    //        strKeyList = "";
    //        for (var i = 0; i < arrKeyIds.length; i++) {
    //            if (i == 0) strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
    //            else strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
    //        }
    //        //
    //        var strWhereCond = " paperId in (" + strKeyList + ")";
    //        const responseText1 = await vPaperReadWrite_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
    
    //            if (this.recCount != 0) {
    //                alert("请先删除该论文下阅读或写作数据！");
    //                return "";
    //            }
    //            else {

    //            }

    //        });

    //        const responseText = await this.DelMultiRecord(arrKeyIds);
    //        const responseText2 = await this.BindGv_vPaper();
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `删除记录不成功. ${e}.`;
    //        alert(strMsg);
    //    }
    //}

    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
*/
    public async AddNewRecordWithMaxIdSaveRetrunId() {
        
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetCreateDate(clsPubFun4Web.getNowDate_ymd());
        this.PutDataToPaperClass(objPaperEN);
        try {

            let strCondition = Format(" 1 = 1 and paperTitle = '{0}' and paperId in (select paperId from PaperEduClsRela where id_CurrEduCls = '{1}')",
                this.paperTitle, clsPublocalStorage.id_CurrEduCls);
            
            var intPaperCount = await Paper_GetRecCountByCondAsync(strCondition);
            if (intPaperCount != 0) {
                var strMsg: string = `添加记录时，当前教学班论文标题：${objPaperEN.paperTitle}已经存在，请重新命名！`;
                alert(strMsg);
                return false;//一定要有一个返回值，否则会出错！
            }

            //const responseText2 = await SysSkill_AddNewRecordWithMaxIdAsync(objSysSkillEN);
            const responseText = await Paper_AddNewRecordWithReturnKeyAsync(objPaperEN);
            var strPaperId: string = responseText;
            //var returnBool: boolean = !!responseText2;
            if (strPaperId != "") {

                $("#hidPaperId").val(strPaperId);
                //判断是否有返回的附件路径值
                if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    var fileOne = $("#hdnFileOne").val();
                    const responseText06 = await this.AddNewRecordPaperAttachmentSave(fileOne, "first");
                    var returnBool2: boolean = !!responseText06;
                    if (returnBool2 != true) {
                        var strInfo: string = `添加论文成功,但添加附件失败，请修改该条数据重新上传附件!`;
                        alert(strInfo);
                        return false;
                    }
                }
                else {
                    if ($("#hdnFileTwo").val() != "") {
                        var fileTwo = $("#hdnFileTwo").val();
                        const responseText07 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                    }
                    else {
                        if ($("#hdnFileThree").val() != "") {
                            var fileThree = $("#hdnFileThree").val();
                            const responseText08 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                        }
                    }

                }


                return true;
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return strPaperId;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        //return strSysPaperId;//一定要有一个返回值，否则会出错！
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
  */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnSubmit_Paper;
        try {
            //判断session是否失效
            if (clsPublocalStorage.userId != "") {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        var returnBool: boolean = true;
                        //const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                        //    var returnBool: boolean = jsonData;

                        //});

                        const responseText2 = await this.AddNewRecordWithMaxIdSaveRetrunId().then((jsonData) => {


                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；

                        var strPaperId = $("#hidPaperId").val();
                        const responseText8 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strPaperId, "01", "1", clsPublocalStorage.id_CurrEduCls);
                        var returnBool8: boolean = !!responseText8;
                        if (returnBool8 == true) {
                            console.log("客观数据总表同步成功；");
                        }
                        else {
                            console.log("客观数据总表同步失败；");
                        }


                        //添加完自动关注该论文
                        //var strPaperId = $("#hidPaperId").val();
                        const responseText4 = await this.btnAttention_Click(strPaperId);
                        var returnBool4: boolean = !!responseText4;
                        if (returnBool4 == true) {
                            console.log("论文关注成功；");
                        }
                        else {
                            console.log("论文关注失败；");
                        }


                        if (returnBool == true) {

                            //添加记录的同时添加历史版本 判断只有原创论文才记录历史版本
                            if (this.paperTypeId == "02") {
                                const responseText6 = await this.AddVersionRecordSave().then((jsonData) => {
                                    var returnBool: boolean = jsonData;
                                    if (returnBool == true) {

                                        //alert("添加历史版本出问题！");
                                    }
                                });
                            }

                            //统计附件数量并添加到论文表
                            const responseText3 = await this.AddAttachmentCount();
                            //添加主题论文关系
                            const responseText4 = await this.AddNewRecordSavePaperRela();

                            var strInfo: string = `添加记录成功!`;
                            alert(strInfo);
                            CloseWindow();
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        var returnBool: boolean = true;
                        const responseText5 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                        });
                        if (returnBool == true) {

                            //添加记录的同时添加历史版本 判断只有原创论文才记录历史版本
                            if (this.paperTypeId == "02") {
                                const responseText6 = await this.AddVersionRecordSave().then((jsonData) => {
                                    var returnBool: boolean = jsonData;
                                    if (returnBool == true) {

                                        //alert("添加历史版本出问题！");
                                    }
                                });
                            }
                            //更新总表3个参数 主键、子表类型、页面操作类型；

                            var strPaperId = $("#hidPaperId").val();
                            const responseText9 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strPaperId, "01", "2", clsPublocalStorage.id_CurrEduCls);
                            var returnBool9: boolean = !!responseText9;
                            if (returnBool9 == true) {
                                console.log("客观数据总表同步成功；");
                            }
                            else {
                                console.log("客观数据总表同步失败；");
                            }
                            //统计附件数量并添加到论文表
                            const responseText6 = await this.AddAttachmentCount();
                            //添加主题论文关系
                            const responseText7 = await this.AddNewRecordSavePaperRela();
                            var strInfo: string = `修改记录成功!`;
                            alert(strInfo);
                            CloseWindow();
                        }

                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                        alert(strMsg);
                        break;
                }

            }
            else {
                alert("登录超时，请重新登录");
                window.top.location.href = "../Web/Login";
            }
            $("#divLoading").hide();
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", false);
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }


    //添加关注
    public async btnAttention_Click(strPaperId: string) {
        const strThisFuncName = this.btnAttention_Click.name;
        try {
            var strUserId = clsPublocalStorage.userId;
            var strWhereCond = " 1 =1 and updUser='" + strUserId + "' and paperId=" + strPaperId;

            const responseText = await gs_PaperAttention_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经关注过这条论文了，请关注其他论文！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }



            var strWhereCond1 = " updUser='" + strUserId + "' and paperGroupName='" + clsPublocalStorage.eduClsName + "'";

            const objgs_PaperGroup = await gs_PaperGroup_GetFirstObjAsync(strWhereCond1);
            if (objgs_PaperGroup == null) {
                const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
                //const strThisFuncName = this.Page_Load.name;
            }
            var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
            objgs_PaperAttentionEN.SetPaperId(strPaperId);
            objgs_PaperAttentionEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
            objgs_PaperAttentionEN.SetUpdUser(strUserId);// 修改用户Id
            objgs_PaperAttentionEN.SetUserId(strUserId);// 修改用户Id
            if (objgs_PaperGroup != null) {
                objgs_PaperAttentionEN.SetPaperGroupId(objgs_PaperGroup.paperGroupId);
            } else {
                var objgs_PaperGroupEN: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
                objgs_PaperGroupEN.SetPaperGroupName(clsPublocalStorage.eduClsName);
                objgs_PaperGroupEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
                objgs_PaperGroupEN.SetUpdUser(strUserId);// 修改用户Id

                var strPaperGroupId = await gs_PaperGroup_AddNewRecordWithReturnKeyAsync(objgs_PaperGroupEN);
                if (strPaperGroupId != "") {
                    objgs_PaperAttentionEN.SetPaperGroupId(strPaperGroupId);
                }
            }

            const responseText3 = await gs_PaperAttention_AddNewRecordAsync(objgs_PaperAttentionEN);
            var returnBool: boolean = !!responseText3;
            if (returnBool == true) {
                const objPage_Paper = new Pub_PaperList();
                await objPage_Paper.BindGv_vPaper();
                layui_Alert(1, "已关注！")
            }
            else {
                var strInfo: string = `关注不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return responseText3;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `关注不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }


    //添加历史版本
    public async AddVersionRecordSave() {
        const strThisFuncName = this.AddVersionRecordSave.name;

        var strPaperId = $("#hidPaperId").val();
        var objgs_PaperEN: clsgs_PaperVerEN = new clsgs_PaperVerEN();
        objgs_PaperEN.SetPaperId(strPaperId);
        this.PutDataToPaperVerClass(objgs_PaperEN);

        try {
            const responseText2 = await gs_PaperVer_AddNewRecordAsync(objgs_PaperEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                var strWhereCond2 = " 1 =1 and paperId=" + strPaperId;
                var intVersionCount = await gs_PaperVer_GetRecCountByCondAsync(strWhereCond2);


                var objPaperEN: clsPaperEN = new clsPaperEN();
                objPaperEN.SetPaperId(strPaperId);
                objPaperEN.SetVersionCount(intVersionCount);


                objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }


                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        return true;
                    }
                    else {
                        var strInfo: string = `添加历史版本数不成功!`;
                        alert(strInfo);
                        console.log("添加历史版本数不成功");
                        return false;
                    }

                });
                return true;
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加版本记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }
    //public async GetPaperDataByPaperId() {

    //}
    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjPaperEN">数据传输的目的类对象</param>
   */
    public async PutDataToPaperVerClass(pobjPaperEN: clsgs_PaperVerEN) {
        var strPaperId = $("#hidPaperId").val();
        pobjPaperEN.SetPaperId(strPaperId);// 论文Id
        pobjPaperEN.SetPaperTitle(this.paperTitle);// 论文标题
        pobjPaperEN.SetPaperContent(this.paperContent);// 主题内容
        pobjPaperEN.SetPeriodical(this.periodical);// 期刊
        pobjPaperEN.SetAuthor(this.author);// 作者
        pobjPaperEN.SetResearchQuestion(this.researchQuestion);// 研究问题
        pobjPaperEN.SetUpdDate(clsPubFun4Web.getNowDate_ymd());// 修改日期
        pobjPaperEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id

        pobjPaperEN.SetMemo(this.memo);// 备注
        pobjPaperEN.SetKeyword(this.keyword);// 关键字
        pobjPaperEN.SetLiteratureSources(this.literatureSources);// 文献来源
        pobjPaperEN.SetLiteratureLink(this.literatureLink);// 文献链接
        pobjPaperEN.SetLiteratureTypeId(this.literatureTypeId);//文献类型
        pobjPaperEN.SetUploadfileUrl($("#hdnpic").val());
        pobjPaperEN.SetIsQuotethesis(this.isQuotethesis);// 是否引用论文
        pobjPaperEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjPaperEN.SetQuoteId(this.quoteId);// 引用Id
        pobjPaperEN.SetIsChecked(this.isChecked);// 是否检查
        pobjPaperEN.SetChecker(this.checker);// 审核人

        pobjPaperEN.SetPaperTypeId(this.paperTypeId);// 论文类型
        pobjPaperEN.SetPaperStatusId(this.paperStatusId);// 论文状态
    }

    //统计附件数量并添加到论文表
    public async AddAttachmentCount() {
        const strThisFuncName = this.AddAttachmentCount.name;
        //添加记录的同时并记录论文的读写数
        var strPaperId = $("#hidPaperId").val();
        var strWhereCond2 = " 1=1 and paperId=" + strPaperId;
        var intAttachmentCount = await PaperAttachment_GetRecCountByCondAsync(strWhereCond2);

        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId(strPaperId);
        objPaperEN.SetAttachmentCount(intAttachmentCount);

        objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        const responseText = await Paper_UpdateRecordAsync(objPaperEN);
        var returnBool: boolean = !!responseText;
        if (returnBool == true) {
            PaperEx_ReFreshThisCacheById_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
            //HideDialog();
            //this.BindGv_vPaper();
            //$("#divLoading").hide();
            ////显示信息框
            //this.Clear();
            //var strInfo: string = `添加记录成功!`;
            //alert(strInfo);
            console.log("添加统计数量成功");
        }
        else {
            var strInfo: string = `添加统计数量不成功!`;
            alert(strInfo);
            console.log("添加统计数量不成功");
        }
    }

    /* 添加新记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
  */
    public async AddNewRecordSave() {
        
        try {
            const responseText01 = await Paper_GetMaxStrIdAsync().then((jsonData) => {
                var returnString: string = jsonData.toString();
                if (returnString == "") {
                    var strInfo: string = `获取表Paper的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtPaperId').val(returnString);
                    $('#hidPaperId').val(returnString);

                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }


        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId($('#hidPaperId').val());
        const responseText02 = await this.PutDataToPaperClass(objPaperEN);
        try {
            const responseText03 = await Paper_IsExistAsync(objPaperEN.paperId);
            var bolIsExist: boolean = responseText03;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objPaperEN.paperId}已经存在！`;
                alert(strMsg);
                return responseText03;//一定要有一个返回值，否则会出错！
            }

            var intPaperCount = await Paper_GetRecCountByCondAsync("1=1 and paperTitle='" + this.paperTitle + "' and id_CurrEduCls ='" + clsPublocalStorage.id_CurrEduCls + "'");
            if (intPaperCount != 0) {
                var strMsg: string = `添加记录时，当前教学班论文标题：${objPaperEN.paperTitle}已经存在，请重新命名！`;
                alert(strMsg);
                return false;//一定要有一个返回值，否则会出错！
            }


            const responseText05= await Paper_AddNewRecordAsync(objPaperEN);
            var returnBool: boolean = !!responseText05;
            if (returnBool == true) {
                //判断是否有返回的附件路径值
                if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    var fileOne = $("#hdnFileOne").val();
                    const responseText06 = await this.AddNewRecordPaperAttachmentSave(fileOne, "first");
                    var returnBool2: boolean = !!responseText06;
                    if (returnBool2 != true) {
                        var strInfo: string = `添加论文成功,但添加附件失败，请修改该条数据重新上传附件!`;
                        alert(strInfo);
                        return false;
                    }
                }
                else {
                    if ($("#hdnFileTwo").val() != "") {
                        var fileTwo = $("#hdnFileTwo").val();
                        const responseText07 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                    }
                    else {
                        if ($("#hdnFileThree").val() != "") {
                            var fileThree = $("#hdnFileThree").val();
                            const responseText08 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                        }
                    }

                }
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText05;//一定要有一个返回值，否则会出错！
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

    //添加上传论文附件方法
    public async AddNewRecordPaperAttachmentSave(filePath: string, strfileNum: string) {
        var objPaperAttachmentEN: clsPaperAttachmentEN = new clsPaperAttachmentEN();
        this.PutDataToPaperAttachmentClass(objPaperAttachmentEN, filePath);
        try {
            const responseText2 = await PaperAttachment_AddNewRecordAsync(objPaperAttachmentEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //第一个附件
                if (strfileNum == "first") {
                    //如果第二个附件不等于空，那么执行添加函数；
                    if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                        var fileTwo = $("#hdnFileTwo").val();
                        const responseText3 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                    }
                    else {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            const responseText4 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                        }
                    }
                }
                else if (strfileNum == "two") {
                    //为空则判断第三个附件值；
                    if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                        var fileThree = $("#hdnFileThree").val();
                        const responseText5 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                    }
                }

            }
            else {
                var strInfo: string = `论文附件添加不成功!`;
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
        //return true;//一定要有一个返回值，否则会出错！
    }
    public PutDataToPaperAttachmentClass(pobjPaperAttachmentEN: clsPaperAttachmentEN, filePath: string) {
        pobjPaperAttachmentEN.SetPaperId($("#hidPaperId").val());// 论文Id
        var strfilePath = filePath;
        var index = strfilePath.lastIndexOf("\/");
        strfilePath = strfilePath.substring(index + 1, strfilePath.length);
        pobjPaperAttachmentEN.SetFilePath(filePath);
        pobjPaperAttachmentEN.SetPaperAttachmentName(strfilePath);

        pobjPaperAttachmentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期


        var strUserId = clsPublocalStorage.userId;
        pobjPaperAttachmentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班
        pobjPaperAttachmentEN.SetUpdUserId(strUserId);// 修改用户Id


    }



    ///////////////////////////////////////////////----------------------------------------------------添加主题论文关系
    /* 添加新记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSavePaperRela() {
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strPaperId = $("#hidPaperId").val();
        var strUserId = clsPublocalStorage.userId;
        var objRTPaperRelaEN: clsRTPaperRelaEN = new clsRTPaperRelaEN();
        this.PutDataToRTPaperRelaClass(objRTPaperRelaEN);

        try {
            //// 同一主题 同一论文 只能添加一次；
            //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And paperId = '" + strPaperId + "'";
            //const responseText = await RTPaperRela_IsExistRecordAsync(strWhere);
            //var bolIsExist: boolean = responseText;
            //if (bolIsExist == true) {
            //    var strMsg: string = `同一主题不能重复添加同一个论文！`;
            //    alert(strMsg);
            //    return responseText;//一定要有一个返回值，否则会出错！
            //}

            const responseText2 = await RTPaperRela_AddNewRecordAsync(objRTPaperRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
            }
            else {
                var strInfo: string = `添加不成功!`;
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
 <param name = "pobjRTPaperRelaEN">数据传输的目的类对象</param>
*/
    public PutDataToRTPaperRelaClass(pobjRTPaperRelaEN: clsRTPaperRelaEN) {
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strPaperId = $("#hidPaperId").val();
   
        pobjRTPaperRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTPaperRelaEN.SetPaperId(strPaperId);// 论文Id
        pobjRTPaperRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTPaperRelaEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjRTPaperRelaEN.SetMemo(this.memo);// 备注
    }




    /* 修改记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
  */
    public async btnUpdateRecord_Click(strKeyId: string) {
        this.opType = "Update";
        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        this.UpdateRecord(strKeyId);
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public async UpdateRecordSave(): Promise<boolean> {
        const strThisFuncName = this.UpdateRecordSave.name;


        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId(this.keyId);
        $('#hidPaperId').val(this.keyId);
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

                        //得到相关论文附件地址，判断是否为空
                        if ($("#hdnFileOne").val() != "" || $("#hdnFileTwo").val() != "" || $("#hdnFileThree").val() != "") {
                            //根据Id删除附件
                            var strwhere = "paperId ='" + objPaperEN.paperId + "'";
                            this.DelRecordByWhere(strwhere);

                        }
                        //else if ($("#hdnFileTwo").val() != "") {
                        //    var fileTwo = $("#hdnFileTwo").val();
                        //    this.AddNewRecordPaperAttachmentSave(fileTwo);
                        //}
                        //else if ($("#hdnFileThree").val() != "") {
                        //    var fileThree = $("#hdnFileThree").val();
                        //    this.AddNewRecordPaperAttachmentSave(fileThree);
                        //}


                        var strInfo: string = `修改记录成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                        $('#lblResult44').val(strInfo);

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
   根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
  */
    public DelRecordByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperAttachment_DelPaperAttachmentsByCondAsync(strWhere).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {

                        //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        ////显示信息框
                        //alert(strInfo);
                    }
                    else {
                        var strInfo: string = `删除记录不成功!`;
                        //显示信息框
                        //alert(strInfo);
                    }

                    //不管是否有数据删除 都需要执行附件添加功能
                    //判断是否有返回的附件路径值
                    //判断是否有返回的附件路径值
                    if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                        var fileOne = $("#hdnFileOne").val();
                        this.AddNewRecordPaperAttachmentSave(fileOne, "first");
                    }
                    else {
                        if ($("#hdnFileTwo").val() != "") {
                            var fileTwo = $("#hdnFileTwo").val();
                            this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                        }
                        else {
                            if ($("#hdnFileThree").val() != "") {
                                var fileThree = $("#hdnFileThree").val();
                                this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                            }
                        }

                    }

                    console.log("完成DelRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        });
    }


    /* 根据关键字获取相应的记录的对象
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
    <param name = "sender">参数列表</param>
  */
    public async UpdateRecord(strPaperId: string): Promise<boolean>  {
        this.btnSubmit_Paper = "确认修改";
        this.btnCancel_Paper = "取消修改";
        this.keyId = strPaperId;
        return new Promise((resolve, reject) => {
            try {
              
                var strUserId = clsPublocalStorage.userId;

                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;

                    //判断是不是添加用户
                    if (objPaperEN.updUser == strUserId) {
                        //判断数据是否已经审核
                        if (objPaperEN.isChecked == true) {
                            //$("#btnOKUpd").hide();
                            //$("#btnCancel").hide();
                            //$('#myModalLabel').html('详细信息');

                            //this.GetDataFromPaperClass(objPaperEN);
                            //console.log("完成UpdateRecord!");
                            //resolve(jsonData);
                            var strMsg: string = `当前记录已被审核不可修改！`;
                            alert(strMsg);
                            return;
                        }
                        else {
                            $("#btnOKUpd").show();
                            $("#btnCancel").show();
                            ShowDialog('Update');
                            this.GetDataFromPaperClass(objPaperEN);
                            $("#txtPaperTitle").attr("disabled", true);
                            console.log("完成UpdateRecord!");
                            //resolve(jsonData);
                        }


                    }
                    else {
                        //$("#btnOKUpd").hide();
                        //$("#btnCancel").hide();
                        //$('#myModalLabel').html('详细信息');
                        //ShowDialog('Update');
                        //this.GetDataFromPaperClass(objPaperEN);
                        //console.log("完成UpdateRecord!");
                        //resolve(jsonData);

                        var strMsg: string = `当前记录不是您添加的只能查看不能修改！`;
                        alert(strMsg);
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
    //public async GetPaperDataByPaperId() {

    //}
    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjPaperEN">数据传输的目的类对象</param>
   */
    public async PutDataToPaperClass(pobjPaperEN: clsPaperEN) {

        pobjPaperEN.SetPaperId(this.paperId);// 论文Id
        pobjPaperEN.SetPaperTitle(this.paperTitle);// 论文标题
        pobjPaperEN.SetPaperContent(this.paperContent);// 主题内容
        pobjPaperEN.SetPeriodical(this.periodical);// 期刊
        pobjPaperEN.SetAuthor(this.author);// 作者
        pobjPaperEN.SetResearchQuestion(this.researchQuestion);// 研究问题
        pobjPaperEN.SetUpdDate(clsPubFun4Web.getNowDate_ymd());// 修改日期

      
        var strUserId = clsPublocalStorage.userId;

        pobjPaperEN.SetUpdUser(strUserId);// 修改用户Id
        //pobjPaperEN.SetUpdUser(clsPublocalStorage.userId;// 修改用户Id
        pobjPaperEN.SetMemo(this.memo);// 备注
        pobjPaperEN.SetKeyword(this.keyword);// 关键字
        pobjPaperEN.SetLiteratureSources(this.literatureSources);// 文献来源
        pobjPaperEN.SetLiteratureLink(this.literatureLink);// 文献链接
        pobjPaperEN.SetLiteratureTypeId(this.literatureTypeId);//文献类型
        pobjPaperEN.SetUploadfileUrl($("#hdnpic").val());
        pobjPaperEN.SetIsQuotethesis(this.isQuotethesis);// 是否引用论文
        pobjPaperEN.SetQuoteId(this.quoteId);// 引用Id
        //pobjPaperEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls;
        pobjPaperEN.SetShareId(this.shareId);
        //pobjPaperEN.SetIsChecked(this.isChecked;// 是否检查
        //在主题维护关系界面、添加论文、暂定默认为true、
        pobjPaperEN.SetIsChecked(false);// 是否检查
        pobjPaperEN.SetIsSubmit(false);//是否提交//因为是个人添加，所以状态为false；
        pobjPaperEN.SetChecker(this.checker);// 审核人

        pobjPaperEN.SetPaperTypeId("01");// 论文类型 01 代表引用类型；
        pobjPaperEN.SetPaperStatusId(this.paperStatusId);// 论文状态
        pobjPaperEN.SetIsPublic(true);//引用论文；
    }


    /* 函数功能:把类对象的属性内容显示到界面上
   注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
    如果在设置数据库时,就应该一级字段在前,二级字段在后
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
    <param name = "pobjPaperEN">表实体类对象</param>
  */
    public async GetDataFromPaperClass(pobjPaperEN: clsPaperEN) {
        this.paperId = pobjPaperEN.paperId;// 论文Id
        this.paperTitle = pobjPaperEN.paperTitle;// 论文标题
        this.paperContent = pobjPaperEN.paperContent;// 主题内容
        this.periodical = pobjPaperEN.periodical;// 期刊
        this.author = pobjPaperEN.author;// 作者
        this.researchQuestion = pobjPaperEN.researchQuestion;// 研究问题
        //this.updDate = pobjPaperEN.updDate;// 修改日期
        this.updUser = pobjPaperEN.updUser;// 修改用户Id
        this.memo = pobjPaperEN.memo;// 备注
        this.keyword = pobjPaperEN.keyword;// 关键字
        this.literatureSources = pobjPaperEN.literatureSources;// 文献来源
        this.literatureLink = pobjPaperEN.literatureLink;// 文献链接
        this.literatureTypeId = pobjPaperEN.literatureTypeId;//文献类型；
        $("#hdnpic").val(pobjPaperEN.uploadfileUrl);
        this.isQuotethesis = pobjPaperEN.isQuotethesis;// 是否引用论文
        this.shareId = pobjPaperEN.shareId;
        this.quoteId = pobjPaperEN.quoteId;// 引用Id
        this.isChecked = pobjPaperEN.isChecked;// 是否检查
        this.checker = pobjPaperEN.checker;// 审核人
        setTextboxio();

        if (pobjPaperEN.paperTypeId != "") {
            if (pobjPaperEN.paperTypeId == "02") {
                $("#ddlPaperTypeId").attr("disabled", true);
                $("#ddlPaperStatusId").attr("disabled", false); //原创论文可以修改 论文状态；
            }
            else {
                $("#ddlPaperTypeId").attr("disabled", true);
                $("#ddlPaperStatusId").attr("disabled", true);
            }

        }
    }


 //   /* 根据条件获取相应的记录对象的列表
 //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 //*/
 //   public async BindGv_vPaper() {
 //       var strListDiv: string = this.divName4DataList;
 //       var strWhereCond = await this.CombinevPaperCondition();
 //       var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 //       var arrPaperExObjLst: Array<clsPaperENEx> = [];
 //       try {
 //           this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
 
 //           });
 //           var objPagerPara: stuPagerPara = {
 //               pageIndex: intCurrPageIndex,
 //               pageSize: this.pageSize,
 //               whereCond: strWhereCond,
 //               orderBy: PaperCRUD.sortPaperBy,
 //               sortFun: (x, y) => { return 0; }
 //           };
 //           const responseObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara).then((jsonData) => {
 //               arrPaperExObjLst = <Array<clsPaperEN>>jsonData;
 //           });

 //           ////绑定专业论文
 //           //const gvResultMajor = await this.BindGv_vPaperMajor();
 //           ////绑定方向论文
 //           //const gvResultDirection = await this.BindGv_vPaperDirection();

 //       }
 //       catch (e) {
 //           console.error('catch(e)=');
 //           console.error(e);
 //           var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
 //           alert(strMsg);
 //       }
 //       //if (arrPaperExObjLst.length == 0) {
 //       //    var strMsg: string = `根据条件获取的对象列表数为空！`;
 //       //console.error(strMsg);
 //       //    alert(strMsg);
 //       //    return;
 //       //}
 //       try {
 //           this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
 //           console.log("完成BindGv_vPaper!");
 //       }
 //       catch (e) {
 //           console.error('catch(e)=');
 //           console.error(e);
 //           var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
 //           alert(strMsg);
 //       }
 //   }

    /* 显示vPaper对象的所有属性值
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
   <param name = "divContainer">显示容器</param>
   <param name = "arrPaperObjLst">需要绑定的对象列表</param>
 */
    //public async BindTab_vPaper(divContainer: string, arrPaperExObjLst: Array<clsPaperENEx>) {
    //    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
    //    if (o == null) {
    //        alert(`${divContainer}不存在！`);
    //        return;
    //    }
    //    var arrDataColumn: Array<clsDataColumn> =
    //        [
    //            {
    //                fldName: "",
    //                colHeader: "",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "CheckBox",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "paperTitle",
    //                colHeader: "论文标题",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            //{
    //            //    fldName: "paperTitle",
    //            //    colHeader: "论文标题",
    //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Label",
    //            //    orderNum: 1,
    //            //    funcName: (strKeyId: string, strText: string) => {
    //            //        var a1: HTMLElement = document.createElement("Label");
    //            //        a1.innerText = strText;
    //            //        a1.className = "btn btn-outline-info";
    //            //        a1.setAttribute("onclick", `btnDetailRecordInTab_Click('${strKeyId}');`);
    //            //        return a1;
    //            //    }
    //            //},                
    //            {
    //                fldName: "periodical",
    //                colHeader: "期刊",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "author",
    //                colHeader: "作者",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            //{
    //            //    fldName: "researchQuestion",
    //            //    colHeader: "研究问题",
    //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Label",
    //            //    orderNum: 1,
    //            //    funcName: () => { }
    //            //},

    //            {
    //                fldName: "keyword",
    //                colHeader: "关键字",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "literatureSources",
    //                colHeader: "文献来源",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            //{
    //            //    fldName: "literatureLink",
    //            //    colHeader: "文献链接",
    //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Label",
    //            //    orderNum: 1,
    //            //    funcName: () => { }
    //            //},
    //            //{
    //            //    fldName: "uploadfileUrl",
    //            //    colHeader: "文件地址",
    //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Label",
    //            //    orderNum: 1,
    //            //    funcName: () => { }
    //            //},
    //            //{
    //            //    fldName: "checker",
    //            //    colHeader: "审核人",
    //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Label",
    //            //    orderNum: 1,
    //            //    funcName: () => { }
    //            //},
    //            {
    //                fldName: "isChecked",
    //                colHeader: "是否检查",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            //{
    //            //    fldName: "isQuotethesis",
    //            //    colHeader: "是否引用论文",
    //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Label",
    //            //    orderNum: 1,
    //            //    funcName: () => { }
    //            //},
    //            {
    //                fldName: "updDate",
    //                colHeader: "提交日期",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "userName",
    //                colHeader: "提交用户",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "pcount",
    //                colHeader: "读写数",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "attachmentCount",
    //                colHeader: "附件数",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "",
    //                colHeader: "详情",
    //                text: "详情",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Button",
    //                orderNum: 1,
    //                funcName: (strKeyId: string, strText: string) => {
    //                    var btn1: HTMLElement = document.createElement("button");
    //                    btn1.innerText = strText;
    //                    btn1.className = "btn btn-outline-info btn-sm";
    //                    btn1.setAttribute("onclick", `btnDetailRecordInTab_Click("${strKeyId}");`);
    //                    return btn1;
    //                }
    //            },
    //            //{
    //            //    fldName: "",
    //            //    colHeader: "删除",
    //            //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Button",
    //            //    orderNum: 1,
    //            //    funcName: (strKeyId: string, strText: string) => {
    //            //        var btn1: HTMLElement = document.createElement("button");
    //            //        btn1.innerText = strText;
    //            //        btn1.className = "btn btn-outline-info";
    //            //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
    //            //        return btn1;
    //            //    }
    //            //},
    //        ];
    //    BindTab(o, arrPaperExObjLst, arrDataColumn, "paperId", this);
    //    this.objPager.recCount = this.recCount;
    //    this.objPager.pageSize = this.pageSize;
    //    this.objPager.ShowPagerV2(this, this.divName4Pager);
    //}



    /*
  * 修改用户Id
 */
    public set updUser(value: string) {
        $("#hidUserId").val(value);
    }
    /*
    * 修改用户Id
   */
    public get updUser(): string {
        return clsPublocalStorage.userId;
    }


    //论文审核
    public async btnAudit_Click(strKeyId: string) {

        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要审核的记录！");
            return;
        }

        this.SubmitRecord(strKeyId);

    }
    //审核判断；
    public async SubmitRecord(strPaperId: string) {

        this.keyId = strPaperId;
 
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;

                
                    var strUserId = clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage.roleId;

                    //判断角色 //学生00620003
                    if (strRoleId == "00620003") {

                        // //通过判断数据用户是否是当前登录用户；
                        if (objPaperEN.updUser == strUserId) {

                            //判断数据是否已审核
                            if (objPaperEN.isChecked == false) {

                                const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                    //var returnBool: boolean = jsonData;
                                    //if (returnBool == true) {
                                    //    HideDialog();
                                    //    this.BindGv_vPaperReadWrite();
                                    //}
                                });
                            }
                            else {
                                alert("当前数据已审核！");
                                return;
                            }


                        }
                        else {
                            alert("当前数据不是您所添加，不能修改！");
                            return;
                        }
                    }
                    else {

                        //可以提交
                        //判断数据是否已提交
                        if (objPaperEN.isChecked == false) {

                            const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                            });
                        }
                        else {
                            alert("当前数据已审核！");
                            return;
                        }
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
    public async SubmitRecordSave(): Promise<boolean> {
        const strThisFuncName = this.SubmitRecordSave.name;
        //
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId(this.keyId);
        //设置提交状态；
        objPaperEN.SetIsChecked(true);
        this.PutDataToPaperClassAudit(objPaperEN);
        objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `论文审核成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                        HideDialog();
                        //this.BindGv_vPaper();
                        this.iShowList.BindGv(clsPaperEN._CurrTabName, returnBool.toString());
                    }
                    else {
                        var strInfo: string = `论文审核不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("审核失败");
                    }
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `修改记录不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
*/
    public PutDataToPaperClassAudit(pobjPaperEN: clsPaperEN) {
        //pobjPaperReadWriteEN.SetPaperRWId(this.paperRWId;// 论文读写Id
        pobjPaperEN.SetIsChecked(true);
        pobjPaperEN.SetChecker(clsPublocalStorage.userId);//提交人；
    }
  



    /* 显示vXzMajorDirection对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrXzMajorDirectionObjLst">需要绑定的对象列表</param>
*/
    //public async BindTab_vXzMajorDirection(divContainer: string, arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN>) {
    //    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
    //    if (o == null) {
    //        alert(`${divContainer}不存在！`);
    //        return;
    //    }
    //    var arrDataColumn: Array<clsDataColumn> =
    //        [
    //            {
    //                fldName: "",
    //                colHeader: "",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "CheckBox",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "majorDirectionId",
    //                colHeader: "研究方向Id",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "majorName",
    //                colHeader: "专业名称",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "majorDirectionName",
    //                colHeader: "研究方向名",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "MajorDirectionENName",
    //                colHeader: "研究方向英文名",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "updDate",
    //                colHeader: "修改日期",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "updUser",
    //                colHeader: "修改人",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "",
    //                colHeader: "确定",
    //                text: "确定",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Button",
    //                orderNum: 1,
    //                funcName: (strKeyId: string, strText: string) => {
    //                    var btn1: HTMLElement = document.createElement("button");
    //                    btn1.innerText = strText;
    //                    btn1.className = "btn btn-outline-info";
    //                    btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
    //                    return btn1;
    //                }
    //            },
    //            //{
    //            //    fldName: "",
    //            //    colHeader: "删除",
    //            //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Button",
    //            //    orderNum: 1,
    //            //    funcName: (strKeyId: string, strText: string) => {
    //            //        var btn1: HTMLElement = document.createElement("button");
    //            //        btn1.innerText = strText;
    //            //        btn1.className = "btn btn-outline-info";
    //            //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
    //            //        return btn1;
    //            //    }
    //            //},
    //        ];
    //    BindTab_V(o, arrvXzMajorDirectionObjLst, arrDataColumn, "majorDirectionId", this);
    //    this.objPager.recCount = this.recCount;
    //    this.objPager.pageSize = this.pageSize;
    //    this.objPager.ShowPagerV2(this, this.divName4Pager);
    //}

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
                window.location.href = "../GraduateEdu/PaperAddXzmajorRela?paperId=" + strPaperId;
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

    ///* 函数功能:在数据 列表中跳转到某一页
    //   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    //   <param name = "intPageIndex">页序号</param>
    // */
    //public IndexPageOne(intPageIndex) {
    //    if (intPageIndex == 0) {
    //        intPageIndex = this.objPager.pageCount;
    //    }
    //    console.log("跳转到" + intPageIndex + "页");
    //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
    //    this.BindGv_vXzMajorDirection();
    //}
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


    /*
  * 设置上传文件
  */
    public set Uploadfile(value: string) {
        $("#txtUploadfile").val(value);
    }
    /*
    * 获取上传文件
    */
    public get Uploadfile(): string {
        return $("#txtUploadfile").val();
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
        //this.updDate = "";
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
        $('#ddlLiteratureTypeId option[0]').attr("selected", true);
        this.Uploadfile = "";
        $("#hdnFileOne").val("");
        $("#hdnFileTwo").val("");
        $("#hdnFileThree").val("");
        $('#ddlPaperTypeId option[0]').attr("selected", true);
        $('#ddlPaperStatusId option[0]').attr("selected", true);


    }
    //屏蔽控件
    public Disabled_true() {
        $("#txtPaperTitle").attr("disabled", true);
        $("#txtPaperContent").attr("disabled", true);

        $("#txtPeriodical").attr("disabled", true);
        $("#txtAuthor").attr("disabled", true);
        $("#txtResearchQuestion").attr("disabled", true);
        $("#txtKeyword").attr("disabled", true);
        $("#ddlLiteratureTypeId").attr("disabled", true);

        $("#txtLiteratureSources").attr("disabled", true);
        $("#txtLiteratureLink").attr("disabled", true);

        $("#txtLiteratureLink").attr("disabled", true);
        $("#txtLiteratureLink").attr("disabled", true);

        $("#ddlPaperTypeId").attr("disabled", true);
        $("#ddlPaperStatusId").attr("disabled", true);
    }

    //开放控件
    public Disabled_false() {
        $("#txtPaperTitle").attr("disabled", false);
        $("#txtPaperContent").attr("disabled", false);

        $("#txtPeriodical").attr("disabled", false);
        $("#txtAuthor").attr("disabled", false);
        $("#txtResearchQuestion").attr("disabled", false);
        $("#txtKeyword").attr("disabled", false);
        $("#ddlLiteratureTypeId").attr("disabled", false);

        $("#ddlPaperTypeId").attr("disabled", false);
        $("#ddlPaperStatusId").attr("disabled", true);


        $("#txtLiteratureSources").attr("disabled", false);
        $("#txtLiteratureLink").attr("disabled", false);

        $("#txtLiteratureLink").attr("disabled", false);
        $("#txtLiteratureLink").attr("disabled", false);
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
  * 论文类型
  */
    public set paperTypeId(value: string) {
        $("#ddlPaperTypeId").val(value);
    }
    /*
    * 论文类型
    */
    public get paperTypeId(): string {
        return $("#ddlPaperTypeId").val();
    }

    /*
 * 论文状态
 */
    public set paperStatusId(value: string) {
        $("#ddlPaperStatusId").val(value);
    }
    /*
    * 论文状态
    */
    public get paperStatusId(): string {
        return $("#ddlPaperStatusId").val();
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

}