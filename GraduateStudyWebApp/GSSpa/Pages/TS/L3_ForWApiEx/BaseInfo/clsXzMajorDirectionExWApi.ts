
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorDirectionExWApi
 表名:XzMajorDirection(01120552)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/11 17:41:46
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
 /// 专业方向(XzMajorDirection)
 /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
 /// </summary>
/**
* Created by pyf on 2021年06月11日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsXzMajorDirectionEN } from "../../L0_Entity/BaseInfo/clsXzMajorDirectionEN.js";
import { clsXzMajorDirectionENEx } from "../../L0_Entity/BaseInfo/clsXzMajorDirectionENEx.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { clsString } from "../../PubFun/clsString.js";
import { XzMajorDirection_CopyObjTo } from "../../L3_ForWApi/BaseInfo/clsXzMajorDirectionWApi.js";

var ResponseData: tzResponseData;
export class clsXzMajorDirectionExWApi 
{
 public static mstrController: string = "XzMajorDirectionExApi";
public objXzMajorDirectionEN: clsXzMajorDirectionEN = new clsXzMajorDirectionEN();

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
 /// <param name = "objXzMajorDirectionENS">源对象</param>
 /// <returns>目标对象=>clsXzMajorDirectionEN:objXzMajorDirectionENT</returns>
 public static CopyToEx(objXzMajorDirectionENS:clsXzMajorDirectionEN ): clsXzMajorDirectionENEx
{
 var objXzMajorDirectionENT = new clsXzMajorDirectionENEx();
try
{
XzMajorDirection_CopyObjTo(objXzMajorDirectionENS, objXzMajorDirectionENT);
 return objXzMajorDirectionENT;
}
catch (e)
{
var strMsg: string = clsString.Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
console.error(strMsg);
alert(strMsg);
 return objXzMajorDirectionENT;
}
}

};