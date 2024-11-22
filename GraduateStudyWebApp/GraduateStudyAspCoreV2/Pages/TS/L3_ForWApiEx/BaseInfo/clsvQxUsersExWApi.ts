﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsersExWApi
 表名:vQxUsers(01120564)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/11 17:40:04
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护
 模块英文名:BaseInfo
 框架-层名:WA_访问扩展层(WA_AccessEx)
 编程语言:TypeScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */

 /// <summary>
 /// vQx用户(vQxUsers)
 /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
 /// </summary>
/**
* Created by pyf on 2021年06月11日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as QQ from "q";
import { clsvQxUsersEN } from "../../L0_Entity/BaseInfo/clsvQxUsersEN.js";
import { clsvQxUsersENEx } from "../../L0_Entity/BaseInfo/clsvQxUsersENEx.js";
import { vQxUsers_CopyObjTo } from "../../L3_ForWApi/BaseInfo/clsvQxUsersWApi.js";
import { Format } from "../../PubFun/clsString.js";

import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";

var ResponseData: tzResponseData;
export class clsvQxUsersExWApi 
{
 public static mstrController: string = "vQxUsersExApi";
public objvQxUsersEN: clsvQxUsersEN = new clsvQxUsersEN();

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
if (clsSysPara4WebApi.bolIsLocalHost == false) {
strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
}
else {
strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
}
return strServiceUrl;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
 /// </summary>
 /// <param name = "objvQxUsersENS">源对象</param>
 /// <returns>目标对象=>clsvQxUsersEN:objvQxUsersENT</returns>
 public static CopyToEx(objvQxUsersENS:clsvQxUsersEN ): clsvQxUsersENEx
{
 var objvQxUsersENT = new clsvQxUsersENEx();
try
{
vQxUsers_CopyObjTo(objvQxUsersENS, objvQxUsersENT);
 return objvQxUsersENT;
}
catch (e)
{
var strMsg: string = Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
console.error(strMsg);
alert(strMsg);
 return objvQxUsersENT;
}
}

};