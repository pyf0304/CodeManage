﻿
/**
* 类名:RTViewpointRela_EditEx(界面:RTViewpointRelaCRUD)
* 表名:RTViewpointRela(01120545)
* 版本:2023.01.04.1(服务器:WIN-SRV103-116)
* 日期:2023/01/06 22:43:59
* 生成者:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:研培主题(GraduateEduTopic)
* 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
import { RTViewpointRela_Edit } from "../PagesBase/GraduateEduTopic/RTViewpointRela_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js";
import { clsvRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js";
import { vRTViewpointRela_GetObjBymIdAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
/* RTViewpointRela_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class RTViewpointRela_EditEx extends RTViewpointRela_Edit {


    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    **/
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnEdit_Click.name;
        const objPage = RTViewpointRela_EditEx.objPage_Edit;
        switch (strCommandName) {
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(RTViewpointRela_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }


    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
  */
    public async PutDataToRTViewpointRelaClass(pobjRTViewpointRelaEN: clsRTViewpointRelaEN) {
        pobjRTViewpointRelaEN.SetTopicId(this.topicId);// 主题编号
        pobjRTViewpointRelaEN.SetViewpointId(this.viewpointId);// 观点Id
        pobjRTViewpointRelaEN.SetProposePeople(this.proposePeople);// 提出人
        pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTViewpointRelaEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id// 修改用户Id
        pobjRTViewpointRelaEN.SetMemo(this.memo);// 备注
    }
    /* 根据关键字获取相应的记录的对象
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
 <param name = "sender">参数列表</param>
*/
    public RtViewpointRelaDetailRecord(lngmId: number) {


        this.keyId = lngmId.toString();
        return new Promise((resolve, reject) => {
            try {
                const responseText = vRTViewpointRela_GetObjBymIdAsync(lngmId).then((jsonData) => {
                    var objvRTViewpointRelaEN: clsvRTViewpointRelaEN = <clsvRTViewpointRelaEN>jsonData;
                    // //显示当前数据；
                    $("#txtTopicNameDetail").html(objvRTViewpointRelaEN.topicName);
                    $("#txtTopicContentDetail").html(objvRTViewpointRelaEN.topicContent);

                    $("#txtViewpointNameDetail").html(objvRTViewpointRelaEN.viewpointName);
                    $("#txtViewpointTypeNameDetail").html(objvRTViewpointRelaEN.viewpointTypeName);
                    $("#txtViewpointContentDetail").html(objvRTViewpointRelaEN.viewpointContent);
                    $("#txtReasonDetail").html(objvRTViewpointRelaEN.reason);
                    $("#txtSourceDetail").html(objvRTViewpointRelaEN.source);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `当前无数据获取失败,${e}.`;
                alert(strMsg);
            }
        });

    }



    public btnDetailInTab_Click(strKeyId: string) {

        if (strKeyId == "") {
            alert("请选择需要查看的记录！");
            return;
        }
        var lngKeyId = Number(strKeyId);
        this.RtViewpointRelaDetailRecord(lngKeyId);
    }



}