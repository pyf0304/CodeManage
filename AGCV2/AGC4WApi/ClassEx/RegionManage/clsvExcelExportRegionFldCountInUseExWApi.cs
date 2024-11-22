﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExcelExportRegionFldCountInUseExWApi
 表名:vExcelExportRegionFldCountInUse(00050582)
 生成代码版本:2020.11.22.1
 生成日期:2020/11/27 16:01:08
 生成者:pyf
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
 框架-层名:WA_访问扩展层(WA_AccessEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using Newtonsoft.Json.Linq; 

namespace AGC4WApi
{
public static class clsvExcelExportRegionFldCountInUseExWApi_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldCountInUseENS">源对象</param>
 /// <returns>目标对象=>clsvExcelExportRegionFldCountInUseEN:objvExcelExportRegionFldCountInUseENT</returns>
 public static clsvExcelExportRegionFldCountInUseENEx CopyToEx(this clsvExcelExportRegionFldCountInUseEN objvExcelExportRegionFldCountInUseENS)
{
try
{
 clsvExcelExportRegionFldCountInUseENEx objvExcelExportRegionFldCountInUseENT = new clsvExcelExportRegionFldCountInUseENEx();
clsvExcelExportRegionFldCountInUseWApi.CopyTo(objvExcelExportRegionFldCountInUseENS, objvExcelExportRegionFldCountInUseENT);
 return objvExcelExportRegionFldCountInUseENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// v在用导出区字段数(vExcelExportRegionFldCountInUse)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsvExcelExportRegionFldCountInUseExWApi
{
private static readonly string mstrApiControllerName = "vExcelExportRegionFldCountInUseExApi";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public static List<clsvExcelExportRegionFldCountInUseEN> arrvExcelExportRegionFldCountInUseObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
/// </summary>
 public clsvExcelExportRegionFldCountInUseExWApi()
 {
 }

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool EditRecordEx(clsvExcelExportRegionFldCountInUseEN objvExcelExportRegionFldCountInUseEN)
{
if (string.IsNullOrEmpty(objvExcelExportRegionFldCountInUseEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objvExcelExportRegionFldCountInUseEN.RegionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "EditRecordEx";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsvExcelExportRegionFldCountInUseEN>(objvExcelExportRegionFldCountInUseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

}
}