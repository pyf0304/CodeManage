﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAndroidSpinnerWApi
 表名:AndroidSpinner(00050391)
 生成代码版本:2018.08.11.1
 生成日期:2018/08/12 00:07:16
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成Android
 模块英文名:GCAndroid
 框架-层名:WebApi访问层(WebApiAccess)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using AGC.BusinessLogic;
using System.Collections.Generic;
using com.taishsoft.json;

namespace AGC4WApi
{
 /// <summary>
 /// Android下拉框(AndroidSpinner)
 /// (AutoGCLib.AutoGC6Cs_WApi:A_GenWebApiTransCode)
 /// </summary>
public class clsAndroidSpinnerWApi
{
private static string mstrApiControllerName = "AndroidSpinnerApi";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.AutoGC6Cs_WApi:A_GenWebApiTransCode)
 /// </summary>
public static List<clsAndroidSpinnerEN> arrAndroidSpinnerObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.AutoGC6Cs_WApi:A_GenWebApiTransCode)
 /// </summary>
protected static int intFindFailCount = 0;

 public clsAndroidSpinnerWApi()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_AndroidSpinnerId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
List<clsAndroidSpinnerEN> arrObjLst = GetObjLst("1=1");
clsAndroidSpinnerEN objAndroidSpinnerEN;
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
objAndroidSpinnerEN = new clsAndroidSpinnerEN();
objAndroidSpinnerEN.AndroidSpinnerId = "0";
objAndroidSpinnerEN.AndroidSpinnerName = "请选择[Android下拉框]...";
arrObjLst.Insert(0, objAndroidSpinnerEN);
//把DataTable中的所有项均加到对象列表中
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="AndroidSpinnerId";
objComboBox.DisplayMember="AndroidSpinnerName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_AndroidSpinnerId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[Android下拉框]...","0");
List<clsAndroidSpinnerEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="AndroidSpinnerId";
objDDL.DataTextField="AndroidSpinnerName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsAndroidSpinnerEN objAndroidSpinnerEN)
{
if (!Object.Equals(null, objAndroidSpinnerEN.AndroidSpinnerId) && getStrLen(objAndroidSpinnerEN.AndroidSpinnerId) > 8)
{
 throw new Exception("字段[AndroidSpinnerId]的长度不能超过8!");
}
if (!Object.Equals(null, objAndroidSpinnerEN.AndroidSpinnerName) && getStrLen(objAndroidSpinnerEN.AndroidSpinnerName) > 30)
{
 throw new Exception("字段[AndroidSpinnerName]的长度不能超过30!");
}
if (!Object.Equals(null, objAndroidSpinnerEN.Text) && getStrLen(objAndroidSpinnerEN.Text) > 30)
{
 throw new Exception("字段[文本]的长度不能超过30!");
}
if (!Object.Equals(null, objAndroidSpinnerEN.CssClass) && getStrLen(objAndroidSpinnerEN.CssClass) > 50)
{
 throw new Exception("字段[样式表]的长度不能超过50!");
}
if (!Object.Equals(null, objAndroidSpinnerEN.OnClick) && getStrLen(objAndroidSpinnerEN.OnClick) > 50)
{
 throw new Exception("字段[单击事件]的长度不能超过50!");
}
if (!Object.Equals(null, objAndroidSpinnerEN.entries) && getStrLen(objAndroidSpinnerEN.entries) > 50)
{
 throw new Exception("字段[下拉项]的长度不能超过50!");
}
 objAndroidSpinnerEN.IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strAndroidSpinnerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAndroidSpinnerEN GetObjByAndroidSpinnerId(string strAndroidSpinnerId)
{
string strAction = "GetObjByAndroidSpinnerId";
string strErrMsg = string.Empty;
string strResult = "";
clsAndroidSpinnerEN objAndroidSpinnerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strAndroidSpinnerId", strAndroidSpinnerId);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
objAndroidSpinnerEN = clsJSON.GetObjFromJson<clsAndroidSpinnerEN>(strResult);
return objAndroidSpinnerEN;
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return objAndroidSpinnerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
string strAction = "GetFirstID_S";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
return strResult;
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "GetFirstID_S", "clsAndroidSpinnerWApi:GetFirstID_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsAndroidSpinnerEN GetFirstAndroidSpinner_S(string strWhereCond)
{
string strAction = "GetFirstAndroidSpinner_S";
string strErrMsg = string.Empty;
string strResult = "";
clsAndroidSpinnerEN objAndroidSpinnerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
objAndroidSpinnerEN = clsJSON.GetObjFromJson<clsAndroidSpinnerEN>(strResult);
return objAndroidSpinnerEN;
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "GetFirstObj_S", "clsAndroidSpinnerWApi:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strAndroidSpinnerId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetAndroidSpinnerNameByAndroidSpinnerId_Cache(string strAndroidSpinnerId)
{
if (string.IsNullOrEmpty(strAndroidSpinnerId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrAndroidSpinnerObjLst_Cache.Count - 1;
int intMid = 0;
clsAndroidSpinnerEN objAndroidSpinnerEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objAndroidSpinnerEN = arrAndroidSpinnerObjLst_Cache[intMid];
if (objAndroidSpinnerEN.AndroidSpinnerId == strAndroidSpinnerId)
{
intFindFailCount = 0;
return objAndroidSpinnerEN.AndroidSpinnerName;
}
else if (objAndroidSpinnerEN.AndroidSpinnerId.CompareTo(strAndroidSpinnerId) > 0)
{
intEnd = intMid - 1;
}
else
{
intStart = intMid + 1;
}
}
intFindFailCount++;
// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
arrAndroidSpinnerObjLst_Cache = null;
if (intFindFailCount == 1) return GetAndroidSpinnerNameByAndroidSpinnerId_Cache(strAndroidSpinnerId);
string strErrMsgForGetObjById = string.Format("在AndroidSpinner对象缓存列表中,找不到记录[AndroidSpinnerId = {0}][intFindFailCount = {1}](函数:{2})", strAndroidSpinnerId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objAndroidSpinnerEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objAndroidSpinnerEN.AndroidSpinnerId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsAndroidSpinnerBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by AndroidSpinnerId");
if (arrAndroidSpinnerObjLst_Cache == null)
{
arrAndroidSpinnerObjLst_Cache = clsAndroidSpinnerWApi.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strAndroidSpinnerId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAndroidSpinnerEN GetObjByAndroidSpinnerId_Cache(string strAndroidSpinnerId)
{
if (string.IsNullOrEmpty(strAndroidSpinnerId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrAndroidSpinnerObjLst_Cache.Count - 1;
int intMid = 0;
clsAndroidSpinnerEN objAndroidSpinnerEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objAndroidSpinnerEN = arrAndroidSpinnerObjLst_Cache[intMid];
if (objAndroidSpinnerEN.AndroidSpinnerId == strAndroidSpinnerId)
{
intFindFailCount = 0;
return objAndroidSpinnerEN;
}
else if (objAndroidSpinnerEN.AndroidSpinnerId.CompareTo(strAndroidSpinnerId) > 0)
{
intEnd = intMid - 1;
}
else
{
intStart = intMid + 1;
}
}
intFindFailCount++;
// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
arrAndroidSpinnerObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByAndroidSpinnerId_Cache(strAndroidSpinnerId);
string strErrMsgForGetObjById = string.Format("在AndroidSpinner对象缓存列表中,找不到记录[AndroidSpinnerId = {0}][intFindFailCount = {1}](函数:{2})", strAndroidSpinnerId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objAndroidSpinnerEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objAndroidSpinnerEN.AndroidSpinnerId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsAndroidSpinnerBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAndroidSpinnerEN> GetObjLst(string strWhereCond)
{
 List<clsAndroidSpinnerEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
arrObjLst = clsJSON.GetObjLstFromJson<clsAndroidSpinnerEN>(strResult);
return arrObjLst;
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return arrObjLst;
}

public static List<clsAndroidSpinnerEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsAndroidSpinnerEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("strOrderBy", strOrderBy);
dictParam.Add("intMinNum", intMinNum.ToString());
dictParam.Add("intMaxNum", intMaxNum.ToString());
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
arrObjLst = clsJSON.GetObjLstFromJson<clsAndroidSpinnerEN>(strResult);
return arrObjLst;
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "GetObjLstByRange", "clsAndroidSpinnerWApi:GetObjLstByRange", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strAndroidSpinnerId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strAndroidSpinnerId", strAndroidSpinnerId);
try
{
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
int intResult  = int.Parse(strResult);
return intResult;
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "DelRecord", "clsAndroidSpinnerWApi:DelRecord", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelAndroidSpinners(List<string> arrAndroidSpinnerId)
{
string strAction = "DelAndroidSpinners";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAndroidSpinnerId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
int intResult  = int.Parse(strResult);
return intResult;
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "DelAndroidSpinners", "clsAndroidSpinnerWApi:DelAndroidSpinners", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelAndroidSpinnersByCond(string strWhereCond)
{
string strAction = "funGetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
  int intRecCount =  int.Parse(strResult);
return intRecCount;
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "DelAndroidSpinnersByCond", "clsAndroidSpinnerWApi:DelAndroidSpinnersByCond", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_AddNewRecordBySql2)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecordByJSON(clsAndroidSpinnerEN objAndroidSpinnerEN)
{
string strAction = "AddNewRecordByJSON";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAndroidSpinnerEN>(objAndroidSpinnerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
bool bolResult = bool.Parse(strResult);
return bolResult;
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "AddNewRecordBySql2", "clsAndroidSpinnerWApi:AddNewRecordBySql2", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_UpdateBySql2)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateBySql2(clsAndroidSpinnerEN objAndroidSpinnerEN)
{
string strAction = "UpdateByJSON";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAndroidSpinnerEN>(objAndroidSpinnerEN);
if (clsPubFun4WApi.Put(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
bool bolResult = bool.Parse(strResult);
return bolResult;
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "UpdateBySql2", "clsAndroidSpinnerWApi:UpdateBySql2", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objAndroidSpinnerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsAndroidSpinnerEN objAndroidSpinnerEN, string strWhereCond)
{
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAndroidSpinnerEN>(objAndroidSpinnerEN);
if (clsPubFun4WApi.Put(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
bool bolResult = bool.Parse(strResult);
return bolResult;
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "UpdateWithCondition", "clsAndroidSpinnerWApi:UpdateWithCondition", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
bool bolIsExist = bool.Parse(strResult);
return bolIsExist;
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strAndroidSpinnerId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strAndroidSpinnerId", strAndroidSpinnerId);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
bool bolIsExist = bool.Parse(strResult);
return bolIsExist;
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_funGetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int funGetRecCountByCond(string strWhereCond)
{
string strAction = "funGetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
return int.Parse(strResult);
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
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
string strMaxAndroidSpinnerId = strResult;
return strMaxAndroidSpinnerId;
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
string strMaxAndroidSpinnerId = strResult;
return strMaxAndroidSpinnerId;
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.AutoGCPubFuncV6:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int getStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}
}
}