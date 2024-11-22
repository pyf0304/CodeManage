
import { clsSchoolTermEN } from "../../L0_Entity/SysPara/clsSchoolTermEN.js";
import { clsSchoolTermENEx } from "../../L0_Entity/SysPara/clsSchoolTermENEx.js";
import { SchoolTerm_CopyObjTo } from "../../L3_ForWApi/SysPara/clsSchoolTermWApi.js";
import { Format } from "../../PubFun/clsString.js";

import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;
export class clsSchoolTermExWApi 
{
 public static mstrController: string = "SchoolTermExApi";
public objSchoolTermEN: clsSchoolTermEN = new clsSchoolTermEN();

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
 /// <param name = "objSchoolTermENS">源对象</param>
 /// <returns>目标对象=>clsSchoolTermEN:objSchoolTermENT</returns>
 public static CopyToEx(objSchoolTermENS:clsSchoolTermEN ): clsSchoolTermENEx
{
 var objSchoolTermENT = new clsSchoolTermENEx();
try
{
SchoolTerm_CopyObjTo(objSchoolTermENS, objSchoolTermENT);
 return objSchoolTermENT;
}
catch (e)
{
var strMsg: string = Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
console.error(strMsg);
alert(strMsg);
 return objSchoolTermENT;
}
}

};