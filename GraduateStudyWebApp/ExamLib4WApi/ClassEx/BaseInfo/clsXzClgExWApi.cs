
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzClgExWApi
 表名:XzClg(01120064)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:58
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护
 模块英文名:BaseInfo
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
public static class clsXzClgExWApi_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objXzClgENS">源对象</param>
 /// <returns>目标对象=>clsXzClgEN:objXzClgENT</returns>
 public static clsXzClgENEx CopyToEx(this clsXzClgEN objXzClgENS)
{
try
{
 clsXzClgENEx objXzClgENT = new clsXzClgENEx();
clsXzClgWApi.CopyTo(objXzClgENS, objXzClgENT);
 return objXzClgENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool EditRecordEx(this clsXzClgEN objXzClgEN)
{
try
{
objXzClgEN.sf_UpdFldSetStr = objXzClgEN.getsf_UpdFldSetStr();
bool bolResult = clsXzClgExWApi.EditRecordEx(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000006)编辑记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 学院(XzClg)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsXzClgExWApi
{
//private static readonly string mstrApiControllerName = "XzClgExApi";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public static List<clsXzClgEN> arrXzClgObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
/// </summary>
 public clsXzClgExWApi()
 {
 }

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool EditRecordEx(clsXzClgEN objXzClgEN)
{
if (string.IsNullOrEmpty(objXzClgEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzClgEN.id_XzCollege, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "EditRecordEx";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzClgEN>(objXzClgEN);
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

 /// <summary>
 /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
 /// </summary>
 /// <param name = "id">strid_XzCollege</param>
 /// <returns>返回对象列表</returns>
public static bool DelRecordEx(string id)
{
string strAction = "DelRecordEx";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id"] = id,
};
try
{
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, id.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var varResult = (bool)jobjReturn["ReturnBool"];
return varResult;
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
string strMsg = string.Format("扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
 /// <summary>
 /// 获取当前表关键字值的最大值,再加1
 /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
 /// </summary>
 /// <returns>返回对象列表</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var varResult = (string)jobjReturn["ReturnStr"];
return varResult;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取当前表关键字值的最大值,再加1出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1
 /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
 /// </summary>
 /// <param name = "strPrefix">strPrefix</param>
 /// <returns>返回对象列表</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrefix"] = strPrefix,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var varResult = (string)jobjReturn["ReturnStr"];
return varResult;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取当前表关键字值的最大值,再加1出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示
 /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
 /// </summary>
 /// <param name = "strid_XzCollege">strid_XzCollege</param>
 /// <returns>返回对象列表</returns>
public static clsXzClgEN GetObjByid_XzCollege(string strid_XzCollege)
{
string strAction = "GetObjByid_XzCollege";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strid_XzCollege"] = strid_XzCollege,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var varResult = clsJSON.GetObjFromJson<clsXzClgEN>((string)jobjReturn["ReturnObj"]);
return varResult;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取当前关键字的记录对象,用对象的形式表示出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示
 /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
 /// </summary>
 /// <param name = "strid_XzCollege">strid_XzCollege</param>
 /// <returns>返回对象列表</returns>
public static clsXzClgENEx GetObjExByid_XzCollege(string strid_XzCollege)
{
string strAction = "GetObjExByid_XzCollege";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strid_XzCollege"] = strid_XzCollege,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var varResult = clsJSON.GetObjFromJson<clsXzClgENEx>((string)jobjReturn["ReturnObj"]);
return varResult;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取当前关键字的记录对象,用对象的形式表示出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
 /// <summary>
 /// 获取扩展对象
 /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
 /// </summary>
 /// <param name = "strCondition">条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzClgENEx> GetObjExLst(string strCondition)
{
string strAction = "GetObjExLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCondition"] = strCondition,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var varResult = clsJSON.GetObjLstFromJson<clsXzClgENEx>((string)jobjReturn["ReturnObjLst"]);
return varResult;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取扩展对象出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
 /// <summary>
 /// 获取项部对象列表
 /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
 /// </summary>
 /// <param name = "objTopPara">顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzClgEN> GetTopObjLst(stuTopPara objTopPara)
{
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["objTopPara"] = objTopPara.ToString(),
};
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var varResult = clsJSON.GetObjLstFromJson<clsXzClgEN>((string)jobjReturn["ReturnObjLst"]);
return varResult;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取项部对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回对象列表</returns>
public static bool IsExistRecord(string strWhereCond)
{
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var varResult = (bool)jobjReturn["ReturnBool"];
return varResult;
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
string strMsg = string.Format("根据条件判断是否存在记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
 /// <summary>
 /// 相加
 /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
 /// </summary>
 /// <param name = "a">a</param>
 /// <param name = "b">b</param>
 /// <returns>返回对象列表</returns>
public static int Plus(int a,int b)
{
string strAction = "Plus";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["a"] = a.ToString(),
["b"] = b.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var varResult = (int)jobjReturn["ReturnInt"];
return varResult;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("相加出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
 /// <summary>
 /// 修改记录
 /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
 /// </summary>
 /// <param name = "objXzClgEN">objXzClgEN</param>
 /// <returns>返回对象列表</returns>
public static bool UpdateRecord(clsXzClgEN objXzClgEN)
{
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["objXzClgEN"] = objXzClgEN.ToString(),
};
try
{
string strJSON = clsJSON.GetJsonFromObj<clsXzClgEN>(objXzClgEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var varResult = (bool)jobjReturn["ReturnBool"];
return varResult;
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
string strMsg = string.Format("修改记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
}
}