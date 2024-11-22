/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiUsers_QUDI_TSEx
表名:Users(00070029)
生成代码版本:2019.08.30.1
生成日期:2019/09/26 01:05:04
生成者:
工程名称:任务管理
工程ID:0007
相关数据库:101.251.68.133,9433TaskManage
PrjDataBaseId:0007
模块中文名:用户管理
模块英文名:UserManage
框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/

import { QxUsers_QUDI_TS } from "../BaseInfo/QxUsers_QUDI_TS.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
//ip
declare var LoginIp;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class LoginmainEx extends QxUsers_QUDI_TS {

    //登录方法
    public async btnQuery_Click(strListDiv: string) {
        var result: string = "";
        var strWhereCond = "";
        try {
            //跳转获取微信地址;
            window.location.href = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=wxc3a28c4bb53ddbbb&redirect_uri=https://www.sh-tz.com/GraduateStudyWebApp/WebApp/wxUserInfo&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect";


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `登录失败,${e}.`;
            alert(strMsg);
        }
    }



}