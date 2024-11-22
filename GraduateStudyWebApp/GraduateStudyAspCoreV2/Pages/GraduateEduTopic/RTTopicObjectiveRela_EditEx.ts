
 /**
 * 类名:RTTopicObjectiveRela_EditEx(界面:RTTopicObjectiveRelaCRUD)
 * 表名:RTTopicObjectiveRela(01120615)
 * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/06 22:44:12
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
 * 编程语言:TypeScript
 **/
import { RTTopicObjectiveRela_Edit } from "../PagesBase/GraduateEduTopic/RTTopicObjectiveRela_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsRTTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js";
import { clsTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js";
import { RTTopicObjectiveRela_AddNewRecordAsync, RTTopicObjectiveRela_GetRecCountByCondAsync, RTTopicObjectiveRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTTopicObjectiveRelaWApi.js";
import { TopicObjective_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
declare function HideDialogEight(): void;
 /* RTTopicObjectiveRela_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class RTTopicObjectiveRela_EditEx extends RTTopicObjectiveRela_Edit
{


 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 **/
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnEdit_Click.name;
const objPage = RTTopicObjectiveRela_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
objPage.btnSubmit_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(RTTopicObjectiveRela_EditEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}
    /* 添加新记录，保存函数
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSave() {
        const strThisFuncName = this.AddNewRecordSave.name;

        var strObjectiveId = $("#hidObjectiveId").val()
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strUserId = clsPublocalStorage.userId;
        
        var objRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN = new clsRTTopicObjectiveRelaEN();
        this.PutDataToRTTopicObjectiveRelaClass(objRTTopicObjectiveRelaEN);
        try {
            //同一主题 同一客观事实 数据 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And topicObjectiveId = '" + strObjectiveId + "'";
            //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
            const responseText = await RTTopicObjectiveRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题同一用户不能重复添加同一个客观事实数据！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            else {
                const responseText = await RTTopicObjectiveRela_AddNewRecordAsync(objRTTopicObjectiveRelaEN);
                var returnBool: boolean = !!responseText;
                if (returnBool == true) {
                    var strInfo: string = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);

                    //根据ID获取最大数；
                    var strWhereCond2 = " 1 =1 and topicObjectiveId=" + strObjectiveId;
                    var intCitationCount = await RTTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond2);


                    var objTopicObjectiveEN: clsTopicObjectiveEN = new clsTopicObjectiveEN();
                    objTopicObjectiveEN.SetTopicObjectiveId(strObjectiveId);
                    objTopicObjectiveEN.SetCitationCount(intCitationCount);

                    objTopicObjectiveEN.sfUpdFldSetStr = objTopicObjectiveEN.updFldString;//设置哪些字段被修改(脏字段)
                    if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                         throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }

                    const responseText = await TopicObjective_UpdateRecordAsync(objTopicObjectiveEN).then((jsonData) => {
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
                    HideDialogEight();
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
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjRTTopicObjectiveRelaEN">数据传输的目的类对象</param>
*/
    public async PutDataToRTTopicObjectiveRelaClass(pobjRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN) {
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strObjectiveId = $("#hidObjectiveId").val();
        var strUserId = clsPublocalStorage.userId;

        var strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        pobjRTTopicObjectiveRelaEN.Setid_CurrEduCls(strId_CurrEduCls);
        pobjRTTopicObjectiveRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTTopicObjectiveRelaEN.SetTopicObjectiveId(strObjectiveId);// 客观Id
        pobjRTTopicObjectiveRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTTopicObjectiveRelaEN.SetUpdUser(strUserId);// 修改人
        pobjRTTopicObjectiveRelaEN.SetMemo(this.memo);// 备注
        pobjRTTopicObjectiveRelaEN.SetClassificationId("0000000000");// 分类为000000

    }



    //确定选择的客观观点 并添加到关系表中
    public btnOkObjectiveInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidObjectiveId").val(strkeyId)
        //执行添加关系方法
        this.AddNewRecordSave();
    }

}