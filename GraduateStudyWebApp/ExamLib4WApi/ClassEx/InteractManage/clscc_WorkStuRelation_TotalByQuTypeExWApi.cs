
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation_TotalByQuTypeExWApi
 表名:cc_WorkStuRelation_TotalByQuType(01120354)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:31
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clscc_WorkStuRelation_TotalByQuTypeExWApi_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkStuRelation_TotalByQuTypeEN:objcc_WorkStuRelation_TotalByQuTypeENT</returns>
 public static clscc_WorkStuRelation_TotalByQuTypeENEx CopyToEx(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeENS)
{
try
{
 clscc_WorkStuRelation_TotalByQuTypeENEx objcc_WorkStuRelation_TotalByQuTypeENT = new clscc_WorkStuRelation_TotalByQuTypeENEx();
clscc_WorkStuRelation_TotalByQuTypeWApi.CopyTo(objcc_WorkStuRelation_TotalByQuTypeENS, objcc_WorkStuRelation_TotalByQuTypeENT);
 return objcc_WorkStuRelation_TotalByQuTypeENT;
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool EditRecordEx(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.sf_UpdFldSetStr = objcc_WorkStuRelation_TotalByQuTypeEN.getsf_UpdFldSetStr();
bool bolResult = clscc_WorkStuRelation_TotalByQuTypeExWApi.EditRecordEx(objcc_WorkStuRelation_TotalByQuTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeWApi.ReFreshCache();
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
 /// 作业完成情况汇总表ByQuType(cc_WorkStuRelation_TotalByQuType)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkStuRelation_TotalByQuTypeExWApi
{
//private static readonly string mstrApiControllerName = "cc_WorkStuRelation_TotalByQuTypeExApi";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> arrcc_WorkStuRelation_TotalByQuTypeObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
/// </summary>
 public clscc_WorkStuRelation_TotalByQuTypeExWApi()
 {
 }

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool EditRecordEx(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
if (string.IsNullOrEmpty(objcc_WorkStuRelation_TotalByQuTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelation_TotalByQuTypeEN.Id_WorkStuRelation_Total, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "EditRecordEx";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation_TotalByQuTypeEN>(objcc_WorkStuRelation_TotalByQuTypeEN);
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