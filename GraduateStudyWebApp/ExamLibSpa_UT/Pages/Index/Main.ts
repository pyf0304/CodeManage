
/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiCollege_UT_TS
表名:College(01160017)
生成代码版本:2019.07.10.1
生成日期:2019/07/11 01:23:16
生成者:
工程名称:简单工程样例
工程ID:0116
相关数据库:101.251.68.133,9433SimplePrj
PrjDataBaseId:0111
模块中文名:基本信息
模块英文名:BaseInfo
框架-层名:WApi界面单元测试脚本后台_TS(WA_ViewUTScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";


import { clsCommonFunc4Web } from "../TS/PubFun/clscommonfunc4web.js";
import { stuLoginPara } from "../TS/PubFun/stuLoginPara.js";
import { stuUserLoginInfo } from "../TS/FunClass/stuUserLoginInfo.js";
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strUserLoginInfo: string;
var objUserLoginInfo: stuUserLoginInfo;
declare var strWebRoot;
declare var $;
/// <summary>
/// WApiCollege_UT_TS 的摘要说明。其中Q代表查询,U代表修改
/// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:GeneCode)
/// </summary>
export class Main {
    public static DispUserInfo() {
        objUserLoginInfo = stuUserLoginInfo.GetObjByHtmlString(strUserLoginInfo);
        $('#spnUserId').html(objUserLoginInfo.UserId);
        $('#spnRoleName').html(objUserLoginInfo.RoleName);

        $('#spnCurrSelPrjId').html(objUserLoginInfo.CurrSelPrjId);
        $('#spnCurrSelPrjName').html(objUserLoginInfo.CurrSelPrjName);

        $('#spnPrjDataBaseName').html(objUserLoginInfo.PrjDataBaseName);

    }

    /*
     演示Session 操作
    */
    public static async Demo_Session() {
        try {
            //设置Session
            var strUserId = "TestUserId";
            await this.SetSessionAsync("UserId", strUserId);
            //获取Session
            var strUserId_Value1 = await this.GetSessionAsync("UserId");
            console.log('strUserId_Value1:' + strUserId_Value1);
            //获取Session方法2：直接读取页面中的hidUserId
            var strUserId_Value2 = $('#hidUserId').val(); 
            console.log('strUserId_Value2:'+ strUserId_Value2);

        }
        catch (e) {
            var strMsg: string = `演示Session不成功,${decodeURIComponent(e.responseText)}.`;
            alert(strMsg);
        }
    }
    /*
     设置Session    
     <param name = "Key">关键字</param>
     <param name = "Value">值</param>
    */
    public static SetSessionAsync(Key: string, Value: string): Promise<void> {
        return new Promise(function (resolve, reject) {

            $.ajax({
                url: strUrl_Session_SetString,
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key,
                    Value: Value
                },
                success: function (data) {
                    //$('#myValue').val(text);
                    var strKey = data.key;
                    var strValue = data.value;

                    //$('#myKey').html(strKey);
                    //$('#myValue').html(strValue);
                    console.log(strKey + strValue);

                }

            });
        });
    }

    /*
 获取Session 关键字的值
 <param name = "Key">关键字</param>
 <return>值</return>
*/
    public static GetSessionAsync(Key: string): Promise<string> {
        return new Promise(function (resolve, reject) {

            $.ajax({
                url: "/Session/GetString",
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key
                },
                success: function (data) {                                  
                    var strValue = data.value;
                    
                    console.log(Key + strValue);
                    resolve(data);
                },
                  error: (e) => {
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }
}