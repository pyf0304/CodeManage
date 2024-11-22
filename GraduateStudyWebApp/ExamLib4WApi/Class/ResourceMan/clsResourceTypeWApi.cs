
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResourceTypeWApi
 表名:ResourceType(01120089)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:45
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理
 模块英文名:ResourceMan
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
public static class clsResourceTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceTypeEN Setid_ResourceType(this clsResourceTypeEN objResourceTypeEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, conResourceType.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, conResourceType.id_ResourceType);
objResourceTypeEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.id_ResourceType) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.id_ResourceType, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.id_ResourceType] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceTypeEN SetResourceTypeID(this clsResourceTypeEN objResourceTypeEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, conResourceType.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, conResourceType.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, conResourceType.ResourceTypeID);
objResourceTypeEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.ResourceTypeID) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.ResourceTypeID, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.ResourceTypeID] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceTypeEN SetResourceTypeName(this clsResourceTypeEN objResourceTypeEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, conResourceType.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, conResourceType.ResourceTypeName);
objResourceTypeEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.ResourceTypeName) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.ResourceTypeName, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.ResourceTypeName] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceTypeEN SetResourceTypeENName(this clsResourceTypeEN objResourceTypeEN, string strResourceTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeENName, 50, conResourceType.ResourceTypeENName);
objResourceTypeEN.ResourceTypeENName = strResourceTypeENName; //ResourceTypeENName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.ResourceTypeENName) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.ResourceTypeENName, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.ResourceTypeENName] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceTypeEN SetFileExtentNameLst(this clsResourceTypeEN objResourceTypeEN, string strFileExtentNameLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileExtentNameLst, 200, conResourceType.FileExtentNameLst);
objResourceTypeEN.FileExtentNameLst = strFileExtentNameLst; //文件扩展名列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.FileExtentNameLst) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.FileExtentNameLst, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.FileExtentNameLst] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceTypeEN SetFileExtentNameLst2(this clsResourceTypeEN objResourceTypeEN, string strFileExtentNameLst2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileExtentNameLst2, 200, conResourceType.FileExtentNameLst2);
objResourceTypeEN.FileExtentNameLst2 = strFileExtentNameLst2; //文件扩展名列表2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.FileExtentNameLst2) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.FileExtentNameLst2, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.FileExtentNameLst2] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceTypeEN SetOrderNum(this clsResourceTypeEN objResourceTypeEN, int intOrderNum, string strComparisonOp="")
	{
objResourceTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.OrderNum) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.OrderNum, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.OrderNum] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceTypeEN SetIsUse(this clsResourceTypeEN objResourceTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objResourceTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.IsUse) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.IsUse, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.IsUse] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceTypeEN SetMemo(this clsResourceTypeEN objResourceTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conResourceType.Memo);
objResourceTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.Memo) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.Memo, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.Memo] = strComparisonOp;
}
}
return objResourceTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsResourceTypeEN objResourceType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objResourceType_Cond.IsUpdated(conResourceType.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objResourceType_Cond.dicFldComparisonOp[conResourceType.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.id_ResourceType, objResourceType_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objResourceType_Cond.IsUpdated(conResourceType.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objResourceType_Cond.dicFldComparisonOp[conResourceType.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.ResourceTypeID, objResourceType_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objResourceType_Cond.IsUpdated(conResourceType.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objResourceType_Cond.dicFldComparisonOp[conResourceType.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.ResourceTypeName, objResourceType_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objResourceType_Cond.IsUpdated(conResourceType.ResourceTypeENName) == true)
{
string strComparisonOp_ResourceTypeENName = objResourceType_Cond.dicFldComparisonOp[conResourceType.ResourceTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.ResourceTypeENName, objResourceType_Cond.ResourceTypeENName, strComparisonOp_ResourceTypeENName);
}
if (objResourceType_Cond.IsUpdated(conResourceType.FileExtentNameLst) == true)
{
string strComparisonOp_FileExtentNameLst = objResourceType_Cond.dicFldComparisonOp[conResourceType.FileExtentNameLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.FileExtentNameLst, objResourceType_Cond.FileExtentNameLst, strComparisonOp_FileExtentNameLst);
}
if (objResourceType_Cond.IsUpdated(conResourceType.FileExtentNameLst2) == true)
{
string strComparisonOp_FileExtentNameLst2 = objResourceType_Cond.dicFldComparisonOp[conResourceType.FileExtentNameLst2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.FileExtentNameLst2, objResourceType_Cond.FileExtentNameLst2, strComparisonOp_FileExtentNameLst2);
}
if (objResourceType_Cond.IsUpdated(conResourceType.OrderNum) == true)
{
string strComparisonOp_OrderNum = objResourceType_Cond.dicFldComparisonOp[conResourceType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conResourceType.OrderNum, objResourceType_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objResourceType_Cond.IsUpdated(conResourceType.IsUse) == true)
{
if (objResourceType_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conResourceType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conResourceType.IsUse);
}
}
if (objResourceType_Cond.IsUpdated(conResourceType.Memo) == true)
{
string strComparisonOp_Memo = objResourceType_Cond.dicFldComparisonOp[conResourceType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.Memo, objResourceType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsResourceTypeEN objResourceTypeEN)
{
 if (string.IsNullOrEmpty(objResourceTypeEN.id_ResourceType) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objResourceTypeEN.sf_UpdFldSetStr = objResourceTypeEN.getsf_UpdFldSetStr();
clsResourceTypeWApi.CheckPropertyNew(objResourceTypeEN); 
bool bolResult = clsResourceTypeWApi.UpdateRecord(objResourceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeWApi.ReFreshCache();
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsResourceTypeEN objResourceTypeEN)
{
 if (string.IsNullOrEmpty(objResourceTypeEN.id_ResourceType) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsResourceTypeWApi.IsExist(objResourceTypeEN.id_ResourceType) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objResourceTypeEN.id_ResourceType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsResourceTypeWApi.CheckPropertyNew(objResourceTypeEN); 
bool bolResult = clsResourceTypeWApi.AddNewRecord(objResourceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeWApi.ReFreshCache();
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsResourceTypeEN objResourceTypeEN)
{
try
{
clsResourceTypeWApi.CheckPropertyNew(objResourceTypeEN); 
string strid_ResourceType = clsResourceTypeWApi.AddNewRecordWithMaxId(objResourceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeWApi.ReFreshCache();
return strid_ResourceType;
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
 /// <param name = "objResourceTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsResourceTypeEN objResourceTypeEN, string strWhereCond)
{
try
{
clsResourceTypeWApi.CheckPropertyNew(objResourceTypeEN); 
bool bolResult = clsResourceTypeWApi.UpdateWithCondition(objResourceTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumResourceTypeWA
{
 /// <summary>
 /// 视频
 /// </summary>
public const string Video_0001 = "0001";
 /// <summary>
 /// 音频
 /// </summary>
public const string Audio_0002 = "0002";
 /// <summary>
 /// 动画
 /// </summary>
public const string Animation_0003 = "0003";
 /// <summary>
 /// 图片
 /// </summary>
public const string Picture_0004 = "0004";
 /// <summary>
 /// 其它
 /// </summary>
public const string Other_0005 = "0005";
 /// <summary>
 /// PPT
 /// </summary>
public const string PPT_0006 = "0006";
 /// <summary>
 /// Word文档
 /// </summary>
public const string Word_0007 = "0007";
 /// <summary>
 /// Access文档
 /// </summary>
public const string Access_0008 = "0008";
 /// <summary>
 /// XPS文档
 /// </summary>
public const string XPS_0009 = "0009";
 /// <summary>
 /// 纯文本
 /// </summary>
public const string Text_0010 = "0010";
 /// <summary>
 /// Html文本
 /// </summary>
public const string Html_0011 = "0011";
 /// <summary>
 /// 压缩文件
 /// </summary>
public const string CompressedFile_0012 = "0012";
 /// <summary>
 /// Pdf文件
 /// </summary>
public const string Pdf_0013 = "0013";
 /// <summary>
 /// Excel文件
 /// </summary>
public const string Excel_0014 = "0014";
 /// <summary>
 /// 源代码
 /// </summary>
public const string SourceCode_0015 = "0015";
}
 /// <summary>
 /// 资源类型(ResourceType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsResourceTypeWApi
{
private static readonly string mstrApiControllerName = "ResourceTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsResourceTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_ResourceType(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[资源类型]...","0");
List<clsResourceTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_ResourceType";
objDDL.DataTextField="ResourceTypeName";
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
public static void BindCbo_id_ResourceType(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conResourceType.id_ResourceType); 
List<clsResourceTypeEN> arrObjLst = clsResourceTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN()
{
id_ResourceType = "0",
ResourceTypeName = "选[资源类型]..."
};
arrObjLst.Insert(0, objResourceTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conResourceType.id_ResourceType;
objComboBox.DisplayMember = conResourceType.ResourceTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsResourceTypeEN objResourceTypeEN)
{
if (!Object.Equals(null, objResourceTypeEN.id_ResourceType) && GetStrLen(objResourceTypeEN.id_ResourceType) > 4)
{
 throw new Exception("字段[资源类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objResourceTypeEN.ResourceTypeID) && GetStrLen(objResourceTypeEN.ResourceTypeID) > 4)
{
 throw new Exception("字段[资源类型ID]的长度不能超过4!");
}
if (!Object.Equals(null, objResourceTypeEN.ResourceTypeName) && GetStrLen(objResourceTypeEN.ResourceTypeName) > 50)
{
 throw new Exception("字段[资源类型名称]的长度不能超过50!");
}
if (!Object.Equals(null, objResourceTypeEN.ResourceTypeENName) && GetStrLen(objResourceTypeEN.ResourceTypeENName) > 50)
{
 throw new Exception("字段[ResourceTypeENName]的长度不能超过50!");
}
if (!Object.Equals(null, objResourceTypeEN.FileExtentNameLst) && GetStrLen(objResourceTypeEN.FileExtentNameLst) > 200)
{
 throw new Exception("字段[文件扩展名列表]的长度不能超过200!");
}
if (!Object.Equals(null, objResourceTypeEN.FileExtentNameLst2) && GetStrLen(objResourceTypeEN.FileExtentNameLst2) > 200)
{
 throw new Exception("字段[文件扩展名列表2]的长度不能超过200!");
}
if (!Object.Equals(null, objResourceTypeEN.Memo) && GetStrLen(objResourceTypeEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objResourceTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_ResourceType">表关键字</param>
 /// <returns>表对象</returns>
public static clsResourceTypeEN GetObjByid_ResourceType(string strid_ResourceType)
{
string strAction = "GetObjByid_ResourceType";
string strErrMsg = string.Empty;
string strResult = "";
clsResourceTypeEN objResourceTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_ResourceType"] = strid_ResourceType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objResourceTypeEN = JsonConvert.DeserializeObject<clsResourceTypeEN>((string)jobjReturn["ReturnObj"]);
return objResourceTypeEN;
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
 /// <param name = "strid_ResourceType">表关键字</param>
 /// <returns>表对象</returns>
public static clsResourceTypeEN GetObjByid_ResourceType_WA_Cache(string strid_ResourceType)
{
string strAction = "GetObjByid_ResourceType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsResourceTypeEN objResourceTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_ResourceType"] = strid_ResourceType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objResourceTypeEN = JsonConvert.DeserializeObject<clsResourceTypeEN>((string)jobjReturn["ReturnObj"]);
return objResourceTypeEN;
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
public static clsResourceTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsResourceTypeEN objResourceTypeEN = null;
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
objResourceTypeEN = JsonConvert.DeserializeObject<clsResourceTypeEN>((string)jobjReturn["ReturnObj"]);
return objResourceTypeEN;
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
 /// <param name = "strid_ResourceType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsResourceTypeEN GetObjByid_ResourceType_Cache(string strid_ResourceType)
{
if (string.IsNullOrEmpty(strid_ResourceType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName_S);
List<clsResourceTypeEN> arrResourceTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsResourceTypeEN> arrResourceTypeObjLst_Sel =
from objResourceTypeEN in arrResourceTypeObjLst_Cache
where objResourceTypeEN.id_ResourceType == strid_ResourceType
select objResourceTypeEN;
if (arrResourceTypeObjLst_Sel.Count() == 0)
{
   clsResourceTypeEN obj = clsResourceTypeWApi.GetObjByid_ResourceType(strid_ResourceType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrResourceTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_ResourceType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetResourceTypeNameByid_ResourceType_Cache(string strid_ResourceType)
{
if (string.IsNullOrEmpty(strid_ResourceType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName_S);
List<clsResourceTypeEN> arrResourceTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsResourceTypeEN> arrResourceTypeObjLst_Sel1 =
from objResourceTypeEN in arrResourceTypeObjLst_Cache
where objResourceTypeEN.id_ResourceType == strid_ResourceType
select objResourceTypeEN;
List <clsResourceTypeEN> arrResourceTypeObjLst_Sel = new List<clsResourceTypeEN>();
foreach (clsResourceTypeEN obj in arrResourceTypeObjLst_Sel1)
{
arrResourceTypeObjLst_Sel.Add(obj);
}
if (arrResourceTypeObjLst_Sel.Count > 0)
{
return arrResourceTypeObjLst_Sel[0].ResourceTypeName;
}
string strErrMsgForGetObjById = string.Format("在ResourceType对象缓存列表中,找不到记录[id_ResourceType = {0}](函数:{1})", strid_ResourceType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsResourceTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_ResourceType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_ResourceType_Cache(string strid_ResourceType)
{
if (string.IsNullOrEmpty(strid_ResourceType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName_S);
List<clsResourceTypeEN> arrResourceTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsResourceTypeEN> arrResourceTypeObjLst_Sel1 =
from objResourceTypeEN in arrResourceTypeObjLst_Cache
where objResourceTypeEN.id_ResourceType == strid_ResourceType
select objResourceTypeEN;
List <clsResourceTypeEN> arrResourceTypeObjLst_Sel = new List<clsResourceTypeEN>();
foreach (clsResourceTypeEN obj in arrResourceTypeObjLst_Sel1)
{
arrResourceTypeObjLst_Sel.Add(obj);
}
if (arrResourceTypeObjLst_Sel.Count > 0)
{
return arrResourceTypeObjLst_Sel[0].ResourceTypeName;
}
string strErrMsgForGetObjById = string.Format("在ResourceType对象缓存列表中,找不到记录的相关名称[id_ResourceType = {0}](函数:{1})", strid_ResourceType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsResourceTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsResourceTypeEN> GetObjLst(string strWhereCond)
{
 List<clsResourceTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsResourceTypeEN> GetObjLstById_ResourceTypeLst(List<string> arrId_ResourceType)
{
 List<clsResourceTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_ResourceTypeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ResourceType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_ResourceType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsResourceTypeEN> GetObjLstById_ResourceTypeLst_Cache(List<string> arrId_ResourceType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName_S);
List<clsResourceTypeEN> arrResourceTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsResourceTypeEN> arrResourceTypeObjLst_Sel =
from objResourceTypeEN in arrResourceTypeObjLst_Cache
where arrId_ResourceType.Contains(objResourceTypeEN.id_ResourceType)
select objResourceTypeEN;
return arrResourceTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsResourceTypeEN> GetObjLstById_ResourceTypeLst_WA_Cache(List<string> arrId_ResourceType)
{
 List<clsResourceTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_ResourceTypeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ResourceType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsResourceTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsResourceTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsResourceTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsResourceTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsResourceTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsResourceTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsResourceTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsResourceTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_ResourceType)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsResourceTypeEN objResourceTypeEN = clsResourceTypeWApi.GetObjByid_ResourceType(strid_ResourceType);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_ResourceType.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsResourceTypeWApi.ReFreshCache();
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
public static int DelResourceTypes(List<string> arrid_ResourceType)
{
string strAction = "DelResourceTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_ResourceType);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsResourceTypeWApi.ReFreshCache();
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
public static int DelResourceTypesByCond(string strWhereCond)
{
string strAction = "DelResourceTypesByCond";
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
public static bool AddNewRecord(clsResourceTypeEN objResourceTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsResourceTypeEN>(objResourceTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsResourceTypeEN objResourceTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsResourceTypeEN>(objResourceTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeWApi.ReFreshCache();
var strid_ResourceType = (string)jobjReturn["ReturnStr"];
return strid_ResourceType;
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
public static bool UpdateRecord(clsResourceTypeEN objResourceTypeEN)
{
if (string.IsNullOrEmpty(objResourceTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objResourceTypeEN.id_ResourceType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsResourceTypeEN>(objResourceTypeEN);
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
 /// <param name = "objResourceTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsResourceTypeEN objResourceTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objResourceTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objResourceTypeEN.id_ResourceType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objResourceTypeEN.id_ResourceType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsResourceTypeEN>(objResourceTypeEN);
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
public static bool IsExist(string strid_ResourceType)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_ResourceType"] = strid_ResourceType
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
 /// <param name = "objResourceTypeENS">源对象</param>
 /// <param name = "objResourceTypeENT">目标对象</param>
 public static void CopyTo(clsResourceTypeEN objResourceTypeENS, clsResourceTypeEN objResourceTypeENT)
{
try
{
objResourceTypeENT.id_ResourceType = objResourceTypeENS.id_ResourceType; //资源类型流水号
objResourceTypeENT.ResourceTypeID = objResourceTypeENS.ResourceTypeID; //资源类型ID
objResourceTypeENT.ResourceTypeName = objResourceTypeENS.ResourceTypeName; //资源类型名称
objResourceTypeENT.ResourceTypeENName = objResourceTypeENS.ResourceTypeENName; //ResourceTypeENName
objResourceTypeENT.FileExtentNameLst = objResourceTypeENS.FileExtentNameLst; //文件扩展名列表
objResourceTypeENT.FileExtentNameLst2 = objResourceTypeENS.FileExtentNameLst2; //文件扩展名列表2
objResourceTypeENT.OrderNum = objResourceTypeENS.OrderNum; //序号
objResourceTypeENT.IsUse = objResourceTypeENS.IsUse; //是否使用
objResourceTypeENT.Memo = objResourceTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsResourceTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsResourceTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsResourceTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsResourceTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsResourceTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsResourceTypeEN.AttributeName)
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
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_ResourceType");
//if (arrResourceTypeObjLst_Cache == null)
//{
//arrResourceTypeObjLst_Cache = await clsResourceTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName_S);
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
if (clsResourceTypeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsResourceTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsResourceTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName_S);
List<clsResourceTypeEN> arrResourceTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrResourceTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsResourceTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conResourceType.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(conResourceType.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(conResourceType.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conResourceType.ResourceTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conResourceType.FileExtentNameLst, Type.GetType("System.String"));
objDT.Columns.Add(conResourceType.FileExtentNameLst2, Type.GetType("System.String"));
objDT.Columns.Add(conResourceType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conResourceType.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conResourceType.Memo, Type.GetType("System.String"));
foreach (clsResourceTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conResourceType.id_ResourceType] = objInFor[conResourceType.id_ResourceType];
objDR[conResourceType.ResourceTypeID] = objInFor[conResourceType.ResourceTypeID];
objDR[conResourceType.ResourceTypeName] = objInFor[conResourceType.ResourceTypeName];
objDR[conResourceType.ResourceTypeENName] = objInFor[conResourceType.ResourceTypeENName];
objDR[conResourceType.FileExtentNameLst] = objInFor[conResourceType.FileExtentNameLst];
objDR[conResourceType.FileExtentNameLst2] = objInFor[conResourceType.FileExtentNameLst2];
objDR[conResourceType.OrderNum] = objInFor[conResourceType.OrderNum];
objDR[conResourceType.IsUse] = objInFor[conResourceType.IsUse];
objDR[conResourceType.Memo] = objInFor[conResourceType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 资源类型(ResourceType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4ResourceType : clsCommFun4BL
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
clsResourceTypeWApi.ReFreshThisCache();
}
}

}