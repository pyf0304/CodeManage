
/**
* 类名:Paper_EditEx(界面:PaperCRUD)
* 表名:Paper(01120535)
* 版本:2023.01.08.1(服务器:WIN-SRV103-116)
* 日期:2023/01/09 01:17:25
* 生成者:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:研培论文(GraduateEduPaper)
* 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
import { Paper_Edit } from "../PagesBase/GraduateEduPaper/Paper_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsgs_PaperAttentionEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
import { clsgs_PaperGroupEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { clsgs_PaperVerEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js";
import { clsMajorDirectionPaperRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { gs_PaperAttention_AddNewRecordAsync, gs_PaperAttention_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { gs_PaperGroup_AddNewRecordWithReturnKeyAsync, gs_PaperGroup_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js";
import { gs_PaperVer_AddNewRecordAsync, gs_PaperVer_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { MajorDirectionPaperRela_AddNewRecordAsync, MajorDirectionPaperRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js";
import { PaperAttachment_AddNewRecordAsync, PaperAttachment_DelPaperAttachmentsByCondAsync, PaperAttachment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { Paper_AddNewRecordAsync, Paper_AddNewRecordWithReturnKeyAsync, Paper_GetMaxStrIdAsync, Paper_GetObjByPaperIdAsync, Paper_GetRecCountByCondAsync, Paper_IsExistAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { PaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
declare function setTextboxio(): void;
declare function HideDialogOne(): void;

/* Paper_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class Paper_EditEx extends Paper_Edit {


    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    **/
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnEdit_Click.name;
        const objPage = Paper_EditEx.objPage_Edit;
        switch (strCommandName) {
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(Paper_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }
    /* 添加新记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
*/
    public async btnAddNewRecord_Click() {

        this.opType = "Add";
        try {
            //var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
            //const ddl_gs_Share = await gs_Share_BindDdl_ShareId_Cache("ddlShareId", objgs_Share_Cond);
            const gvBindDdl = await this.BindDdl4EditRegionInDiv();
            const responseText = await this.AddNewRecord();
            //获取分享Id
            const responseText1 = await gs_UserConfigEx_GetNewReturnShareIdEx("01", clsPublocalStorage.userId);
            var strShareId: string = responseText1;
            //var returnBool: boolean = !!responseText2;
            if (strShareId != "") {
                this.shareId = strShareId;
            }
            //因为是初次添加所以只显示 基本信息；否则2个信息都显示；
            $("#liextendEdit").attr("style", "display:none;");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
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
    /* 为插入记录做准备工作 设置相关操作；
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
  */
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_Paper = "确认添加";
        this.btnCancel_Paper = "取消添加";
        this.Clear();
        this.Disabled_false();
        //$('#btnOKUpd').attr("disabled", false);
        //wucPaperB1.paperId = clsPaperBL.GetMaxStrId_S();

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

            //先判断数据论文标题是否重名
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

                //return true;
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
        if (clsPublocalStorage.userId != "") {
            var strCommandText: string = this.btnSubmit_Paper;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,

                        var returnBool: boolean = true;
                        //const responseText2 = await this.AddNewRecordWithMaxIdSaveRetrunId AddNewRecordSave().then((jsonData) => {
                        //    returnBool = jsonData;

                        //});
                        const responseText2 = await this.AddNewRecordWithMaxIdSaveRetrunId().then((jsonData) => {
                        });
                        if (returnBool == true) {
                            //添加成功后统计附件数量到论文表
                            const responseText3 = await this.AddAttachmentCount();


                            //添加记录的同时添加历史版本 判断只有原创论文才记录历史版本
                            if (this.paperTypeId == "02") {
                                const responseText6 = await this.AddVersionRecordSave().then((jsonData) => {
                                    var returnBool: boolean = jsonData;
                                    if (returnBool == true) {

                                        //alert("添加历史版本出问题！");
                                    }
                                });
                            }
                            //同时把数据同步到数据总表
                            var strPaperId = $("#hidPaperId").val();
                            const responseText2 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strPaperId, "01", "1", clsPublocalStorage.id_CurrEduCls);
                            var returnBool2: boolean = !!responseText2;
                            if (returnBool2 == true) {
                                console.log("论文数据总表同步成功；");
                            }
                            else {
                                console.log("论文数据总表同步失败；");
                            }

                            //添加完自动关注该论文
                            var strPaperId = $("#hidPaperId").val();
                            const responseText4 = await this.btnAttention_Click(strPaperId);
                            var returnBool4: boolean = !!responseText4;
                            if (returnBool4 == true) {
                                console.log("论文关注成功；");
                            }
                            else {
                                console.log("论文关注失败；");
                            }


                            var strInfo: string = `添加记录成功!`;
                            alert(strInfo);
                            this.Clear();
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        var returnBool: boolean = true;
                        const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;

                        });
                        if (returnBool == true) {
                            //判断只有原创论文才记录历史版本
                            if (this.paperTypeId == "02") {
                                const responseText6 = await this.AddVersionRecordSave().then((jsonData) => {
                                    var returnBool: boolean = jsonData;
                                    if (returnBool == true) {

                                        //alert("添加历史版本出问题！");
                                    }
                                });
                            }
                            //把数据更新到总表
                            var strPaperId = $("#hidPaperId").val();
                            const responseText2 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strPaperId, "01", "2", clsPublocalStorage.id_CurrEduCls);
                            var returnBool2: boolean = !!responseText2;
                            if (returnBool2 == true) {
                                console.log("论文数据总表同步成功；");
                            }
                            else {
                                console.log("论文数据总表同步失败；");
                            }

                            //修改成功后删除附件并添加新的附件
                            const responseText5 = await this.DelOldfileAddNewfile();
                            //修改成功后统计附件数量到论文表
                            const responseText6 = await this.AddAttachmentCount();
                            var strInfo: string = `修改记录成功!`;
                            alert(strInfo);
                            this.Disabled_false();
                            this.Clear();
                        }
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                        alert(strMsg);
                        break;
                }
                //取消提交按钮不可用状态
                $("#divLoading").hide();
                $("#btnOKUpd").attr("disabled", false);

            }
            catch (e) {
                var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        } else {
            $("#btnOKUpd").attr("disabled", false);
            alert("用户session丢失，请重新登录！");

        }
    }


    //统计附件数量并添加到论文表
    public async AddAttachmentCount() {
        const strThisFuncName = this.AddAttachmentCount.name;

        //添加记录的同时并记录论文的读写数
        //  var strPaperId = $('#txtPaperId').val();
        var strPaperId = $("#hidPaperId").val();
        var strWhereCond2 = " 1=1 and paperId='" + strPaperId + "'";
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
            HideDialog();
            this.iShowList.BindGv(clsPaperEN._CurrTabName, "");

            $("#divLoading").hide();
            //显示信息框
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
        //创建时间
        objPaperEN.SetCreateDate(clsPubFun4Web.getNowDate_ymd());
        const responseText02 = await this.PutDataToPaperClass(objPaperEN);
        try {
            const responseText03 = await Paper_IsExistAsync(objPaperEN.paperId);
            var bolIsExist: boolean = responseText03;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objPaperEN.paperId}已经存在！`;
                alert(strMsg);
                return responseText03;//一定要有一个返回值，否则会出错！
            }

            let strCondition = Format(" 1 = 1 and paperTitle = '{0}' and paperId in (select paperId from PaperEduClsRela where id_CurrEduCls = '{1}')",
                this.paperTitle, clsPublocalStorage.id_CurrEduCls);

            var intPaperCount = await Paper_GetRecCountByCondAsync(strCondition);
            if (intPaperCount != 0) {
                var strMsg: string = `添加记录时，当前教学班论文标题：${objPaperEN.paperTitle}已经存在，请重新命名！`;
                alert(strMsg);
                return false;//一定要有一个返回值，否则会出错！
            }

            const responseText05 = await Paper_AddNewRecordAsync(objPaperEN);
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
        const responseText1 = await this.PutDataToPaperAttachmentClass(objPaperAttachmentEN, filePath);
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



    public async PutDataToPaperAttachmentClass(pobjPaperAttachmentEN: clsPaperAttachmentEN, filePath: string) {

        pobjPaperAttachmentEN.SetPaperId($("#hidPaperId").val());// 论文Id
        var strfilePath = filePath;
        var index = strfilePath.lastIndexOf("\/");
        strfilePath = strfilePath.substring(index + 1, strfilePath.length);
        pobjPaperAttachmentEN.SetFilePath(filePath);
        pobjPaperAttachmentEN.SetPaperAttachmentName(strfilePath);

        pobjPaperAttachmentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjPaperAttachmentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班
        pobjPaperAttachmentEN.SetUpdUserId(clsPublocalStorage.userId);// 修改用户Id


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


                var strWhereCond2 = " 1=1 and paperId='" + strPaperId + "'";
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
        //this.updUser = "";
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

    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjPaperEN">数据传输的目的类对象</param>
  */
    public async PutDataToPaperClass(pobjPaperEN: clsPaperEN) {

        //pobjPaperEN.SetPaperId(this.paperId;// 论文Id
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
        //pobjPaperEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls;
        pobjPaperEN.SetQuoteId(this.quoteId);// 引用Id
        pobjPaperEN.SetIsChecked(this.isChecked);// 是否检查
        pobjPaperEN.SetChecker(this.checker);// 审核人
        pobjPaperEN.SetShareId(this.shareId);

        pobjPaperEN.SetPaperTypeId("01");// 论文类型  该页面默认状态为01
        pobjPaperEN.SetPaperStatusId(this.paperStatusId);// 论文状态
        pobjPaperEN.SetIsPublic(true);//引用论文 默认为true
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
        //this.updUser = pobjPaperEN.updUser;// 修改用户Id
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
        this.paperTypeId = pobjPaperEN.paperTypeId;// 论文类型
        this.paperStatusId = pobjPaperEN.paperStatusId;// 论文状态
        this.shareId = pobjPaperEN.shareId;



        setTextboxio();

        if (pobjPaperEN.isSubmit == true) {
            this.Disabled_true();
        }
        else {
            this.Disabled_false();
        }

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
    public async DelOldfileAddNewfile() {

        try {
            //得到相关论文附件地址，判断是否为空
            if ($("#hdnFileOne").val() != "" || $("#hdnFileTwo").val() != "" || $("#hdnFileThree").val() != "") {
                //根据Id删除附件
                var strwhere = "paperId ='" + this.keyId + "'";
                const responseText1 = await this.DelRecordByWhere(strwhere);

            }
            //不管是否有数据删除 都需要执行附件添加功能
            //判断是否有返回的附件路径值
            //判断是否有返回的附件路径值
            if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                var fileOne = $("#hdnFileOne").val();
                const responseText2 = await this.AddNewRecordPaperAttachmentSave(fileOne, "first");
                var returnBool2: boolean = !!responseText2;
                if (returnBool2 != true) {
                    var strInfo: string = `修改记录成功,但添加附件失败，请修改该条数据重新上传附件!`;
                    alert(strInfo);
                    return "";
                }
            }
            else {
                if ($("#hdnFileTwo").val() != "") {
                    var fileTwo = $("#hdnFileTwo").val();
                    const responseText3 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                }
                else {
                    if ($("#hdnFileThree").val() != "") {
                        var fileThree = $("#hdnFileThree").val();
                        const responseText4 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                    }
                }

            }


        }
        catch (e) {
            var strInfo: string = `修改记录不成功!`;
            $('#lblResult44').val(strInfo);
            //显示信息框
            alert(strInfo);
            console.log("完成UpdateRecordSave");
        }

    }

    /* 
   根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
  */
    public async DelRecordByWhere(strWhere: string) {

        try {
            const returnInt = await PaperAttachment_DelPaperAttachmentsByCondAsync(strWhere);
            if (returnInt > 0) {

                //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                ////显示信息框
                //alert(strInfo);
                console.log("删除附件成功,共删除" + returnInt + "条记录!");
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                //alert(strInfo);
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



    /* 根据关键字获取相应的记录的对象
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
    <param name = "sender">参数列表</param>
  */
    public async UpdateRecord(strPaperId: string) {
        const strThisFuncName = this.UpdateRecord.name;
        this.btnSubmit_Paper = "确认修改";
        this.btnCancel_Paper = "取消修改";
        this.keyId = strPaperId;

        try {
            const objPaperEN = await Paper_GetObjByPaperIdAsync(strPaperId);

            if (objPaperEN == null) {
                const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }


            $("#btnOKUpd").show();
            $("#btnCancel").show();
            ShowDialog('Update');
            this.GetDataFromPaperClass(objPaperEN);
            $("#txtPaperTitle").attr("disabled", true);
            console.log("完成UpdateRecord!");

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }

    //添加关注
    public async btnAttention_Click(strPaperId: string) {
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
                this.iShowList.BindGv(clsPaperEN._CurrTabName, "");
                //    this.BindGv_vPaper();
                //    layui_Alert(1, "已关注！")
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



    /* 修改记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
  */
    public async btnUpdateRecord_Click(strKeyId: string) {
        const gvBindDdl = await this.BindDdl4EditRegionInDiv();

        this.opType = "Update";
        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }

        this.UpdateRecord(strKeyId);
        //因为是修改2个信息都显示；
        $("#liextendEdit").attr("style", "display:block;");
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public async UpdateRecordSave() {
        const strThisFuncName = this.UpdateRecordSave.name;

        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId(this.keyId);
        $("#hidPaperId").val(this.keyId);
        const responseText01 = await this.PutDataToPaperClass(objPaperEN);
        objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            var returnBool: boolean = true;
            const responseText02 = await Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                returnBool = jsonData;
            });
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }

    }

    //审核判断；
    public async SubmitRecord(strPaperId: string) {

        this.keyId = strPaperId;

        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;

                    //通过session 权限获取权限

                    //判断角色 //学生00620003
                    if (clsPublocalStorage.roleId == "00620003") {

                        // //通过判断数据用户是否是当前登录用户；
                        if (objPaperEN.updUser == clsPublocalStorage.userId) {

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
    /* 论文审核
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
                        //刷新缓存
                        PaperEx_ReFreshThisCacheById_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
                        HideDialog();
                        //this.BindGv_vPaper();
                        this.iShowList.BindGv(clsPaperEN._CurrTabName, "");
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


    //论文审核
    public async btnAudit_Click(strKeyId: string) {

        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (IsNullOrEmpty(strKeyId) == true) {
            alert("请选择需要审核的记录！");
            return;
        }

        this.SubmitRecord(strKeyId);

    }



    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjMajorDirectionPaperRelaEN">数据传输的目的类对象</param>
  */
    public PutDataToMajorDirectionPaperRelaClass(pobjMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN) {
        var strMajorDirectionId = $("#hidMajorDirectionId").val();
        //var strViewpointId = $("#hidPaperId").val();
        //var strUserId = clsPublocalStorage.userId;

        pobjMajorDirectionPaperRelaEN.SetMajorDirectionId(strMajorDirectionId);// 研究方向Id
        pobjMajorDirectionPaperRelaEN.SetPaperId($("#hidPaperId").val());// 论文Id
        pobjMajorDirectionPaperRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjMajorDirectionPaperRelaEN.SetUpdUser(clsPublocalStorage.userId);// 修改人

        pobjMajorDirectionPaperRelaEN.SetMemo(this.memo);// 备注
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
    //用来选择专业记录方法；
    public btnOkInTab_Click(strKeyId: string) {
        $('#hidMajorDirectionId').val(strKeyId);//专业方向
        this.AddNewRecordSaveMajorDirection();
    }
}