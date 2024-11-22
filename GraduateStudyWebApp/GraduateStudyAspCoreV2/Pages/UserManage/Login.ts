
/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiTaskType_UT_TS
表名:TaskType(01160017)
生成代码版本:2019.07.10.1
生成日期:2019/07/11 01:23:16
生成者:
工程名称:简单工程样例
工程ID:0116
相关数据库:101.251.68.133,9433TaskManage
PrjDataBaseId:0111
模块中文名:基本信息
模块英文名:BaseInfo
框架-层名:WApi界面单元测试脚本后台_TS(WA_ViewUTScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////

import { BindTab } from "../TS/PubFun/clsCommFunc4Web.js";
import { stuTopPara } from "../TS/PubFun/stuTopPara.js";
import { stuRangePara } from "../TS/PubFun/stuRangePara.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare var $;
declare var window;
/// <summary>
/// WApiTaskType_UT_TS 的摘要说明。其中Q代表查询,U代表修改
/// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:GeneCode)
/// </summary>
export class Login {


    /// <summary>
    /// 根据关键字列表获取相应的记录对象的列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByKeyLst)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    public static async btnLogin_Click() {
        var strUserId: string = $('#txtUserId').val();
        var strPassword: string = $('#txtPassword').val();

        try {
            //const responseText = await TaskType_GetObjLstByTaskTypeIdLstAsync(arrTaskTypeId);
            //var arrTaskTypeObjLst : Array<clsTaskTypeEN> = < Array<clsTaskTypeEN>>responseText;
            //var strInfo: string = `根据关键字列表:[${strKeyIdLst}]共获取对象列表数：${arrTaskTypeObjLst.length}!`;
            //$('#lblResult15').val(strInfo);
            ////显示信息框
            //alert(strInfo);
            //this.BindTab_TaskType("divResult15", arrTaskTypeObjLst);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

}