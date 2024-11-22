
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubResTypeBL
 表名:PaperSubResType(01120965)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsPaperSubResTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperSubResTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubResTypeEN GetObj(this K_PaperSubResTypeId_PaperSubResType myKey)
{
clsPaperSubResTypeEN objPaperSubResTypeEN = clsPaperSubResTypeBL.PaperSubResTypeDA.GetObjByPaperSubResTypeId(myKey.Value);
return objPaperSubResTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPaperSubResTypeEN objPaperSubResTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPaperSubResTypeBL.IsExist(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPaperSubResTypeEN.PaperSubResTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsPaperSubResTypeBL.PaperSubResTypeDA.AddNewRecordBySQL2(objPaperSubResTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsPaperSubResTypeEN objPaperSubResTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsPaperSubResTypeBL.IsExist(objPaperSubResTypeEN.PaperSubResTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objPaperSubResTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objPaperSubResTypeEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPaperSubResTypeEN objPaperSubResTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPaperSubResTypeBL.IsExist(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPaperSubResTypeEN.PaperSubResTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsPaperSubResTypeBL.PaperSubResTypeDA.AddNewRecordBySQL2WithReturnKey(objPaperSubResTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResTypeEN SetPaperSubResTypeId(this clsPaperSubResTypeEN objPaperSubResTypeEN, string strPaperSubResTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperSubResTypeId, 4, conPaperSubResType.PaperSubResTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperSubResTypeId, 4, conPaperSubResType.PaperSubResTypeId);
}
objPaperSubResTypeEN.PaperSubResTypeId = strPaperSubResTypeId; //论文子资源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResTypeEN.dicFldComparisonOp.ContainsKey(conPaperSubResType.PaperSubResTypeId) == false)
{
objPaperSubResTypeEN.dicFldComparisonOp.Add(conPaperSubResType.PaperSubResTypeId, strComparisonOp);
}
else
{
objPaperSubResTypeEN.dicFldComparisonOp[conPaperSubResType.PaperSubResTypeId] = strComparisonOp;
}
}
return objPaperSubResTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResTypeEN SetPaperSubResTypeName(this clsPaperSubResTypeEN objPaperSubResTypeEN, string strPaperSubResTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperSubResTypeName, conPaperSubResType.PaperSubResTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperSubResTypeName, 50, conPaperSubResType.PaperSubResTypeName);
}
objPaperSubResTypeEN.PaperSubResTypeName = strPaperSubResTypeName; //论文子资源类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResTypeEN.dicFldComparisonOp.ContainsKey(conPaperSubResType.PaperSubResTypeName) == false)
{
objPaperSubResTypeEN.dicFldComparisonOp.Add(conPaperSubResType.PaperSubResTypeName, strComparisonOp);
}
else
{
objPaperSubResTypeEN.dicFldComparisonOp[conPaperSubResType.PaperSubResTypeName] = strComparisonOp;
}
}
return objPaperSubResTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResTypeEN SetPaperSubResTypeENName(this clsPaperSubResTypeEN objPaperSubResTypeEN, string strPaperSubResTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperSubResTypeENName, 50, conPaperSubResType.PaperSubResTypeENName);
}
objPaperSubResTypeEN.PaperSubResTypeENName = strPaperSubResTypeENName; //论文子资源类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResTypeEN.dicFldComparisonOp.ContainsKey(conPaperSubResType.PaperSubResTypeENName) == false)
{
objPaperSubResTypeEN.dicFldComparisonOp.Add(conPaperSubResType.PaperSubResTypeENName, strComparisonOp);
}
else
{
objPaperSubResTypeEN.dicFldComparisonOp[conPaperSubResType.PaperSubResTypeENName] = strComparisonOp;
}
}
return objPaperSubResTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResTypeEN SetFileExtentNameLst(this clsPaperSubResTypeEN objPaperSubResTypeEN, string strFileExtentNameLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileExtentNameLst, 200, conPaperSubResType.FileExtentNameLst);
}
objPaperSubResTypeEN.FileExtentNameLst = strFileExtentNameLst; //文件扩展名列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResTypeEN.dicFldComparisonOp.ContainsKey(conPaperSubResType.FileExtentNameLst) == false)
{
objPaperSubResTypeEN.dicFldComparisonOp.Add(conPaperSubResType.FileExtentNameLst, strComparisonOp);
}
else
{
objPaperSubResTypeEN.dicFldComparisonOp[conPaperSubResType.FileExtentNameLst] = strComparisonOp;
}
}
return objPaperSubResTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResTypeEN SetFileExtentNameLst2(this clsPaperSubResTypeEN objPaperSubResTypeEN, string strFileExtentNameLst2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileExtentNameLst2, 200, conPaperSubResType.FileExtentNameLst2);
}
objPaperSubResTypeEN.FileExtentNameLst2 = strFileExtentNameLst2; //文件扩展名列表2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResTypeEN.dicFldComparisonOp.ContainsKey(conPaperSubResType.FileExtentNameLst2) == false)
{
objPaperSubResTypeEN.dicFldComparisonOp.Add(conPaperSubResType.FileExtentNameLst2, strComparisonOp);
}
else
{
objPaperSubResTypeEN.dicFldComparisonOp[conPaperSubResType.FileExtentNameLst2] = strComparisonOp;
}
}
return objPaperSubResTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResTypeEN SetIsUse(this clsPaperSubResTypeEN objPaperSubResTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objPaperSubResTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResTypeEN.dicFldComparisonOp.ContainsKey(conPaperSubResType.IsUse) == false)
{
objPaperSubResTypeEN.dicFldComparisonOp.Add(conPaperSubResType.IsUse, strComparisonOp);
}
else
{
objPaperSubResTypeEN.dicFldComparisonOp[conPaperSubResType.IsUse] = strComparisonOp;
}
}
return objPaperSubResTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResTypeEN SetOrderNum(this clsPaperSubResTypeEN objPaperSubResTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objPaperSubResTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResTypeEN.dicFldComparisonOp.ContainsKey(conPaperSubResType.OrderNum) == false)
{
objPaperSubResTypeEN.dicFldComparisonOp.Add(conPaperSubResType.OrderNum, strComparisonOp);
}
else
{
objPaperSubResTypeEN.dicFldComparisonOp[conPaperSubResType.OrderNum] = strComparisonOp;
}
}
return objPaperSubResTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResTypeEN SetUpdDate(this clsPaperSubResTypeEN objPaperSubResTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaperSubResType.UpdDate);
}
objPaperSubResTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResTypeEN.dicFldComparisonOp.ContainsKey(conPaperSubResType.UpdDate) == false)
{
objPaperSubResTypeEN.dicFldComparisonOp.Add(conPaperSubResType.UpdDate, strComparisonOp);
}
else
{
objPaperSubResTypeEN.dicFldComparisonOp[conPaperSubResType.UpdDate] = strComparisonOp;
}
}
return objPaperSubResTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResTypeEN SetUpdUser(this clsPaperSubResTypeEN objPaperSubResTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPaperSubResType.UpdUser);
}
objPaperSubResTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResTypeEN.dicFldComparisonOp.ContainsKey(conPaperSubResType.UpdUser) == false)
{
objPaperSubResTypeEN.dicFldComparisonOp.Add(conPaperSubResType.UpdUser, strComparisonOp);
}
else
{
objPaperSubResTypeEN.dicFldComparisonOp[conPaperSubResType.UpdUser] = strComparisonOp;
}
}
return objPaperSubResTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResTypeEN SetMemo(this clsPaperSubResTypeEN objPaperSubResTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPaperSubResType.Memo);
}
objPaperSubResTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResTypeEN.dicFldComparisonOp.ContainsKey(conPaperSubResType.Memo) == false)
{
objPaperSubResTypeEN.dicFldComparisonOp.Add(conPaperSubResType.Memo, strComparisonOp);
}
else
{
objPaperSubResTypeEN.dicFldComparisonOp[conPaperSubResType.Memo] = strComparisonOp;
}
}
return objPaperSubResTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPaperSubResTypeEN objPaperSubResTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPaperSubResTypeEN.CheckPropertyNew();
clsPaperSubResTypeEN objPaperSubResTypeCond = new clsPaperSubResTypeEN();
string strCondition = objPaperSubResTypeCond
.SetPaperSubResTypeId(objPaperSubResTypeEN.PaperSubResTypeId, "=")
.GetCombineCondition();
objPaperSubResTypeEN._IsCheckProperty = true;
bool bolIsExist = clsPaperSubResTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPaperSubResTypeEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubResTypeEN objPaperSubResTypeEN)
{
 if (string.IsNullOrEmpty(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperSubResTypeBL.PaperSubResTypeDA.UpdateBySql2(objPaperSubResTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubResTypeEN objPaperSubResTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperSubResTypeBL.PaperSubResTypeDA.UpdateBySql2(objPaperSubResTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubResTypeEN objPaperSubResTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsPaperSubResTypeBL.PaperSubResTypeDA.UpdateBySqlWithCondition(objPaperSubResTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubResTypeEN objPaperSubResTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPaperSubResTypeBL.PaperSubResTypeDA.UpdateBySqlWithConditionTransaction(objPaperSubResTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "strPaperSubResTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPaperSubResTypeEN objPaperSubResTypeEN)
{
try
{
int intRecNum = clsPaperSubResTypeBL.PaperSubResTypeDA.DelRecord(objPaperSubResTypeEN.PaperSubResTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objPaperSubResTypeENS">源对象</param>
 /// <param name = "objPaperSubResTypeENT">目标对象</param>
 public static void CopyTo(this clsPaperSubResTypeEN objPaperSubResTypeENS, clsPaperSubResTypeEN objPaperSubResTypeENT)
{
try
{
objPaperSubResTypeENT.PaperSubResTypeId = objPaperSubResTypeENS.PaperSubResTypeId; //论文子资源类型Id
objPaperSubResTypeENT.PaperSubResTypeName = objPaperSubResTypeENS.PaperSubResTypeName; //论文子资源类型名
objPaperSubResTypeENT.PaperSubResTypeENName = objPaperSubResTypeENS.PaperSubResTypeENName; //论文子资源类型英文名
objPaperSubResTypeENT.FileExtentNameLst = objPaperSubResTypeENS.FileExtentNameLst; //文件扩展名列表
objPaperSubResTypeENT.FileExtentNameLst2 = objPaperSubResTypeENS.FileExtentNameLst2; //文件扩展名列表2
objPaperSubResTypeENT.IsUse = objPaperSubResTypeENS.IsUse; //是否使用
objPaperSubResTypeENT.OrderNum = objPaperSubResTypeENS.OrderNum; //序号
objPaperSubResTypeENT.UpdDate = objPaperSubResTypeENS.UpdDate; //修改日期
objPaperSubResTypeENT.UpdUser = objPaperSubResTypeENS.UpdUser; //修改人
objPaperSubResTypeENT.Memo = objPaperSubResTypeENS.Memo; //备注
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
 /// <param name = "objPaperSubResTypeENS">源对象</param>
 /// <returns>目标对象=>clsPaperSubResTypeEN:objPaperSubResTypeENT</returns>
 public static clsPaperSubResTypeEN CopyTo(this clsPaperSubResTypeEN objPaperSubResTypeENS)
{
try
{
 clsPaperSubResTypeEN objPaperSubResTypeENT = new clsPaperSubResTypeEN()
{
PaperSubResTypeId = objPaperSubResTypeENS.PaperSubResTypeId, //论文子资源类型Id
PaperSubResTypeName = objPaperSubResTypeENS.PaperSubResTypeName, //论文子资源类型名
PaperSubResTypeENName = objPaperSubResTypeENS.PaperSubResTypeENName, //论文子资源类型英文名
FileExtentNameLst = objPaperSubResTypeENS.FileExtentNameLst, //文件扩展名列表
FileExtentNameLst2 = objPaperSubResTypeENS.FileExtentNameLst2, //文件扩展名列表2
IsUse = objPaperSubResTypeENS.IsUse, //是否使用
OrderNum = objPaperSubResTypeENS.OrderNum, //序号
UpdDate = objPaperSubResTypeENS.UpdDate, //修改日期
UpdUser = objPaperSubResTypeENS.UpdUser, //修改人
Memo = objPaperSubResTypeENS.Memo, //备注
};
 return objPaperSubResTypeENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsPaperSubResTypeEN objPaperSubResTypeEN)
{
 clsPaperSubResTypeBL.PaperSubResTypeDA.CheckPropertyNew(objPaperSubResTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPaperSubResTypeEN objPaperSubResTypeEN)
{
 clsPaperSubResTypeBL.PaperSubResTypeDA.CheckProperty4Condition(objPaperSubResTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPaperSubResTypeEN objPaperSubResTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPaperSubResTypeCond.IsUpdated(conPaperSubResType.PaperSubResTypeId) == true)
{
string strComparisonOpPaperSubResTypeId = objPaperSubResTypeCond.dicFldComparisonOp[conPaperSubResType.PaperSubResTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubResType.PaperSubResTypeId, objPaperSubResTypeCond.PaperSubResTypeId, strComparisonOpPaperSubResTypeId);
}
if (objPaperSubResTypeCond.IsUpdated(conPaperSubResType.PaperSubResTypeName) == true)
{
string strComparisonOpPaperSubResTypeName = objPaperSubResTypeCond.dicFldComparisonOp[conPaperSubResType.PaperSubResTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubResType.PaperSubResTypeName, objPaperSubResTypeCond.PaperSubResTypeName, strComparisonOpPaperSubResTypeName);
}
if (objPaperSubResTypeCond.IsUpdated(conPaperSubResType.PaperSubResTypeENName) == true)
{
string strComparisonOpPaperSubResTypeENName = objPaperSubResTypeCond.dicFldComparisonOp[conPaperSubResType.PaperSubResTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubResType.PaperSubResTypeENName, objPaperSubResTypeCond.PaperSubResTypeENName, strComparisonOpPaperSubResTypeENName);
}
if (objPaperSubResTypeCond.IsUpdated(conPaperSubResType.FileExtentNameLst) == true)
{
string strComparisonOpFileExtentNameLst = objPaperSubResTypeCond.dicFldComparisonOp[conPaperSubResType.FileExtentNameLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubResType.FileExtentNameLst, objPaperSubResTypeCond.FileExtentNameLst, strComparisonOpFileExtentNameLst);
}
if (objPaperSubResTypeCond.IsUpdated(conPaperSubResType.FileExtentNameLst2) == true)
{
string strComparisonOpFileExtentNameLst2 = objPaperSubResTypeCond.dicFldComparisonOp[conPaperSubResType.FileExtentNameLst2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubResType.FileExtentNameLst2, objPaperSubResTypeCond.FileExtentNameLst2, strComparisonOpFileExtentNameLst2);
}
if (objPaperSubResTypeCond.IsUpdated(conPaperSubResType.IsUse) == true)
{
if (objPaperSubResTypeCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPaperSubResType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPaperSubResType.IsUse);
}
}
if (objPaperSubResTypeCond.IsUpdated(conPaperSubResType.OrderNum) == true)
{
string strComparisonOpOrderNum = objPaperSubResTypeCond.dicFldComparisonOp[conPaperSubResType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubResType.OrderNum, objPaperSubResTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objPaperSubResTypeCond.IsUpdated(conPaperSubResType.UpdDate) == true)
{
string strComparisonOpUpdDate = objPaperSubResTypeCond.dicFldComparisonOp[conPaperSubResType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubResType.UpdDate, objPaperSubResTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objPaperSubResTypeCond.IsUpdated(conPaperSubResType.UpdUser) == true)
{
string strComparisonOpUpdUser = objPaperSubResTypeCond.dicFldComparisonOp[conPaperSubResType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubResType.UpdUser, objPaperSubResTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objPaperSubResTypeCond.IsUpdated(conPaperSubResType.Memo) == true)
{
string strComparisonOpMemo = objPaperSubResTypeCond.dicFldComparisonOp[conPaperSubResType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubResType.Memo, objPaperSubResTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PaperSubResType
{
public virtual bool UpdRelaTabDate(string strPaperSubResTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumPaperSubResType
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
 /// Pdf文件
 /// </summary>
public const string Pdf_0005 = "0005";
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
 /// Excel文件
 /// </summary>
public const string Excel_0014 = "0014";
 /// <summary>
 /// 源代码
 /// </summary>
public const string SourceCode_0015 = "0015";
 /// <summary>
 /// 其它
 /// </summary>
public const string Other_0016 = "0016";
}
 /// <summary>
 /// 论文子资源类型(PaperSubResType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPaperSubResTypeBL
{
public static RelatedActions_PaperSubResType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPaperSubResTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPaperSubResTypeDA PaperSubResTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPaperSubResTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsPaperSubResTypeBL()
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
if (string.IsNullOrEmpty(clsPaperSubResTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperSubResTypeEN._ConnectString);
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
public static DataTable GetDataTable_PaperSubResType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PaperSubResTypeDA.GetDataTable_PaperSubResType(strWhereCond);
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
objDT = PaperSubResTypeDA.GetDataTable(strWhereCond);
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
objDT = PaperSubResTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PaperSubResTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PaperSubResTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PaperSubResTypeDA.GetDataTable_Top(objTopPara);
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
objDT = PaperSubResTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PaperSubResTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PaperSubResTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperSubResTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPaperSubResTypeEN> GetObjLstByPaperSubResTypeIdLst(List<string> arrPaperSubResTypeIdLst)
{
List<clsPaperSubResTypeEN> arrObjLst = new List<clsPaperSubResTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperSubResTypeIdLst, true);
 string strWhereCond = string.Format("PaperSubResTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResTypeEN objPaperSubResTypeEN = new clsPaperSubResTypeEN();
try
{
objPaperSubResTypeEN.PaperSubResTypeId = objRow[conPaperSubResType.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResTypeEN.PaperSubResTypeName = objRow[conPaperSubResType.PaperSubResTypeName].ToString().Trim(); //论文子资源类型名
objPaperSubResTypeEN.PaperSubResTypeENName = objRow[conPaperSubResType.PaperSubResTypeENName] == DBNull.Value ? null : objRow[conPaperSubResType.PaperSubResTypeENName].ToString().Trim(); //论文子资源类型英文名
objPaperSubResTypeEN.FileExtentNameLst = objRow[conPaperSubResType.FileExtentNameLst] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objPaperSubResTypeEN.FileExtentNameLst2 = objRow[conPaperSubResType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objPaperSubResTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubResType.IsUse].ToString().Trim()); //是否使用
objPaperSubResTypeEN.OrderNum = objRow[conPaperSubResType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubResType.OrderNum].ToString().Trim()); //序号
objPaperSubResTypeEN.UpdDate = objRow[conPaperSubResType.UpdDate] == DBNull.Value ? null : objRow[conPaperSubResType.UpdDate].ToString().Trim(); //修改日期
objPaperSubResTypeEN.UpdUser = objRow[conPaperSubResType.UpdUser] == DBNull.Value ? null : objRow[conPaperSubResType.UpdUser].ToString().Trim(); //修改人
objPaperSubResTypeEN.Memo = objRow[conPaperSubResType.Memo] == DBNull.Value ? null : objRow[conPaperSubResType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResTypeEN.PaperSubResTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperSubResTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPaperSubResTypeEN> GetObjLstByPaperSubResTypeIdLstCache(List<string> arrPaperSubResTypeIdLst)
{
string strKey = string.Format("{0}", clsPaperSubResTypeEN._CurrTabName);
List<clsPaperSubResTypeEN> arrPaperSubResTypeObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubResTypeEN> arrPaperSubResTypeObjLst_Sel =
arrPaperSubResTypeObjLstCache
.Where(x => arrPaperSubResTypeIdLst.Contains(x.PaperSubResTypeId));
return arrPaperSubResTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubResTypeEN> GetObjLst(string strWhereCond)
{
List<clsPaperSubResTypeEN> arrObjLst = new List<clsPaperSubResTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResTypeEN objPaperSubResTypeEN = new clsPaperSubResTypeEN();
try
{
objPaperSubResTypeEN.PaperSubResTypeId = objRow[conPaperSubResType.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResTypeEN.PaperSubResTypeName = objRow[conPaperSubResType.PaperSubResTypeName].ToString().Trim(); //论文子资源类型名
objPaperSubResTypeEN.PaperSubResTypeENName = objRow[conPaperSubResType.PaperSubResTypeENName] == DBNull.Value ? null : objRow[conPaperSubResType.PaperSubResTypeENName].ToString().Trim(); //论文子资源类型英文名
objPaperSubResTypeEN.FileExtentNameLst = objRow[conPaperSubResType.FileExtentNameLst] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objPaperSubResTypeEN.FileExtentNameLst2 = objRow[conPaperSubResType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objPaperSubResTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubResType.IsUse].ToString().Trim()); //是否使用
objPaperSubResTypeEN.OrderNum = objRow[conPaperSubResType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubResType.OrderNum].ToString().Trim()); //序号
objPaperSubResTypeEN.UpdDate = objRow[conPaperSubResType.UpdDate] == DBNull.Value ? null : objRow[conPaperSubResType.UpdDate].ToString().Trim(); //修改日期
objPaperSubResTypeEN.UpdUser = objRow[conPaperSubResType.UpdUser] == DBNull.Value ? null : objRow[conPaperSubResType.UpdUser].ToString().Trim(); //修改人
objPaperSubResTypeEN.Memo = objRow[conPaperSubResType.Memo] == DBNull.Value ? null : objRow[conPaperSubResType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResTypeEN.PaperSubResTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResTypeEN);
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
public static List<clsPaperSubResTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPaperSubResTypeEN> arrObjLst = new List<clsPaperSubResTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResTypeEN objPaperSubResTypeEN = new clsPaperSubResTypeEN();
try
{
objPaperSubResTypeEN.PaperSubResTypeId = objRow[conPaperSubResType.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResTypeEN.PaperSubResTypeName = objRow[conPaperSubResType.PaperSubResTypeName].ToString().Trim(); //论文子资源类型名
objPaperSubResTypeEN.PaperSubResTypeENName = objRow[conPaperSubResType.PaperSubResTypeENName] == DBNull.Value ? null : objRow[conPaperSubResType.PaperSubResTypeENName].ToString().Trim(); //论文子资源类型英文名
objPaperSubResTypeEN.FileExtentNameLst = objRow[conPaperSubResType.FileExtentNameLst] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objPaperSubResTypeEN.FileExtentNameLst2 = objRow[conPaperSubResType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objPaperSubResTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubResType.IsUse].ToString().Trim()); //是否使用
objPaperSubResTypeEN.OrderNum = objRow[conPaperSubResType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubResType.OrderNum].ToString().Trim()); //序号
objPaperSubResTypeEN.UpdDate = objRow[conPaperSubResType.UpdDate] == DBNull.Value ? null : objRow[conPaperSubResType.UpdDate].ToString().Trim(); //修改日期
objPaperSubResTypeEN.UpdUser = objRow[conPaperSubResType.UpdUser] == DBNull.Value ? null : objRow[conPaperSubResType.UpdUser].ToString().Trim(); //修改人
objPaperSubResTypeEN.Memo = objRow[conPaperSubResType.Memo] == DBNull.Value ? null : objRow[conPaperSubResType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResTypeEN.PaperSubResTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPaperSubResTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPaperSubResTypeEN> GetSubObjLstCache(clsPaperSubResTypeEN objPaperSubResTypeCond)
{
List<clsPaperSubResTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubResTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperSubResType.AttributeName)
{
if (objPaperSubResTypeCond.IsUpdated(strFldName) == false) continue;
if (objPaperSubResTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubResTypeCond[strFldName].ToString());
}
else
{
if (objPaperSubResTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperSubResTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubResTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperSubResTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperSubResTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperSubResTypeCond[strFldName]));
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
public static List<clsPaperSubResTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPaperSubResTypeEN> arrObjLst = new List<clsPaperSubResTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResTypeEN objPaperSubResTypeEN = new clsPaperSubResTypeEN();
try
{
objPaperSubResTypeEN.PaperSubResTypeId = objRow[conPaperSubResType.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResTypeEN.PaperSubResTypeName = objRow[conPaperSubResType.PaperSubResTypeName].ToString().Trim(); //论文子资源类型名
objPaperSubResTypeEN.PaperSubResTypeENName = objRow[conPaperSubResType.PaperSubResTypeENName] == DBNull.Value ? null : objRow[conPaperSubResType.PaperSubResTypeENName].ToString().Trim(); //论文子资源类型英文名
objPaperSubResTypeEN.FileExtentNameLst = objRow[conPaperSubResType.FileExtentNameLst] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objPaperSubResTypeEN.FileExtentNameLst2 = objRow[conPaperSubResType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objPaperSubResTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubResType.IsUse].ToString().Trim()); //是否使用
objPaperSubResTypeEN.OrderNum = objRow[conPaperSubResType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubResType.OrderNum].ToString().Trim()); //序号
objPaperSubResTypeEN.UpdDate = objRow[conPaperSubResType.UpdDate] == DBNull.Value ? null : objRow[conPaperSubResType.UpdDate].ToString().Trim(); //修改日期
objPaperSubResTypeEN.UpdUser = objRow[conPaperSubResType.UpdUser] == DBNull.Value ? null : objRow[conPaperSubResType.UpdUser].ToString().Trim(); //修改人
objPaperSubResTypeEN.Memo = objRow[conPaperSubResType.Memo] == DBNull.Value ? null : objRow[conPaperSubResType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResTypeEN.PaperSubResTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResTypeEN);
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
public static List<clsPaperSubResTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPaperSubResTypeEN> arrObjLst = new List<clsPaperSubResTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResTypeEN objPaperSubResTypeEN = new clsPaperSubResTypeEN();
try
{
objPaperSubResTypeEN.PaperSubResTypeId = objRow[conPaperSubResType.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResTypeEN.PaperSubResTypeName = objRow[conPaperSubResType.PaperSubResTypeName].ToString().Trim(); //论文子资源类型名
objPaperSubResTypeEN.PaperSubResTypeENName = objRow[conPaperSubResType.PaperSubResTypeENName] == DBNull.Value ? null : objRow[conPaperSubResType.PaperSubResTypeENName].ToString().Trim(); //论文子资源类型英文名
objPaperSubResTypeEN.FileExtentNameLst = objRow[conPaperSubResType.FileExtentNameLst] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objPaperSubResTypeEN.FileExtentNameLst2 = objRow[conPaperSubResType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objPaperSubResTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubResType.IsUse].ToString().Trim()); //是否使用
objPaperSubResTypeEN.OrderNum = objRow[conPaperSubResType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubResType.OrderNum].ToString().Trim()); //序号
objPaperSubResTypeEN.UpdDate = objRow[conPaperSubResType.UpdDate] == DBNull.Value ? null : objRow[conPaperSubResType.UpdDate].ToString().Trim(); //修改日期
objPaperSubResTypeEN.UpdUser = objRow[conPaperSubResType.UpdUser] == DBNull.Value ? null : objRow[conPaperSubResType.UpdUser].ToString().Trim(); //修改人
objPaperSubResTypeEN.Memo = objRow[conPaperSubResType.Memo] == DBNull.Value ? null : objRow[conPaperSubResType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResTypeEN.PaperSubResTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResTypeEN);
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
List<clsPaperSubResTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPaperSubResTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubResTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPaperSubResTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPaperSubResTypeEN> arrObjLst = new List<clsPaperSubResTypeEN>(); 
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
	clsPaperSubResTypeEN objPaperSubResTypeEN = new clsPaperSubResTypeEN();
try
{
objPaperSubResTypeEN.PaperSubResTypeId = objRow[conPaperSubResType.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResTypeEN.PaperSubResTypeName = objRow[conPaperSubResType.PaperSubResTypeName].ToString().Trim(); //论文子资源类型名
objPaperSubResTypeEN.PaperSubResTypeENName = objRow[conPaperSubResType.PaperSubResTypeENName] == DBNull.Value ? null : objRow[conPaperSubResType.PaperSubResTypeENName].ToString().Trim(); //论文子资源类型英文名
objPaperSubResTypeEN.FileExtentNameLst = objRow[conPaperSubResType.FileExtentNameLst] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objPaperSubResTypeEN.FileExtentNameLst2 = objRow[conPaperSubResType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objPaperSubResTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubResType.IsUse].ToString().Trim()); //是否使用
objPaperSubResTypeEN.OrderNum = objRow[conPaperSubResType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubResType.OrderNum].ToString().Trim()); //序号
objPaperSubResTypeEN.UpdDate = objRow[conPaperSubResType.UpdDate] == DBNull.Value ? null : objRow[conPaperSubResType.UpdDate].ToString().Trim(); //修改日期
objPaperSubResTypeEN.UpdUser = objRow[conPaperSubResType.UpdUser] == DBNull.Value ? null : objRow[conPaperSubResType.UpdUser].ToString().Trim(); //修改人
objPaperSubResTypeEN.Memo = objRow[conPaperSubResType.Memo] == DBNull.Value ? null : objRow[conPaperSubResType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResTypeEN.PaperSubResTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResTypeEN);
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
public static List<clsPaperSubResTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPaperSubResTypeEN> arrObjLst = new List<clsPaperSubResTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResTypeEN objPaperSubResTypeEN = new clsPaperSubResTypeEN();
try
{
objPaperSubResTypeEN.PaperSubResTypeId = objRow[conPaperSubResType.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResTypeEN.PaperSubResTypeName = objRow[conPaperSubResType.PaperSubResTypeName].ToString().Trim(); //论文子资源类型名
objPaperSubResTypeEN.PaperSubResTypeENName = objRow[conPaperSubResType.PaperSubResTypeENName] == DBNull.Value ? null : objRow[conPaperSubResType.PaperSubResTypeENName].ToString().Trim(); //论文子资源类型英文名
objPaperSubResTypeEN.FileExtentNameLst = objRow[conPaperSubResType.FileExtentNameLst] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objPaperSubResTypeEN.FileExtentNameLst2 = objRow[conPaperSubResType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objPaperSubResTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubResType.IsUse].ToString().Trim()); //是否使用
objPaperSubResTypeEN.OrderNum = objRow[conPaperSubResType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubResType.OrderNum].ToString().Trim()); //序号
objPaperSubResTypeEN.UpdDate = objRow[conPaperSubResType.UpdDate] == DBNull.Value ? null : objRow[conPaperSubResType.UpdDate].ToString().Trim(); //修改日期
objPaperSubResTypeEN.UpdUser = objRow[conPaperSubResType.UpdUser] == DBNull.Value ? null : objRow[conPaperSubResType.UpdUser].ToString().Trim(); //修改人
objPaperSubResTypeEN.Memo = objRow[conPaperSubResType.Memo] == DBNull.Value ? null : objRow[conPaperSubResType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResTypeEN.PaperSubResTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPaperSubResTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPaperSubResTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPaperSubResTypeEN> arrObjLst = new List<clsPaperSubResTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResTypeEN objPaperSubResTypeEN = new clsPaperSubResTypeEN();
try
{
objPaperSubResTypeEN.PaperSubResTypeId = objRow[conPaperSubResType.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResTypeEN.PaperSubResTypeName = objRow[conPaperSubResType.PaperSubResTypeName].ToString().Trim(); //论文子资源类型名
objPaperSubResTypeEN.PaperSubResTypeENName = objRow[conPaperSubResType.PaperSubResTypeENName] == DBNull.Value ? null : objRow[conPaperSubResType.PaperSubResTypeENName].ToString().Trim(); //论文子资源类型英文名
objPaperSubResTypeEN.FileExtentNameLst = objRow[conPaperSubResType.FileExtentNameLst] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objPaperSubResTypeEN.FileExtentNameLst2 = objRow[conPaperSubResType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objPaperSubResTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubResType.IsUse].ToString().Trim()); //是否使用
objPaperSubResTypeEN.OrderNum = objRow[conPaperSubResType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubResType.OrderNum].ToString().Trim()); //序号
objPaperSubResTypeEN.UpdDate = objRow[conPaperSubResType.UpdDate] == DBNull.Value ? null : objRow[conPaperSubResType.UpdDate].ToString().Trim(); //修改日期
objPaperSubResTypeEN.UpdUser = objRow[conPaperSubResType.UpdUser] == DBNull.Value ? null : objRow[conPaperSubResType.UpdUser].ToString().Trim(); //修改人
objPaperSubResTypeEN.Memo = objRow[conPaperSubResType.Memo] == DBNull.Value ? null : objRow[conPaperSubResType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResTypeEN.PaperSubResTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResTypeEN);
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
public static List<clsPaperSubResTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPaperSubResTypeEN> arrObjLst = new List<clsPaperSubResTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResTypeEN objPaperSubResTypeEN = new clsPaperSubResTypeEN();
try
{
objPaperSubResTypeEN.PaperSubResTypeId = objRow[conPaperSubResType.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResTypeEN.PaperSubResTypeName = objRow[conPaperSubResType.PaperSubResTypeName].ToString().Trim(); //论文子资源类型名
objPaperSubResTypeEN.PaperSubResTypeENName = objRow[conPaperSubResType.PaperSubResTypeENName] == DBNull.Value ? null : objRow[conPaperSubResType.PaperSubResTypeENName].ToString().Trim(); //论文子资源类型英文名
objPaperSubResTypeEN.FileExtentNameLst = objRow[conPaperSubResType.FileExtentNameLst] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objPaperSubResTypeEN.FileExtentNameLst2 = objRow[conPaperSubResType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objPaperSubResTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubResType.IsUse].ToString().Trim()); //是否使用
objPaperSubResTypeEN.OrderNum = objRow[conPaperSubResType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubResType.OrderNum].ToString().Trim()); //序号
objPaperSubResTypeEN.UpdDate = objRow[conPaperSubResType.UpdDate] == DBNull.Value ? null : objRow[conPaperSubResType.UpdDate].ToString().Trim(); //修改日期
objPaperSubResTypeEN.UpdUser = objRow[conPaperSubResType.UpdUser] == DBNull.Value ? null : objRow[conPaperSubResType.UpdUser].ToString().Trim(); //修改人
objPaperSubResTypeEN.Memo = objRow[conPaperSubResType.Memo] == DBNull.Value ? null : objRow[conPaperSubResType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResTypeEN.PaperSubResTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubResTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPaperSubResTypeEN> arrObjLst = new List<clsPaperSubResTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResTypeEN objPaperSubResTypeEN = new clsPaperSubResTypeEN();
try
{
objPaperSubResTypeEN.PaperSubResTypeId = objRow[conPaperSubResType.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResTypeEN.PaperSubResTypeName = objRow[conPaperSubResType.PaperSubResTypeName].ToString().Trim(); //论文子资源类型名
objPaperSubResTypeEN.PaperSubResTypeENName = objRow[conPaperSubResType.PaperSubResTypeENName] == DBNull.Value ? null : objRow[conPaperSubResType.PaperSubResTypeENName].ToString().Trim(); //论文子资源类型英文名
objPaperSubResTypeEN.FileExtentNameLst = objRow[conPaperSubResType.FileExtentNameLst] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objPaperSubResTypeEN.FileExtentNameLst2 = objRow[conPaperSubResType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conPaperSubResType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objPaperSubResTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubResType.IsUse].ToString().Trim()); //是否使用
objPaperSubResTypeEN.OrderNum = objRow[conPaperSubResType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubResType.OrderNum].ToString().Trim()); //序号
objPaperSubResTypeEN.UpdDate = objRow[conPaperSubResType.UpdDate] == DBNull.Value ? null : objRow[conPaperSubResType.UpdDate].ToString().Trim(); //修改日期
objPaperSubResTypeEN.UpdUser = objRow[conPaperSubResType.UpdUser] == DBNull.Value ? null : objRow[conPaperSubResType.UpdUser].ToString().Trim(); //修改人
objPaperSubResTypeEN.Memo = objRow[conPaperSubResType.Memo] == DBNull.Value ? null : objRow[conPaperSubResType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResTypeEN.PaperSubResTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPaperSubResType(ref clsPaperSubResTypeEN objPaperSubResTypeEN)
{
bool bolResult = PaperSubResTypeDA.GetPaperSubResType(ref objPaperSubResTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperSubResTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubResTypeEN GetObjByPaperSubResTypeId(string strPaperSubResTypeId)
{
if (strPaperSubResTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPaperSubResTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPaperSubResTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPaperSubResTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPaperSubResTypeEN objPaperSubResTypeEN = PaperSubResTypeDA.GetObjByPaperSubResTypeId(strPaperSubResTypeId);
return objPaperSubResTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPaperSubResTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPaperSubResTypeEN objPaperSubResTypeEN = PaperSubResTypeDA.GetFirstObj(strWhereCond);
 return objPaperSubResTypeEN;
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
public static clsPaperSubResTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPaperSubResTypeEN objPaperSubResTypeEN = PaperSubResTypeDA.GetObjByDataRow(objRow);
 return objPaperSubResTypeEN;
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
public static clsPaperSubResTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPaperSubResTypeEN objPaperSubResTypeEN = PaperSubResTypeDA.GetObjByDataRow(objRow);
 return objPaperSubResTypeEN;
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
 /// <param name = "strPaperSubResTypeId">所给的关键字</param>
 /// <param name = "lstPaperSubResTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubResTypeEN GetObjByPaperSubResTypeIdFromList(string strPaperSubResTypeId, List<clsPaperSubResTypeEN> lstPaperSubResTypeObjLst)
{
foreach (clsPaperSubResTypeEN objPaperSubResTypeEN in lstPaperSubResTypeObjLst)
{
if (objPaperSubResTypeEN.PaperSubResTypeId == strPaperSubResTypeId)
{
return objPaperSubResTypeEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strPaperSubResTypeId;
 try
 {
 strPaperSubResTypeId = new clsPaperSubResTypeDA().GetFirstID(strWhereCond);
 return strPaperSubResTypeId;
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
 arrList = PaperSubResTypeDA.GetID(strWhereCond);
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
bool bolIsExist = PaperSubResTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPaperSubResTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPaperSubResTypeId)
{
if (string.IsNullOrEmpty(strPaperSubResTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPaperSubResTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PaperSubResTypeDA.IsExist(strPaperSubResTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPaperSubResTypeId">论文子资源类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPaperSubResTypeId, string strOpUser)
{
clsPaperSubResTypeEN objPaperSubResTypeEN = clsPaperSubResTypeBL.GetObjByPaperSubResTypeId(strPaperSubResTypeId);
objPaperSubResTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPaperSubResTypeEN.UpdUser = strOpUser;
return clsPaperSubResTypeBL.UpdateBySql2(objPaperSubResTypeEN);
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
 bolIsExist = clsPaperSubResTypeDA.IsExistTable();
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
 bolIsExist = PaperSubResTypeDA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPaperSubResTypeEN objPaperSubResTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPaperSubResTypeBL.IsExist(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPaperSubResTypeEN.PaperSubResTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = PaperSubResTypeDA.AddNewRecordBySQL2(objPaperSubResTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPaperSubResTypeEN objPaperSubResTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPaperSubResTypeBL.IsExist(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPaperSubResTypeEN.PaperSubResTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = PaperSubResTypeDA.AddNewRecordBySQL2WithReturnKey(objPaperSubResTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPaperSubResTypeEN objPaperSubResTypeEN)
{
try
{
bool bolResult = PaperSubResTypeDA.Update(objPaperSubResTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objPaperSubResTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPaperSubResTypeEN objPaperSubResTypeEN)
{
 if (string.IsNullOrEmpty(objPaperSubResTypeEN.PaperSubResTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PaperSubResTypeDA.UpdateBySql2(objPaperSubResTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResTypeBL.ReFreshCache();

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "strPaperSubResTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPaperSubResTypeId)
{
try
{
 clsPaperSubResTypeEN objPaperSubResTypeEN = clsPaperSubResTypeBL.GetObjByPaperSubResTypeId(strPaperSubResTypeId);

if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(objPaperSubResTypeEN.PaperSubResTypeId, objPaperSubResTypeEN.UpdUser);
}
if (objPaperSubResTypeEN != null)
{
int intRecNum = PaperSubResTypeDA.DelRecord(strPaperSubResTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strPaperSubResTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPaperSubResTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperSubResTypeDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[PaperSubResType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPaperSubResType.PaperSubResTypeId,
//strPaperSubResTypeId);
//        clsPaperSubResTypeBL.DelPaperSubResTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperSubResTypeBL.DelRecord(strPaperSubResTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperSubResTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPaperSubResTypeId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "strPaperSubResTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPaperSubResTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPaperSubResTypeBL.relatedActions != null)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(strPaperSubResTypeId, "UpdRelaTabDate");
}
bool bolResult = PaperSubResTypeDA.DelRecord(strPaperSubResTypeId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrPaperSubResTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPaperSubResTypes(List<string> arrPaperSubResTypeIdLst)
{
if (arrPaperSubResTypeIdLst.Count == 0) return 0;
try
{
if (clsPaperSubResTypeBL.relatedActions != null)
{
foreach (var strPaperSubResTypeId in arrPaperSubResTypeIdLst)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(strPaperSubResTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = PaperSubResTypeDA.DelPaperSubResType(arrPaperSubResTypeIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int DelPaperSubResTypesByCond(string strWhereCond)
{
try
{
if (clsPaperSubResTypeBL.relatedActions != null)
{
List<string> arrPaperSubResTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperSubResTypeId in arrPaperSubResTypeId)
{
clsPaperSubResTypeBL.relatedActions.UpdRelaTabDate(strPaperSubResTypeId, "UpdRelaTabDate");
}
}
int intRecNum = PaperSubResTypeDA.DelPaperSubResType(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PaperSubResType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPaperSubResTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPaperSubResTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperSubResTypeDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[PaperSubResType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperSubResTypeBL.DelRecord(strPaperSubResTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperSubResTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPaperSubResTypeId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objPaperSubResTypeENS">源对象</param>
 /// <param name = "objPaperSubResTypeENT">目标对象</param>
 public static void CopyTo(clsPaperSubResTypeEN objPaperSubResTypeENS, clsPaperSubResTypeEN objPaperSubResTypeENT)
{
try
{
objPaperSubResTypeENT.PaperSubResTypeId = objPaperSubResTypeENS.PaperSubResTypeId; //论文子资源类型Id
objPaperSubResTypeENT.PaperSubResTypeName = objPaperSubResTypeENS.PaperSubResTypeName; //论文子资源类型名
objPaperSubResTypeENT.PaperSubResTypeENName = objPaperSubResTypeENS.PaperSubResTypeENName; //论文子资源类型英文名
objPaperSubResTypeENT.FileExtentNameLst = objPaperSubResTypeENS.FileExtentNameLst; //文件扩展名列表
objPaperSubResTypeENT.FileExtentNameLst2 = objPaperSubResTypeENS.FileExtentNameLst2; //文件扩展名列表2
objPaperSubResTypeENT.IsUse = objPaperSubResTypeENS.IsUse; //是否使用
objPaperSubResTypeENT.OrderNum = objPaperSubResTypeENS.OrderNum; //序号
objPaperSubResTypeENT.UpdDate = objPaperSubResTypeENS.UpdDate; //修改日期
objPaperSubResTypeENT.UpdUser = objPaperSubResTypeENS.UpdUser; //修改人
objPaperSubResTypeENT.Memo = objPaperSubResTypeENS.Memo; //备注
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
 /// <param name = "objPaperSubResTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsPaperSubResTypeEN objPaperSubResTypeEN)
{
try
{
objPaperSubResTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPaperSubResTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPaperSubResType.PaperSubResTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResTypeEN.PaperSubResTypeId = objPaperSubResTypeEN.PaperSubResTypeId; //论文子资源类型Id
}
if (arrFldSet.Contains(conPaperSubResType.PaperSubResTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResTypeEN.PaperSubResTypeName = objPaperSubResTypeEN.PaperSubResTypeName; //论文子资源类型名
}
if (arrFldSet.Contains(conPaperSubResType.PaperSubResTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResTypeEN.PaperSubResTypeENName = objPaperSubResTypeEN.PaperSubResTypeENName == "[null]" ? null :  objPaperSubResTypeEN.PaperSubResTypeENName; //论文子资源类型英文名
}
if (arrFldSet.Contains(conPaperSubResType.FileExtentNameLst, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResTypeEN.FileExtentNameLst = objPaperSubResTypeEN.FileExtentNameLst == "[null]" ? null :  objPaperSubResTypeEN.FileExtentNameLst; //文件扩展名列表
}
if (arrFldSet.Contains(conPaperSubResType.FileExtentNameLst2, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResTypeEN.FileExtentNameLst2 = objPaperSubResTypeEN.FileExtentNameLst2 == "[null]" ? null :  objPaperSubResTypeEN.FileExtentNameLst2; //文件扩展名列表2
}
if (arrFldSet.Contains(conPaperSubResType.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResTypeEN.IsUse = objPaperSubResTypeEN.IsUse; //是否使用
}
if (arrFldSet.Contains(conPaperSubResType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResTypeEN.OrderNum = objPaperSubResTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conPaperSubResType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResTypeEN.UpdDate = objPaperSubResTypeEN.UpdDate == "[null]" ? null :  objPaperSubResTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPaperSubResType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResTypeEN.UpdUser = objPaperSubResTypeEN.UpdUser == "[null]" ? null :  objPaperSubResTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conPaperSubResType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResTypeEN.Memo = objPaperSubResTypeEN.Memo == "[null]" ? null :  objPaperSubResTypeEN.Memo; //备注
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
 /// <param name = "objPaperSubResTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsPaperSubResTypeEN objPaperSubResTypeEN)
{
try
{
if (objPaperSubResTypeEN.PaperSubResTypeENName == "[null]") objPaperSubResTypeEN.PaperSubResTypeENName = null; //论文子资源类型英文名
if (objPaperSubResTypeEN.FileExtentNameLst == "[null]") objPaperSubResTypeEN.FileExtentNameLst = null; //文件扩展名列表
if (objPaperSubResTypeEN.FileExtentNameLst2 == "[null]") objPaperSubResTypeEN.FileExtentNameLst2 = null; //文件扩展名列表2
if (objPaperSubResTypeEN.UpdDate == "[null]") objPaperSubResTypeEN.UpdDate = null; //修改日期
if (objPaperSubResTypeEN.UpdUser == "[null]") objPaperSubResTypeEN.UpdUser = null; //修改人
if (objPaperSubResTypeEN.Memo == "[null]") objPaperSubResTypeEN.Memo = null; //备注
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPaperSubResTypeEN objPaperSubResTypeEN)
{
 PaperSubResTypeDA.CheckPropertyNew(objPaperSubResTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPaperSubResTypeEN objPaperSubResTypeEN)
{
 PaperSubResTypeDA.CheckProperty4Condition(objPaperSubResTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PaperSubResTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文子资源类型]...","0");
List<clsPaperSubResTypeEN> arrPaperSubResTypeObjLst = GetAllPaperSubResTypeObjLstCache(); 
objDDL.DataValueField = conPaperSubResType.PaperSubResTypeId;
objDDL.DataTextField = conPaperSubResType.PaperSubResTypeName;
objDDL.DataSource = arrPaperSubResTypeObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsPaperSubResTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubResTypeBL没有刷新缓存机制(clsPaperSubResTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperSubResTypeId");
//if (arrPaperSubResTypeObjLstCache == null)
//{
//arrPaperSubResTypeObjLstCache = PaperSubResTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPaperSubResTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubResTypeEN GetObjByPaperSubResTypeIdCache(string strPaperSubResTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPaperSubResTypeEN._CurrTabName);
List<clsPaperSubResTypeEN> arrPaperSubResTypeObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubResTypeEN> arrPaperSubResTypeObjLst_Sel =
arrPaperSubResTypeObjLstCache
.Where(x=> x.PaperSubResTypeId == strPaperSubResTypeId 
);
if (arrPaperSubResTypeObjLst_Sel.Count() == 0)
{
   clsPaperSubResTypeEN obj = clsPaperSubResTypeBL.GetObjByPaperSubResTypeId(strPaperSubResTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPaperSubResTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPaperSubResTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPaperSubResTypeNameByPaperSubResTypeIdCache(string strPaperSubResTypeId)
{
if (string.IsNullOrEmpty(strPaperSubResTypeId) == true) return "";
//获取缓存中的对象列表
clsPaperSubResTypeEN objPaperSubResType = GetObjByPaperSubResTypeIdCache(strPaperSubResTypeId);
if (objPaperSubResType == null) return "";
return objPaperSubResType.PaperSubResTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPaperSubResTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPaperSubResTypeIdCache(string strPaperSubResTypeId)
{
if (string.IsNullOrEmpty(strPaperSubResTypeId) == true) return "";
//获取缓存中的对象列表
clsPaperSubResTypeEN objPaperSubResType = GetObjByPaperSubResTypeIdCache(strPaperSubResTypeId);
if (objPaperSubResType == null) return "";
return objPaperSubResType.PaperSubResTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubResTypeEN> GetAllPaperSubResTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsPaperSubResTypeEN> arrPaperSubResTypeObjLstCache = GetObjLstCache(); 
return arrPaperSubResTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubResTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPaperSubResTypeEN._CurrTabName);
List<clsPaperSubResTypeEN> arrPaperSubResTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPaperSubResTypeObjLstCache;
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
string strKey = string.Format("{0}", clsPaperSubResTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperSubResTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsPaperSubResTypeEN._RefreshTimeLst.Count == 0) return "";
return clsPaperSubResTypeEN._RefreshTimeLst[clsPaperSubResTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPaperSubResTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPaperSubResTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperSubResTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPaperSubResTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-13
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPaperSubResTypeId)
{
if (strInFldName != conPaperSubResType.PaperSubResTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPaperSubResType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPaperSubResType.AttributeName));
throw new Exception(strMsg);
}
var objPaperSubResType = clsPaperSubResTypeBL.GetObjByPaperSubResTypeIdCache(strPaperSubResTypeId);
if (objPaperSubResType == null) return "";
return objPaperSubResType[strOutFldName].ToString();
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
int intRecCount = clsPaperSubResTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsPaperSubResTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPaperSubResTypeDA.GetRecCount();
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
int intRecCount = clsPaperSubResTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPaperSubResTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPaperSubResTypeEN objPaperSubResTypeCond)
{
List<clsPaperSubResTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubResTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperSubResType.AttributeName)
{
if (objPaperSubResTypeCond.IsUpdated(strFldName) == false) continue;
if (objPaperSubResTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubResTypeCond[strFldName].ToString());
}
else
{
if (objPaperSubResTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperSubResTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubResTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperSubResTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperSubResTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperSubResTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperSubResTypeCond[strFldName]));
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
 List<string> arrList = clsPaperSubResTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PaperSubResTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PaperSubResTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = PaperSubResTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsPaperSubResTypeDA.SetFldValue(clsPaperSubResTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = PaperSubResTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsPaperSubResTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsPaperSubResTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsPaperSubResTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[PaperSubResType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**论文子资源类型Id*/ 
 strCreateTabCode.Append(" PaperSubResTypeId char(4) primary key, "); 
 // /**论文子资源类型名*/ 
 strCreateTabCode.Append(" PaperSubResTypeName varchar(50) not Null, "); 
 // /**论文子资源类型英文名*/ 
 strCreateTabCode.Append(" PaperSubResTypeENName varchar(50) Null, "); 
 // /**文件扩展名列表*/ 
 strCreateTabCode.Append(" FileExtentNameLst varchar(200) Null, "); 
 // /**文件扩展名列表2*/ 
 strCreateTabCode.Append(" FileExtentNameLst2 varchar(200) Null, "); 
 // /**是否使用*/ 
 strCreateTabCode.Append(" IsUse bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文子资源类型(PaperSubResType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PaperSubResType : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
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
clsPaperSubResTypeBL.ReFreshThisCache();
}
}

}