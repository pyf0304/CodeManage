
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLiveRoomWApi
 表名:LiveRoom(01120263)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:56
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
public static class clsLiveRoomWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetLiveRoomID(this clsLiveRoomEN objLiveRoomEN, long lngLiveRoomID, string strComparisonOp="")
	{
objLiveRoomEN.LiveRoomID = lngLiveRoomID; //房间ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.LiveRoomID) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.LiveRoomID, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.LiveRoomID] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetRoomName(this clsLiveRoomEN objLiveRoomEN, string strRoomName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoomName, conLiveRoom.RoomName);
clsCheckSql.CheckFieldLen(strRoomName, 50, conLiveRoom.RoomName);
objLiveRoomEN.RoomName = strRoomName; //房间名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.RoomName) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.RoomName, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.RoomName] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetLiveCode(this clsLiveRoomEN objLiveRoomEN, string strLiveCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveCode, 100, conLiveRoom.LiveCode);
objLiveRoomEN.LiveCode = strLiveCode; //直播代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.LiveCode) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.LiveCode, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.LiveCode] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetSchool(this clsLiveRoomEN objLiveRoomEN, string strSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchool, conLiveRoom.School);
clsCheckSql.CheckFieldLen(strSchool, 50, conLiveRoom.School);
objLiveRoomEN.School = strSchool; //School
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.School) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.School, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.School] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetLink(this clsLiveRoomEN objLiveRoomEN, string strLink, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLink, 200, conLiveRoom.Link);
objLiveRoomEN.Link = strLink; //相应链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.Link) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.Link, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.Link] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetPublishSite(this clsLiveRoomEN objLiveRoomEN, string strPublishSite, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPublishSite, 50, conLiveRoom.PublishSite);
objLiveRoomEN.PublishSite = strPublishSite; //发布点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.PublishSite) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.PublishSite, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.PublishSite] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetVideoName(this clsLiveRoomEN objLiveRoomEN, string strVideoName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoName, 100, conLiveRoom.VideoName);
objLiveRoomEN.VideoName = strVideoName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.VideoName) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.VideoName, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.VideoName] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetCourseContent(this clsLiveRoomEN objLiveRoomEN, string strCourseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseContent, 8000, conLiveRoom.CourseContent);
objLiveRoomEN.CourseContent = strCourseContent; //授课内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.CourseContent) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.CourseContent, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.CourseContent] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetInstructors(this clsLiveRoomEN objLiveRoomEN, string strInstructors, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInstructors, 20, conLiveRoom.Instructors);
objLiveRoomEN.Instructors = strInstructors; //授课教师
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.Instructors) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.Instructors, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.Instructors] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetIsOpen(this clsLiveRoomEN objLiveRoomEN, bool bolIsOpen, string strComparisonOp="")
	{
objLiveRoomEN.IsOpen = bolIsOpen; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.IsOpen) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.IsOpen, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.IsOpen] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetMemo(this clsLiveRoomEN objLiveRoomEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conLiveRoom.Memo);
objLiveRoomEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.Memo) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.Memo, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.Memo] = strComparisonOp;
}
}
return objLiveRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsLiveRoomEN SetLiveRoomSite(this clsLiveRoomEN objLiveRoomEN, string strLiveRoomSite, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveRoomSite, 100, conLiveRoom.LiveRoomSite);
objLiveRoomEN.LiveRoomSite = strLiveRoomSite; //LiveRoomSite
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLiveRoomEN.dicFldComparisonOp.ContainsKey(conLiveRoom.LiveRoomSite) == false)
{
objLiveRoomEN.dicFldComparisonOp.Add(conLiveRoom.LiveRoomSite, strComparisonOp);
}
else
{
objLiveRoomEN.dicFldComparisonOp[conLiveRoom.LiveRoomSite] = strComparisonOp;
}
}
return objLiveRoomEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsLiveRoomEN objLiveRoom_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.LiveRoomID) == true)
{
string strComparisonOp_LiveRoomID = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.LiveRoomID];
strWhereCond += string.Format(" And {0} {2} {1}", conLiveRoom.LiveRoomID, objLiveRoom_Cond.LiveRoomID, strComparisonOp_LiveRoomID);
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.RoomName) == true)
{
string strComparisonOp_RoomName = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.RoomName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLiveRoom.RoomName, objLiveRoom_Cond.RoomName, strComparisonOp_RoomName);
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.LiveCode) == true)
{
string strComparisonOp_LiveCode = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.LiveCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLiveRoom.LiveCode, objLiveRoom_Cond.LiveCode, strComparisonOp_LiveCode);
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.School) == true)
{
string strComparisonOp_School = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.School];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLiveRoom.School, objLiveRoom_Cond.School, strComparisonOp_School);
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.Link) == true)
{
string strComparisonOp_Link = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.Link];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLiveRoom.Link, objLiveRoom_Cond.Link, strComparisonOp_Link);
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.PublishSite) == true)
{
string strComparisonOp_PublishSite = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.PublishSite];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLiveRoom.PublishSite, objLiveRoom_Cond.PublishSite, strComparisonOp_PublishSite);
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.VideoName) == true)
{
string strComparisonOp_VideoName = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.VideoName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLiveRoom.VideoName, objLiveRoom_Cond.VideoName, strComparisonOp_VideoName);
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.CourseContent) == true)
{
string strComparisonOp_CourseContent = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.CourseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLiveRoom.CourseContent, objLiveRoom_Cond.CourseContent, strComparisonOp_CourseContent);
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.Instructors) == true)
{
string strComparisonOp_Instructors = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.Instructors];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLiveRoom.Instructors, objLiveRoom_Cond.Instructors, strComparisonOp_Instructors);
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.IsOpen) == true)
{
if (objLiveRoom_Cond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", conLiveRoom.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conLiveRoom.IsOpen);
}
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.Memo) == true)
{
string strComparisonOp_Memo = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLiveRoom.Memo, objLiveRoom_Cond.Memo, strComparisonOp_Memo);
}
if (objLiveRoom_Cond.IsUpdated(conLiveRoom.LiveRoomSite) == true)
{
string strComparisonOp_LiveRoomSite = objLiveRoom_Cond.dicFldComparisonOp[conLiveRoom.LiveRoomSite];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLiveRoom.LiveRoomSite, objLiveRoom_Cond.LiveRoomSite, strComparisonOp_LiveRoomSite);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLiveRoomEN objLiveRoomEN)
{
 if (objLiveRoomEN.LiveRoomID == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objLiveRoomEN.sf_UpdFldSetStr = objLiveRoomEN.getsf_UpdFldSetStr();
clsLiveRoomWApi.CheckPropertyNew(objLiveRoomEN); 
bool bolResult = clsLiveRoomWApi.UpdateRecord(objLiveRoomEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLiveRoomWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--LiveRoom(直播教室), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objLiveRoomEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_LiveRoomSite_School(this clsLiveRoomEN objLiveRoomEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objLiveRoomEN == null) return "";
if (objLiveRoomEN.LiveRoomID == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and LiveRoomSite = '{0}'", objLiveRoomEN.LiveRoomSite);
 sbCondition.AppendFormat(" and School = '{0}'", objLiveRoomEN.School);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("LiveRoomID !=  {0}", objLiveRoomEN.LiveRoomID);
 sbCondition.AppendFormat(" and LiveRoomSite = '{0}'", objLiveRoomEN.LiveRoomSite);
 sbCondition.AppendFormat(" and School = '{0}'", objLiveRoomEN.School);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsLiveRoomEN objLiveRoomEN)
{
try
{
clsLiveRoomWApi.CheckPropertyNew(objLiveRoomEN); 
bool bolResult = clsLiveRoomWApi.AddNewRecord(objLiveRoomEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLiveRoomWApi.ReFreshCache();
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
 /// <param name = "objLiveRoomEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLiveRoomEN objLiveRoomEN, string strWhereCond)
{
try
{
clsLiveRoomWApi.CheckPropertyNew(objLiveRoomEN); 
bool bolResult = clsLiveRoomWApi.UpdateWithCondition(objLiveRoomEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLiveRoomWApi.ReFreshCache();
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
 /// 直播教室(LiveRoom)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsLiveRoomWApi
{
private static readonly string mstrApiControllerName = "LiveRoomApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsLiveRoomWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsLiveRoomEN objLiveRoomEN)
{
if (!Object.Equals(null, objLiveRoomEN.RoomName) && GetStrLen(objLiveRoomEN.RoomName) > 50)
{
 throw new Exception("字段[房间名称]的长度不能超过50!");
}
if (!Object.Equals(null, objLiveRoomEN.LiveCode) && GetStrLen(objLiveRoomEN.LiveCode) > 100)
{
 throw new Exception("字段[直播代码]的长度不能超过100!");
}
if (!Object.Equals(null, objLiveRoomEN.School) && GetStrLen(objLiveRoomEN.School) > 50)
{
 throw new Exception("字段[School]的长度不能超过50!");
}
if (!Object.Equals(null, objLiveRoomEN.Link) && GetStrLen(objLiveRoomEN.Link) > 200)
{
 throw new Exception("字段[相应链接]的长度不能超过200!");
}
if (!Object.Equals(null, objLiveRoomEN.PublishSite) && GetStrLen(objLiveRoomEN.PublishSite) > 50)
{
 throw new Exception("字段[发布点]的长度不能超过50!");
}
if (!Object.Equals(null, objLiveRoomEN.VideoName) && GetStrLen(objLiveRoomEN.VideoName) > 100)
{
 throw new Exception("字段[视频名称]的长度不能超过100!");
}
if (!Object.Equals(null, objLiveRoomEN.CourseContent) && GetStrLen(objLiveRoomEN.CourseContent) > 8000)
{
 throw new Exception("字段[授课内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objLiveRoomEN.Instructors) && GetStrLen(objLiveRoomEN.Instructors) > 20)
{
 throw new Exception("字段[授课教师]的长度不能超过20!");
}
if (!Object.Equals(null, objLiveRoomEN.Memo) && GetStrLen(objLiveRoomEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objLiveRoomEN.LiveRoomSite) && GetStrLen(objLiveRoomEN.LiveRoomSite) > 100)
{
 throw new Exception("字段[LiveRoomSite]的长度不能超过100!");
}
 objLiveRoomEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngLiveRoomID">表关键字</param>
 /// <returns>表对象</returns>
public static clsLiveRoomEN GetObjByLiveRoomID(long lngLiveRoomID)
{
string strAction = "GetObjByLiveRoomID";
string strErrMsg = string.Empty;
string strResult = "";
clsLiveRoomEN objLiveRoomEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["LiveRoomID"] = lngLiveRoomID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objLiveRoomEN = JsonConvert.DeserializeObject<clsLiveRoomEN>((string)jobjReturn["ReturnObj"]);
return objLiveRoomEN;
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
 /// <param name = "lngLiveRoomID">表关键字</param>
 /// <returns>表对象</returns>
public static clsLiveRoomEN GetObjByLiveRoomID_WA_Cache(long lngLiveRoomID)
{
string strAction = "GetObjByLiveRoomID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsLiveRoomEN objLiveRoomEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["LiveRoomID"] = lngLiveRoomID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objLiveRoomEN = JsonConvert.DeserializeObject<clsLiveRoomEN>((string)jobjReturn["ReturnObj"]);
return objLiveRoomEN;
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
public static clsLiveRoomEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsLiveRoomEN objLiveRoomEN = null;
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
objLiveRoomEN = JsonConvert.DeserializeObject<clsLiveRoomEN>((string)jobjReturn["ReturnObj"]);
return objLiveRoomEN;
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
 /// <param name = "lngLiveRoomID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsLiveRoomEN GetObjByLiveRoomID_Cache(long lngLiveRoomID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsLiveRoomEN._CurrTabName_S);
List<clsLiveRoomEN> arrLiveRoomObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsLiveRoomEN> arrLiveRoomObjLst_Sel =
from objLiveRoomEN in arrLiveRoomObjLst_Cache
where objLiveRoomEN.LiveRoomID == lngLiveRoomID
select objLiveRoomEN;
if (arrLiveRoomObjLst_Sel.Count() == 0)
{
   clsLiveRoomEN obj = clsLiveRoomWApi.GetObjByLiveRoomID(lngLiveRoomID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrLiveRoomObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsLiveRoomEN> GetObjLst(string strWhereCond)
{
 List<clsLiveRoomEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLiveRoomEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsLiveRoomEN> GetObjLstByLiveRoomIDLst(List<long> arrLiveRoomID)
{
 List<clsLiveRoomEN> arrObjLst = null; 
string strAction = "GetObjLstByLiveRoomIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrLiveRoomID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsLiveRoomEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngLiveRoomID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsLiveRoomEN> GetObjLstByLiveRoomIDLst_Cache(List<long> arrLiveRoomID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsLiveRoomEN._CurrTabName_S);
List<clsLiveRoomEN> arrLiveRoomObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsLiveRoomEN> arrLiveRoomObjLst_Sel =
from objLiveRoomEN in arrLiveRoomObjLst_Cache
where arrLiveRoomID.Contains(objLiveRoomEN.LiveRoomID)
select objLiveRoomEN;
return arrLiveRoomObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsLiveRoomEN> GetObjLstByLiveRoomIDLst_WA_Cache(List<long> arrLiveRoomID)
{
 List<clsLiveRoomEN> arrObjLst = null; 
string strAction = "GetObjLstByLiveRoomIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrLiveRoomID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsLiveRoomEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsLiveRoomEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsLiveRoomEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLiveRoomEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsLiveRoomEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsLiveRoomEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLiveRoomEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsLiveRoomEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsLiveRoomEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLiveRoomEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsLiveRoomEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsLiveRoomEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLiveRoomEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngLiveRoomID)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsLiveRoomEN objLiveRoomEN = clsLiveRoomWApi.GetObjByLiveRoomID(lngLiveRoomID);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngLiveRoomID.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsLiveRoomWApi.ReFreshCache();
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
public static int DelLiveRooms(List<string> arrLiveRoomID)
{
string strAction = "DelLiveRooms";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrLiveRoomID);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsLiveRoomWApi.ReFreshCache();
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
public static int DelLiveRoomsByCond(string strWhereCond)
{
string strAction = "DelLiveRoomsByCond";
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
public static bool AddNewRecord(clsLiveRoomEN objLiveRoomEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLiveRoomEN>(objLiveRoomEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLiveRoomWApi.ReFreshCache();
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
 /// <param name = "objLiveRoomEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsLiveRoomEN objLiveRoomEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLiveRoomEN>(objLiveRoomEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLiveRoomWApi.ReFreshCache();
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
public static bool UpdateRecord(clsLiveRoomEN objLiveRoomEN)
{
if (string.IsNullOrEmpty(objLiveRoomEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objLiveRoomEN.LiveRoomID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLiveRoomEN>(objLiveRoomEN);
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
 /// <param name = "objLiveRoomEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsLiveRoomEN objLiveRoomEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objLiveRoomEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objLiveRoomEN.LiveRoomID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objLiveRoomEN.LiveRoomID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLiveRoomEN>(objLiveRoomEN);
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
public static bool IsExist(long lngLiveRoomID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["LiveRoomID"] = lngLiveRoomID.ToString()
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
 /// <param name = "objLiveRoomENS">源对象</param>
 /// <param name = "objLiveRoomENT">目标对象</param>
 public static void CopyTo(clsLiveRoomEN objLiveRoomENS, clsLiveRoomEN objLiveRoomENT)
{
try
{
objLiveRoomENT.LiveRoomID = objLiveRoomENS.LiveRoomID; //房间ID
objLiveRoomENT.RoomName = objLiveRoomENS.RoomName; //房间名称
objLiveRoomENT.LiveCode = objLiveRoomENS.LiveCode; //直播代码
objLiveRoomENT.School = objLiveRoomENS.School; //School
objLiveRoomENT.Link = objLiveRoomENS.Link; //相应链接
objLiveRoomENT.PublishSite = objLiveRoomENS.PublishSite; //发布点
objLiveRoomENT.VideoName = objLiveRoomENS.VideoName; //视频名称
objLiveRoomENT.CourseContent = objLiveRoomENS.CourseContent; //授课内容
objLiveRoomENT.Instructors = objLiveRoomENS.Instructors; //授课教师
objLiveRoomENT.IsOpen = objLiveRoomENS.IsOpen; //是否公开
objLiveRoomENT.Memo = objLiveRoomENS.Memo; //备注
objLiveRoomENT.LiveRoomSite = objLiveRoomENS.LiveRoomSite; //LiveRoomSite
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
public static DataTable ToDataTable(List<clsLiveRoomEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsLiveRoomEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsLiveRoomEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsLiveRoomEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsLiveRoomEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsLiveRoomEN.AttributeName)
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
if (clsLiveRoomWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsLiveRoomWApi没有刷新缓存机制(clsLiveRoomWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by LiveRoomID");
//if (arrLiveRoomObjLst_Cache == null)
//{
//arrLiveRoomObjLst_Cache = await clsLiveRoomWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsLiveRoomEN._CurrTabName_S);
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
if (clsLiveRoomWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsLiveRoomEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsLiveRoomWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLiveRoomEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsLiveRoomEN._CurrTabName_S);
List<clsLiveRoomEN> arrLiveRoomObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrLiveRoomObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsLiveRoomEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conLiveRoom.LiveRoomID, Type.GetType("System.Int64"));
objDT.Columns.Add(conLiveRoom.RoomName, Type.GetType("System.String"));
objDT.Columns.Add(conLiveRoom.LiveCode, Type.GetType("System.String"));
objDT.Columns.Add(conLiveRoom.School, Type.GetType("System.String"));
objDT.Columns.Add(conLiveRoom.Link, Type.GetType("System.String"));
objDT.Columns.Add(conLiveRoom.PublishSite, Type.GetType("System.String"));
objDT.Columns.Add(conLiveRoom.VideoName, Type.GetType("System.String"));
objDT.Columns.Add(conLiveRoom.CourseContent, Type.GetType("System.String"));
objDT.Columns.Add(conLiveRoom.Instructors, Type.GetType("System.String"));
objDT.Columns.Add(conLiveRoom.IsOpen, Type.GetType("System.Boolean"));
objDT.Columns.Add(conLiveRoom.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conLiveRoom.LiveRoomSite, Type.GetType("System.String"));
foreach (clsLiveRoomEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conLiveRoom.LiveRoomID] = objInFor[conLiveRoom.LiveRoomID];
objDR[conLiveRoom.RoomName] = objInFor[conLiveRoom.RoomName];
objDR[conLiveRoom.LiveCode] = objInFor[conLiveRoom.LiveCode];
objDR[conLiveRoom.School] = objInFor[conLiveRoom.School];
objDR[conLiveRoom.Link] = objInFor[conLiveRoom.Link];
objDR[conLiveRoom.PublishSite] = objInFor[conLiveRoom.PublishSite];
objDR[conLiveRoom.VideoName] = objInFor[conLiveRoom.VideoName];
objDR[conLiveRoom.CourseContent] = objInFor[conLiveRoom.CourseContent];
objDR[conLiveRoom.Instructors] = objInFor[conLiveRoom.Instructors];
objDR[conLiveRoom.IsOpen] = objInFor[conLiveRoom.IsOpen];
objDR[conLiveRoom.Memo] = objInFor[conLiveRoom.Memo];
objDR[conLiveRoom.LiveRoomSite] = objInFor[conLiveRoom.LiveRoomSite];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 直播教室(LiveRoom)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4LiveRoom : clsCommFun4BL
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
clsLiveRoomWApi.ReFreshThisCache();
}
}

}