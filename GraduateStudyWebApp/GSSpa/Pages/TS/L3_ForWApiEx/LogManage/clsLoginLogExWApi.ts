
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLoginLogExWApi
 表名:LoginLog(01120357)
 生成代码版本:2021.01.04.1
 生成日期:2021/01/04 16:59:47
 生成者:lyl
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理
 模块英文名:LogManage
 框架-层名:WA_访问扩展层(WA_AccessEx)
 编程语言:TypeScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */

 /// <summary>
 /// 登录日志(LoginLog)
 /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
 /// </summary>
/**
* Created by lyl on 2021年01月04日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsLoginLogEN } from "../../L0_Entity/LogManage/clsLoginLogEN.js";
import { clsLoginLogENEx } from "../../L0_Entity/LogManage/clsLoginLogENEx.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
var ResponseData: tzResponseData;
export class clsLoginLogExWApi 
{
 public static mstrController: string = "LoginLogExApi";
public objLoginLogEN: clsLoginLogEN = new clsLoginLogEN();

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
/// </summary>
 constructor()
 {
 };

 /// <summary>
 /// 获取WebApi的地址
 /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
 /// </summary>
 /// <returns>返回当前文件中Web服务的地址</returns>
public static GetWebApiUrl(strController: string, strAction: string): string {
var strServiceUrl:string;
if (clsSysPara4WebApi2.bolIsLocalHost == false) {
strServiceUrl = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx}/${strController}/${strAction}`;
}
else {
strServiceUrl = `${clsSysPara4WebApi2.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi2.CurrPrx}/${strController}/${strAction}`;
}
return strServiceUrl;
}

 /// <summary>
 /// 把同一个类的对象,复制到该类的扩展对象
 /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
 /// </summary>
 /// <param name = "objLoginLogENS">源对象</param>
 /// <param name = "objLoginLogENT">目标对象</param>
public static CopyToEx(objLoginLogENS: clsLoginLogEN  ): clsLoginLogENEx 
{
var objLoginLogENT: clsLoginLogENEx = new clsLoginLogENEx();
objLoginLogENT.loginLogId = objLoginLogENS.loginLogId; //loginLogId
objLoginLogENT.loginLogNumber = objLoginLogENS.loginLogNumber; //loginLogNumber
objLoginLogENT.loginIP = objLoginLogENS.loginIP; //loginIP
objLoginLogENT.failReason = objLoginLogENS.failReason; //failReason
objLoginLogENT.loginResult = objLoginLogENS.loginResult; //loginResult
objLoginLogENT.loginTime = objLoginLogENS.loginTime; //loginTime
objLoginLogENT.loginUserId = objLoginLogENS.loginUserId; //loginUserId
objLoginLogENT.memo = objLoginLogENS.memo; //备注
objLoginLogENT.onlineTime = objLoginLogENS.onlineTime; //onlineTime
objLoginLogENT.outTime = objLoginLogENS.outTime; //outTime
objLoginLogENT.sf_UpdFldSetStr = objLoginLogENS.updFldString; //专门用于记录某字段属性是否修改
objLoginLogENT.sf_FldComparisonOp = objLoginLogENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
return objLoginLogENT; 
}

};