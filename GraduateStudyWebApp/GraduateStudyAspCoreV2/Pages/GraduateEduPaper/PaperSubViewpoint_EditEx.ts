

import { PaperSubViewpoint_pdf } from "../GraduateEduEx/PaperSubViewpoint_pdf.js";
import { PaperSubViewpoint_Edit } from "../PagesBase/GraduateEduPaper/PaperSubViewpoint_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperSubAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js";
import { clsPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js";
import { clsSubViewpointTypeEN, enumSubViewpointType } from "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js";
import { PaperSubAttachment_AddNewRecordAsync, PaperSubAttachment_DelPaperSubAttachmentsByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js";
import { PaperSubViewpoint_GetUniCondStr_PaperRWId_SubViewpointTypeId_SubViewpointContent, PaperSubViewpoint_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js";
import { SubViewpointType_GetFirstObjAsync } from "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js";
import { PaperSubViewpointEx_AddNewRecordWithReturnKeyAsyncEx, PaperSubViewpointEx_UpdateRecordAsyncEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsPaperSubViewpointExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
/* PaperSubViewpoint_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class PaperSubViewpoint_EditEx extends PaperSubViewpoint_Edit {


    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    **/
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnEdit_Click.name;
        const objPage = PaperSubViewpoint_EditEx.objPage_Edit;
        switch (strCommandName) {
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(PaperSubViewpoint_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }
    /* 函数功能:把界面上的属性数据传到类对象中
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
   <param name = "pobjPaperSubViewpointEN">数据传输的目的类对象</param>
 */
    public async PutDataToPaperSubViewpointClass(pobjPaperSubViewpointEN: clsPaperSubViewpointEN) {
        pobjPaperSubViewpointEN.SetPaperRWId($("#hidPaperRWId").val());// 论文读写Id
        const strPaperId = $("#hidPaperId").val();
        pobjPaperSubViewpointEN.SetPaperId(strPaperId);//论文Id
        pobjPaperSubViewpointEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//论文Id
        pobjPaperSubViewpointEN.SetUserId(clsPublocalStorage.userId);//论文Id
        pobjPaperSubViewpointEN.SetShareId(this.shareId);//论文Id
        pobjPaperSubViewpointEN.SetAttitudesId(this.attitudesId);//论文Id

        pobjPaperSubViewpointEN.SetSectionId(this.sectionId);//节
        pobjPaperSubViewpointEN.SetSubViewpointTypeId(this.subViewpointTypeId);// 类型Id
        pobjPaperSubViewpointEN.SetRWTitle(this.rwTitle);// 读写标题

        pobjPaperSubViewpointEN.SetSubViewpointContent(this.subViewpointContent);// 详情内容
        pobjPaperSubViewpointEN.SetExplainTypeId(this.explainTypeId);// 说明类型Id
        pobjPaperSubViewpointEN.SetExplainContent(this.explainContent);// 说明内容
        pobjPaperSubViewpointEN.SetIsPublic(this.isPublic);// 是否公开
        pobjPaperSubViewpointEN.SetLiteratureSourcesId(this.literatureSourcesId);// 文献来源
        pobjPaperSubViewpointEN.SetPageNumber(this.pageNumber);// 页码

        if (this.orderNum == 0) {
            pobjPaperSubViewpointEN.SetOrderNum(30);
        }
        else {
            pobjPaperSubViewpointEN.SetOrderNum(this.orderNum);// 序号
        }

        pobjPaperSubViewpointEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id

        //pobjPaperSubViewpointEN.SetUpdUser(clsPublocalStorage.userId;// 修改用户Id
        pobjPaperSubViewpointEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjPaperSubViewpointEN.SetMemo(this.memo);// 备注
    }
    public Clear() {
        //this.paperRWId = "";
        $('#ddlSectionId option[0]').attr("selected", true);
        $('#ddlSubViewpointTypeId option[0]').attr("selected", true);
        //this.rwTitle = "";
        this.subViewpointContent = "";
        $('#ddlExplainTypeId option[0]').attr("selected", true);
        this.explainContent = "";
        this.isPublic = false;
        this.literatureSourcesId = "";
        this.pageNumber = 0;
        this.orderNum = 0;
        this.Uploadfile = "";
        //this.updUser = "";
        //this.updDate = "";
        this.memo = "";
        $("#hdnFileOne").val("");
        $("#hdnFileTwo").val("");
        $("#hdnFileThree").val("");
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



    /* 为插入记录做准备工作
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
  */
    public async AddNewRecord() {
        this.btnSubmit_PaperSubViewpoint = "确认添加";
        this.btnCancel_PaperSubViewpoint = "取消添加";
        this.Clear();
        //wucPaperSubViewpointB1.subViewpointId = clsPaperSubViewpointBL.GetMaxStrId_S();
    }

    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public async btnUpdateRecordInTab_Click(strKeyId: string) {
        this.opType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        this.Clear();
        var lngKeyId = strKeyId;
        this.UpdateRecord(lngKeyId);
    }

    /** 函数功能:为编辑区绑定下拉框
* (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
**/
    public async BindDdl4EditRegionInDiv() {
        const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
        // 在此处放置用户代码以初始化页面

        const strPaperId = $("#hidPaperId").val();
        //const strPaperId = PaperSubViewpoint_Edit.PaperId_Static;


        await this.SetDdl_SectionIdInDiv(strPaperId);//编辑区域

        await this.SetDdl_SubViewpointTypeIdInDiv();//编辑区域

        await this.SetDdl_ExplainTypeIdInDiv();//编辑区域

        await this.SetDdl_ShareIdInDiv();//编辑区域

        await this.SetDdl_AttitudesIdInDiv();//编辑区域
    }
    /**添加 */
    public async btnAddNewRecord_Click() {
        this.opType = "Add";
        try {
            if (IsNullOrEmpty(this.subViewpointTypeId) == true) this.subViewpointTypeId = enumSubViewpointType.QuestioningProcess_00000001;
            this.selectTitle_Click();
            this.Clear();
            this.BindDdl4EditRegionInDiv();
            const responseText = await this.AddNewRecord();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }



    public async selectTitle_Click() {
        const strThisFuncName = this.selectTitle_Click.name;
        try {


            var strWhereCond = " subViewpointTypeId='" + this.subViewpointTypeId + "'";
            const objSubViewpointType = await SubViewpointType_GetFirstObjAsync(strWhereCond);
            if (objSubViewpointType == null) {
                const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }


            this.rwTitle = objSubViewpointType.defaTitle;

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取记录不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
  */
    public async btnSubmit_Click() {
        this.divName4Edit = "divEditRegion";
        var strCommandText: string = this.btnSubmit_PaperSubViewpoint;
        let returnBool;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    returnBool = await this.AddNewRecordSaves();


                    //var returnBool: boolean = jsonData;
                    //if (returnBool == true) {
                    HideDialog();
                    //this.btnReOrder_Click();
                    //this.BindGv_vPaperSubViewpoint();
                    this.iShowList.BindGv(clsPaperSubViewpointEN._CurrTabName, "");
                    // }

                    //var returnBool: boolean = jsonData;
                    //if (returnBool == true) {
                    //    HideDialog();
                    //    this.BindGv_vPaperSubViewpoint();
                    //}

                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    returnBool = await this.UpdateRecordSave();
                    if (returnBool == true) {
                        HideDialog();
                        this.iShowList.BindGv(clsPaperSubViewpointEN._CurrTabName, "");

                    }

                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`
                    alert(strMsg);
                    break;
            }
            if (returnBool == true) {
                $('#div_PaperDetail').show();
                $('#divQuery').show();
                $('#div_SubViewpointList').show();
                $('#divEditRegion').hide();
                $("#btnSubmit_PaperSubViewpoint").attr("disabled", false);          
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
    public async AddNewRecordSaves() {
        //
        var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
        this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        try {
            if (IsNullOrEmpty(objPaperSubViewpointEN.paperRWId) == true) objPaperSubViewpointEN.paperRWId = "00000000";
            //const responseText2 = await PaperSubViewpoint_AddNewRecordAsync(objPaperSubViewpointEN);
            const strUniCondition = PaperSubViewpoint_GetUniCondStr_PaperRWId_SubViewpointTypeId_SubViewpointContent(objPaperSubViewpointEN);
            const bolIsExist = await PaperSubViewpoint_IsExistRecordAsync(strUniCondition);
            if (bolIsExist == true) {
                var strMsg: string = `详情内容:[${objPaperSubViewpointEN.subViewpointContent}]已经存在，不能再添加！`;
                alert(strMsg);
                return false;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await PaperSubViewpointEx_AddNewRecordWithReturnKeyAsyncEx(objPaperSubViewpointEN);

            var returnString: string = responseText2.toString();
            if (returnString != "") {

                //存放主键；
                $("#hidKeyId").val(returnString);

                //判断是否有返回的附件路径值
                if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    var fileOne = $("#hdnFileOne").val();
                    this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                }
                else {
                    if ($("#hdnFileTwo").val() != "") {
                        var fileTwo = $("#hdnFileTwo").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    }
                    else {
                        if ($("#hdnFileThree").val() != "") {
                            var fileThree = $("#hdnFileThree").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }

                }

                var strInfo: string = `添加记录成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.Clear();
                return responseText2;//一定要有一个返回值，否则会出错！
            }

  
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            this.Clear();
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }


    //添加上传论文附件方法
    public async AddNewRecordobjPaperSubAttachmentENSave(filePath: string, strfileNum: string) {
        var objPaperSubAttachmentEN: clsPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
        this.PutDataToPaperAttachmentClass(objPaperSubAttachmentEN, filePath);
        try {
            const responseText2 = await PaperSubAttachment_AddNewRecordAsync(objPaperSubAttachmentEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //var returnKeyId: string = responseText2;
                //if (returnKeyId != "") {
                //存放返回主键
                //  $("#hidKeyId").val(returnKeyId);
                //第一个附件
                if (strfileNum == "first") {
                    //如果第二个附件不等于空，那么执行添加函数；
                    if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                        var fileTwo = $("#hdnFileTwo").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    }
                    else {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }
                }
                else if (strfileNum == "two") {
                    //为空则判断第三个附件值；
                    if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                        var fileThree = $("#hdnFileThree").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
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
        }
        return true;//一定要有一个返回值，否则会出错！
    }
    public PutDataToPaperAttachmentClass(pobjPaperSubAttachmentEN: clsPaperSubAttachmentEN, filePath: string) {
        pobjPaperSubAttachmentEN.SetSubViewpointId($("#hidKeyId").val());// 论文Id

        var strfilePath = filePath;
        //判断地址不为空则执行截取操作
        if (strfilePath != "") {
            var index = strfilePath.lastIndexOf("\/");
            strfilePath = strfilePath.substring(index + 1, strfilePath.length);
            pobjPaperSubAttachmentEN.SetFilePath(filePath);

            pobjPaperSubAttachmentEN.SetPaperSubAttachmentName(strfilePath);
        }
        pobjPaperSubAttachmentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期



        pobjPaperSubAttachmentEN.SetUpdUserId(clsPublocalStorage.userId);// 修改用户Id


    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public async UpdateRecordSave(): Promise<boolean> {
        const strThisFuncName = this.UpdateRecordSave.name;
        
        var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
        objPaperSubViewpointEN.SetSubViewpointId(this.keyId);
        this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        objPaperSubViewpointEN.sfUpdFldSetStr = objPaperSubViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubViewpointEx_UpdateRecordAsyncEx(objPaperSubViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //存放主键;
                        $("#hidKeyId").val(objPaperSubViewpointEN.subViewpointId);
                        //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                        if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            //根据Id删除附件
                            var strwhere = "subViewpointId ='" + objPaperSubViewpointEN.subViewpointId + "'";
                            this.DelRecordByWhere(strwhere);

                        }

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
 根据关键字删除记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public DelRecordByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubAttachment_DelPaperSubAttachmentsByCondAsync(strWhere).then((jsonData) => {
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

                    //在修改时候，不管是否有附件数据被清除； 都需要执行附件添加功能
                    //判断是否有返回的附件路径值
                    var fileOne = $("#hdnFileOne").val();
                    if (fileOne != "" && fileOne != undefined) { //第一个附件框判断

                        this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                    }
                    else {
                        var fileTwo = $("#hdnFileTwo").val();
                        if (fileTwo != "" && fileTwo != undefined) {

                            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            var fileThree = $("#hdnFileThree").val();
                            if (fileThree != "" && fileThree != undefined) {

                                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
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


    /* 函数功能:系统生成的Change事件函数
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript+<>c__DisplayClass9_0:<Gen_WApi_Ts_GeneEventFuncEx>b__1)
   */
    public async ddlSubViewpointTypeId_SelectedIndexChanged() {
        const strThisFuncName = this.ddlSubViewpointTypeId_SelectedIndexChanged.name;
        /*alert('请在扩展层:PaperSubViewpoint_EditExEx中重写该函数！');*/
        const strSubViewpointTypeId = this.subViewpointTypeId;
        if (IsNullOrEmpty(strSubViewpointTypeId) == false) this.selectTitle_Click();
    }


    /*
 提交编辑
(AutoGCLib.WA_ViewScript_TS4CSharp:Gen_WApi_JS_mySubmit)
*/
    public mySubmit(pstrOp: string) {
        this.divName4Edit = "divEditRegion";
        //$("#btnSubmit_PaperSubViewpoint").attr("disabled", true);
        console.error("已经进入mySubmit", pstrOp);
        if ($("#hidUserInfo").val() != "") {
            if (IsNullOrEmpty(this.shareId) == true || this.shareId == "0") {
                alert('分享不能为空!');
                return;
            }
            else {
                //GetPaperRWId();
                //调用附件验证；
                //var bolIsExist = await IsHasFile();
                //console.error("bolIsExist:", bolIsExist);
                //if (bolIsExist == false) {
                
                let objPage: PaperSubViewpoint_pdf = new PaperSubViewpoint_pdf();
                const objPage_Edit: PaperSubViewpoint_EditEx = new PaperSubViewpoint_EditEx(objPage);

                objPage_Edit.btnSubmit_Click();

                //    $('#div_PaperDetail').show();
                //    $('#divQuery').show();
                //    $('#div_SubViewpointList').show();
                //    $('#divEditRegion').hide();
                //}
            }
        } else {
            $("#btnSubmit_PaperSubViewpoint").attr("disabled", false);
            alert("用户session丢失，请重新登录！");
        }


    }

}