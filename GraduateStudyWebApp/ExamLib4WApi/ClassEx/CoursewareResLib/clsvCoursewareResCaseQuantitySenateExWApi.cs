﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCaseQuantitySenateExWApi
 表名:vCoursewareResCaseQuantitySenate(01120453)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:22
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库
 模块英文名:CoursewareResLib
 框架-层名:WA_访问扩展层_CS(WA_AccessEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using com.taishsoft.common;
using System.ServiceModel;
using ExamLib.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using Newtonsoft.Json.Linq;

namespace ExamLib4WApi
{
public static class clsvCoursewareResCaseQuantitySenateExWApi_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateENS">源对象</param>
 /// <returns>目标对象=>clsvCoursewareResCaseQuantitySenateEN:objvCoursewareResCaseQuantitySenateENT</returns>
 public static clsvCoursewareResCaseQuantitySenateENEx CopyToEx(this clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateENS)
{
try
{
 clsvCoursewareResCaseQuantitySenateENEx objvCoursewareResCaseQuantitySenateENT = new clsvCoursewareResCaseQuantitySenateENEx();
clsvCoursewareResCaseQuantitySenateWApi.CopyTo(objvCoursewareResCaseQuantitySenateENS, objvCoursewareResCaseQuantitySenateENT);
 return objvCoursewareResCaseQuantitySenateENT;
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
 /// v课件资源量化评议(vCoursewareResCaseQuantitySenate)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareResCaseQuantitySenateExWApi
{
//private static readonly string mstrApiControllerName = "vCoursewareResCaseQuantitySenateExApi";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public static List<clsvCoursewareResCaseQuantitySenateEN> arrvCoursewareResCaseQuantitySenateObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
/// </summary>
 public clsvCoursewareResCaseQuantitySenateExWApi()
 {
 }

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool EditRecordEx(clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN)
{
if (string.IsNullOrEmpty(objvCoursewareResCaseQuantitySenateEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objvCoursewareResCaseQuantitySenateEN.id_microteachCaseQuantitySenate, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "EditRecordEx";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsvCoursewareResCaseQuantitySenateEN>(objvCoursewareResCaseQuantitySenateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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