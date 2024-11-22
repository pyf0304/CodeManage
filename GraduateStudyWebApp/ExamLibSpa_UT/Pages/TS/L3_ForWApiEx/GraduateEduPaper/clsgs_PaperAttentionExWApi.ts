
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperAttentionExWApi
 表名:gs_PaperAttention(01120748)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/29 00:00:13
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_访问扩展层(WA_AccessEx)
 编程语言:TypeScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */

 /// <summary>
 /// 论文关注(gs_PaperAttention)
 /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
 /// </summary>
/**
* Created by pyf2 on 2020年09月29日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsgs_PaperAttentionEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
import { clsgs_PaperAttentionENEx } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionENEx.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
var ResponseData: tzResponseData;
export class clsgs_PaperAttentionExWApi 
{
 public static mstrController: string = "gs_PaperAttentionExApi";
public objgs_PaperAttentionEN: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();

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
 /// 把同一个类的对象,复制到该类的扩展对象
 /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PaperAttentionENS">源对象</param>
 /// <param name = "objgs_PaperAttentionENT">目标对象</param>
public static CopyToEx(objgs_PaperAttentionENS: clsgs_PaperAttentionEN  ): clsgs_PaperAttentionENEx 
{
var objgs_PaperAttentionENT: clsgs_PaperAttentionENEx = new clsgs_PaperAttentionENEx();
objgs_PaperAttentionENT.PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objgs_PaperAttentionENT.PaperId = objgs_PaperAttentionENS.PaperId; //论文Id
objgs_PaperAttentionENT.UserId = objgs_PaperAttentionENS.UserId; //用户ID
objgs_PaperAttentionENT.PaperGroupId = objgs_PaperAttentionENS.PaperGroupId; //组Id
objgs_PaperAttentionENT.UpdUser = objgs_PaperAttentionENS.UpdUser; //修改人
objgs_PaperAttentionENT.UpdDate = objgs_PaperAttentionENS.UpdDate; //修改日期
objgs_PaperAttentionENT.Meno = objgs_PaperAttentionENS.Meno; //备注
objgs_PaperAttentionENT.sf_UpdFldSetStr = objgs_PaperAttentionENS.UpdFldString; //专门用于记录某字段属性是否修改
objgs_PaperAttentionENT.sf_FldComparisonOp = objgs_PaperAttentionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
return objgs_PaperAttentionENT; 
}

};