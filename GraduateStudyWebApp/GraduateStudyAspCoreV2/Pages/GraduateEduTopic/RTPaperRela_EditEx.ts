
 /**
 * 类名:RTPaperRela_EditEx(界面:RTPaperRelaCRUD)
 * 表名:RTPaperRela(01120581)
 * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/06 22:44:09
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
 * 编程语言:TypeScript
 **/
import { RTPaperRela_Edit } from "../PagesBase/GraduateEduTopic/RTPaperRela_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js";
import { clsvRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { Paper_GetObjByPaperIdAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { RTPaperRela_AddNewRecordAsync, RTPaperRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js";
import { vRTPaperRela_GetObjBymIdAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { PaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
declare function HideDialogThree(): void;
 /* RTPaperRela_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class RTPaperRela_EditEx extends RTPaperRela_Edit
{
    public static Paper_Static = "";

 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 **/
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnEdit_Click.name;
const objPage = RTPaperRela_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
objPage.btnSubmit_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(RTPaperRela_EditEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}

    /* 根据关键字获取相应的记录的对象
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
<param name = "sender">参数列表</param>
*/
    public async RtPaperRelaDetailRecord(lngmId: number) {
        //获取用户缓存数据
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        this.keyId = lngmId.toString();
        return new Promise((resolve, reject) => {
            try {
                const responseText = vRTPaperRela_GetObjBymIdAsync(lngmId).then((jsonData) => {
                    var objRTPaperRelaEN: clsvRTPaperRelaEN = <clsvRTPaperRelaEN>jsonData;
                    // //显示当前数据；
                    $("#txtTopicNameDetail").html(objRTPaperRelaEN.topicName);
                    $("#txtTopicContentDetail").html(objRTPaperRelaEN.topicContent);

                    $("#txtTopicProposePeopleDetail").html(objRTPaperRelaEN.topicProposePeople);
                    $("#txtPaperTitleDetail").html(objRTPaperRelaEN.paperTitle);
                    $("#txtPaperContentDetail").html(objRTPaperRelaEN.paperContent);
                    $("#txtAuthorDetail").html(objRTPaperRelaEN.author);
                    $("#txtPeriodicalDetail").html(objRTPaperRelaEN.periodical);
                    var objUser = arrUsers.find(x => x.userId == objRTPaperRelaEN.updUser);
                    if (objUser != null) {
                        $("#txtUserNameDetail").html(objUser.userName);
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

    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjRTPaperRelaEN">数据传输的目的类对象</param>
*/
    public async PutDataToRTPaperRelaClass(pobjRTPaperRelaEN: clsRTPaperRelaEN) {
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strPaperId = RTPaperRela_EditEx.Paper_Static;
        var strUserId = clsPublocalStorage.userId;
        pobjRTPaperRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTPaperRelaEN.SetPaperId(strPaperId);// 论文Id
        pobjRTPaperRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTPaperRelaEN.SetUpdUser(strUserId);// 修改人
        pobjRTPaperRelaEN.SetMemo(this.memo);// 备注
    }

    public async SubmitPaperRecord(strPaperId: string) {

        this.keyId = strPaperId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;

                    //通过session 权限获取权限
                    var strUserId = clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage.roleId;

                    // //通过判断数据用户是否是当前登录用户；
                    if (objPaperEN.updUser == clsPublocalStorage.userId) {
                        //判断数据是否已审核
                        if (objPaperEN.isSubmit == false) {
                            const responseText3 = this.SubmitPaperRecordSave().then((jsonData) => {

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
    public async SubmitPaperRecordSave(): Promise<boolean> {
        const strThisFuncName = this.SubmitPaperRecordSave.name;

        //
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId(this.keyId);
        //设置提交状态；
        objPaperEN.SetIsSubmit(true);
        //this.PutDataToPaperClassAudit(objPaperEN);
        objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `操作成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //刷新缓存
                        //vPaper_ReFreshThisCache();
                        //刷新缓存
                        PaperEx_ReFreshThisCacheById_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
                        HideDialog();
                        
                        this.iShowList.BindGv(clsRTPaperRelaEN._CurrTabName, returnBool.toString());
                    }
                    else {
                        var strInfo: string = `操作不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("操作失败");
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



    public async PublicPaperRecord(strPaperId: string) {

        this.keyId = strPaperId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;

                    //通过session 权限获取权限
                    var strUserId = clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage.roleId;

                    // //通过判断数据用户是否是当前登录用户；
                    if (objPaperEN.updUser == clsPublocalStorage.userId) {

                        //判断数据是否已审核
                        if (objPaperEN.isSubmit == false) {

                            const responseText3 = this.PublicRecordSave().then((jsonData) => {

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

                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 论文公开
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async PublicRecordSave(): Promise<boolean> {
        const strThisFuncName = this.PublicRecordSave.name;

        //
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId(this.keyId);
        //设置提交状态；
        objPaperEN.SetIsPublic(true);
        //this.PutDataToPaperClassAudit(objPaperEN);
        objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `操作成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //刷新缓存
                        //vPaper_ReFreshThisCache();
                        //刷新缓存
                        PaperEx_ReFreshThisCacheById_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
                        HideDialog();
                        this.iShowList.BindGv(clsRTPaperRelaEN._CurrTabName, returnBool.toString());
                    }
                    else {
                        var strInfo: string = `操作不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("操作失败");
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

    public async btnIsSubmitPaper_Click(strKeyId: string) {
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }
        this.SubmitPaperRecord(strKeyId);
    }

    //小组论文写作 公开
    public async btnIsPublicPaper_Click(strKeyId: string) {
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }
        this.PublicPaperRecord(strKeyId);
    }
    /* 添加新记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSavePaperRela(strPaperId: string):Promise<boolean> {
        var strTopicId = clsPrivateSessionStorage.topicId;
        RTPaperRela_EditEx.Paper_Static = strPaperId;
        var strUserId = clsPublocalStorage.userId;
        var objRTPaperRelaEN: clsRTPaperRelaEN = new clsRTPaperRelaEN();
        this.PutDataToRTPaperRelaClass(objRTPaperRelaEN);

        try {
            // 同一主题 同一论文 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And paperId = '" + strPaperId + "'";
            const bolIsExist = await RTPaperRela_IsExistRecordAsync(strWhere);
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个论文！`;
                alert(strMsg);
                return false;//一定要有一个返回值，否则会出错！
            }

            const returnBool = await RTPaperRela_AddNewRecordAsync(objRTPaperRelaEN);
                 if (returnBool == true) {
                var strInfo: string = `添加成功!`;
     
                //HideDialogThree();
                //显示信息框
                //alert(strInfo);
                //this.iShowList.BindGv(clsRTPaperRelaEN._CurrTabName, returnBool.toString());
                     return true;
            }
            else {
                var strInfo: string = `添加不成功!`;
                //显示信息框
                     alert(strInfo);
                     return false;
            }
       
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }   
    }

    //确定选择的论文 并添加到关系表中
    public btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)
        console.error('btnPaperRecordInTab_Click');
        //获取论文条件 02代表 小组成员论文数据；
        var strType = $("#hidstrType").val();
        //if (strType == "01") {
        //执行添加关系方法
        this.AddNewRecordSavePaperRela(strkeyId);//所有论文
        //}
        //else {

        //    //小组成员论文；
        //    //this.AddNewRecordSaveResearchResult();
        //}
    }

}