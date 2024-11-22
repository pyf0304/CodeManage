﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PTopicObjectiveRelaExWApi
 表名:gs_PTopicObjectiveRela(01120673)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/11 17:34:12
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_访问扩展层(WA_AccessEx)
 编程语言:TypeScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
//import * as QQ from "q";
import { clsgs_PTopicObjectiveRelaEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PTopicObjectiveRelaEN.js";
import { clsgs_PTopicObjectiveRelaENEx } from "../../L0_Entity/GraduateEduPaper/clsgs_PTopicObjectiveRelaENEx.js";
import { gs_PTopicObjectiveRela_CopyObjTo } from "../../L3_ForWApi/GraduateEduPaper/clsgs_PTopicObjectiveRelaWApi.js";
import { Format } from "../../PubFun/clsString.js";

import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;
export class clsgs_PTopicObjectiveRelaExWApi 
{
 public static mstrController: string = "gs_PTopicObjectiveRelaExApi";
public objgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN = new clsgs_PTopicObjectiveRelaEN();

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
 /// <param name = "objgs_PTopicObjectiveRelaENS">源对象</param>
 /// <returns>目标对象=>clsgs_PTopicObjectiveRelaEN:objgs_PTopicObjectiveRelaENT</returns>
 public static CopyToEx(objgs_PTopicObjectiveRelaENS:clsgs_PTopicObjectiveRelaEN ): clsgs_PTopicObjectiveRelaENEx
{
 var objgs_PTopicObjectiveRelaENT = new clsgs_PTopicObjectiveRelaENEx();
try
{
gs_PTopicObjectiveRela_CopyObjTo(objgs_PTopicObjectiveRelaENS, objgs_PTopicObjectiveRelaENT);
 return objgs_PTopicObjectiveRelaENT;
}
catch (e)
{
var strMsg: string = Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
console.error(strMsg);
alert(strMsg);
 return objgs_PTopicObjectiveRelaENT;
}
}

};