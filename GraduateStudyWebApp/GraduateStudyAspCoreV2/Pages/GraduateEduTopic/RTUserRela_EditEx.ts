
/**
* 类名:RTUserRela_EditEx(界面:RTUserRelaCRUD)
* 表名:RTUserRela(01120582)
* 版本:2023.01.04.1(服务器:WIN-SRV103-116)
* 日期:2023/01/06 22:44:36
* 生成者:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:研培主题(GraduateEduTopic)
* 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
import { RTUserRela_Edit } from "../PagesBase/GraduateEduTopic/RTUserRela_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js";
import { clsgs_ColorEN } from "../TS/L0_Entity/ParameterTable/clsgs_ColorEN.js";
import { enumTopicUserRole } from "../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js";
import { RTUserRela_AddNewRecordAsync, RTUserRela_GetFirstObjAsync, RTUserRela_IsExistRecordAsync, RTUserRela_ReFreshCache, RTUserRela_ReOrderAsync, RTUserRela_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js";
import { gs_Color_GetObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ColorWApi.js";
import { clsOrderByData } from "../TS/PubFun/clsOrderByData.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
/* RTUserRela_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class RTUserRela_EditEx extends RTUserRela_Edit {
    public static TopicId_Static = "";

    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    **/
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnEdit_Click.name;
        const objPage = RTUserRela_EditEx.objPage_Edit;
        switch (strCommandName) {
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(RTUserRela_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }


    /* 添加主题同时把用户作为组长存放到主题用户关系表*/
    public async AddNewTopicAndRecordSaveUserRela(strTopicId: string):Promise<boolean> {
        RTUserRela_EditEx.TopicId_Static = strTopicId;
        var strUserId = clsPublocalStorage.userId;
        var objRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
        await this.PutDataToRTUserRelaClassWhere(objRTUserRelaEN, strTopicId);
        //获取缓存色码表；
        var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
        try {
            // 同一主题 同一用户 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
            const bolIsExist = await RTUserRela_IsExistRecordAsync(strWhere);
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个用户！`;
                //alert(strMsg);
                console.log("同一主题不能重复添加同一个用户！");
                return false;
                // return responseText;//一定要有一个返回值，否则会出错！
            }

            const returnBool = await RTUserRela_AddNewRecordAsync(objRTUserRelaEN);

            if (returnBool == true) {
                RTUserRela_ReFreshCache(strTopicId);
                var strInfo: string = `添加成功!`;
                
                //隐藏用户框
                //HideDialogFour();
                //显示信息框
                //alert(strInfo);
                const responseText3 = await this.btnReOrder_Click();
                //获取色码数据
                const arrGs_ColorObjLst = await gs_Color_GetObjLst_Cache();

                //添加完成后把根据用户排序号得到色码表 样式把样式更新到主题用户关系表；
                var strWhereUserRela = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
                //const responseText = await RTUserRela_GetFirstObjAsync(strWhere);
                const objRTUserRelaEN = await RTUserRela_GetFirstObjAsync(strWhereUserRela);

                if (objRTUserRelaEN != null) {
                    //得到用户排序号
                    var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRTUserRelaEN.orderNum);
                    if (Objgs_Color != null) {
                        //得到色码

                        var objUpdateRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
                        objUpdateRTUserRelaEN.SetmId(objRTUserRelaEN.mId);
                        objUpdateRTUserRelaEN.SetColorId(Objgs_Color.colorId);
                        objUpdateRTUserRelaEN.SetUserBgColor(Objgs_Color.colorCode);//用户背景色码；

                        objUpdateRTUserRelaEN.sfUpdFldSetStr = objUpdateRTUserRelaEN.updFldString;//设置哪些字段被修改(脏字段)

                        const responseText = RTUserRela_UpdateRecordAsync(objUpdateRTUserRelaEN).then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                return true;
                            }
                            else {
                                var strInfo: string = `修改用户色码不成功!`;
                                alert(strInfo);
                                console.log("修改用户色码不成功");
                                return false;
                            }
                        });
                    }
                }
                return true;
                //this.BindGv_vRTUserRela();
                ////主题Id
                //window.location.href = "../GraduateEdu/WApiRTUserRela_QUDI_TS?TopicRelaId='01'";
            }
            else {
                var strInfo: string = `添加不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                return false;
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加主题用户关系不成功,${e}.`;
            alert(strMsg);
            return false;
        }

    }
    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjRTUserRelaEN">数据传输的目的类对象</param>
   */
    public PutDataToRTUserRelaClassWhere(pobjRTUserRelaEN: clsRTUserRelaEN, strTopicId: string) {
        var strUserId = clsPublocalStorage.userId;
        pobjRTUserRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTUserRelaEN.SetUserId(strUserId);// 用户ID
        pobjRTUserRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTUserRelaEN.SetTopicUserRoleId(enumTopicUserRole.TeamLeader_0002);//组成
        pobjRTUserRelaEN.SetUpdUser(strUserId);// 修改人
        pobjRTUserRelaEN.SetOrderNum(30);
        pobjRTUserRelaEN.SetColorId(""); //获取不同色码
        pobjRTUserRelaEN.SetMemo("");// 备注
    }
    /*
重序
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
*/
    public async btnReOrder_Click() {

        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            var jsonObject =
            {
                "topicId": RTUserRela_EditEx.TopicId_Static,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await RTUserRela_ReOrderAsync(objOrderByData);
            RTUserRela_ReFreshCache(RTUserRela_EditEx.TopicId_Static);
        }
        catch (e) {
            var strMsg: string = `重序出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        //绑定主题用户关系；
        //this.BindGv_vRTUserRela();
    }



}