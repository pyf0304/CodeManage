
 /**
 * 类名:SysSocialRelations_EditEx(界面:SysSocialRelationsCRUD)
 * 表名:SysSocialRelations(01120644)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/07 23:56:29
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
 * 编程语言:TypeScript
 **/
import { SysSocialRelations_Edit } from "../PagesBase/GraduateEduTopic/SysSocialRelations_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsSysSecurityLevelEN } from "../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js";
import { SysSocialRelations_AddNewRecordWithReturnKeyAsync, SysSocialRelations_GetMaxStrIdAsync, SysSocialRelations_GetObjBySocialIdAsync, SysSocialRelations_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { SysSecurityLevel_BindDdl_LevelIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
declare var window;
declare var $;
 /* SysSocialRelations_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class SysSocialRelations_EditEx extends SysSocialRelations_Edit
{
    public Id_CurrEduCls: string = "";

 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 **/
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnEdit_Click.name;
const objPage = SysSocialRelations_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
objPage.btnSubmit_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(SysSocialRelations_EditEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}


    /* 函数功能:为编辑区绑定下拉框
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
      */
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面
        var objSysSecurityLevel_Cond: clsSysSecurityLevelEN = new clsSysSecurityLevelEN();//编辑区域
        const ddlLevelId = await SysSecurityLevel_BindDdl_LevelIdInDiv_Cache(this.divName4Edit, "ddlLevelId");//编辑区域

        var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
        const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4Edit, "ddlShareId");
    }
    /* 添加新记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
  */
    public async btnAddNewRecord_Click() {
        this.opType = "Add";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Add');
                this.bolIsLoadEditRegion = true;  //
                //获取分享Id
                const responseText1 = await gs_UserConfigEx_GetNewReturnShareIdEx("10", clsPublocalStorage.userId);
                var strShareId: string = responseText1;
                //var returnBool: boolean = !!responseText2;
                if (strShareId != "") {
                    this.shareId = strShareId;
                }
                const responseText = this.AddNewRecord();
            }
            else {
                ShowDialog('Add');
                const responseText = await this.AddNewRecord();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }
    /*取消
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async CancelSubmitRecordSave(strKeyId: string) {
        const strThisFuncName = this.CancelSubmitRecordSave.name;

        //
        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
        objSysSocialRelationsEN.SetSocialId(strKeyId);
        objSysSocialRelationsEN.SetIsSubmit(false);
        objSysSocialRelationsEN.sfUpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }

        try {
            const responseText = SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {
                    var strInfo: string = `取消成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);

                    //HideDialog();
                    this.iShowList.BindGv(clsvSysSocialRelationsEN._CurrTabName, returnBool.toString());
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
    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
*/
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnSubmit_Click.name;
        try {
            if (clsPublocalStorage.userId != "") {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            //    var returnBool2: boolean = jsonData;
                            //    if (returnBool2 == true) {
                            //        HideDialog();
                            //        this.iShowList.BindGv(clsvSysSocialRelationsEN._CurrTabName, returnBool.toString());
                            //    }
                            //});
                            const responseText2 = await this.AddNewRecordWithReturnKeyAsync().then((jsonData) => {

                                HideDialog();
                                this.iShowList.BindGv(clsvSysSocialRelationsEN._CurrTabName, "");
                            });

                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsvSysSocialRelationsEN._CurrTabName, returnBool.toString());
                                }
                            });
                        }
                        //更新总表3个参数 主键、子表类型、页面操作类型；

                        var strSocialId = $("#hidSocialId").val();
                        const responseText8 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSocialId, "10", "1", clsPublocalStorage.id_CurrEduCls);
                        var returnBool8: boolean = !!responseText8;
                        if (returnBool8 == true) {
                            console.log("社会关系数据总表同步成功；");
                        }
                        else {
                            console.log("社会关系数据总表同步失败；");
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In SysSocialRelationsCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog();
                                this.iShowList.BindGv(clsvSysSocialRelationsEN._CurrTabName, returnBool.toString());
                            }
                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；

                        var strSocialId = $("#hidSocialId").val();
                        const responseText9 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSocialId, "10", "2", clsPublocalStorage.id_CurrEduCls);
                        var returnBool9: boolean = !!responseText9;
                        if (returnBool9 == true) {
                            console.log("社会关系数据总表同步成功；");
                        }
                        else {
                            console.log("社会关系数据总表同步失败；");
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
            $('#btnOKUpd').attr("disabled", "false");
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

    /* 修改记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async UpdateRecordSave() {
        const strThisFuncName = this.UpdateRecordSave.name;


        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
        objSysSocialRelationsEN.SetSocialId(this.keyId);
        $("#hidSocialId").val(this.keyId);
        this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
        objSysSocialRelationsEN.sfUpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
            }
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
    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
  */
    public async AddNewRecordWithReturnKeyAsync() {
        
        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
        objSysSocialRelationsEN.SetCreateDate(clsPubFun4Web.getNowDate_ymd());
        this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
        try {
            const responseText2 = await SysSocialRelations_AddNewRecordWithReturnKeyAsync(objSysSocialRelationsEN);//.AddNewRecordWithMaxIdAsync(objSysSocialRelationsEN);
            var strSocialId: string = responseText2.toString();
            if (strSocialId != "") {
                $("#hidSocialId").val(strSocialId);
                var strInfo: string = `添加记录成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
                return true;
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return strSocialId;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        // return true;//一定要有一个返回值，否则会出错！
    }
    /* 为插入记录做准备工作
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
*/
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        $('#btnOKUpd').attr("disabled", "false");
        this.opType = "AddWithMaxId";

        this.btnSubmit_SysSocialRelations = "确认添加";
        this.btnCancel_SysSocialRelations = "取消添加";
        this.Clear();
        //wucSysSocialRelationsB1.socialId = clsSysSocialRelationsBL.GetMaxStrId_S();
        try {
            const responseText = await SysSocialRelations_GetMaxStrIdAsync();
            var returnString: string = responseText;
            if (returnString == "") {
                var strInfo: string = `获取表SysSocialRelations的最大关键字为空，不成功，请检查!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                $('#txtSocialId').val(returnString);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.SetKeyReadOnly(false);
        $('#btnOKUpd').attr("disabled", "false");
        this.opType = "AddWithMaxId";

        this.btnSubmit_SysSocialRelations = "确认添加";
        this.btnCancel_SysSocialRelations = "取消添加";
        this.Clear();
        //wucSysSocialRelationsB1.socialId = clsSysSocialRelationsBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjSysSocialRelationsEN">数据传输的目的类对象</param>
*/
    public async PutDataToSysSocialRelationsClass(pobjSysSocialRelationsEN: clsSysSocialRelationsEN) {
        pobjSysSocialRelationsEN.SetSocialId(this.socialId);// 社会Id
        pobjSysSocialRelationsEN.SetFullName(this.fullName);// 姓名
        pobjSysSocialRelationsEN.SetNationality(this.nationality);// 国籍
        pobjSysSocialRelationsEN.SetLevelId(this.levelId);// 级别Id
        pobjSysSocialRelationsEN.SetWorkUnit(this.workUnit);// 工作单位
        pobjSysSocialRelationsEN.SetMajor(this.major);// 专业
        pobjSysSocialRelationsEN.SetAchievement(this.achievement);// 成就
        pobjSysSocialRelationsEN.SetShareId(this.shareId);
        pobjSysSocialRelationsEN.SetDetailedDescription(this.detailedDescription);// 详细说明
        pobjSysSocialRelationsEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjSysSocialRelationsEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjSysSocialRelationsEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjSysSocialRelationsEN.SetIsSubmit(this.isSubmit);// 是否提交
        pobjSysSocialRelationsEN.SetMemo(this.memo);// 备注
    }
    /* 函数功能:把类对象的属性内容显示到界面上
   注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
    如果在设置数据库时,就应该一级字段在前,二级字段在后
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
    <param name = "pobjSysSocialRelationsEN">表实体类对象</param>
  */
    public GetDataFromSysSocialRelationsClass(pobjSysSocialRelationsEN: clsSysSocialRelationsEN) {
        this.socialId = pobjSysSocialRelationsEN.socialId;// 社会Id
        this.fullName = pobjSysSocialRelationsEN.fullName;// 姓名
        this.nationality = pobjSysSocialRelationsEN.nationality;// 国籍
        this.levelId = pobjSysSocialRelationsEN.levelId;// 级别Id
        this.workUnit = pobjSysSocialRelationsEN.workUnit;// 工作单位
        this.major = pobjSysSocialRelationsEN.major;// 专业
        this.achievement = pobjSysSocialRelationsEN.achievement;// 成就
        this.detailedDescription = pobjSysSocialRelationsEN.detailedDescription;// 详细说明
        this.shareId = pobjSysSocialRelationsEN.shareId;
        this.updUser = pobjSysSocialRelationsEN.updUser;// 修改人
        this.updDate = pobjSysSocialRelationsEN.updDate;// 修改日期
        this.isSubmit = pobjSysSocialRelationsEN.isSubmit;// 是否提交
        this.memo = pobjSysSocialRelationsEN.memo;// 备注
    }

    //概念提交审核
    public async btnIsSubmit_Click(strKeyId: string) {

        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        this.SubmitRecord(strKeyId);

    }
    //提交判断；
    public async SubmitRecord(strSocialId: string) {

        this.keyId = strSocialId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = SysSocialRelations_GetObjBySocialIdAsync(strSocialId).then((jsonData) => {
                    var objSysSocialRelationsEN: clsSysSocialRelationsEN = <clsSysSocialRelationsEN>jsonData;

                    //通过session 权限获取权限
                    var strUserId = clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage.roleId;

                    //判断角色 //学生00620003
                    if (strRoleId == "00620003") {
                        // //通过判断数据用户是否是当前登录用户；
                        if (objSysSocialRelationsEN.updUser == strUserId) {
                            //判断数据是否已审核
                            if (objSysSocialRelationsEN.isSubmit == false) {
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
                        if (objSysSocialRelationsEN.isSubmit == false) {
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
        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
        objSysSocialRelationsEN.SetSocialId(this.keyId);
        objSysSocialRelationsEN.SetIsSubmit(true);
        objSysSocialRelationsEN.sfUpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `提交成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                        HideDialog();
                        this.iShowList.BindGv(clsvSysSocialRelationsEN._CurrTabName, returnBool.toString());
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