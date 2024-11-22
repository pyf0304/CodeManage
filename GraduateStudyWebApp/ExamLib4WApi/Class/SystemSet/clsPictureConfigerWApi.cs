
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPictureConfigerWApi
 表名:PictureConfiger(01120039)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:13
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
 框架-层名:WA_访问层_CS(WA_Access)
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsPictureConfigerWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureConfigerEN SetPictureConfigerId(this clsPictureConfigerEN objPictureConfigerEN, string strPictureConfigerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPictureConfigerId, 4, conPictureConfiger.PictureConfigerId);
clsCheckSql.CheckFieldForeignKey(strPictureConfigerId, 4, conPictureConfiger.PictureConfigerId);
objPictureConfigerEN.PictureConfigerId = strPictureConfigerId; //PictureConfigerId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureConfigerEN.dicFldComparisonOp.ContainsKey(conPictureConfiger.PictureConfigerId) == false)
{
objPictureConfigerEN.dicFldComparisonOp.Add(conPictureConfiger.PictureConfigerId, strComparisonOp);
}
else
{
objPictureConfigerEN.dicFldComparisonOp[conPictureConfiger.PictureConfigerId] = strComparisonOp;
}
}
return objPictureConfigerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureConfigerEN SetPictureConfigName(this clsPictureConfigerEN objPictureConfigerEN, string strPictureConfigName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPictureConfigName, conPictureConfiger.PictureConfigName);
clsCheckSql.CheckFieldLen(strPictureConfigName, 50, conPictureConfiger.PictureConfigName);
objPictureConfigerEN.PictureConfigName = strPictureConfigName; //PictureConfigName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureConfigerEN.dicFldComparisonOp.ContainsKey(conPictureConfiger.PictureConfigName) == false)
{
objPictureConfigerEN.dicFldComparisonOp.Add(conPictureConfiger.PictureConfigName, strComparisonOp);
}
else
{
objPictureConfigerEN.dicFldComparisonOp[conPictureConfiger.PictureConfigName] = strComparisonOp;
}
}
return objPictureConfigerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureConfigerEN SetPicturePath(this clsPictureConfigerEN objPictureConfigerEN, string strPicturePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPicturePath, conPictureConfiger.PicturePath);
clsCheckSql.CheckFieldLen(strPicturePath, 50, conPictureConfiger.PicturePath);
objPictureConfigerEN.PicturePath = strPicturePath; //PicturePath
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureConfigerEN.dicFldComparisonOp.ContainsKey(conPictureConfiger.PicturePath) == false)
{
objPictureConfigerEN.dicFldComparisonOp.Add(conPictureConfiger.PicturePath, strComparisonOp);
}
else
{
objPictureConfigerEN.dicFldComparisonOp[conPictureConfiger.PicturePath] = strComparisonOp;
}
}
return objPictureConfigerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureConfigerEN SetThumbHeight(this clsPictureConfigerEN objPictureConfigerEN, int intThumbHeight, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intThumbHeight, conPictureConfiger.ThumbHeight);
objPictureConfigerEN.ThumbHeight = intThumbHeight; //ThumbHeight
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureConfigerEN.dicFldComparisonOp.ContainsKey(conPictureConfiger.ThumbHeight) == false)
{
objPictureConfigerEN.dicFldComparisonOp.Add(conPictureConfiger.ThumbHeight, strComparisonOp);
}
else
{
objPictureConfigerEN.dicFldComparisonOp[conPictureConfiger.ThumbHeight] = strComparisonOp;
}
}
return objPictureConfigerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureConfigerEN SetThumbWidth(this clsPictureConfigerEN objPictureConfigerEN, int intThumbWidth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intThumbWidth, conPictureConfiger.ThumbWidth);
objPictureConfigerEN.ThumbWidth = intThumbWidth; //ThumbWidth
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureConfigerEN.dicFldComparisonOp.ContainsKey(conPictureConfiger.ThumbWidth) == false)
{
objPictureConfigerEN.dicFldComparisonOp.Add(conPictureConfiger.ThumbWidth, strComparisonOp);
}
else
{
objPictureConfigerEN.dicFldComparisonOp[conPictureConfiger.ThumbWidth] = strComparisonOp;
}
}
return objPictureConfigerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureConfigerEN SetResizePictureHeight(this clsPictureConfigerEN objPictureConfigerEN, int intResizePictureHeight, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intResizePictureHeight, conPictureConfiger.ResizePictureHeight);
objPictureConfigerEN.ResizePictureHeight = intResizePictureHeight; //ResizePictureHeight
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureConfigerEN.dicFldComparisonOp.ContainsKey(conPictureConfiger.ResizePictureHeight) == false)
{
objPictureConfigerEN.dicFldComparisonOp.Add(conPictureConfiger.ResizePictureHeight, strComparisonOp);
}
else
{
objPictureConfigerEN.dicFldComparisonOp[conPictureConfiger.ResizePictureHeight] = strComparisonOp;
}
}
return objPictureConfigerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureConfigerEN SetMaxSize(this clsPictureConfigerEN objPictureConfigerEN, string strMaxSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMaxSize, conPictureConfiger.MaxSize);
clsCheckSql.CheckFieldLen(strMaxSize, 50, conPictureConfiger.MaxSize);
objPictureConfigerEN.MaxSize = strMaxSize; //MaxSize
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureConfigerEN.dicFldComparisonOp.ContainsKey(conPictureConfiger.MaxSize) == false)
{
objPictureConfigerEN.dicFldComparisonOp.Add(conPictureConfiger.MaxSize, strComparisonOp);
}
else
{
objPictureConfigerEN.dicFldComparisonOp[conPictureConfiger.MaxSize] = strComparisonOp;
}
}
return objPictureConfigerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureConfigerEN SetResizePictureWidth(this clsPictureConfigerEN objPictureConfigerEN, int intResizePictureWidth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intResizePictureWidth, conPictureConfiger.ResizePictureWidth);
objPictureConfigerEN.ResizePictureWidth = intResizePictureWidth; //ResizePictureWidth
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureConfigerEN.dicFldComparisonOp.ContainsKey(conPictureConfiger.ResizePictureWidth) == false)
{
objPictureConfigerEN.dicFldComparisonOp.Add(conPictureConfiger.ResizePictureWidth, strComparisonOp);
}
else
{
objPictureConfigerEN.dicFldComparisonOp[conPictureConfiger.ResizePictureWidth] = strComparisonOp;
}
}
return objPictureConfigerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureConfigerEN SetMemo(this clsPictureConfigerEN objPictureConfigerEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPictureConfiger.Memo);
objPictureConfigerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureConfigerEN.dicFldComparisonOp.ContainsKey(conPictureConfiger.Memo) == false)
{
objPictureConfigerEN.dicFldComparisonOp.Add(conPictureConfiger.Memo, strComparisonOp);
}
else
{
objPictureConfigerEN.dicFldComparisonOp[conPictureConfiger.Memo] = strComparisonOp;
}
}
return objPictureConfigerEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPictureConfigerEN objPictureConfiger_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPictureConfiger_Cond.IsUpdated(conPictureConfiger.PictureConfigerId) == true)
{
string strComparisonOp_PictureConfigerId = objPictureConfiger_Cond.dicFldComparisonOp[conPictureConfiger.PictureConfigerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureConfiger.PictureConfigerId, objPictureConfiger_Cond.PictureConfigerId, strComparisonOp_PictureConfigerId);
}
if (objPictureConfiger_Cond.IsUpdated(conPictureConfiger.PictureConfigName) == true)
{
string strComparisonOp_PictureConfigName = objPictureConfiger_Cond.dicFldComparisonOp[conPictureConfiger.PictureConfigName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureConfiger.PictureConfigName, objPictureConfiger_Cond.PictureConfigName, strComparisonOp_PictureConfigName);
}
if (objPictureConfiger_Cond.IsUpdated(conPictureConfiger.PicturePath) == true)
{
string strComparisonOp_PicturePath = objPictureConfiger_Cond.dicFldComparisonOp[conPictureConfiger.PicturePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureConfiger.PicturePath, objPictureConfiger_Cond.PicturePath, strComparisonOp_PicturePath);
}
if (objPictureConfiger_Cond.IsUpdated(conPictureConfiger.ThumbHeight) == true)
{
string strComparisonOp_ThumbHeight = objPictureConfiger_Cond.dicFldComparisonOp[conPictureConfiger.ThumbHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureConfiger.ThumbHeight, objPictureConfiger_Cond.ThumbHeight, strComparisonOp_ThumbHeight);
}
if (objPictureConfiger_Cond.IsUpdated(conPictureConfiger.ThumbWidth) == true)
{
string strComparisonOp_ThumbWidth = objPictureConfiger_Cond.dicFldComparisonOp[conPictureConfiger.ThumbWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureConfiger.ThumbWidth, objPictureConfiger_Cond.ThumbWidth, strComparisonOp_ThumbWidth);
}
if (objPictureConfiger_Cond.IsUpdated(conPictureConfiger.ResizePictureHeight) == true)
{
string strComparisonOp_ResizePictureHeight = objPictureConfiger_Cond.dicFldComparisonOp[conPictureConfiger.ResizePictureHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureConfiger.ResizePictureHeight, objPictureConfiger_Cond.ResizePictureHeight, strComparisonOp_ResizePictureHeight);
}
if (objPictureConfiger_Cond.IsUpdated(conPictureConfiger.MaxSize) == true)
{
string strComparisonOp_MaxSize = objPictureConfiger_Cond.dicFldComparisonOp[conPictureConfiger.MaxSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureConfiger.MaxSize, objPictureConfiger_Cond.MaxSize, strComparisonOp_MaxSize);
}
if (objPictureConfiger_Cond.IsUpdated(conPictureConfiger.ResizePictureWidth) == true)
{
string strComparisonOp_ResizePictureWidth = objPictureConfiger_Cond.dicFldComparisonOp[conPictureConfiger.ResizePictureWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureConfiger.ResizePictureWidth, objPictureConfiger_Cond.ResizePictureWidth, strComparisonOp_ResizePictureWidth);
}
if (objPictureConfiger_Cond.IsUpdated(conPictureConfiger.Memo) == true)
{
string strComparisonOp_Memo = objPictureConfiger_Cond.dicFldComparisonOp[conPictureConfiger.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureConfiger.Memo, objPictureConfiger_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPictureConfigerEN objPictureConfigerEN)
{
 if (string.IsNullOrEmpty(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPictureConfigerEN.sf_UpdFldSetStr = objPictureConfigerEN.getsf_UpdFldSetStr();
clsPictureConfigerWApi.CheckPropertyNew(objPictureConfigerEN); 
bool bolResult = clsPictureConfigerWApi.UpdateRecord(objPictureConfigerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPictureConfigerEN objPictureConfigerEN)
{
 if (string.IsNullOrEmpty(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPictureConfigerWApi.IsExist(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objPictureConfigerEN.PictureConfigerId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsPictureConfigerWApi.CheckPropertyNew(objPictureConfigerEN); 
bool bolResult = clsPictureConfigerWApi.AddNewRecord(objPictureConfigerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPictureConfigerEN objPictureConfigerEN)
{
try
{
clsPictureConfigerWApi.CheckPropertyNew(objPictureConfigerEN); 
string strPictureConfigerId = clsPictureConfigerWApi.AddNewRecordWithMaxId(objPictureConfigerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerWApi.ReFreshCache();
return strPictureConfigerId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPictureConfigerEN objPictureConfigerEN, string strWhereCond)
{
try
{
clsPictureConfigerWApi.CheckPropertyNew(objPictureConfigerEN); 
bool bolResult = clsPictureConfigerWApi.UpdateWithCondition(objPictureConfigerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 图片配置(PictureConfiger)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPictureConfigerWApi
{
private static readonly string mstrApiControllerName = "PictureConfigerApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsPictureConfigerWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PictureConfigerId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[图片配置]...","0");
List<clsPictureConfigerEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PictureConfigerId";
objDDL.DataTextField="PictureConfigName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_PictureConfigerId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPictureConfiger.PictureConfigerId); 
List<clsPictureConfigerEN> arrObjLst = clsPictureConfigerWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN()
{
PictureConfigerId = "0",
PictureConfigName = "选[图片配置]..."
};
arrObjLst.Insert(0, objPictureConfigerEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPictureConfiger.PictureConfigerId;
objComboBox.DisplayMember = conPictureConfiger.PictureConfigName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPictureConfigerEN objPictureConfigerEN)
{
if (!Object.Equals(null, objPictureConfigerEN.PictureConfigerId) && GetStrLen(objPictureConfigerEN.PictureConfigerId) > 4)
{
 throw new Exception("字段[PictureConfigerId]的长度不能超过4!");
}
if (!Object.Equals(null, objPictureConfigerEN.PictureConfigName) && GetStrLen(objPictureConfigerEN.PictureConfigName) > 50)
{
 throw new Exception("字段[PictureConfigName]的长度不能超过50!");
}
if (!Object.Equals(null, objPictureConfigerEN.PicturePath) && GetStrLen(objPictureConfigerEN.PicturePath) > 50)
{
 throw new Exception("字段[PicturePath]的长度不能超过50!");
}
if (!Object.Equals(null, objPictureConfigerEN.MaxSize) && GetStrLen(objPictureConfigerEN.MaxSize) > 50)
{
 throw new Exception("字段[MaxSize]的长度不能超过50!");
}
if (!Object.Equals(null, objPictureConfigerEN.Memo) && GetStrLen(objPictureConfigerEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objPictureConfigerEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPictureConfigerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPictureConfigerEN GetObjByPictureConfigerId(string strPictureConfigerId)
{
string strAction = "GetObjByPictureConfigerId";
string strErrMsg = string.Empty;
string strResult = "";
clsPictureConfigerEN objPictureConfigerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PictureConfigerId"] = strPictureConfigerId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPictureConfigerEN = JsonConvert.DeserializeObject<clsPictureConfigerEN>((string)jobjReturn["ReturnObj"]);
return objPictureConfigerEN;
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
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strPictureConfigerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPictureConfigerEN GetObjByPictureConfigerId_WA_Cache(string strPictureConfigerId)
{
string strAction = "GetObjByPictureConfigerId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsPictureConfigerEN objPictureConfigerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PictureConfigerId"] = strPictureConfigerId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPictureConfigerEN = JsonConvert.DeserializeObject<clsPictureConfigerEN>((string)jobjReturn["ReturnObj"]);
return objPictureConfigerEN;
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
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsPictureConfigerEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsPictureConfigerEN objPictureConfigerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPictureConfigerEN = JsonConvert.DeserializeObject<clsPictureConfigerEN>((string)jobjReturn["ReturnObj"]);
return objPictureConfigerEN;
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strPictureConfigerId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPictureConfigerEN GetObjByPictureConfigerId_Cache(string strPictureConfigerId)
{
if (string.IsNullOrEmpty(strPictureConfigerId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName_S);
List<clsPictureConfigerEN> arrPictureConfigerObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPictureConfigerEN> arrPictureConfigerObjLst_Sel =
from objPictureConfigerEN in arrPictureConfigerObjLst_Cache
where objPictureConfigerEN.PictureConfigerId == strPictureConfigerId
select objPictureConfigerEN;
if (arrPictureConfigerObjLst_Sel.Count() == 0)
{
   clsPictureConfigerEN obj = clsPictureConfigerWApi.GetObjByPictureConfigerId(strPictureConfigerId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPictureConfigerObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strPictureConfigerId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPictureConfigNameByPictureConfigerId_Cache(string strPictureConfigerId)
{
if (string.IsNullOrEmpty(strPictureConfigerId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName_S);
List<clsPictureConfigerEN> arrPictureConfigerObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPictureConfigerEN> arrPictureConfigerObjLst_Sel1 =
from objPictureConfigerEN in arrPictureConfigerObjLst_Cache
where objPictureConfigerEN.PictureConfigerId == strPictureConfigerId
select objPictureConfigerEN;
List <clsPictureConfigerEN> arrPictureConfigerObjLst_Sel = new List<clsPictureConfigerEN>();
foreach (clsPictureConfigerEN obj in arrPictureConfigerObjLst_Sel1)
{
arrPictureConfigerObjLst_Sel.Add(obj);
}
if (arrPictureConfigerObjLst_Sel.Count > 0)
{
return arrPictureConfigerObjLst_Sel[0].PictureConfigName;
}
string strErrMsgForGetObjById = string.Format("在PictureConfiger对象缓存列表中,找不到记录[PictureConfigerId = {0}](函数:{1})", strPictureConfigerId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPictureConfigerBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strPictureConfigerId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPictureConfigerId_Cache(string strPictureConfigerId)
{
if (string.IsNullOrEmpty(strPictureConfigerId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName_S);
List<clsPictureConfigerEN> arrPictureConfigerObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPictureConfigerEN> arrPictureConfigerObjLst_Sel1 =
from objPictureConfigerEN in arrPictureConfigerObjLst_Cache
where objPictureConfigerEN.PictureConfigerId == strPictureConfigerId
select objPictureConfigerEN;
List <clsPictureConfigerEN> arrPictureConfigerObjLst_Sel = new List<clsPictureConfigerEN>();
foreach (clsPictureConfigerEN obj in arrPictureConfigerObjLst_Sel1)
{
arrPictureConfigerObjLst_Sel.Add(obj);
}
if (arrPictureConfigerObjLst_Sel.Count > 0)
{
return arrPictureConfigerObjLst_Sel[0].PictureConfigName;
}
string strErrMsgForGetObjById = string.Format("在PictureConfiger对象缓存列表中,找不到记录的相关名称[PictureConfigerId = {0}](函数:{1})", strPictureConfigerId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPictureConfigerBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLst(string strWhereCond)
{
 List<clsPictureConfigerEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureConfigerEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
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
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLstByPictureConfigerIdLst(List<string> arrPictureConfigerId)
{
 List<clsPictureConfigerEN> arrObjLst = null; 
string strAction = "GetObjLstByPictureConfigerIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPictureConfigerId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureConfigerEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
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
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strPictureConfigerId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsPictureConfigerEN> GetObjLstByPictureConfigerIdLst_Cache(List<string> arrPictureConfigerId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName_S);
List<clsPictureConfigerEN> arrPictureConfigerObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPictureConfigerEN> arrPictureConfigerObjLst_Sel =
from objPictureConfigerEN in arrPictureConfigerObjLst_Cache
where arrPictureConfigerId.Contains(objPictureConfigerEN.PictureConfigerId)
select objPictureConfigerEN;
return arrPictureConfigerObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLstByPictureConfigerIdLst_WA_Cache(List<string> arrPictureConfigerId)
{
 List<clsPictureConfigerEN> arrObjLst = null; 
string strAction = "GetObjLstByPictureConfigerIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPictureConfigerId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureConfigerEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
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
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureConfigerEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPictureConfigerEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureConfigerEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
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
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPictureConfigerEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureConfigerEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPictureConfigerEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureConfigerEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsPictureConfigerEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureConfigerEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strPictureConfigerId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsPictureConfigerEN objPictureConfigerEN = clsPictureConfigerWApi.GetObjByPictureConfigerId(strPictureConfigerId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strPictureConfigerId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPictureConfigerWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelPictureConfigers(List<string> arrPictureConfigerId)
{
string strAction = "DelPictureConfigers";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPictureConfigerId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPictureConfigerWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelPictureConfigersByCond(string strWhereCond)
{
string strAction = "DelPictureConfigersByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsPictureConfigerEN objPictureConfigerEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPictureConfigerEN>(objPictureConfigerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerWApi.ReFreshCache();
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsPictureConfigerEN objPictureConfigerEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPictureConfigerEN>(objPictureConfigerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerWApi.ReFreshCache();
var strPictureConfigerId = (string)jobjReturn["ReturnStr"];
return strPictureConfigerId;
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsPictureConfigerEN objPictureConfigerEN)
{
if (string.IsNullOrEmpty(objPictureConfigerEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPictureConfigerEN.PictureConfigerId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPictureConfigerEN>(objPictureConfigerEN);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPictureConfigerEN objPictureConfigerEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPictureConfigerEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPictureConfigerEN.PictureConfigerId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPictureConfigerEN.PictureConfigerId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPictureConfigerEN>(objPictureConfigerEN);
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
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
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
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strPictureConfigerId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PictureConfigerId"] = strPictureConfigerId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
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
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
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
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
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
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
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
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
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
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objPictureConfigerENS">源对象</param>
 /// <param name = "objPictureConfigerENT">目标对象</param>
 public static void CopyTo(clsPictureConfigerEN objPictureConfigerENS, clsPictureConfigerEN objPictureConfigerENT)
{
try
{
objPictureConfigerENT.PictureConfigerId = objPictureConfigerENS.PictureConfigerId; //PictureConfigerId
objPictureConfigerENT.PictureConfigName = objPictureConfigerENS.PictureConfigName; //PictureConfigName
objPictureConfigerENT.PicturePath = objPictureConfigerENS.PicturePath; //PicturePath
objPictureConfigerENT.ThumbHeight = objPictureConfigerENS.ThumbHeight; //ThumbHeight
objPictureConfigerENT.ThumbWidth = objPictureConfigerENS.ThumbWidth; //ThumbWidth
objPictureConfigerENT.ResizePictureHeight = objPictureConfigerENS.ResizePictureHeight; //ResizePictureHeight
objPictureConfigerENT.MaxSize = objPictureConfigerENS.MaxSize; //MaxSize
objPictureConfigerENT.ResizePictureWidth = objPictureConfigerENS.ResizePictureWidth; //ResizePictureWidth
objPictureConfigerENT.Memo = objPictureConfigerENS.Memo; //备注
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsPictureConfigerEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPictureConfigerEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPictureConfigerEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPictureConfigerEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPictureConfigerEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPictureConfigerEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsPictureConfigerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPictureConfigerWApi没有刷新缓存机制(clsPictureConfigerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PictureConfigerId");
//if (arrPictureConfigerObjLst_Cache == null)
//{
//arrPictureConfigerObjLst_Cache = await clsPictureConfigerWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName_S);
CacheHelper.Remove(strKey);
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsPictureConfigerWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsPictureConfigerWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName_S);
List<clsPictureConfigerEN> arrPictureConfigerObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPictureConfigerObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPictureConfigerEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPictureConfiger.PictureConfigerId, Type.GetType("System.String"));
objDT.Columns.Add(conPictureConfiger.PictureConfigName, Type.GetType("System.String"));
objDT.Columns.Add(conPictureConfiger.PicturePath, Type.GetType("System.String"));
objDT.Columns.Add(conPictureConfiger.ThumbHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(conPictureConfiger.ThumbWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(conPictureConfiger.ResizePictureHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(conPictureConfiger.MaxSize, Type.GetType("System.String"));
objDT.Columns.Add(conPictureConfiger.ResizePictureWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(conPictureConfiger.Memo, Type.GetType("System.String"));
foreach (clsPictureConfigerEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPictureConfiger.PictureConfigerId] = objInFor[conPictureConfiger.PictureConfigerId];
objDR[conPictureConfiger.PictureConfigName] = objInFor[conPictureConfiger.PictureConfigName];
objDR[conPictureConfiger.PicturePath] = objInFor[conPictureConfiger.PicturePath];
objDR[conPictureConfiger.ThumbHeight] = objInFor[conPictureConfiger.ThumbHeight];
objDR[conPictureConfiger.ThumbWidth] = objInFor[conPictureConfiger.ThumbWidth];
objDR[conPictureConfiger.ResizePictureHeight] = objInFor[conPictureConfiger.ResizePictureHeight];
objDR[conPictureConfiger.MaxSize] = objInFor[conPictureConfiger.MaxSize];
objDR[conPictureConfiger.ResizePictureWidth] = objInFor[conPictureConfiger.ResizePictureWidth];
objDR[conPictureConfiger.Memo] = objInFor[conPictureConfiger.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 图片配置(PictureConfiger)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4PictureConfiger : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerWApi.ReFreshThisCache();
}
}

}