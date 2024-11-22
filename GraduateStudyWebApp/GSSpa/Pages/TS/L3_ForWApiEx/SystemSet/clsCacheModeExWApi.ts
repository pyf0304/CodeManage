﻿
 /**
 * 类名:clsCacheModeExWApi
 * 表名:CacheMode(01120688)
 * 生成代码版本:2021.09.17.1
 * 生成日期:2021/09/20 16:03:13
 * 生成者:pyf
 * 生成服务器IP:103.116.76.183
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:系统设置
 * 模块英文名:SystemSet
 * 框架-层名:WA_访问扩展层(WA_AccessEx)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

 /**
 * 缓存方式(CacheMode)
 * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
* Created by pyf on 2021年09月20日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
//import $ from "jquery";
import { clsCacheModeEN } from "../../L0_Entity/SystemSet/clsCacheModeEN.js";
import { clsCacheModeENEx } from "../../L0_Entity/SystemSet/clsCacheModeENEx.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { clsString } from "../../PubFun/clsString.js";
import { CacheMode_CopyObjTo } from "../../L3_ForWApi/SystemSet/clsCacheModeWApi.js";
export class clsCacheModeExWApi 
{
 public static mstrController = "CacheModeExApi";
public objCacheModeEN = new clsCacheModeEN();

 /**
 * 获取WebApi的地址
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
 **/
public static GetWebApiUrl(strController: string, strAction: string): string {
let strServiceUrl:string;
if (clsSysPara4WebApi2.bolIsLocalHost == false) {
strServiceUrl = clsString.Format("{0}/{1}/{2}/{3}", clsSysPara4WebApi2.CurrIPAddressAndPort, clsSysPara4WebApi2.CurrPrx, strController, strAction);
}
else {
strServiceUrl = clsString.Format("{0}/{1}/{2}/{3}", clsSysPara4WebApi2.CurrIPAddressAndPort_Local, clsSysPara4WebApi2.CurrPrx, strController, strAction);
}
return strServiceUrl;
}

 /**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
 * @param objCacheModeENS:源对象
 * @returns 目标对象=>clsCacheModeEN:objCacheModeENT
 **/
 public static CopyToEx(objCacheModeENS:clsCacheModeEN ): clsCacheModeENEx
{
 const objCacheModeENT = new clsCacheModeENEx();
try
{
CacheMode_CopyObjTo(objCacheModeENS, objCacheModeENT);
 return objCacheModeENT;
}
catch (e)
{
const strMsg = clsString.Format("(errid:Watl000066)Copy表对象数据出错,{0}.", e);
console.error(strMsg);
alert(strMsg);
 return objCacheModeENT;
}
}

}