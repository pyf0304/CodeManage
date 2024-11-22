
 /**
 * 类名:clsvcc_CourseExWApi
 * 表名:vcc_Course(01120058)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 18:18:15
 * 生成者:pyf
 * 生成服务器IP:103.116.76.183
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:课程学习
 * 模块英文名:CourseLearning
 * 框架-层名:WA_访问扩展层(WA_AccessEx)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

 /**
 * v课程(vcc_Course)
 * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
* Created by pyf on 2021年09月27日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
//import $ from "jquery";
import { clsvcc_CourseEN } from "../../L0_Entity/CourseLearning/clsvcc_CourseEN.js";
import { clsvcc_CourseENEx } from "../../L0_Entity/CourseLearning/clsvcc_CourseENEx.js";
import { vcc_Course_CopyObjTo } from "../../L3_ForWApi/CourseLearning/clsvcc_CourseWApi.js";
import { clsString } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
export class clsvcc_CourseExWApi 
{
 public static mstrController = "vcc_CourseExApi";
public objvcc_CourseEN = new clsvcc_CourseEN();

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
 * @param objvcc_CourseENS:源对象
 * @returns 目标对象=>clsvcc_CourseEN:objvcc_CourseENT
 **/
 public static CopyToEx(objvcc_CourseENS:clsvcc_CourseEN ): clsvcc_CourseENEx
{
 const objvcc_CourseENT = new clsvcc_CourseENEx();
try
{
vcc_Course_CopyObjTo(objvcc_CourseENS, objvcc_CourseENT);
 return objvcc_CourseENT;
}
catch (e)
{
const strMsg = clsString.Format("(errid:Watl000066)Copy表对象数据出错,{0}.", e);
console.error(strMsg);
alert(strMsg);
 return objvcc_CourseENT;
}
}

}