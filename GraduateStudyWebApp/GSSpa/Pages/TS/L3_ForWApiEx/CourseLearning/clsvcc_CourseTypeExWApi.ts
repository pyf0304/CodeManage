
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTypeExWApi
 表名:vcc_CourseType(01120059)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/11 17:37:54
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
import { clsvcc_CourseTypeEN } from "../../L0_Entity/CourseLearning/clsvcc_CourseTypeEN.js";
import { clsvcc_CourseTypeENEx } from "../../L0_Entity/CourseLearning/clsvcc_CourseTypeENEx.js";
import { vcc_CourseType_CopyObjTo } from "../../L3_ForWApi/CourseLearning/clsvcc_CourseTypeWApi.js";
import { clsString } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;
export class clsvcc_CourseTypeExWApi 
{
 public static mstrController: string = "vcc_CourseTypeExApi";
public objvcc_CourseTypeEN: clsvcc_CourseTypeEN = new clsvcc_CourseTypeEN();

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
 /// <param name = "objvcc_CourseTypeENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseTypeEN:objvcc_CourseTypeENT</returns>
 public static CopyToEx(objvcc_CourseTypeENS:clsvcc_CourseTypeEN ): clsvcc_CourseTypeENEx
{
 var objvcc_CourseTypeENT = new clsvcc_CourseTypeENEx();
try
{
vcc_CourseType_CopyObjTo(objvcc_CourseTypeENS, objvcc_CourseTypeENT);
 return objvcc_CourseTypeENT;
}
catch (e)
{
var strMsg: string = clsString.Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
console.error(strMsg);
alert(strMsg);
 return objvcc_CourseTypeENT;
}
}

};