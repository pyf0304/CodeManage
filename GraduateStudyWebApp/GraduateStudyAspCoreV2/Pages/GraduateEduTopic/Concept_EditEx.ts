
/**
* 类名:Concept_EditEx(界面:ConceptCRUD)
* 表名:Concept(01120602)
* 版本:2023.01.04.1(服务器:WIN-SRV103-116)
* 日期:2023/01/06 15:36:29
* 生成者:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:研培主题(GraduateEduTopic)
* 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
import { Concept_Edit } from "../PagesBase/GraduateEduTopic/Concept_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsConceptAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptAttachmentEN.js";
import { clsConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js";
import { clsConceptVerEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptVerEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { ConceptAttachment_AddNewRecordAsync, ConceptAttachment_DelConceptAttachmentsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptAttachmentWApi.js";
import { ConceptVer_AddNewRecordAsync, ConceptVer_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptVerWApi.js";
import { Concept_AddNewRecordAsync, Concept_GetMaxStrIdAsync, Concept_GetObjByConceptIdAsync, Concept_IsExistAsync, Concept_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js";
import { vConcept_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
declare var window;

/* Concept_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class Concept_EditEx extends Concept_Edit {


    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    **/
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnEdit_Click.name;
        const objPage = Concept_EditEx.objPage_Edit;
        switch (strCommandName) {
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(Concept_EditEx.btn_Click)中没有被处理！";
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
            var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
            const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4Edit, "ddlShareId");
            const responseText = await this.AddNewRecord();
            //获取分享Id
            const responseText1 = await gs_UserConfigEx_GetNewReturnShareIdEx("06", clsPublocalStorage.userId);
            var strShareId: string = responseText1;
            //var returnBool: boolean = !!responseText2;
            if (strShareId != "") {
                this.shareId = strShareId;
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 为插入记录做准备工作
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
 */
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_Concept = "确认添加";
        this.btnCancel_Concept = "取消添加";
        this.Clear();
        //去掉提交按钮不可用状态
        $('#btnOKUpd').attr("disabled", false);
        //wucConceptB1.conceptId = clsConceptBL.GetMaxStrId_S();
    }
    /* 添加新记录，保存函数
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 */
    public async AddNewRecordSave() {
        try {
            const responseText = await Concept_GetMaxStrIdAsync().then((jsonData) => {
                var returnString: string = jsonData.toString();
                if (returnString == "") {
                    var strInfo: string = `获取表ViewPoint的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtConceptId').val(returnString);
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        if ($('#txtConceptId').val() != "") {
            
            var objConceptEN: clsConceptEN = new clsConceptEN();
            objConceptEN.SetCreateDate(clsPubFun4Web.getNowDate_ymd());
            var strConceptId = $('#txtConceptId').val();
            $('#hidConceptId').val(strConceptId);

            this.PutDataToConceptClass(objConceptEN);
            try {
                const responseText = await Concept_IsExistAsync(objConceptEN.conceptId);
                var bolIsExist: boolean = responseText;
                if (bolIsExist == true) {
                    var strMsg: string = `添加记录时，关键字：${objConceptEN.conceptId}已经存在！`;
                    alert(strMsg);
                    return responseText;//一定要有一个返回值，否则会出错！
                }
                const responseText2 = await Concept_AddNewRecordAsync(objConceptEN);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {

                    ////添加引用论文之前需要判断是否有引用论文；有则执行论文添加、没有则执行附件；
                    //if ($("#txtPaperId").val() == "") {
                    //添加成功，则执行附件添加方法；
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
                    //}
                    //else {

                    //    //1.这里执行添加观点引用论文；
                    //    var objclsConceptCitationEN: clsConceptCitationEN = new clsConceptCitationEN();
                    //    this.PutDataToclsConceptCitationClass(objclsConceptCitationEN);
                    //    //引用论文；
                    //    const responseText3 = await ConceptCitation_AddNewRecordAsync(objclsConceptCitationEN);
                    //    var returnBool: boolean = !!responseText3;

                    //    if (returnBool == true) {




                    //    }
                    //    else {

                    //    }
                    //}
                    this.iShowList.BindGv_Cache(clsConceptEN._CurrTabName, "");
                    // Concept_ReFreshCache();
                    //const arrConcept_Cache = await Concept_GetObjLstAsync("1=1");
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

        } else {
            var strInfo: string = `获取最大关键字为空，不成功!`;
            //显示信息框
            alert(strInfo);

        }
        return true;//一定要有一个返回值，否则会出错！
    }


    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjConceptEN">数据传输的目的类对象</param>
   */
    public PutDataToConceptVClass(pobjConceptVerEN: clsConceptVerEN) {

        var strUserId = clsPublocalStorage.userId;
        pobjConceptVerEN.SetConceptId(this.conceptId);// 概念Id
        pobjConceptVerEN.SetConceptContent(this.conceptContent);// 概念内容
        pobjConceptVerEN.SetConceptName(this.conceptName);// 概念名称

        pobjConceptVerEN.SetCitationId(this.paperId);//引用论文Id；
        pobjConceptVerEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjConceptVerEN.SetUpdUser(strUserId);// 修改用户Id
        pobjConceptVerEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjConceptVerEN.SetMemo(this.memo);// 备注
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjConceptEN">数据传输的目的类对象</param>
   */
    public async PutDataToConceptClass(pobjConceptEN: clsConceptEN) {

        var strUserId = clsPublocalStorage.userId;
        pobjConceptEN.SetConceptId(this.conceptId);// 概念Id
        pobjConceptEN.SetConceptContent(this.conceptContent);// 概念内容
        pobjConceptEN.SetConceptName(this.conceptName);// 概念名称
        pobjConceptEN.SetIsSubmit(false);// 是否提交
        pobjConceptEN.SetCitationId(this.paperId);//引用论文Id；
        pobjConceptEN.SetShareId(this.shareId);
        pobjConceptEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjConceptEN.SetUpdUser(strUserId);// 修改用户Id
        pobjConceptEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjConceptEN.SetMemo(this.memo);// 备注
    }




    ///////////////////////////////////////////////////////////////////////////////////////////////修改时的方法
    /* 修改记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async UpdateRecordSave(): Promise<boolean> {
        const strThisFuncName = this.UpdateRecordSave.name;


        var objConceptEN: clsConceptEN = new clsConceptEN();
        objConceptEN.SetConceptId(this.keyId);

        $('#hidConceptId').val(this.keyId);

        this.PutDataToConceptClass(objConceptEN);
        objConceptEN.sfUpdFldSetStr = objConceptEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }

        try {
            const returnBool = await Concept_UpdateRecordAsync(objConceptEN);
            if (returnBool == true) {

                ////判断引用的论文ID是否为空
                //var strPaperId = $("#txtPaperId").val();
                //if (strPaperId != "") {
                //    //，如果不为空，根据Id删除引用文件
                //    var strwhere = "conceptId ='" + objConceptEN.conceptId + "'";
                //    this.DelRecordViewpointCitationByWhere(strwhere);

                //}
                //else {

                //如果等于空，那么就去判断附件是否为空；
                //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                    //根据Id删除附件
                    var strwhere = "conceptId ='" + objConceptEN.conceptId + "'";
                    this.DelRecordByWhere(strwhere);

                }
                //}




                var strInfo: string = `修改记录成功!`;
                $('#lblResult51').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `修改记录不成功!`;
                $('#lblResult51').val(strInfo);
                //显示信息框
                alert(strInfo);
                console.log("完成UpdateRecordSave");
            }

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


    //添加历史版本
    public async AddVersionRecordSave() {
        const strThisFuncName = this.AddVersionRecordSave.name;

        var objConceptVerEN: clsConceptVerEN = new clsConceptVerEN();
        objConceptVerEN.SetConceptId(this.conceptId);
        this.PutDataToConceptVClass(objConceptVerEN);

        try {
            const responseText2 = await ConceptVer_AddNewRecordAsync(objConceptVerEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                var strWhereCond2 = " 1 =1 and conceptId=" + this.conceptId;
                var intVersionCount = await ConceptVer_GetRecCountByCondAsync(strWhereCond2);


                var objConceptEN: clsConceptEN = new clsConceptEN();
                objConceptEN.SetConceptId(this.conceptId);
                objConceptEN.SetVersionCount(intVersionCount);


                objConceptEN.sfUpdFldSetStr = objConceptEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }


                const responseText = Concept_UpdateRecordAsync(objConceptEN).then((jsonData) => {
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


    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
   具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
 */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnSubmit_Concept;
        try {
            if (clsPublocalStorage.userId != "") {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        //if (this.opType == "AddWithMaxId") {
                        //    const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                        //        var returnBool2: boolean = jsonData;
                        //        if (returnBool2 == true) {
                        //            HideDialog();
                        //            this.BindGv_Concept_Cache();
                        //        }
                        //    });
                        //}
                        //else {

                        //}
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                            }
                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；
                        var strSubViewpointId = $('#hidConceptId').val();
                        const responseText6 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSubViewpointId, "06", "1", clsPublocalStorage.id_CurrEduCls);
                        var returnBool6: boolean = !!responseText6;
                        if (returnBool6 == true) {
                            console.log("论文子观点数据总表同步成功；");
                        }
                        else {
                            console.log("论文子观点数据总表同步失败；");
                        }
                        //修改记录的同时添加历史版本
                        const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                vConcept_ReFreshThisCache(clsPublocalStorage.id_CurrEduCls);
                                HideDialog();
                                this.iShowList.BindGv_Cache(clsConceptEN._CurrTabName, "");
                                //alert("添加历史版本出问题！");
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                //Concept_ReFreshCache();
                                //const arrConcept_Cache = Concept_GetObjLstAsync("1=1");

                            }
                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；
                        var strSubViewpointId = $('#hidConceptId').val();
                        const responseText7 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSubViewpointId, "06", "2", clsPublocalStorage.id_CurrEduCls);
                        var returnBool7: boolean = !!responseText7;
                        if (returnBool7 == true) {
                            console.log("论文子观点数据总表同步成功；");
                        }
                        else {
                            console.log("论文子观点数据总表同步失败；");
                        }
                        //修改记录的同时添加历史版本
                        const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                vConcept_ReFreshThisCache(clsPublocalStorage.id_CurrEduCls);
                                this.iShowList.BindGv_Cache(clsConceptEN._CurrTabName, "");
                                //alert("添加历史版本出问题！");
                            }
                        });
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

    /* 根据关键字获取相应的记录的对象
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
    <param name = "sender">参数列表</param>
  */
    public async UpdateRecord(strConceptId: string): Promise<boolean> {
        const strThisFuncName = this.UpdateRecord.name;
        this.btnSubmit_Concept = "确认修改";
        this.btnCancel_Concept = "取消修改";
        this.keyId = strConceptId;
        var strUserId = clsPublocalStorage.userId;

        try {
            const objConceptEN = await Concept_GetObjByConceptIdAsync(strConceptId);
            if (objConceptEN == null) {
                const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }

            // //通过判断数据用户是否是当前登录用户；
            if (objConceptEN.updUser == strUserId) {

                //判断数据是否提交，提交则不可修改；
                if (objConceptEN.isSubmit == false) {
                    ShowDialog('Update');
                    this.GetDataFromConceptClass(objConceptEN);
                    console.log("完成UpdateRecord!");

                }
                else {
                    alert("当前数据已提交,不能修改！");
                    return false;
                }

            }
            else {
                alert("当前数据不是您所添加，不能修改！");
                return false;
            }
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }
    /* 函数功能:把类对象的属性内容显示到界面上
  注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
   如果在设置数据库时,就应该一级字段在前,二级字段在后
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
   <param name = "pobjConceptEN">表实体类对象</param>
 */
    public GetDataFromConceptClass(pobjConceptEN: clsConceptEN) {
        this.conceptId = pobjConceptEN.conceptId;// 概念Id
        this.conceptContent = pobjConceptEN.conceptContent;// 概念内容
        this.conceptName = pobjConceptEN.conceptName;// 概念名称
        this.isSubmit = pobjConceptEN.isSubmit;// 是否提交
        this.paperId = pobjConceptEN.citationId;//引用论文Id
        this.shareId = pobjConceptEN.shareId;
        this.updDate = pobjConceptEN.updDate;// 修改日期
        this.updUser = pobjConceptEN.updUser;// 修改用户Id
        this.memo = pobjConceptEN.memo;// 备注
    }
    //概念提交审核
    public async btnIsSubmit_Click(strKeyId: string) {

        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        const responseText1 = await this.SubmitRecord(strKeyId);
        this.iShowList.BindGv_Cache(clsConceptEN._CurrTabName, strKeyId);

    }
    //提交判断；
    public async SubmitRecord(strConceptId: string) {

        this.keyId = strConceptId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = Concept_GetObjByConceptIdAsync(strConceptId).then((jsonData) => {
                    var objConceptEN: clsConceptEN = <clsConceptEN>jsonData;

                    //通过session 权限获取权限
                    var strUserId = clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage.roleId;

                    //判断角色 //学生00620003
                    if (strRoleId == "00620003") {

                        // //通过判断数据用户是否是当前登录用户；
                        if (objConceptEN.updUser == strUserId) {

                            //判断数据是否已审核
                            if (objConceptEN.isSubmit == false) {

                                const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                });
                            }
                            else {
                                alert("当前数据已提交！");
                                return;
                            }
                        }
                        else {
                            alert("当前数据不是您所添加，不能提交！");
                            return;
                        }
                    }
                    else {

                        //可以提交
                        //判断数据是否已提交
                        if (objConceptEN.isSubmit == false) {

                            const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                            });
                        }
                        else {
                            alert("当前数据已提交！");
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
        var objConceptEN: clsConceptEN = new clsConceptEN();
        objConceptEN.SetConceptId(this.keyId);
        objConceptEN.SetIsSubmit(true);
        // this.PutDataToConceptClass(objConceptEN);
        objConceptEN.sfUpdFldSetStr = objConceptEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Concept_UpdateRecordAsync(objConceptEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `提交成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                        HideDialog();
                        vConcept_ReFreshThisCache(clsPublocalStorage.id_CurrEduCls);
                        this.iShowList.BindGv_Cache(clsConceptEN._CurrTabName, "");
                    }
                    else {
                        var strInfo: string = `提交不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("提交失败");
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
    //取消提交
    public async btnCancelSubmit_Click(strKeyId: string) {
        var strUserId = clsPublocalStorage.userId;
        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要取消的记录！");
            return;
        }

        try {
            this.CancelSubmitRecordSave(strKeyId);

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*取消论文
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async CancelSubmitRecordSave(strKeyId: string) {
        const strThisFuncName = this.CancelSubmitRecordSave.name;
        //
        var objConceptEN: clsConceptEN = new clsConceptEN();
        objConceptEN.SetConceptId(strKeyId);
        objConceptEN.SetIsSubmit(false);
        //objPaperEN..submitter = clsPublocalStorage.userId;//提交人；
        objConceptEN.sfUpdFldSetStr = objConceptEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }

        try {
            const responseText = Concept_UpdateRecordAsync(objConceptEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {
                    var strInfo: string = `取消成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    vConcept_ReFreshThisCache(clsPublocalStorage.id_CurrEduCls);
                    //HideDialog();
                    this.iShowList.BindGv_Cache(clsConceptEN._CurrTabName, "");
                }
                else {
                    var strInfo: string = `取消不成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("取消失败");
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `取消记录不成功,${e}.`;
            alert(strMsg);
        }

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


    /* 在数据表里修改记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
  */
    public async btnUpdateRecordInTab_Click(strKeyId: string) {
        this.opType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
        const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4Edit, "ddlShareId");
        this.UpdateRecord(strKeyId);
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

    //////////////////////////////////////////////////////////////////////附件添加
    //添加上传论文附件方法
    public async AddNewRecordobjPaperSubAttachmentENSave(filePath: string, strfileNum: string) {
        var objConceptAttachmentEN: clsConceptAttachmentEN = new clsConceptAttachmentEN();
        this.PutDataToPaperAttachmentClass(objConceptAttachmentEN, filePath);
        try {
            const responseText2 = await ConceptAttachment_AddNewRecordAsync(objConceptAttachmentEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
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

    //观点附件数据存放
    public PutDataToPaperAttachmentClass(pobjConceptAttachmentEN: clsConceptAttachmentEN, filePath: string) {
        pobjConceptAttachmentEN.SetConceptId($("#txtConceptId").val());// 概念Id

        var strfilePath = filePath;
        //判断地址不为空则执行截取操作
        if (strfilePath != "") {
            var index = strfilePath.lastIndexOf("\/");
            strfilePath = strfilePath.substring(index + 1, strfilePath.length);
            pobjConceptAttachmentEN.SetFilePath(filePath);

            pobjConceptAttachmentEN.SetConceptAttachmentName(strfilePath);
        }
        pobjConceptAttachmentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期

        pobjConceptAttachmentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班
        pobjConceptAttachmentEN.SetUpdUserId(clsPublocalStorage.userId);// 修改用户Id
    }

    /*
 * 论文Id
*/
    public set paperId(value: string) {
        $("#txtPaperId").val(value);
    }
    /*
    * 论文
   */
    public get paperId(): string {
        return $("#txtPaperId").val();
    }
    //删除观点附件
    /* 
根据关键字删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public DelRecordByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = ConceptAttachment_DelConceptAttachmentsByCondAsync(strWhere).then((jsonData) => {
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
}