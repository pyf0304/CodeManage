
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserPointRecWApi
 表名:UserPointRec(01120304)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:12
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:位置管理
 模块英文名:PointManage
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
public static class clsUserPointRecWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetmId(this clsUserPointRecEN objUserPointRecEN, long lngmId, string strComparisonOp="")
	{
objUserPointRecEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.mId) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.mId, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.mId] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetPointId(this clsUserPointRecEN objUserPointRecEN, string strPointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointId, conUserPointRec.PointId);
clsCheckSql.CheckFieldLen(strPointId, 10, conUserPointRec.PointId);
clsCheckSql.CheckFieldForeignKey(strPointId, 10, conUserPointRec.PointId);
objUserPointRecEN.PointId = strPointId; //点位Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.PointId) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.PointId, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.PointId] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetUserId(this clsUserPointRecEN objUserPointRecEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, conUserPointRec.UserId);
objUserPointRecEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.UserId) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.UserId, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.UserId] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetPointTypeId(this clsUserPointRecEN objUserPointRecEN, string strPointTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointTypeId, conUserPointRec.PointTypeId);
clsCheckSql.CheckFieldLen(strPointTypeId, 2, conUserPointRec.PointTypeId);
clsCheckSql.CheckFieldForeignKey(strPointTypeId, 2, conUserPointRec.PointTypeId);
objUserPointRecEN.PointTypeId = strPointTypeId; //点位类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.PointTypeId) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.PointTypeId, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.PointTypeId] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetLongitude(this clsUserPointRecEN objUserPointRecEN, double dblLongitude, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblLongitude, conUserPointRec.Longitude);
objUserPointRecEN.Longitude = dblLongitude; //经度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.Longitude) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.Longitude, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.Longitude] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetLatitude(this clsUserPointRecEN objUserPointRecEN, double dblLatitude, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblLatitude, conUserPointRec.Latitude);
objUserPointRecEN.Latitude = dblLatitude; //纬度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.Latitude) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.Latitude, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.Latitude] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetAddress(this clsUserPointRecEN objUserPointRecEN, string strAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAddress, 200, conUserPointRec.Address);
objUserPointRecEN.Address = strAddress; //地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.Address) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.Address, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.Address] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetPhoneModels(this clsUserPointRecEN objUserPointRecEN, string strPhoneModels, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneModels, 50, conUserPointRec.PhoneModels);
objUserPointRecEN.PhoneModels = strPhoneModels; //手机型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.PhoneModels) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.PhoneModels, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.PhoneModels] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetPhoneOS(this clsUserPointRecEN objUserPointRecEN, string strPhoneOS, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneOS, 50, conUserPointRec.PhoneOS);
objUserPointRecEN.PhoneOS = strPhoneOS; //手机系统
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.PhoneOS) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.PhoneOS, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.PhoneOS] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetIMEI(this clsUserPointRecEN objUserPointRecEN, string strIMEI, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIMEI, 50, conUserPointRec.IMEI);
objUserPointRecEN.IMEI = strIMEI; //IMEI
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.IMEI) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.IMEI, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.IMEI] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetUpdDate(this clsUserPointRecEN objUserPointRecEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conUserPointRec.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserPointRec.UpdDate);
objUserPointRecEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.UpdDate) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.UpdDate, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.UpdDate] = strComparisonOp;
}
}
return objUserPointRecEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsUserPointRecEN SetMemo(this clsUserPointRecEN objUserPointRecEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserPointRec.Memo);
objUserPointRecEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPointRecEN.dicFldComparisonOp.ContainsKey(conUserPointRec.Memo) == false)
{
objUserPointRecEN.dicFldComparisonOp.Add(conUserPointRec.Memo, strComparisonOp);
}
else
{
objUserPointRecEN.dicFldComparisonOp[conUserPointRec.Memo] = strComparisonOp;
}
}
return objUserPointRecEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserPointRecEN objUserPointRec_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.mId) == true)
{
string strComparisonOp_mId = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserPointRec.mId, objUserPointRec_Cond.mId, strComparisonOp_mId);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.PointId) == true)
{
string strComparisonOp_PointId = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.PointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPointRec.PointId, objUserPointRec_Cond.PointId, strComparisonOp_PointId);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.UserId) == true)
{
string strComparisonOp_UserId = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPointRec.UserId, objUserPointRec_Cond.UserId, strComparisonOp_UserId);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.PointTypeId) == true)
{
string strComparisonOp_PointTypeId = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.PointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPointRec.PointTypeId, objUserPointRec_Cond.PointTypeId, strComparisonOp_PointTypeId);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.Longitude) == true)
{
string strComparisonOp_Longitude = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.Longitude];
strWhereCond += string.Format(" And {0} {2} {1}", conUserPointRec.Longitude, objUserPointRec_Cond.Longitude, strComparisonOp_Longitude);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.Latitude) == true)
{
string strComparisonOp_Latitude = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.Latitude];
strWhereCond += string.Format(" And {0} {2} {1}", conUserPointRec.Latitude, objUserPointRec_Cond.Latitude, strComparisonOp_Latitude);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.Address) == true)
{
string strComparisonOp_Address = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.Address];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPointRec.Address, objUserPointRec_Cond.Address, strComparisonOp_Address);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.PhoneModels) == true)
{
string strComparisonOp_PhoneModels = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.PhoneModels];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPointRec.PhoneModels, objUserPointRec_Cond.PhoneModels, strComparisonOp_PhoneModels);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.PhoneOS) == true)
{
string strComparisonOp_PhoneOS = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.PhoneOS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPointRec.PhoneOS, objUserPointRec_Cond.PhoneOS, strComparisonOp_PhoneOS);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.IMEI) == true)
{
string strComparisonOp_IMEI = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.IMEI];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPointRec.IMEI, objUserPointRec_Cond.IMEI, strComparisonOp_IMEI);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.UpdDate) == true)
{
string strComparisonOp_UpdDate = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPointRec.UpdDate, objUserPointRec_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objUserPointRec_Cond.IsUpdated(conUserPointRec.Memo) == true)
{
string strComparisonOp_Memo = objUserPointRec_Cond.dicFldComparisonOp[conUserPointRec.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPointRec.Memo, objUserPointRec_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserPointRecEN objUserPointRecEN)
{
 if (objUserPointRecEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objUserPointRecEN.sf_UpdFldSetStr = objUserPointRecEN.getsf_UpdFldSetStr();
clsUserPointRecWApi.CheckPropertyNew(objUserPointRecEN); 
bool bolResult = clsUserPointRecWApi.UpdateRecord(objUserPointRecEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPointRecWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--UserPointRec(用户点位记录), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserPointRecEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_UserId_PointId(this clsUserPointRecEN objUserPointRecEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserPointRecEN == null) return "";
if (objUserPointRecEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserPointRecEN.UserId);
 sbCondition.AppendFormat(" and PointId = '{0}'", objUserPointRecEN.PointId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserPointRecEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserPointRecEN.UserId);
 sbCondition.AppendFormat(" and PointId = '{0}'", objUserPointRecEN.PointId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserPointRecEN objUserPointRecEN)
{
try
{
clsUserPointRecWApi.CheckPropertyNew(objUserPointRecEN); 
bool bolResult = clsUserPointRecWApi.AddNewRecord(objUserPointRecEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPointRecWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserPointRecEN objUserPointRecEN, string strWhereCond)
{
try
{
clsUserPointRecWApi.CheckPropertyNew(objUserPointRecEN); 
bool bolResult = clsUserPointRecWApi.UpdateWithCondition(objUserPointRecEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPointRecWApi.ReFreshCache();
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
 /// 用户点位记录(UserPointRec)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsUserPointRecWApi
{
private static readonly string mstrApiControllerName = "UserPointRecApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsUserPointRecWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsUserPointRecEN objUserPointRecEN)
{
if (!Object.Equals(null, objUserPointRecEN.PointId) && GetStrLen(objUserPointRecEN.PointId) > 10)
{
 throw new Exception("字段[点位Id]的长度不能超过10!");
}
if (!Object.Equals(null, objUserPointRecEN.UserId) && GetStrLen(objUserPointRecEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objUserPointRecEN.PointTypeId) && GetStrLen(objUserPointRecEN.PointTypeId) > 2)
{
 throw new Exception("字段[点位类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objUserPointRecEN.Address) && GetStrLen(objUserPointRecEN.Address) > 200)
{
 throw new Exception("字段[地址]的长度不能超过200!");
}
if (!Object.Equals(null, objUserPointRecEN.PhoneModels) && GetStrLen(objUserPointRecEN.PhoneModels) > 50)
{
 throw new Exception("字段[手机型号]的长度不能超过50!");
}
if (!Object.Equals(null, objUserPointRecEN.PhoneOS) && GetStrLen(objUserPointRecEN.PhoneOS) > 50)
{
 throw new Exception("字段[手机系统]的长度不能超过50!");
}
if (!Object.Equals(null, objUserPointRecEN.IMEI) && GetStrLen(objUserPointRecEN.IMEI) > 50)
{
 throw new Exception("字段[IMEI]的长度不能超过50!");
}
if (!Object.Equals(null, objUserPointRecEN.UpdDate) && GetStrLen(objUserPointRecEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objUserPointRecEN.Memo) && GetStrLen(objUserPointRecEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objUserPointRecEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserPointRecEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsUserPointRecEN objUserPointRecEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objUserPointRecEN = JsonConvert.DeserializeObject<clsUserPointRecEN>((string)jobjReturn["ReturnObj"]);
return objUserPointRecEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserPointRecEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsUserPointRecEN objUserPointRecEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objUserPointRecEN = JsonConvert.DeserializeObject<clsUserPointRecEN>((string)jobjReturn["ReturnObj"]);
return objUserPointRecEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsUserPointRecEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsUserPointRecEN objUserPointRecEN = null;
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
objUserPointRecEN = JsonConvert.DeserializeObject<clsUserPointRecEN>((string)jobjReturn["ReturnObj"]);
return objUserPointRecEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserPointRecEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsUserPointRecEN._CurrTabName_S);
List<clsUserPointRecEN> arrUserPointRecObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsUserPointRecEN> arrUserPointRecObjLst_Sel =
from objUserPointRecEN in arrUserPointRecObjLst_Cache
where objUserPointRecEN.mId == lngmId
select objUserPointRecEN;
if (arrUserPointRecObjLst_Sel.Count() == 0)
{
   clsUserPointRecEN obj = clsUserPointRecWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrUserPointRecObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserPointRecEN> GetObjLst(string strWhereCond)
{
 List<clsUserPointRecEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPointRecEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUserPointRecEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsUserPointRecEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPointRecEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsUserPointRecEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsUserPointRecEN._CurrTabName_S);
List<clsUserPointRecEN> arrUserPointRecObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsUserPointRecEN> arrUserPointRecObjLst_Sel =
from objUserPointRecEN in arrUserPointRecObjLst_Cache
where arrMId.Contains(objUserPointRecEN.mId)
select objUserPointRecEN;
return arrUserPointRecObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserPointRecEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsUserPointRecEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPointRecEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUserPointRecEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsUserPointRecEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPointRecEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUserPointRecEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsUserPointRecEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPointRecEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUserPointRecEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsUserPointRecEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPointRecEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsUserPointRecEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsUserPointRecEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPointRecEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsUserPointRecEN objUserPointRecEN = clsUserPointRecWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsUserPointRecWApi.ReFreshCache();
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
public static int DelUserPointRecs(List<string> arrmId)
{
string strAction = "DelUserPointRecs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsUserPointRecWApi.ReFreshCache();
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
public static int DelUserPointRecsByCond(string strWhereCond)
{
string strAction = "DelUserPointRecsByCond";
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
public static bool AddNewRecord(clsUserPointRecEN objUserPointRecEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserPointRecEN>(objUserPointRecEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPointRecWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objUserPointRecEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsUserPointRecEN objUserPointRecEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserPointRecEN>(objUserPointRecEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPointRecWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsUserPointRecEN objUserPointRecEN)
{
if (string.IsNullOrEmpty(objUserPointRecEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objUserPointRecEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserPointRecEN>(objUserPointRecEN);
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
 /// <param name = "objUserPointRecEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsUserPointRecEN objUserPointRecEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objUserPointRecEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objUserPointRecEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objUserPointRecEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserPointRecEN>(objUserPointRecEN);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objUserPointRecENS">源对象</param>
 /// <param name = "objUserPointRecENT">目标对象</param>
 public static void CopyTo(clsUserPointRecEN objUserPointRecENS, clsUserPointRecEN objUserPointRecENT)
{
try
{
objUserPointRecENT.mId = objUserPointRecENS.mId; //mId
objUserPointRecENT.PointId = objUserPointRecENS.PointId; //点位Id
objUserPointRecENT.UserId = objUserPointRecENS.UserId; //用户ID
objUserPointRecENT.PointTypeId = objUserPointRecENS.PointTypeId; //点位类型Id
objUserPointRecENT.Longitude = objUserPointRecENS.Longitude; //经度
objUserPointRecENT.Latitude = objUserPointRecENS.Latitude; //纬度
objUserPointRecENT.Address = objUserPointRecENS.Address; //地址
objUserPointRecENT.PhoneModels = objUserPointRecENS.PhoneModels; //手机型号
objUserPointRecENT.PhoneOS = objUserPointRecENS.PhoneOS; //手机系统
objUserPointRecENT.IMEI = objUserPointRecENS.IMEI; //IMEI
objUserPointRecENT.UpdDate = objUserPointRecENS.UpdDate; //修改日期
objUserPointRecENT.Memo = objUserPointRecENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsUserPointRecEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsUserPointRecEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsUserPointRecEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsUserPointRecEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsUserPointRecEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsUserPointRecEN.AttributeName)
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
if (clsUserPointRecWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserPointRecWApi没有刷新缓存机制(clsUserPointRecWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrUserPointRecObjLst_Cache == null)
//{
//arrUserPointRecObjLst_Cache = await clsUserPointRecWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsUserPointRecEN._CurrTabName_S);
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
if (clsUserPointRecWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUserPointRecEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsUserPointRecWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserPointRecEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsUserPointRecEN._CurrTabName_S);
List<clsUserPointRecEN> arrUserPointRecObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUserPointRecObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsUserPointRecEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conUserPointRec.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conUserPointRec.PointId, Type.GetType("System.String"));
objDT.Columns.Add(conUserPointRec.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conUserPointRec.PointTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conUserPointRec.Longitude, Type.GetType("System.Decimal"));
objDT.Columns.Add(conUserPointRec.Latitude, Type.GetType("System.Decimal"));
objDT.Columns.Add(conUserPointRec.Address, Type.GetType("System.String"));
objDT.Columns.Add(conUserPointRec.PhoneModels, Type.GetType("System.String"));
objDT.Columns.Add(conUserPointRec.PhoneOS, Type.GetType("System.String"));
objDT.Columns.Add(conUserPointRec.IMEI, Type.GetType("System.String"));
objDT.Columns.Add(conUserPointRec.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conUserPointRec.Memo, Type.GetType("System.String"));
foreach (clsUserPointRecEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conUserPointRec.mId] = objInFor[conUserPointRec.mId];
objDR[conUserPointRec.PointId] = objInFor[conUserPointRec.PointId];
objDR[conUserPointRec.UserId] = objInFor[conUserPointRec.UserId];
objDR[conUserPointRec.PointTypeId] = objInFor[conUserPointRec.PointTypeId];
objDR[conUserPointRec.Longitude] = objInFor[conUserPointRec.Longitude];
objDR[conUserPointRec.Latitude] = objInFor[conUserPointRec.Latitude];
objDR[conUserPointRec.Address] = objInFor[conUserPointRec.Address];
objDR[conUserPointRec.PhoneModels] = objInFor[conUserPointRec.PhoneModels];
objDR[conUserPointRec.PhoneOS] = objInFor[conUserPointRec.PhoneOS];
objDR[conUserPointRec.IMEI] = objInFor[conUserPointRec.IMEI];
objDR[conUserPointRec.UpdDate] = objInFor[conUserPointRec.UpdDate];
objDR[conUserPointRec.Memo] = objInFor[conUserPointRec.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户点位记录(UserPointRec)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4UserPointRec : clsCommFun4BL
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
clsUserPointRecWApi.ReFreshThisCache();
}
}

}