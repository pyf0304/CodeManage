
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_UserGroupBL
 表名:vzx_UserGroup(01120843)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvzx_UserGroupBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_UserGroupEN GetObj(this K_mId_vzx_UserGroup myKey)
{
clsvzx_UserGroupEN objvzx_UserGroupEN = clsvzx_UserGroupBL.vzx_UserGroupDA.GetObjBymId(myKey.Value);
return objvzx_UserGroupEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetTopicUserRoleName(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strTopicUserRoleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicUserRoleName, 100, convzx_UserGroup.TopicUserRoleName);
}
objvzx_UserGroupEN.TopicUserRoleName = strTopicUserRoleName; //主题用户角色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.TopicUserRoleName) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.TopicUserRoleName, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.TopicUserRoleName] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetmId(this clsvzx_UserGroupEN objvzx_UserGroupEN, long lngmId, string strComparisonOp="")
	{
objvzx_UserGroupEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.mId) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.mId, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.mId] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetUserId(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convzx_UserGroup.UserId);
}
objvzx_UserGroupEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.UserId) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.UserId, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.UserId] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetUpdDate(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_UserGroup.UpdDate);
}
objvzx_UserGroupEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.UpdDate) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.UpdDate, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.UpdDate] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetUpdUser(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_UserGroup.UpdUser);
}
objvzx_UserGroupEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.UpdUser) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.UpdUser, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.UpdUser] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetMemo(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_UserGroup.Memo);
}
objvzx_UserGroupEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.Memo) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.Memo, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.Memo] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetzxTopicUserRoleId(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strzxTopicUserRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxTopicUserRoleId, convzx_UserGroup.zxTopicUserRoleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTopicUserRoleId, 4, convzx_UserGroup.zxTopicUserRoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTopicUserRoleId, 4, convzx_UserGroup.zxTopicUserRoleId);
}
objvzx_UserGroupEN.zxTopicUserRoleId = strzxTopicUserRoleId; //主键Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.zxTopicUserRoleId) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.zxTopicUserRoleId, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.zxTopicUserRoleId] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetGroupTextId(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_UserGroup.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_UserGroup.GroupTextId);
}
objvzx_UserGroupEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.GroupTextId) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.GroupTextId, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.GroupTextId] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetzxColorId(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strzxColorId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxColorId, convzx_UserGroup.zxColorId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxColorId, 2, convzx_UserGroup.zxColorId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxColorId, 2, convzx_UserGroup.zxColorId);
}
objvzx_UserGroupEN.zxColorId = strzxColorId; //颜色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.zxColorId) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.zxColorId, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.zxColorId] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetOrderNum(this clsvzx_UserGroupEN objvzx_UserGroupEN, int? intOrderNum, string strComparisonOp="")
	{
objvzx_UserGroupEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.OrderNum) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.OrderNum, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.OrderNum] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetColorCode(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strColorCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strColorCode, 200, convzx_UserGroup.ColorCode);
}
objvzx_UserGroupEN.ColorCode = strColorCode; //颜色码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.ColorCode) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.ColorCode, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.ColorCode] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetUserNo(this clsvzx_UserGroupEN objvzx_UserGroupEN, int? intUserNo, string strComparisonOp="")
	{
objvzx_UserGroupEN.UserNo = intUserNo; //用户号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.UserNo) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.UserNo, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.UserNo] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetCollegeName(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convzx_UserGroup.CollegeName);
}
objvzx_UserGroupEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.CollegeName) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.CollegeName, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.CollegeName] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetGroupTextName(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strGroupTextName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextName, 2000, convzx_UserGroup.GroupTextName);
}
objvzx_UserGroupEN.GroupTextName = strGroupTextName; //小组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.GroupTextName) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.GroupTextName, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.GroupTextName] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetIdXzCollege(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convzx_UserGroup.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convzx_UserGroup.IdXzCollege);
}
objvzx_UserGroupEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.IdXzCollege) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.IdXzCollege, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.IdXzCollege] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetIdXzMajor(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convzx_UserGroup.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convzx_UserGroup.IdXzMajor);
}
objvzx_UserGroupEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.IdXzMajor) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.IdXzMajor, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.IdXzMajor] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetMajorName(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convzx_UserGroup.MajorName);
}
objvzx_UserGroupEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.MajorName) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.MajorName, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.MajorName] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_UserGroupEN SetUserName(this clsvzx_UserGroupEN objvzx_UserGroupEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convzx_UserGroup.UserName);
}
objvzx_UserGroupEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_UserGroupEN.dicFldComparisonOp.ContainsKey(convzx_UserGroup.UserName) == false)
{
objvzx_UserGroupEN.dicFldComparisonOp.Add(convzx_UserGroup.UserName, strComparisonOp);
}
else
{
objvzx_UserGroupEN.dicFldComparisonOp[convzx_UserGroup.UserName] = strComparisonOp;
}
}
return objvzx_UserGroupEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_UserGroupENS">源对象</param>
 /// <param name = "objvzx_UserGroupENT">目标对象</param>
 public static void CopyTo(this clsvzx_UserGroupEN objvzx_UserGroupENS, clsvzx_UserGroupEN objvzx_UserGroupENT)
{
try
{
objvzx_UserGroupENT.TopicUserRoleName = objvzx_UserGroupENS.TopicUserRoleName; //主题用户角色
objvzx_UserGroupENT.mId = objvzx_UserGroupENS.mId; //mId
objvzx_UserGroupENT.UserId = objvzx_UserGroupENS.UserId; //用户ID
objvzx_UserGroupENT.UpdDate = objvzx_UserGroupENS.UpdDate; //修改日期
objvzx_UserGroupENT.UpdUser = objvzx_UserGroupENS.UpdUser; //修改人
objvzx_UserGroupENT.Memo = objvzx_UserGroupENS.Memo; //备注
objvzx_UserGroupENT.zxTopicUserRoleId = objvzx_UserGroupENS.zxTopicUserRoleId; //主键Id
objvzx_UserGroupENT.GroupTextId = objvzx_UserGroupENS.GroupTextId; //小组Id
objvzx_UserGroupENT.zxColorId = objvzx_UserGroupENS.zxColorId; //颜色Id
objvzx_UserGroupENT.OrderNum = objvzx_UserGroupENS.OrderNum; //序号
objvzx_UserGroupENT.ColorCode = objvzx_UserGroupENS.ColorCode; //颜色码
objvzx_UserGroupENT.UserNo = objvzx_UserGroupENS.UserNo; //用户号
objvzx_UserGroupENT.CollegeName = objvzx_UserGroupENS.CollegeName; //学院名称
objvzx_UserGroupENT.GroupTextName = objvzx_UserGroupENS.GroupTextName; //小组名称
objvzx_UserGroupENT.IdXzCollege = objvzx_UserGroupENS.IdXzCollege; //学院流水号
objvzx_UserGroupENT.IdXzMajor = objvzx_UserGroupENS.IdXzMajor; //专业流水号
objvzx_UserGroupENT.MajorName = objvzx_UserGroupENS.MajorName; //专业名称
objvzx_UserGroupENT.UserName = objvzx_UserGroupENS.UserName; //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvzx_UserGroupENS">源对象</param>
 /// <returns>目标对象=>clsvzx_UserGroupEN:objvzx_UserGroupENT</returns>
 public static clsvzx_UserGroupEN CopyTo(this clsvzx_UserGroupEN objvzx_UserGroupENS)
{
try
{
 clsvzx_UserGroupEN objvzx_UserGroupENT = new clsvzx_UserGroupEN()
{
TopicUserRoleName = objvzx_UserGroupENS.TopicUserRoleName, //主题用户角色
mId = objvzx_UserGroupENS.mId, //mId
UserId = objvzx_UserGroupENS.UserId, //用户ID
UpdDate = objvzx_UserGroupENS.UpdDate, //修改日期
UpdUser = objvzx_UserGroupENS.UpdUser, //修改人
Memo = objvzx_UserGroupENS.Memo, //备注
zxTopicUserRoleId = objvzx_UserGroupENS.zxTopicUserRoleId, //主键Id
GroupTextId = objvzx_UserGroupENS.GroupTextId, //小组Id
zxColorId = objvzx_UserGroupENS.zxColorId, //颜色Id
OrderNum = objvzx_UserGroupENS.OrderNum, //序号
ColorCode = objvzx_UserGroupENS.ColorCode, //颜色码
UserNo = objvzx_UserGroupENS.UserNo, //用户号
CollegeName = objvzx_UserGroupENS.CollegeName, //学院名称
GroupTextName = objvzx_UserGroupENS.GroupTextName, //小组名称
IdXzCollege = objvzx_UserGroupENS.IdXzCollege, //学院流水号
IdXzMajor = objvzx_UserGroupENS.IdXzMajor, //专业流水号
MajorName = objvzx_UserGroupENS.MajorName, //专业名称
UserName = objvzx_UserGroupENS.UserName, //用户名
};
 return objvzx_UserGroupENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvzx_UserGroupEN objvzx_UserGroupEN)
{
 clsvzx_UserGroupBL.vzx_UserGroupDA.CheckProperty4Condition(objvzx_UserGroupEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_UserGroupEN objvzx_UserGroupCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.TopicUserRoleName) == true)
{
string strComparisonOpTopicUserRoleName = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.TopicUserRoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.TopicUserRoleName, objvzx_UserGroupCond.TopicUserRoleName, strComparisonOpTopicUserRoleName);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.mId) == true)
{
string strComparisonOpmId = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_UserGroup.mId, objvzx_UserGroupCond.mId, strComparisonOpmId);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.UserId) == true)
{
string strComparisonOpUserId = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.UserId, objvzx_UserGroupCond.UserId, strComparisonOpUserId);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.UpdDate, objvzx_UserGroupCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.UpdUser, objvzx_UserGroupCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.Memo) == true)
{
string strComparisonOpMemo = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.Memo, objvzx_UserGroupCond.Memo, strComparisonOpMemo);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.zxTopicUserRoleId) == true)
{
string strComparisonOpzxTopicUserRoleId = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.zxTopicUserRoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.zxTopicUserRoleId, objvzx_UserGroupCond.zxTopicUserRoleId, strComparisonOpzxTopicUserRoleId);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.GroupTextId, objvzx_UserGroupCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.zxColorId) == true)
{
string strComparisonOpzxColorId = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.zxColorId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.zxColorId, objvzx_UserGroupCond.zxColorId, strComparisonOpzxColorId);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.OrderNum) == true)
{
string strComparisonOpOrderNum = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_UserGroup.OrderNum, objvzx_UserGroupCond.OrderNum, strComparisonOpOrderNum);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.ColorCode) == true)
{
string strComparisonOpColorCode = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.ColorCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.ColorCode, objvzx_UserGroupCond.ColorCode, strComparisonOpColorCode);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.UserNo) == true)
{
string strComparisonOpUserNo = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.UserNo];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_UserGroup.UserNo, objvzx_UserGroupCond.UserNo, strComparisonOpUserNo);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.CollegeName) == true)
{
string strComparisonOpCollegeName = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.CollegeName, objvzx_UserGroupCond.CollegeName, strComparisonOpCollegeName);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.GroupTextName) == true)
{
string strComparisonOpGroupTextName = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.GroupTextName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.GroupTextName, objvzx_UserGroupCond.GroupTextName, strComparisonOpGroupTextName);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.IdXzCollege, objvzx_UserGroupCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.IdXzMajor, objvzx_UserGroupCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.MajorName) == true)
{
string strComparisonOpMajorName = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.MajorName, objvzx_UserGroupCond.MajorName, strComparisonOpMajorName);
}
if (objvzx_UserGroupCond.IsUpdated(convzx_UserGroup.UserName) == true)
{
string strComparisonOpUserName = objvzx_UserGroupCond.dicFldComparisonOp[convzx_UserGroup.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_UserGroup.UserName, objvzx_UserGroupCond.UserName, strComparisonOpUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_UserGroup
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_UserGroup(vzx_UserGroup)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_UserGroupBL
{
public static RelatedActions_vzx_UserGroup relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_UserGroupDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_UserGroupDA vzx_UserGroupDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_UserGroupDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_UserGroupBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvzx_UserGroupEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_UserGroupEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vzx_UserGroup(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_UserGroupDA.GetDataTable_vzx_UserGroup(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_UserGroupDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vzx_UserGroupDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vzx_UserGroupDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vzx_UserGroupDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vzx_UserGroupDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vzx_UserGroupDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vzx_UserGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vzx_UserGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_UserGroupEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_UserGroupEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_UserGroupEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvzx_UserGroupEN._CurrTabName);
List<clsvzx_UserGroupEN> arrvzx_UserGroupObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_UserGroupEN> arrvzx_UserGroupObjLst_Sel =
arrvzx_UserGroupObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvzx_UserGroupObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_UserGroupEN> GetObjLst(string strWhereCond)
{
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_UserGroupEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_UserGroupEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_UserGroupEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_UserGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_UserGroupEN> GetSubObjLstCache(clsvzx_UserGroupEN objvzx_UserGroupCond)
{
List<clsvzx_UserGroupEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_UserGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_UserGroup.AttributeName)
{
if (objvzx_UserGroupCond.IsUpdated(strFldName) == false) continue;
if (objvzx_UserGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_UserGroupCond[strFldName].ToString());
}
else
{
if (objvzx_UserGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_UserGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_UserGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_UserGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_UserGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_UserGroupCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_UserGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_UserGroupEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_UserGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_UserGroupEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvzx_UserGroupEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_UserGroupEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_UserGroupEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_UserGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_UserGroupEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_UserGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_UserGroupEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_UserGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_UserGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_UserGroupEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_UserGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_UserGroupEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_UserGroupEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_UserGroupEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_UserGroup(ref clsvzx_UserGroupEN objvzx_UserGroupEN)
{
bool bolResult = vzx_UserGroupDA.Getvzx_UserGroup(ref objvzx_UserGroupEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_UserGroupEN GetObjBymId(long lngmId)
{
clsvzx_UserGroupEN objvzx_UserGroupEN = vzx_UserGroupDA.GetObjBymId(lngmId);
return objvzx_UserGroupEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_UserGroupEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_UserGroupEN objvzx_UserGroupEN = vzx_UserGroupDA.GetFirstObj(strWhereCond);
 return objvzx_UserGroupEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvzx_UserGroupEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_UserGroupEN objvzx_UserGroupEN = vzx_UserGroupDA.GetObjByDataRow(objRow);
 return objvzx_UserGroupEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvzx_UserGroupEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_UserGroupEN objvzx_UserGroupEN = vzx_UserGroupDA.GetObjByDataRow(objRow);
 return objvzx_UserGroupEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvzx_UserGroupObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_UserGroupEN GetObjBymIdFromList(long lngmId, List<clsvzx_UserGroupEN> lstvzx_UserGroupObjLst)
{
foreach (clsvzx_UserGroupEN objvzx_UserGroupEN in lstvzx_UserGroupObjLst)
{
if (objvzx_UserGroupEN.mId == lngmId)
{
return objvzx_UserGroupEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvzx_UserGroupDA().GetFirstID(strWhereCond);
 return lngmId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vzx_UserGroupDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vzx_UserGroupDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vzx_UserGroupDA.IsExist(lngmId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvzx_UserGroupDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vzx_UserGroupDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvzx_UserGroupENS">源对象</param>
 /// <param name = "objvzx_UserGroupENT">目标对象</param>
 public static void CopyTo(clsvzx_UserGroupEN objvzx_UserGroupENS, clsvzx_UserGroupEN objvzx_UserGroupENT)
{
try
{
objvzx_UserGroupENT.TopicUserRoleName = objvzx_UserGroupENS.TopicUserRoleName; //主题用户角色
objvzx_UserGroupENT.mId = objvzx_UserGroupENS.mId; //mId
objvzx_UserGroupENT.UserId = objvzx_UserGroupENS.UserId; //用户ID
objvzx_UserGroupENT.UpdDate = objvzx_UserGroupENS.UpdDate; //修改日期
objvzx_UserGroupENT.UpdUser = objvzx_UserGroupENS.UpdUser; //修改人
objvzx_UserGroupENT.Memo = objvzx_UserGroupENS.Memo; //备注
objvzx_UserGroupENT.zxTopicUserRoleId = objvzx_UserGroupENS.zxTopicUserRoleId; //主键Id
objvzx_UserGroupENT.GroupTextId = objvzx_UserGroupENS.GroupTextId; //小组Id
objvzx_UserGroupENT.zxColorId = objvzx_UserGroupENS.zxColorId; //颜色Id
objvzx_UserGroupENT.OrderNum = objvzx_UserGroupENS.OrderNum; //序号
objvzx_UserGroupENT.ColorCode = objvzx_UserGroupENS.ColorCode; //颜色码
objvzx_UserGroupENT.UserNo = objvzx_UserGroupENS.UserNo; //用户号
objvzx_UserGroupENT.CollegeName = objvzx_UserGroupENS.CollegeName; //学院名称
objvzx_UserGroupENT.GroupTextName = objvzx_UserGroupENS.GroupTextName; //小组名称
objvzx_UserGroupENT.IdXzCollege = objvzx_UserGroupENS.IdXzCollege; //学院流水号
objvzx_UserGroupENT.IdXzMajor = objvzx_UserGroupENS.IdXzMajor; //专业流水号
objvzx_UserGroupENT.MajorName = objvzx_UserGroupENS.MajorName; //专业名称
objvzx_UserGroupENT.UserName = objvzx_UserGroupENS.UserName; //用户名
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_UserGroupEN objvzx_UserGroupEN)
{
try
{
objvzx_UserGroupEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_UserGroupEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_UserGroup.TopicUserRoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.TopicUserRoleName = objvzx_UserGroupEN.TopicUserRoleName == "[null]" ? null :  objvzx_UserGroupEN.TopicUserRoleName; //主题用户角色
}
if (arrFldSet.Contains(convzx_UserGroup.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.mId = objvzx_UserGroupEN.mId; //mId
}
if (arrFldSet.Contains(convzx_UserGroup.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.UserId = objvzx_UserGroupEN.UserId == "[null]" ? null :  objvzx_UserGroupEN.UserId; //用户ID
}
if (arrFldSet.Contains(convzx_UserGroup.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.UpdDate = objvzx_UserGroupEN.UpdDate == "[null]" ? null :  objvzx_UserGroupEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_UserGroup.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.UpdUser = objvzx_UserGroupEN.UpdUser == "[null]" ? null :  objvzx_UserGroupEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_UserGroup.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.Memo = objvzx_UserGroupEN.Memo == "[null]" ? null :  objvzx_UserGroupEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_UserGroup.zxTopicUserRoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.zxTopicUserRoleId = objvzx_UserGroupEN.zxTopicUserRoleId; //主键Id
}
if (arrFldSet.Contains(convzx_UserGroup.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.GroupTextId = objvzx_UserGroupEN.GroupTextId == "[null]" ? null :  objvzx_UserGroupEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_UserGroup.zxColorId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.zxColorId = objvzx_UserGroupEN.zxColorId; //颜色Id
}
if (arrFldSet.Contains(convzx_UserGroup.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.OrderNum = objvzx_UserGroupEN.OrderNum; //序号
}
if (arrFldSet.Contains(convzx_UserGroup.ColorCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.ColorCode = objvzx_UserGroupEN.ColorCode == "[null]" ? null :  objvzx_UserGroupEN.ColorCode; //颜色码
}
if (arrFldSet.Contains(convzx_UserGroup.UserNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.UserNo = objvzx_UserGroupEN.UserNo; //用户号
}
if (arrFldSet.Contains(convzx_UserGroup.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.CollegeName = objvzx_UserGroupEN.CollegeName == "[null]" ? null :  objvzx_UserGroupEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convzx_UserGroup.GroupTextName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.GroupTextName = objvzx_UserGroupEN.GroupTextName == "[null]" ? null :  objvzx_UserGroupEN.GroupTextName; //小组名称
}
if (arrFldSet.Contains(convzx_UserGroup.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.IdXzCollege = objvzx_UserGroupEN.IdXzCollege == "[null]" ? null :  objvzx_UserGroupEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convzx_UserGroup.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.IdXzMajor = objvzx_UserGroupEN.IdXzMajor == "[null]" ? null :  objvzx_UserGroupEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convzx_UserGroup.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.MajorName = objvzx_UserGroupEN.MajorName == "[null]" ? null :  objvzx_UserGroupEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convzx_UserGroup.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_UserGroupEN.UserName = objvzx_UserGroupEN.UserName == "[null]" ? null :  objvzx_UserGroupEN.UserName; //用户名
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_UserGroupEN objvzx_UserGroupEN)
{
try
{
if (objvzx_UserGroupEN.TopicUserRoleName == "[null]") objvzx_UserGroupEN.TopicUserRoleName = null; //主题用户角色
if (objvzx_UserGroupEN.UserId == "[null]") objvzx_UserGroupEN.UserId = null; //用户ID
if (objvzx_UserGroupEN.UpdDate == "[null]") objvzx_UserGroupEN.UpdDate = null; //修改日期
if (objvzx_UserGroupEN.UpdUser == "[null]") objvzx_UserGroupEN.UpdUser = null; //修改人
if (objvzx_UserGroupEN.Memo == "[null]") objvzx_UserGroupEN.Memo = null; //备注
if (objvzx_UserGroupEN.GroupTextId == "[null]") objvzx_UserGroupEN.GroupTextId = null; //小组Id
if (objvzx_UserGroupEN.ColorCode == "[null]") objvzx_UserGroupEN.ColorCode = null; //颜色码
if (objvzx_UserGroupEN.CollegeName == "[null]") objvzx_UserGroupEN.CollegeName = null; //学院名称
if (objvzx_UserGroupEN.GroupTextName == "[null]") objvzx_UserGroupEN.GroupTextName = null; //小组名称
if (objvzx_UserGroupEN.IdXzCollege == "[null]") objvzx_UserGroupEN.IdXzCollege = null; //学院流水号
if (objvzx_UserGroupEN.IdXzMajor == "[null]") objvzx_UserGroupEN.IdXzMajor = null; //专业流水号
if (objvzx_UserGroupEN.MajorName == "[null]") objvzx_UserGroupEN.MajorName = null; //专业名称
if (objvzx_UserGroupEN.UserName == "[null]") objvzx_UserGroupEN.UserName = null; //用户名
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvzx_UserGroupEN objvzx_UserGroupEN)
{
 vzx_UserGroupDA.CheckProperty4Condition(objvzx_UserGroupEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clszx_UserGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_UserGroupBL没有刷新缓存机制(clszx_UserGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_GroupTextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_GroupTextBL没有刷新缓存机制(clszx_GroupTextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_ColorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ColorBL没有刷新缓存机制(clszx_ColorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TopicUserRoleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TopicUserRoleBL没有刷新缓存机制(clszx_TopicUserRoleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvzx_UserGroupObjLstCache == null)
//{
//arrvzx_UserGroupObjLstCache = vzx_UserGroupDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_UserGroupEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_UserGroupEN._CurrTabName);
List<clsvzx_UserGroupEN> arrvzx_UserGroupObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_UserGroupEN> arrvzx_UserGroupObjLst_Sel =
arrvzx_UserGroupObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvzx_UserGroupObjLst_Sel.Count() == 0)
{
   clsvzx_UserGroupEN obj = clsvzx_UserGroupBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_UserGroupObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_UserGroupEN> GetAllvzx_UserGroupObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_UserGroupEN> arrvzx_UserGroupObjLstCache = GetObjLstCache(); 
return arrvzx_UserGroupObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_UserGroupEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_UserGroupEN._CurrTabName);
List<clsvzx_UserGroupEN> arrvzx_UserGroupObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_UserGroupObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvzx_UserGroupEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convzx_UserGroup.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_UserGroup.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_UserGroup.AttributeName));
throw new Exception(strMsg);
}
var objvzx_UserGroup = clsvzx_UserGroupBL.GetObjBymIdCache(lngmId);
if (objvzx_UserGroup == null) return "";
return objvzx_UserGroup[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvzx_UserGroupDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvzx_UserGroupDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_UserGroupDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvzx_UserGroupDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_UserGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_UserGroupEN objvzx_UserGroupCond)
{
List<clsvzx_UserGroupEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_UserGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_UserGroup.AttributeName)
{
if (objvzx_UserGroupCond.IsUpdated(strFldName) == false) continue;
if (objvzx_UserGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_UserGroupCond[strFldName].ToString());
}
else
{
if (objvzx_UserGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_UserGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_UserGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_UserGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_UserGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_UserGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_UserGroupCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvzx_UserGroupDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vzx_UserGroupDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vzx_UserGroupDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}