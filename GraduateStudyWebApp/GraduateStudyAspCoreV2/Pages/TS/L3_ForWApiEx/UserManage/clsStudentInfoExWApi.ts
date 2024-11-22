
//import * as QQ from "q";
import { clsStudentInfoEN } from "../../L0_Entity/UserManage_Share/clsStudentInfoEN.js";
import { clsStudentInfoENEx } from "../../L0_Entity/UserManage_Share/clsStudentInfoENEx.js";
import { StudentInfo_CopyObjTo } from "../../L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js";
import { Format } from "../../PubFun/clsString.js";

import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;
export class clsStudentInfoExWApi 
{
 public static mstrController: string = "StudentInfoExApi";
public objStudentInfoEN: clsStudentInfoEN = new clsStudentInfoEN();

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
 /// <param name = "objStudentInfoENS">源对象</param>
 /// <returns>目标对象=>clsStudentInfoEN:objStudentInfoENT</returns>
 public static CopyToEx(objStudentInfoENS:clsStudentInfoEN ): clsStudentInfoENEx
{
 var objStudentInfoENT = new clsStudentInfoENEx();
try
{
StudentInfo_CopyObjTo(objStudentInfoENS, objStudentInfoENT);
 return objStudentInfoENT;
}
catch (e)
{
var strMsg: string = Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
console.error(strMsg);
alert(strMsg);
 return objStudentInfoENT;
}
}

};