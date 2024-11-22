
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPictureConfigerBL
 表名:PictureConfiger(01120039)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
public static class  clsPictureConfigerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPictureConfigerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPictureConfigerEN GetObj(this K_PictureConfigerId_PictureConfiger myKey)
{
clsPictureConfigerEN objPictureConfigerEN = clsPictureConfigerBL.PictureConfigerDA.GetObjByPictureConfigerId(myKey.Value);
return objPictureConfigerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPictureConfigerEN objPictureConfigerEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPictureConfigerBL.IsExist(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPictureConfigerEN.PictureConfigerId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsPictureConfigerBL.PictureConfigerDA.AddNewRecordBySQL2(objPictureConfigerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPictureConfigerEN objPictureConfigerEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsPictureConfigerBL.IsExist(objPictureConfigerEN.PictureConfigerId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objPictureConfigerEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objPictureConfigerEN.AddNewRecord();
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
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPictureConfigerEN objPictureConfigerEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPictureConfigerBL.IsExist(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPictureConfigerEN.PictureConfigerId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsPictureConfigerBL.PictureConfigerDA.AddNewRecordBySQL2WithReturnKey(objPictureConfigerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureConfigerEN SetPictureConfigerId(this clsPictureConfigerEN objPictureConfigerEN, string strPictureConfigerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPictureConfigerId, 4, conPictureConfiger.PictureConfigerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPictureConfigerId, 4, conPictureConfiger.PictureConfigerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureConfigerEN SetPictureConfigName(this clsPictureConfigerEN objPictureConfigerEN, string strPictureConfigName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPictureConfigName, conPictureConfiger.PictureConfigName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPictureConfigName, 50, conPictureConfiger.PictureConfigName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureConfigerEN SetPicturePath(this clsPictureConfigerEN objPictureConfigerEN, string strPicturePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPicturePath, conPictureConfiger.PicturePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPicturePath, 50, conPictureConfiger.PicturePath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureConfigerEN SetMaxSize(this clsPictureConfigerEN objPictureConfigerEN, string strMaxSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMaxSize, conPictureConfiger.MaxSize);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMaxSize, 50, conPictureConfiger.MaxSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureConfigerEN SetMemo(this clsPictureConfigerEN objPictureConfigerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPictureConfiger.Memo);
}
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
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPictureConfigerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPictureConfigerEN objPictureConfigerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPictureConfigerEN.CheckPropertyNew();
clsPictureConfigerEN objPictureConfigerCond = new clsPictureConfigerEN();
string strCondition = objPictureConfigerCond
.SetPictureConfigerId(objPictureConfigerEN.PictureConfigerId, "=")
.GetCombineCondition();
objPictureConfigerEN._IsCheckProperty = true;
bool bolIsExist = clsPictureConfigerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPictureConfigerEN.Update();
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
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPictureConfigerEN objPictureConfigerEN)
{
 if (string.IsNullOrEmpty(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPictureConfigerBL.PictureConfigerDA.UpdateBySql2(objPictureConfigerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPictureConfigerEN objPictureConfigerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPictureConfigerBL.PictureConfigerDA.UpdateBySql2(objPictureConfigerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
 /// <param name = "objPictureConfigerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPictureConfigerEN objPictureConfigerEN, string strWhereCond)
{
try
{
bool bolResult = clsPictureConfigerBL.PictureConfigerDA.UpdateBySqlWithCondition(objPictureConfigerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
 /// <param name = "objPictureConfigerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPictureConfigerEN objPictureConfigerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPictureConfigerBL.PictureConfigerDA.UpdateBySqlWithConditionTransaction(objPictureConfigerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
 /// <param name = "strPictureConfigerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPictureConfigerEN objPictureConfigerEN)
{
try
{
int intRecNum = clsPictureConfigerBL.PictureConfigerDA.DelRecord(objPictureConfigerEN.PictureConfigerId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
 /// <param name = "objPictureConfigerENS">源对象</param>
 /// <param name = "objPictureConfigerENT">目标对象</param>
 public static void CopyTo(this clsPictureConfigerEN objPictureConfigerENS, clsPictureConfigerEN objPictureConfigerENT)
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
 /// <param name = "objPictureConfigerENS">源对象</param>
 /// <returns>目标对象=>clsPictureConfigerEN:objPictureConfigerENT</returns>
 public static clsPictureConfigerEN CopyTo(this clsPictureConfigerEN objPictureConfigerENS)
{
try
{
 clsPictureConfigerEN objPictureConfigerENT = new clsPictureConfigerEN()
{
PictureConfigerId = objPictureConfigerENS.PictureConfigerId, //PictureConfigerId
PictureConfigName = objPictureConfigerENS.PictureConfigName, //PictureConfigName
PicturePath = objPictureConfigerENS.PicturePath, //PicturePath
ThumbHeight = objPictureConfigerENS.ThumbHeight, //ThumbHeight
ThumbWidth = objPictureConfigerENS.ThumbWidth, //ThumbWidth
ResizePictureHeight = objPictureConfigerENS.ResizePictureHeight, //ResizePictureHeight
MaxSize = objPictureConfigerENS.MaxSize, //MaxSize
ResizePictureWidth = objPictureConfigerENS.ResizePictureWidth, //ResizePictureWidth
Memo = objPictureConfigerENS.Memo, //备注
};
 return objPictureConfigerENT;
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
public static void CheckPropertyNew(this clsPictureConfigerEN objPictureConfigerEN)
{
 clsPictureConfigerBL.PictureConfigerDA.CheckPropertyNew(objPictureConfigerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPictureConfigerEN objPictureConfigerEN)
{
 clsPictureConfigerBL.PictureConfigerDA.CheckProperty4Condition(objPictureConfigerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPictureConfigerEN objPictureConfigerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPictureConfigerCond.IsUpdated(conPictureConfiger.PictureConfigerId) == true)
{
string strComparisonOpPictureConfigerId = objPictureConfigerCond.dicFldComparisonOp[conPictureConfiger.PictureConfigerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureConfiger.PictureConfigerId, objPictureConfigerCond.PictureConfigerId, strComparisonOpPictureConfigerId);
}
if (objPictureConfigerCond.IsUpdated(conPictureConfiger.PictureConfigName) == true)
{
string strComparisonOpPictureConfigName = objPictureConfigerCond.dicFldComparisonOp[conPictureConfiger.PictureConfigName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureConfiger.PictureConfigName, objPictureConfigerCond.PictureConfigName, strComparisonOpPictureConfigName);
}
if (objPictureConfigerCond.IsUpdated(conPictureConfiger.PicturePath) == true)
{
string strComparisonOpPicturePath = objPictureConfigerCond.dicFldComparisonOp[conPictureConfiger.PicturePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureConfiger.PicturePath, objPictureConfigerCond.PicturePath, strComparisonOpPicturePath);
}
if (objPictureConfigerCond.IsUpdated(conPictureConfiger.ThumbHeight) == true)
{
string strComparisonOpThumbHeight = objPictureConfigerCond.dicFldComparisonOp[conPictureConfiger.ThumbHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureConfiger.ThumbHeight, objPictureConfigerCond.ThumbHeight, strComparisonOpThumbHeight);
}
if (objPictureConfigerCond.IsUpdated(conPictureConfiger.ThumbWidth) == true)
{
string strComparisonOpThumbWidth = objPictureConfigerCond.dicFldComparisonOp[conPictureConfiger.ThumbWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureConfiger.ThumbWidth, objPictureConfigerCond.ThumbWidth, strComparisonOpThumbWidth);
}
if (objPictureConfigerCond.IsUpdated(conPictureConfiger.ResizePictureHeight) == true)
{
string strComparisonOpResizePictureHeight = objPictureConfigerCond.dicFldComparisonOp[conPictureConfiger.ResizePictureHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureConfiger.ResizePictureHeight, objPictureConfigerCond.ResizePictureHeight, strComparisonOpResizePictureHeight);
}
if (objPictureConfigerCond.IsUpdated(conPictureConfiger.MaxSize) == true)
{
string strComparisonOpMaxSize = objPictureConfigerCond.dicFldComparisonOp[conPictureConfiger.MaxSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureConfiger.MaxSize, objPictureConfigerCond.MaxSize, strComparisonOpMaxSize);
}
if (objPictureConfigerCond.IsUpdated(conPictureConfiger.ResizePictureWidth) == true)
{
string strComparisonOpResizePictureWidth = objPictureConfigerCond.dicFldComparisonOp[conPictureConfiger.ResizePictureWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureConfiger.ResizePictureWidth, objPictureConfigerCond.ResizePictureWidth, strComparisonOpResizePictureWidth);
}
if (objPictureConfigerCond.IsUpdated(conPictureConfiger.Memo) == true)
{
string strComparisonOpMemo = objPictureConfigerCond.dicFldComparisonOp[conPictureConfiger.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureConfiger.Memo, objPictureConfigerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PictureConfiger
{
public virtual bool UpdRelaTabDate(string strPictureConfigerId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 图片配置(PictureConfiger)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPictureConfigerBL
{
public static RelatedActions_PictureConfiger relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPictureConfigerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPictureConfigerDA PictureConfigerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPictureConfigerDA();
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
 public clsPictureConfigerBL()
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
if (string.IsNullOrEmpty(clsPictureConfigerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPictureConfigerEN._ConnectString);
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
public static DataTable GetDataTable_PictureConfiger(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PictureConfigerDA.GetDataTable_PictureConfiger(strWhereCond);
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
objDT = PictureConfigerDA.GetDataTable(strWhereCond);
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
objDT = PictureConfigerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PictureConfigerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PictureConfigerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PictureConfigerDA.GetDataTable_Top(objTopPara);
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
objDT = PictureConfigerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PictureConfigerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PictureConfigerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPictureConfigerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLstByPictureConfigerIdLst(List<string> arrPictureConfigerIdLst)
{
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPictureConfigerIdLst, true);
 string strWhereCond = string.Format("PictureConfigerId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureConfigerEN.PictureConfigerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureConfigerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPictureConfigerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPictureConfigerEN> GetObjLstByPictureConfigerIdLstCache(List<string> arrPictureConfigerIdLst)
{
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName);
List<clsPictureConfigerEN> arrPictureConfigerObjLstCache = GetObjLstCache();
IEnumerable <clsPictureConfigerEN> arrPictureConfigerObjLst_Sel =
arrPictureConfigerObjLstCache
.Where(x => arrPictureConfigerIdLst.Contains(x.PictureConfigerId));
return arrPictureConfigerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLst(string strWhereCond)
{
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureConfigerEN.PictureConfigerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureConfigerEN);
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
public static List<clsPictureConfigerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureConfigerEN.PictureConfigerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureConfigerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPictureConfigerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPictureConfigerEN> GetSubObjLstCache(clsPictureConfigerEN objPictureConfigerCond)
{
List<clsPictureConfigerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPictureConfigerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPictureConfiger.AttributeName)
{
if (objPictureConfigerCond.IsUpdated(strFldName) == false) continue;
if (objPictureConfigerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPictureConfigerCond[strFldName].ToString());
}
else
{
if (objPictureConfigerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPictureConfigerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPictureConfigerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPictureConfigerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPictureConfigerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPictureConfigerCond[strFldName]));
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
public static List<clsPictureConfigerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureConfigerEN.PictureConfigerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureConfigerEN);
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
public static List<clsPictureConfigerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureConfigerEN.PictureConfigerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureConfigerEN);
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
List<clsPictureConfigerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPictureConfigerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureConfigerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPictureConfigerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
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
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureConfigerEN.PictureConfigerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureConfigerEN);
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
public static List<clsPictureConfigerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureConfigerEN.PictureConfigerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureConfigerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPictureConfigerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureConfigerEN.PictureConfigerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureConfigerEN);
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
public static List<clsPictureConfigerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureConfigerEN.PictureConfigerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureConfigerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPictureConfigerEN> arrObjLst = new List<clsPictureConfigerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureConfigerEN objPictureConfigerEN = new clsPictureConfigerEN();
try
{
objPictureConfigerEN.PictureConfigerId = objRow[conPictureConfiger.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureConfigerEN.PictureConfigName = objRow[conPictureConfiger.PictureConfigName].ToString().Trim(); //PictureConfigName
objPictureConfigerEN.PicturePath = objRow[conPictureConfiger.PicturePath].ToString().Trim(); //PicturePath
objPictureConfigerEN.ThumbHeight = Int32.Parse(objRow[conPictureConfiger.ThumbHeight].ToString().Trim()); //ThumbHeight
objPictureConfigerEN.ThumbWidth = Int32.Parse(objRow[conPictureConfiger.ThumbWidth].ToString().Trim()); //ThumbWidth
objPictureConfigerEN.ResizePictureHeight = Int32.Parse(objRow[conPictureConfiger.ResizePictureHeight].ToString().Trim()); //ResizePictureHeight
objPictureConfigerEN.MaxSize = objRow[conPictureConfiger.MaxSize].ToString().Trim(); //MaxSize
objPictureConfigerEN.ResizePictureWidth = Int32.Parse(objRow[conPictureConfiger.ResizePictureWidth].ToString().Trim()); //ResizePictureWidth
objPictureConfigerEN.Memo = objRow[conPictureConfiger.Memo] == DBNull.Value ? null : objRow[conPictureConfiger.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureConfigerEN.PictureConfigerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureConfigerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPictureConfigerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPictureConfiger(ref clsPictureConfigerEN objPictureConfigerEN)
{
bool bolResult = PictureConfigerDA.GetPictureConfiger(ref objPictureConfigerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPictureConfigerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPictureConfigerEN GetObjByPictureConfigerId(string strPictureConfigerId)
{
if (strPictureConfigerId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPictureConfigerId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPictureConfigerId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPictureConfigerId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPictureConfigerEN objPictureConfigerEN = PictureConfigerDA.GetObjByPictureConfigerId(strPictureConfigerId);
return objPictureConfigerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPictureConfigerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPictureConfigerEN objPictureConfigerEN = PictureConfigerDA.GetFirstObj(strWhereCond);
 return objPictureConfigerEN;
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
public static clsPictureConfigerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPictureConfigerEN objPictureConfigerEN = PictureConfigerDA.GetObjByDataRow(objRow);
 return objPictureConfigerEN;
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
public static clsPictureConfigerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPictureConfigerEN objPictureConfigerEN = PictureConfigerDA.GetObjByDataRow(objRow);
 return objPictureConfigerEN;
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
 /// <param name = "strPictureConfigerId">所给的关键字</param>
 /// <param name = "lstPictureConfigerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPictureConfigerEN GetObjByPictureConfigerIdFromList(string strPictureConfigerId, List<clsPictureConfigerEN> lstPictureConfigerObjLst)
{
foreach (clsPictureConfigerEN objPictureConfigerEN in lstPictureConfigerObjLst)
{
if (objPictureConfigerEN.PictureConfigerId == strPictureConfigerId)
{
return objPictureConfigerEN;
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
 string strPictureConfigerId;
 try
 {
 strPictureConfigerId = new clsPictureConfigerDA().GetFirstID(strWhereCond);
 return strPictureConfigerId;
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
 arrList = PictureConfigerDA.GetID(strWhereCond);
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
bool bolIsExist = PictureConfigerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPictureConfigerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPictureConfigerId)
{
if (string.IsNullOrEmpty(strPictureConfigerId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPictureConfigerId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PictureConfigerDA.IsExist(strPictureConfigerId);
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
 bolIsExist = clsPictureConfigerDA.IsExistTable();
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
 bolIsExist = PictureConfigerDA.IsExistTable(strTabName);
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
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPictureConfigerEN objPictureConfigerEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPictureConfigerBL.IsExist(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPictureConfigerEN.PictureConfigerId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = PictureConfigerDA.AddNewRecordBySQL2(objPictureConfigerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPictureConfigerEN objPictureConfigerEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPictureConfigerBL.IsExist(objPictureConfigerEN.PictureConfigerId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPictureConfigerEN.PictureConfigerId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = PictureConfigerDA.AddNewRecordBySQL2WithReturnKey(objPictureConfigerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPictureConfigerEN objPictureConfigerEN)
{
try
{
bool bolResult = PictureConfigerDA.Update(objPictureConfigerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
 /// <param name = "objPictureConfigerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPictureConfigerEN objPictureConfigerEN)
{
 if (string.IsNullOrEmpty(objPictureConfigerEN.PictureConfigerId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PictureConfigerDA.UpdateBySql2(objPictureConfigerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureConfigerBL.ReFreshCache();

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
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
 /// <param name = "strPictureConfigerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPictureConfigerId)
{
try
{
 clsPictureConfigerEN objPictureConfigerEN = clsPictureConfigerBL.GetObjByPictureConfigerId(strPictureConfigerId);

if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(objPictureConfigerEN.PictureConfigerId, "SetUpdDate");
}
if (objPictureConfigerEN != null)
{
int intRecNum = PictureConfigerDA.DelRecord(strPictureConfigerId);
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
/// <param name="strPictureConfigerId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPictureConfigerId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPictureConfigerDA.GetSpecSQLObj();
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
//删除与表:[PictureConfiger]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPictureConfiger.PictureConfigerId,
//strPictureConfigerId);
//        clsPictureConfigerBL.DelPictureConfigersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPictureConfigerBL.DelRecord(strPictureConfigerId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPictureConfigerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPictureConfigerId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPictureConfigerId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPictureConfigerId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPictureConfigerBL.relatedActions != null)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(strPictureConfigerId, "UpdRelaTabDate");
}
bool bolResult = PictureConfigerDA.DelRecord(strPictureConfigerId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPictureConfigerIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPictureConfigers(List<string> arrPictureConfigerIdLst)
{
if (arrPictureConfigerIdLst.Count == 0) return 0;
try
{
if (clsPictureConfigerBL.relatedActions != null)
{
foreach (var strPictureConfigerId in arrPictureConfigerIdLst)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(strPictureConfigerId, "UpdRelaTabDate");
}
}
int intDelRecNum = PictureConfigerDA.DelPictureConfiger(arrPictureConfigerIdLst);
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
public static int DelPictureConfigersByCond(string strWhereCond)
{
try
{
if (clsPictureConfigerBL.relatedActions != null)
{
List<string> arrPictureConfigerId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPictureConfigerId in arrPictureConfigerId)
{
clsPictureConfigerBL.relatedActions.UpdRelaTabDate(strPictureConfigerId, "UpdRelaTabDate");
}
}
int intRecNum = PictureConfigerDA.DelPictureConfiger(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PictureConfiger]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPictureConfigerId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPictureConfigerId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPictureConfigerDA.GetSpecSQLObj();
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
//删除与表:[PictureConfiger]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPictureConfigerBL.DelRecord(strPictureConfigerId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPictureConfigerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPictureConfigerId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPictureConfigerEN">源简化对象</param>
 public static void SetUpdFlag(clsPictureConfigerEN objPictureConfigerEN)
{
try
{
objPictureConfigerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPictureConfigerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPictureConfiger.PictureConfigerId, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureConfigerEN.PictureConfigerId = objPictureConfigerEN.PictureConfigerId; //PictureConfigerId
}
if (arrFldSet.Contains(conPictureConfiger.PictureConfigName, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureConfigerEN.PictureConfigName = objPictureConfigerEN.PictureConfigName; //PictureConfigName
}
if (arrFldSet.Contains(conPictureConfiger.PicturePath, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureConfigerEN.PicturePath = objPictureConfigerEN.PicturePath; //PicturePath
}
if (arrFldSet.Contains(conPictureConfiger.ThumbHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureConfigerEN.ThumbHeight = objPictureConfigerEN.ThumbHeight; //ThumbHeight
}
if (arrFldSet.Contains(conPictureConfiger.ThumbWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureConfigerEN.ThumbWidth = objPictureConfigerEN.ThumbWidth; //ThumbWidth
}
if (arrFldSet.Contains(conPictureConfiger.ResizePictureHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureConfigerEN.ResizePictureHeight = objPictureConfigerEN.ResizePictureHeight; //ResizePictureHeight
}
if (arrFldSet.Contains(conPictureConfiger.MaxSize, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureConfigerEN.MaxSize = objPictureConfigerEN.MaxSize; //MaxSize
}
if (arrFldSet.Contains(conPictureConfiger.ResizePictureWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureConfigerEN.ResizePictureWidth = objPictureConfigerEN.ResizePictureWidth; //ResizePictureWidth
}
if (arrFldSet.Contains(conPictureConfiger.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureConfigerEN.Memo = objPictureConfigerEN.Memo == "[null]" ? null :  objPictureConfigerEN.Memo; //备注
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
 /// <param name = "objPictureConfigerEN">源简化对象</param>
 public static void AccessFldValueNull(clsPictureConfigerEN objPictureConfigerEN)
{
try
{
if (objPictureConfigerEN.Memo == "[null]") objPictureConfigerEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsPictureConfigerEN objPictureConfigerEN)
{
 PictureConfigerDA.CheckPropertyNew(objPictureConfigerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPictureConfigerEN objPictureConfigerEN)
{
 PictureConfigerDA.CheckProperty4Condition(objPictureConfigerEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_PictureConfigerId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPictureConfiger.PictureConfigerId); 
List<clsPictureConfigerEN> arrObjLst = clsPictureConfigerBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_PictureConfigerId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[图片配置]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conPictureConfiger.PictureConfigerId); 
IEnumerable<clsPictureConfigerEN> arrObjLst = clsPictureConfigerBL.GetObjLst(strCondition);
objDDL.DataValueField = conPictureConfiger.PictureConfigerId;
objDDL.DataTextField = conPictureConfiger.PictureConfigName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PictureConfigerIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[图片配置]...","0");
List<clsPictureConfigerEN> arrPictureConfigerObjLst = GetAllPictureConfigerObjLstCache(); 
objDDL.DataValueField = conPictureConfiger.PictureConfigerId;
objDDL.DataTextField = conPictureConfiger.PictureConfigName;
objDDL.DataSource = arrPictureConfigerObjLst;
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
if (clsPictureConfigerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPictureConfigerBL没有刷新缓存机制(clsPictureConfigerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PictureConfigerId");
//if (arrPictureConfigerObjLstCache == null)
//{
//arrPictureConfigerObjLstCache = PictureConfigerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPictureConfigerId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPictureConfigerEN GetObjByPictureConfigerIdCache(string strPictureConfigerId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName);
List<clsPictureConfigerEN> arrPictureConfigerObjLstCache = GetObjLstCache();
IEnumerable <clsPictureConfigerEN> arrPictureConfigerObjLst_Sel =
arrPictureConfigerObjLstCache
.Where(x=> x.PictureConfigerId == strPictureConfigerId 
);
if (arrPictureConfigerObjLst_Sel.Count() == 0)
{
   clsPictureConfigerEN obj = clsPictureConfigerBL.GetObjByPictureConfigerId(strPictureConfigerId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPictureConfigerObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPictureConfigerId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPictureConfigNameByPictureConfigerIdCache(string strPictureConfigerId)
{
if (string.IsNullOrEmpty(strPictureConfigerId) == true) return "";
//获取缓存中的对象列表
clsPictureConfigerEN objPictureConfiger = GetObjByPictureConfigerIdCache(strPictureConfigerId);
if (objPictureConfiger == null) return "";
return objPictureConfiger.PictureConfigName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPictureConfigerId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPictureConfigerIdCache(string strPictureConfigerId)
{
if (string.IsNullOrEmpty(strPictureConfigerId) == true) return "";
//获取缓存中的对象列表
clsPictureConfigerEN objPictureConfiger = GetObjByPictureConfigerIdCache(strPictureConfigerId);
if (objPictureConfiger == null) return "";
return objPictureConfiger.PictureConfigName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPictureConfigerEN> GetAllPictureConfigerObjLstCache()
{
//获取缓存中的对象列表
List<clsPictureConfigerEN> arrPictureConfigerObjLstCache = GetObjLstCache(); 
return arrPictureConfigerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPictureConfigerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName);
List<clsPictureConfigerEN> arrPictureConfigerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPictureConfigerObjLstCache;
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
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPictureConfigerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPictureConfigerEN._RefreshTimeLst.Count == 0) return "";
return clsPictureConfigerEN._RefreshTimeLst[clsPictureConfigerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPictureConfigerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPictureConfigerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPictureConfigerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPictureConfigerBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strPictureConfigerId)
{
if (strInFldName != conPictureConfiger.PictureConfigerId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPictureConfiger.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPictureConfiger.AttributeName));
throw new Exception(strMsg);
}
var objPictureConfiger = clsPictureConfigerBL.GetObjByPictureConfigerIdCache(strPictureConfigerId);
if (objPictureConfiger == null) return "";
return objPictureConfiger[strOutFldName].ToString();
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
int intRecCount = clsPictureConfigerDA.GetRecCount(strTabName);
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
int intRecCount = clsPictureConfigerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPictureConfigerDA.GetRecCount();
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
int intRecCount = clsPictureConfigerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPictureConfigerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPictureConfigerEN objPictureConfigerCond)
{
List<clsPictureConfigerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPictureConfigerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPictureConfiger.AttributeName)
{
if (objPictureConfigerCond.IsUpdated(strFldName) == false) continue;
if (objPictureConfigerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPictureConfigerCond[strFldName].ToString());
}
else
{
if (objPictureConfigerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPictureConfigerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPictureConfigerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPictureConfigerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPictureConfigerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPictureConfigerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPictureConfigerCond[strFldName]));
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
 List<string> arrList = clsPictureConfigerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PictureConfigerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PictureConfigerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PictureConfigerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPictureConfigerDA.SetFldValue(clsPictureConfigerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PictureConfigerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPictureConfigerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPictureConfigerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPictureConfigerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PictureConfiger] "); 
 strCreateTabCode.Append(" ( "); 
 // /**PictureConfigerId*/ 
 strCreateTabCode.Append(" PictureConfigerId char(4) primary key, "); 
 // /**PictureConfigName*/ 
 strCreateTabCode.Append(" PictureConfigName varchar(50) not Null, "); 
 // /**PicturePath*/ 
 strCreateTabCode.Append(" PicturePath varchar(50) not Null, "); 
 // /**ThumbHeight*/ 
 strCreateTabCode.Append(" ThumbHeight int not Null, "); 
 // /**ThumbWidth*/ 
 strCreateTabCode.Append(" ThumbWidth int not Null, "); 
 // /**ResizePictureHeight*/ 
 strCreateTabCode.Append(" ResizePictureHeight int not Null, "); 
 // /**MaxSize*/ 
 strCreateTabCode.Append(" MaxSize varchar(50) not Null, "); 
 // /**ResizePictureWidth*/ 
 strCreateTabCode.Append(" ResizePictureWidth int not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 图片配置(PictureConfiger)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PictureConfiger : clsCommFun4BL
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
clsPictureConfigerBL.ReFreshThisCache();
}
}

}