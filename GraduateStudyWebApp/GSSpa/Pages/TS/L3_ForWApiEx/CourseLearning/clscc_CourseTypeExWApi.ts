
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseTypeExWApi
 表名:cc_CourseType(01120057)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/11 17:32:40
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
 框架-层名:WA_访问扩展层(WA_AccessEx)
 编程语言:TypeScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
//import * as QQ from "q";
import { clscc_CourseTypeEN } from "../../L0_Entity/CourseLearning/clscc_CourseTypeEN.js";
import { clscc_CourseTypeENEx } from "../../L0_Entity/CourseLearning/clscc_CourseTypeENEx.js";
import { cc_CourseType_CopyObjTo } from "../../L3_ForWApi/CourseLearning/clscc_CourseTypeWApi.js";
import { clsString } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;
export class clscc_CourseTypeExWApi 
{
 public static mstrController: string = "cc_CourseTypeExApi";
public objcc_CourseTypeEN: clscc_CourseTypeEN = new clscc_CourseTypeEN();

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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
 /// </summary>
 /// <param name = "objcc_CourseTypeENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseTypeEN:objcc_CourseTypeENT</returns>
 public static CopyToEx(objcc_CourseTypeENS:clscc_CourseTypeEN ): clscc_CourseTypeENEx
{
 var objcc_CourseTypeENT = new clscc_CourseTypeENEx();
try
{
cc_CourseType_CopyObjTo(objcc_CourseTypeENS, objcc_CourseTypeENT);
 return objcc_CourseTypeENT;
}
catch (e)
{
var strMsg: string = clsString.Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
console.error(strMsg);
alert(strMsg);
 return objcc_CourseTypeENT;
}
}

};