
/**
* 类名:SysSocialRelations_EditEx(界面:SysSocialRelationsCRUD)
* 表名:SysSocialRelations(01120644)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/08 00:34:37
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
import { clsRTSysSocialRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTSysSocialRelaEN.js";
import { clsSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { RTSysSocialRela_AddNewRecordAsync, RTSysSocialRela_GetRecCountByCondAsync, RTSysSocialRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js";
import { SysSocialRelations_GetMaxStrIdAsync, SysSocialRelations_GetObjBySocialIdAsync, SysSocialRelations_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
declare function HideDialog(): void;
declare function HideDialogTen(): void;

declare var window;
declare var $;
/* SysSocialRelations_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class SysSocialRelations_EditEx_Research extends SysSocialRelations_Edit {


    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    **/
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnEdit_Click.name;
        const objPage = SysSocialRelations_EditEx_Research.objPage_Edit;
        switch (strCommandName) {
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(SysSocialRelations_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
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
        pobjSysSocialRelationsEN.SetDetailedDescription(this.detailedDescription);// 详细说明
        pobjSysSocialRelationsEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjSysSocialRelationsEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjSysSocialRelationsEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjSysSocialRelationsEN.SetIsSubmit(this.isSubmit);// 是否提交
        pobjSysSocialRelationsEN.SetMemo(this.memo);// 备注
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
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnBool2: string = <string>jsonData;
                                if (IsNullOrEmpty( returnBool2 )== false) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsvSysSocialRelationsEN._CurrTabName, returnBool2);
                                }
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




    //确定选择的观点 并添加到关系表中
    public btnOkRTSysSocialRelaInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidSocialId").val(strkeyId)
        //执行添加关系方法
        this.AddNewRecordSave();
    }


    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjRTSysSocialRelaEN">数据传输的目的类对象</param>
*/
    public PutDataToRTSysSocialRelaClass(pobjRTSysSocialRelaEN: clsRTSysSocialRelaEN) {
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strUserId = clsPublocalStorage.userId;
        var strSocialId = $("#hidSocialId").val();
        pobjRTSysSocialRelaEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjRTSysSocialRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTSysSocialRelaEN.SetSocialId(strSocialId);// 社会Id
        pobjRTSysSocialRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTSysSocialRelaEN.SetUpdUser(strUserId);// 修改人
        pobjRTSysSocialRelaEN.SetMemo(this.memo);// 备注
        pobjRTSysSocialRelaEN.SetClassificationId("0000000000");// 分类为000000
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        const strThisFuncName = this.AddNewRecordSave.name;

        
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strSocialId = $("#hidSocialId").val();
        var strUserId = clsPublocalStorage.userId;
        var objRTSysSocialRelaEN: clsRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
        this.PutDataToRTSysSocialRelaClass(objRTSysSocialRelaEN);
        try {

            //同一用户，同一主题 同一技能 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And socialId = '" + strSocialId + "' And updUser = '" + strUserId + "'";
            const responseText = await RTSysSocialRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题同一个用户不能重复添加同一个关系！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            else {
                const responseText2 = await RTSysSocialRela_AddNewRecordAsync(objRTSysSocialRelaEN);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
                    var strInfo: string = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);



                    //根据ID获取最大数；
                    var strWhereCond2 = " 1 =1 and socialId=" + strSocialId;
                    var intCitationCount = await RTSysSocialRela_GetRecCountByCondAsync(strWhereCond2);


                    var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
                    objSysSocialRelationsEN.SetSocialId(strSocialId);
                    objSysSocialRelationsEN.SetCitationCount(intCitationCount);

                    objSysSocialRelationsEN.sfUpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
                    if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                         throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }

                    const responseText = await SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN).then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {


                        }
                        else {
                            var strInfo: string = `操作不成功!`;
                            alert(strInfo);
                            console.log("操作不成功");
                        }

                    });


                    //显示信息框
                    alert(strInfo);
                    HideDialogTen();
                }
                else {
                    var strInfo: string = `添加记录不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
            }



            return responseText;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
    }


}