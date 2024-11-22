
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsTeacher4SynchExWApi
 表名:CurrEduClsTeacher4Synch(01120360)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:11
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步
 模块英文名:DataSynch
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
public static class clsCurrEduClsTeacher4SynchExWApi_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchENS">源对象</param>
 /// <returns>目标对象=>clsCurrEduClsTeacher4SynchEN:objCurrEduClsTeacher4SynchENT</returns>
 public static clsCurrEduClsTeacher4SynchENEx CopyToEx(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchENS)
{
try
{
 clsCurrEduClsTeacher4SynchENEx objCurrEduClsTeacher4SynchENT = new clsCurrEduClsTeacher4SynchENEx();
clsCurrEduClsTeacher4SynchWApi.CopyTo(objCurrEduClsTeacher4SynchENS, objCurrEduClsTeacher4SynchENT);
 return objCurrEduClsTeacher4SynchENT;
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
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool EditRecordEx(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN)
{
try
{
objCurrEduClsTeacher4SynchEN.sf_UpdFldSetStr = objCurrEduClsTeacher4SynchEN.getsf_UpdFldSetStr();
bool bolResult = clsCurrEduClsTeacher4SynchExWApi.EditRecordEx(objCurrEduClsTeacher4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacher4SynchWApi.ReFreshCache();
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
 /// 当前教学班教师_同步(CurrEduClsTeacher4Synch)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduClsTeacher4SynchExWApi
{
//private static readonly string mstrApiControllerName = "CurrEduClsTeacher4SynchExApi";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public static List<clsCurrEduClsTeacher4SynchEN> arrCurrEduClsTeacher4SynchObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
/// </summary>
 public clsCurrEduClsTeacher4SynchExWApi()
 {
 }

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool EditRecordEx(clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN)
{
if (string.IsNullOrEmpty(objCurrEduClsTeacher4SynchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsTeacher4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "EditRecordEx";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsTeacher4SynchEN>(objCurrEduClsTeacher4SynchEN);
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