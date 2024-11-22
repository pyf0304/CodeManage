
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPictureResourcesBL
 表名:PictureResources(01120040)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
public static class  clsPictureResourcesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intPictureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPictureResourcesEN GetObj(this K_PictureId_PictureResources myKey)
{
clsPictureResourcesEN objPictureResourcesEN = clsPictureResourcesBL.PictureResourcesDA.GetObjByPictureId(myKey.Value);
return objPictureResourcesEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPictureResourcesEN objPictureResourcesEN)
{
if (CheckUniqueness(objPictureResourcesEN) == false)
{
var strMsg = string.Format("记录已经存在!PictureName = [{0}],PictureConfigerId = [{1}]的数据已经存在!(in clsPictureResourcesBL.AddNewRecord)", objPictureResourcesEN.PictureName,objPictureResourcesEN.PictureConfigerId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPictureResourcesBL.PictureResourcesDA.AddNewRecordBySQL2(objPictureResourcesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPictureResourcesEN objPictureResourcesEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objPictureResourcesEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objPictureResourcesEN.CheckUniqueness() == false)
{
strMsg = string.Format("(PictureName(PictureName)=[{0}],PictureConfigerId(PictureConfigerId)=[{1}])已经存在,不能重复!", objPictureResourcesEN.PictureName, objPictureResourcesEN.PictureConfigerId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPictureResourcesEN.AddNewRecord();
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
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPictureResourcesEN objPictureResourcesEN)
{
if (CheckUniqueness(objPictureResourcesEN) == false)
{
var strMsg = string.Format("记录已经存在!PictureName = [{0}],PictureConfigerId = [{1}]的数据已经存在!(in clsPictureResourcesBL.AddNewRecordWithReturnKey)", objPictureResourcesEN.PictureName,objPictureResourcesEN.PictureConfigerId);
throw new Exception(strMsg);
}
try
{
string strKey = clsPictureResourcesBL.PictureResourcesDA.AddNewRecordBySQL2WithReturnKey(objPictureResourcesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetMemo(this clsPictureResourcesEN objPictureResourcesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPictureResources.Memo);
}
objPictureResourcesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.Memo) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.Memo, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.Memo] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetPictureId(this clsPictureResourcesEN objPictureResourcesEN, int intPictureId, string strComparisonOp="")
	{
objPictureResourcesEN.PictureId = intPictureId; //PictureId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.PictureId) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.PictureId, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.PictureId] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetPictureName(this clsPictureResourcesEN objPictureResourcesEN, string strPictureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPictureName, conPictureResources.PictureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPictureName, 100, conPictureResources.PictureName);
}
objPictureResourcesEN.PictureName = strPictureName; //PictureName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.PictureName) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.PictureName, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.PictureName] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetOrginialFileName(this clsPictureResourcesEN objPictureResourcesEN, string strOrginialFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOrginialFileName, 100, conPictureResources.OrginialFileName);
}
objPictureResourcesEN.OrginialFileName = strOrginialFileName; //OrginialFileName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.OrginialFileName) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.OrginialFileName, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.OrginialFileName] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetOrginialFileSize(this clsPictureResourcesEN objPictureResourcesEN, int? intOrginialFileSize, string strComparisonOp="")
	{
objPictureResourcesEN.OrginialFileSize = intOrginialFileSize; //OrginialFileSize
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.OrginialFileSize) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.OrginialFileSize, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.OrginialFileSize] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetResizePictureSize(this clsPictureResourcesEN objPictureResourcesEN, int? intResizePictureSize, string strComparisonOp="")
	{
objPictureResourcesEN.ResizePictureSize = intResizePictureSize; //ResizePictureSize
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.ResizePictureSize) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.ResizePictureSize, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.ResizePictureSize] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetThumbSize(this clsPictureResourcesEN objPictureResourcesEN, int intThumbSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intThumbSize, conPictureResources.ThumbSize);
objPictureResourcesEN.ThumbSize = intThumbSize; //ThumbSize
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.ThumbSize) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.ThumbSize, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.ThumbSize] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetOrginialFileWidth(this clsPictureResourcesEN objPictureResourcesEN, int intOrginialFileWidth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrginialFileWidth, conPictureResources.OrginialFileWidth);
objPictureResourcesEN.OrginialFileWidth = intOrginialFileWidth; //OrginialFileWidth
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.OrginialFileWidth) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.OrginialFileWidth, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.OrginialFileWidth] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetPictureConfigerId(this clsPictureResourcesEN objPictureResourcesEN, string strPictureConfigerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPictureConfigerId, 4, conPictureResources.PictureConfigerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPictureConfigerId, 4, conPictureResources.PictureConfigerId);
}
objPictureResourcesEN.PictureConfigerId = strPictureConfigerId; //PictureConfigerId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.PictureConfigerId) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.PictureConfigerId, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.PictureConfigerId] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetResizePictureName(this clsPictureResourcesEN objPictureResourcesEN, string strResizePictureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResizePictureName, conPictureResources.ResizePictureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResizePictureName, 100, conPictureResources.ResizePictureName);
}
objPictureResourcesEN.ResizePictureName = strResizePictureName; //ResizePictureName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.ResizePictureName) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.ResizePictureName, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.ResizePictureName] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetThumbName(this clsPictureResourcesEN objPictureResourcesEN, string strThumbName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strThumbName, conPictureResources.ThumbName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThumbName, 100, conPictureResources.ThumbName);
}
objPictureResourcesEN.ThumbName = strThumbName; //ThumbName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.ThumbName) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.ThumbName, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.ThumbName] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPictureResourcesEN SetOrginialFileHeight(this clsPictureResourcesEN objPictureResourcesEN, int? intOrginialFileHeight, string strComparisonOp="")
	{
objPictureResourcesEN.OrginialFileHeight = intOrginialFileHeight; //OrginialFileHeight
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.OrginialFileHeight) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.OrginialFileHeight, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.OrginialFileHeight] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPictureResourcesEN objPictureResourcesEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPictureResourcesEN.CheckPropertyNew();
clsPictureResourcesEN objPictureResourcesCond = new clsPictureResourcesEN();
string strCondition = objPictureResourcesCond
.SetPictureId(objPictureResourcesEN.PictureId, "<>")
.SetPictureName(objPictureResourcesEN.PictureName, "=")
.SetPictureConfigerId(objPictureResourcesEN.PictureConfigerId, "=")
.GetCombineCondition();
objPictureResourcesEN._IsCheckProperty = true;
bool bolIsExist = clsPictureResourcesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PictureName_PictureConfigerId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPictureResourcesEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objPictureResources">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPictureResourcesEN objPictureResources)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPictureResourcesEN objPictureResourcesCond = new clsPictureResourcesEN();
string strCondition = objPictureResourcesCond
.SetPictureName(objPictureResources.PictureName, "=")
.SetPictureConfigerId(objPictureResources.PictureConfigerId, "=")
.GetCombineCondition();
objPictureResources._IsCheckProperty = true;
bool bolIsExist = clsPictureResourcesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPictureResources.PictureId = clsPictureResourcesBL.GetFirstID_S(strCondition);
objPictureResources.UpdateWithCondition(strCondition);
}
else
{
objPictureResources.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPictureResourcesEN objPictureResourcesEN)
{
 if (objPictureResourcesEN.PictureId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPictureResourcesBL.PictureResourcesDA.UpdateBySql2(objPictureResourcesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPictureResourcesEN objPictureResourcesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPictureResourcesEN.PictureId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPictureResourcesBL.PictureResourcesDA.UpdateBySql2(objPictureResourcesEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
 /// <param name = "objPictureResourcesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPictureResourcesEN objPictureResourcesEN, string strWhereCond)
{
try
{
bool bolResult = clsPictureResourcesBL.PictureResourcesDA.UpdateBySqlWithCondition(objPictureResourcesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
 /// <param name = "objPictureResourcesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPictureResourcesEN objPictureResourcesEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPictureResourcesBL.PictureResourcesDA.UpdateBySqlWithConditionTransaction(objPictureResourcesEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
 /// <param name = "intPictureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPictureResourcesEN objPictureResourcesEN)
{
try
{
int intRecNum = clsPictureResourcesBL.PictureResourcesDA.DelRecord(objPictureResourcesEN.PictureId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
 /// <param name = "objPictureResourcesENS">源对象</param>
 /// <param name = "objPictureResourcesENT">目标对象</param>
 public static void CopyTo(this clsPictureResourcesEN objPictureResourcesENS, clsPictureResourcesEN objPictureResourcesENT)
{
try
{
objPictureResourcesENT.Memo = objPictureResourcesENS.Memo; //备注
objPictureResourcesENT.PictureId = objPictureResourcesENS.PictureId; //PictureId
objPictureResourcesENT.PictureName = objPictureResourcesENS.PictureName; //PictureName
objPictureResourcesENT.OrginialFileName = objPictureResourcesENS.OrginialFileName; //OrginialFileName
objPictureResourcesENT.OrginialFileSize = objPictureResourcesENS.OrginialFileSize; //OrginialFileSize
objPictureResourcesENT.ResizePictureSize = objPictureResourcesENS.ResizePictureSize; //ResizePictureSize
objPictureResourcesENT.ThumbSize = objPictureResourcesENS.ThumbSize; //ThumbSize
objPictureResourcesENT.OrginialFileWidth = objPictureResourcesENS.OrginialFileWidth; //OrginialFileWidth
objPictureResourcesENT.PictureConfigerId = objPictureResourcesENS.PictureConfigerId; //PictureConfigerId
objPictureResourcesENT.ResizePictureName = objPictureResourcesENS.ResizePictureName; //ResizePictureName
objPictureResourcesENT.ThumbName = objPictureResourcesENS.ThumbName; //ThumbName
objPictureResourcesENT.OrginialFileHeight = objPictureResourcesENS.OrginialFileHeight; //OrginialFileHeight
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
 /// <param name = "objPictureResourcesENS">源对象</param>
 /// <returns>目标对象=>clsPictureResourcesEN:objPictureResourcesENT</returns>
 public static clsPictureResourcesEN CopyTo(this clsPictureResourcesEN objPictureResourcesENS)
{
try
{
 clsPictureResourcesEN objPictureResourcesENT = new clsPictureResourcesEN()
{
Memo = objPictureResourcesENS.Memo, //备注
PictureId = objPictureResourcesENS.PictureId, //PictureId
PictureName = objPictureResourcesENS.PictureName, //PictureName
OrginialFileName = objPictureResourcesENS.OrginialFileName, //OrginialFileName
OrginialFileSize = objPictureResourcesENS.OrginialFileSize, //OrginialFileSize
ResizePictureSize = objPictureResourcesENS.ResizePictureSize, //ResizePictureSize
ThumbSize = objPictureResourcesENS.ThumbSize, //ThumbSize
OrginialFileWidth = objPictureResourcesENS.OrginialFileWidth, //OrginialFileWidth
PictureConfigerId = objPictureResourcesENS.PictureConfigerId, //PictureConfigerId
ResizePictureName = objPictureResourcesENS.ResizePictureName, //ResizePictureName
ThumbName = objPictureResourcesENS.ThumbName, //ThumbName
OrginialFileHeight = objPictureResourcesENS.OrginialFileHeight, //OrginialFileHeight
};
 return objPictureResourcesENT;
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
public static void CheckPropertyNew(this clsPictureResourcesEN objPictureResourcesEN)
{
 clsPictureResourcesBL.PictureResourcesDA.CheckPropertyNew(objPictureResourcesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPictureResourcesEN objPictureResourcesEN)
{
 clsPictureResourcesBL.PictureResourcesDA.CheckProperty4Condition(objPictureResourcesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPictureResourcesEN objPictureResourcesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPictureResourcesCond.IsUpdated(conPictureResources.Memo) == true)
{
string strComparisonOpMemo = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.Memo, objPictureResourcesCond.Memo, strComparisonOpMemo);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.PictureId) == true)
{
string strComparisonOpPictureId = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.PictureId];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.PictureId, objPictureResourcesCond.PictureId, strComparisonOpPictureId);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.PictureName) == true)
{
string strComparisonOpPictureName = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.PictureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.PictureName, objPictureResourcesCond.PictureName, strComparisonOpPictureName);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.OrginialFileName) == true)
{
string strComparisonOpOrginialFileName = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.OrginialFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.OrginialFileName, objPictureResourcesCond.OrginialFileName, strComparisonOpOrginialFileName);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.OrginialFileSize) == true)
{
string strComparisonOpOrginialFileSize = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.OrginialFileSize];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.OrginialFileSize, objPictureResourcesCond.OrginialFileSize, strComparisonOpOrginialFileSize);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.ResizePictureSize) == true)
{
string strComparisonOpResizePictureSize = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.ResizePictureSize];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.ResizePictureSize, objPictureResourcesCond.ResizePictureSize, strComparisonOpResizePictureSize);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.ThumbSize) == true)
{
string strComparisonOpThumbSize = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.ThumbSize];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.ThumbSize, objPictureResourcesCond.ThumbSize, strComparisonOpThumbSize);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.OrginialFileWidth) == true)
{
string strComparisonOpOrginialFileWidth = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.OrginialFileWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.OrginialFileWidth, objPictureResourcesCond.OrginialFileWidth, strComparisonOpOrginialFileWidth);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.PictureConfigerId) == true)
{
string strComparisonOpPictureConfigerId = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.PictureConfigerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.PictureConfigerId, objPictureResourcesCond.PictureConfigerId, strComparisonOpPictureConfigerId);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.ResizePictureName) == true)
{
string strComparisonOpResizePictureName = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.ResizePictureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.ResizePictureName, objPictureResourcesCond.ResizePictureName, strComparisonOpResizePictureName);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.ThumbName) == true)
{
string strComparisonOpThumbName = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.ThumbName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.ThumbName, objPictureResourcesCond.ThumbName, strComparisonOpThumbName);
}
if (objPictureResourcesCond.IsUpdated(conPictureResources.OrginialFileHeight) == true)
{
string strComparisonOpOrginialFileHeight = objPictureResourcesCond.dicFldComparisonOp[conPictureResources.OrginialFileHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.OrginialFileHeight, objPictureResourcesCond.OrginialFileHeight, strComparisonOpOrginialFileHeight);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PictureResources(图片资源), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PictureName_PictureConfigerId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPictureResourcesEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPictureResourcesEN objPictureResourcesEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPictureResourcesEN == null) return true;
if (objPictureResourcesEN.PictureId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PictureName = '{0}'", objPictureResourcesEN.PictureName);
 if (objPictureResourcesEN.PictureConfigerId == null)
{
 sbCondition.AppendFormat(" and PictureConfigerId is null", objPictureResourcesEN.PictureConfigerId);
}
else
{
 sbCondition.AppendFormat(" and PictureConfigerId = '{0}'", objPictureResourcesEN.PictureConfigerId);
}
if (clsPictureResourcesBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PictureId !=  {0}", objPictureResourcesEN.PictureId);
 sbCondition.AppendFormat(" and PictureName = '{0}'", objPictureResourcesEN.PictureName);
 sbCondition.AppendFormat(" and PictureConfigerId = '{0}'", objPictureResourcesEN.PictureConfigerId);
if (clsPictureResourcesBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--PictureResources(图片资源), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PictureName_PictureConfigerId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPictureResourcesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPictureResourcesEN objPictureResourcesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPictureResourcesEN == null) return "";
if (objPictureResourcesEN.PictureId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PictureName = '{0}'", objPictureResourcesEN.PictureName);
 if (objPictureResourcesEN.PictureConfigerId == null)
{
 sbCondition.AppendFormat(" and PictureConfigerId is null", objPictureResourcesEN.PictureConfigerId);
}
else
{
 sbCondition.AppendFormat(" and PictureConfigerId = '{0}'", objPictureResourcesEN.PictureConfigerId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PictureId !=  {0}", objPictureResourcesEN.PictureId);
 sbCondition.AppendFormat(" and PictureName = '{0}'", objPictureResourcesEN.PictureName);
 sbCondition.AppendFormat(" and PictureConfigerId = '{0}'", objPictureResourcesEN.PictureConfigerId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PictureResources
{
public virtual bool UpdRelaTabDate(int intPictureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 图片资源(PictureResources)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPictureResourcesBL
{
public static RelatedActions_PictureResources relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPictureResourcesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPictureResourcesDA PictureResourcesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPictureResourcesDA();
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
 public clsPictureResourcesBL()
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
if (string.IsNullOrEmpty(clsPictureResourcesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPictureResourcesEN._ConnectString);
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
public static DataTable GetDataTable_PictureResources(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PictureResourcesDA.GetDataTable_PictureResources(strWhereCond);
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
objDT = PictureResourcesDA.GetDataTable(strWhereCond);
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
objDT = PictureResourcesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PictureResourcesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PictureResourcesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PictureResourcesDA.GetDataTable_Top(objTopPara);
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
objDT = PictureResourcesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PictureResourcesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PictureResourcesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPictureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPictureResourcesEN> GetObjLstByPictureIdLst(List<int> arrPictureIdLst)
{
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPictureIdLst);
 string strWhereCond = string.Format("PictureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureResourcesEN.PictureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureResourcesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPictureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPictureResourcesEN> GetObjLstByPictureIdLstCache(List<int> arrPictureIdLst)
{
string strKey = string.Format("{0}", clsPictureResourcesEN._CurrTabName);
List<clsPictureResourcesEN> arrPictureResourcesObjLstCache = GetObjLstCache();
IEnumerable <clsPictureResourcesEN> arrPictureResourcesObjLst_Sel =
arrPictureResourcesObjLstCache
.Where(x => arrPictureIdLst.Contains(x.PictureId));
return arrPictureResourcesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureResourcesEN> GetObjLst(string strWhereCond)
{
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureResourcesEN.PictureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureResourcesEN);
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
public static List<clsPictureResourcesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureResourcesEN.PictureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureResourcesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPictureResourcesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPictureResourcesEN> GetSubObjLstCache(clsPictureResourcesEN objPictureResourcesCond)
{
List<clsPictureResourcesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPictureResourcesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPictureResources.AttributeName)
{
if (objPictureResourcesCond.IsUpdated(strFldName) == false) continue;
if (objPictureResourcesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPictureResourcesCond[strFldName].ToString());
}
else
{
if (objPictureResourcesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPictureResourcesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPictureResourcesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPictureResourcesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPictureResourcesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPictureResourcesCond[strFldName]));
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
public static List<clsPictureResourcesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureResourcesEN.PictureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureResourcesEN);
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
public static List<clsPictureResourcesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureResourcesEN.PictureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureResourcesEN);
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
List<clsPictureResourcesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPictureResourcesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureResourcesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPictureResourcesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
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
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureResourcesEN.PictureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureResourcesEN);
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
public static List<clsPictureResourcesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureResourcesEN.PictureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureResourcesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPictureResourcesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPictureResourcesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureResourcesEN.PictureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureResourcesEN);
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
public static List<clsPictureResourcesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureResourcesEN.PictureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureResourcesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureResourcesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPictureResourcesEN> arrObjLst = new List<clsPictureResourcesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPictureResourcesEN objPictureResourcesEN = new clsPictureResourcesEN();
try
{
objPictureResourcesEN.Memo = objRow[conPictureResources.Memo] == DBNull.Value ? null : objRow[conPictureResources.Memo].ToString().Trim(); //备注
objPictureResourcesEN.PictureId = Int32.Parse(objRow[conPictureResources.PictureId].ToString().Trim()); //PictureId
objPictureResourcesEN.PictureName = objRow[conPictureResources.PictureName].ToString().Trim(); //PictureName
objPictureResourcesEN.OrginialFileName = objRow[conPictureResources.OrginialFileName] == DBNull.Value ? null : objRow[conPictureResources.OrginialFileName].ToString().Trim(); //OrginialFileName
objPictureResourcesEN.OrginialFileSize = objRow[conPictureResources.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objPictureResourcesEN.ResizePictureSize = objRow[conPictureResources.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objPictureResourcesEN.ThumbSize = Int32.Parse(objRow[conPictureResources.ThumbSize].ToString().Trim()); //ThumbSize
objPictureResourcesEN.OrginialFileWidth = Int32.Parse(objRow[conPictureResources.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objPictureResourcesEN.PictureConfigerId = objRow[conPictureResources.PictureConfigerId] == DBNull.Value ? null : objRow[conPictureResources.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objPictureResourcesEN.ResizePictureName = objRow[conPictureResources.ResizePictureName].ToString().Trim(); //ResizePictureName
objPictureResourcesEN.ThumbName = objRow[conPictureResources.ThumbName].ToString().Trim(); //ThumbName
objPictureResourcesEN.OrginialFileHeight = objRow[conPictureResources.OrginialFileHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPictureResources.OrginialFileHeight].ToString().Trim()); //OrginialFileHeight
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPictureResourcesEN.PictureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPictureResourcesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPictureResourcesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPictureResources(ref clsPictureResourcesEN objPictureResourcesEN)
{
bool bolResult = PictureResourcesDA.GetPictureResources(ref objPictureResourcesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intPictureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPictureResourcesEN GetObjByPictureId(int intPictureId)
{
clsPictureResourcesEN objPictureResourcesEN = PictureResourcesDA.GetObjByPictureId(intPictureId);
return objPictureResourcesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPictureResourcesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPictureResourcesEN objPictureResourcesEN = PictureResourcesDA.GetFirstObj(strWhereCond);
 return objPictureResourcesEN;
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
public static clsPictureResourcesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPictureResourcesEN objPictureResourcesEN = PictureResourcesDA.GetObjByDataRow(objRow);
 return objPictureResourcesEN;
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
public static clsPictureResourcesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPictureResourcesEN objPictureResourcesEN = PictureResourcesDA.GetObjByDataRow(objRow);
 return objPictureResourcesEN;
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
 /// <param name = "intPictureId">所给的关键字</param>
 /// <param name = "lstPictureResourcesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPictureResourcesEN GetObjByPictureIdFromList(int intPictureId, List<clsPictureResourcesEN> lstPictureResourcesObjLst)
{
foreach (clsPictureResourcesEN objPictureResourcesEN in lstPictureResourcesObjLst)
{
if (objPictureResourcesEN.PictureId == intPictureId)
{
return objPictureResourcesEN;
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
public static int GetFirstID_S(string strWhereCond) 
{
 int intPictureId;
 try
 {
 intPictureId = new clsPictureResourcesDA().GetFirstID(strWhereCond);
 return intPictureId;
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
 arrList = PictureResourcesDA.GetID(strWhereCond);
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
bool bolIsExist = PictureResourcesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intPictureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intPictureId)
{
//检测记录是否存在
bool bolIsExist = PictureResourcesDA.IsExist(intPictureId);
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
 bolIsExist = clsPictureResourcesDA.IsExistTable();
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
 bolIsExist = PictureResourcesDA.IsExistTable(strTabName);
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
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPictureResourcesEN objPictureResourcesEN)
{
if (objPictureResourcesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!PictureName = [{0}],PictureConfigerId = [{1}]的数据已经存在!(in clsPictureResourcesBL.AddNewRecordBySql2)", objPictureResourcesEN.PictureName,objPictureResourcesEN.PictureConfigerId);
throw new Exception(strMsg);
}
try
{
bool bolResult = PictureResourcesDA.AddNewRecordBySQL2(objPictureResourcesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPictureResourcesEN objPictureResourcesEN)
{
if (objPictureResourcesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!PictureName = [{0}],PictureConfigerId = [{1}]的数据已经存在!(in clsPictureResourcesBL.AddNewRecordBySql2WithReturnKey)", objPictureResourcesEN.PictureName,objPictureResourcesEN.PictureConfigerId);
throw new Exception(strMsg);
}
try
{
string strKey = PictureResourcesDA.AddNewRecordBySQL2WithReturnKey(objPictureResourcesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPictureResourcesEN objPictureResourcesEN)
{
try
{
bool bolResult = PictureResourcesDA.Update(objPictureResourcesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPictureResourcesEN objPictureResourcesEN)
{
 if (objPictureResourcesEN.PictureId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PictureResourcesDA.UpdateBySql2(objPictureResourcesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesBL.ReFreshCache();

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
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
 /// <param name = "intPictureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(int intPictureId)
{
try
{
 clsPictureResourcesEN objPictureResourcesEN = clsPictureResourcesBL.GetObjByPictureId(intPictureId);

if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(objPictureResourcesEN.PictureId, "SetUpdDate");
}
if (objPictureResourcesEN != null)
{
int intRecNum = PictureResourcesDA.DelRecord(intPictureId);
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
/// <param name="intPictureId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(int intPictureId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPictureResourcesDA.GetSpecSQLObj();
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
//删除与表:[PictureResources]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPictureResources.PictureId,
//intPictureId);
//        clsPictureResourcesBL.DelPictureResourcessByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPictureResourcesBL.DelRecord(intPictureId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPictureResourcesBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intPictureId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "intPictureId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(int intPictureId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPictureResourcesBL.relatedActions != null)
{
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(intPictureId, "UpdRelaTabDate");
}
bool bolResult = PictureResourcesDA.DelRecord(intPictureId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPictureIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPictureResourcess(List<string> arrPictureIdLst)
{
if (arrPictureIdLst.Count == 0) return 0;
try
{
if (clsPictureResourcesBL.relatedActions != null)
{
foreach (var strPictureId in arrPictureIdLst)
{
int intPictureId = int.Parse(strPictureId);
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(intPictureId, "UpdRelaTabDate");
}
}
int intDelRecNum = PictureResourcesDA.DelPictureResources(arrPictureIdLst);
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
public static int DelPictureResourcessByCond(string strWhereCond)
{
try
{
if (clsPictureResourcesBL.relatedActions != null)
{
List<string> arrPictureId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPictureId in arrPictureId)
{
int intPictureId = int.Parse(strPictureId);
clsPictureResourcesBL.relatedActions.UpdRelaTabDate(intPictureId, "UpdRelaTabDate");
}
}
int intRecNum = PictureResourcesDA.DelPictureResources(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PictureResources]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="intPictureId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(int intPictureId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPictureResourcesDA.GetSpecSQLObj();
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
//删除与表:[PictureResources]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPictureResourcesBL.DelRecord(intPictureId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPictureResourcesBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intPictureId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPictureResourcesENS">源对象</param>
 /// <param name = "objPictureResourcesENT">目标对象</param>
 public static void CopyTo(clsPictureResourcesEN objPictureResourcesENS, clsPictureResourcesEN objPictureResourcesENT)
{
try
{
objPictureResourcesENT.Memo = objPictureResourcesENS.Memo; //备注
objPictureResourcesENT.PictureId = objPictureResourcesENS.PictureId; //PictureId
objPictureResourcesENT.PictureName = objPictureResourcesENS.PictureName; //PictureName
objPictureResourcesENT.OrginialFileName = objPictureResourcesENS.OrginialFileName; //OrginialFileName
objPictureResourcesENT.OrginialFileSize = objPictureResourcesENS.OrginialFileSize; //OrginialFileSize
objPictureResourcesENT.ResizePictureSize = objPictureResourcesENS.ResizePictureSize; //ResizePictureSize
objPictureResourcesENT.ThumbSize = objPictureResourcesENS.ThumbSize; //ThumbSize
objPictureResourcesENT.OrginialFileWidth = objPictureResourcesENS.OrginialFileWidth; //OrginialFileWidth
objPictureResourcesENT.PictureConfigerId = objPictureResourcesENS.PictureConfigerId; //PictureConfigerId
objPictureResourcesENT.ResizePictureName = objPictureResourcesENS.ResizePictureName; //ResizePictureName
objPictureResourcesENT.ThumbName = objPictureResourcesENS.ThumbName; //ThumbName
objPictureResourcesENT.OrginialFileHeight = objPictureResourcesENS.OrginialFileHeight; //OrginialFileHeight
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
 /// <param name = "objPictureResourcesEN">源简化对象</param>
 public static void SetUpdFlag(clsPictureResourcesEN objPictureResourcesEN)
{
try
{
objPictureResourcesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPictureResourcesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPictureResources.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.Memo = objPictureResourcesEN.Memo == "[null]" ? null :  objPictureResourcesEN.Memo; //备注
}
if (arrFldSet.Contains(conPictureResources.PictureId, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.PictureId = objPictureResourcesEN.PictureId; //PictureId
}
if (arrFldSet.Contains(conPictureResources.PictureName, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.PictureName = objPictureResourcesEN.PictureName; //PictureName
}
if (arrFldSet.Contains(conPictureResources.OrginialFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.OrginialFileName = objPictureResourcesEN.OrginialFileName == "[null]" ? null :  objPictureResourcesEN.OrginialFileName; //OrginialFileName
}
if (arrFldSet.Contains(conPictureResources.OrginialFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.OrginialFileSize = objPictureResourcesEN.OrginialFileSize; //OrginialFileSize
}
if (arrFldSet.Contains(conPictureResources.ResizePictureSize, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.ResizePictureSize = objPictureResourcesEN.ResizePictureSize; //ResizePictureSize
}
if (arrFldSet.Contains(conPictureResources.ThumbSize, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.ThumbSize = objPictureResourcesEN.ThumbSize; //ThumbSize
}
if (arrFldSet.Contains(conPictureResources.OrginialFileWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.OrginialFileWidth = objPictureResourcesEN.OrginialFileWidth; //OrginialFileWidth
}
if (arrFldSet.Contains(conPictureResources.PictureConfigerId, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.PictureConfigerId = objPictureResourcesEN.PictureConfigerId == "[null]" ? null :  objPictureResourcesEN.PictureConfigerId; //PictureConfigerId
}
if (arrFldSet.Contains(conPictureResources.ResizePictureName, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.ResizePictureName = objPictureResourcesEN.ResizePictureName; //ResizePictureName
}
if (arrFldSet.Contains(conPictureResources.ThumbName, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.ThumbName = objPictureResourcesEN.ThumbName; //ThumbName
}
if (arrFldSet.Contains(conPictureResources.OrginialFileHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objPictureResourcesEN.OrginialFileHeight = objPictureResourcesEN.OrginialFileHeight; //OrginialFileHeight
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
 /// <param name = "objPictureResourcesEN">源简化对象</param>
 public static void AccessFldValueNull(clsPictureResourcesEN objPictureResourcesEN)
{
try
{
if (objPictureResourcesEN.Memo == "[null]") objPictureResourcesEN.Memo = null; //备注
if (objPictureResourcesEN.OrginialFileName == "[null]") objPictureResourcesEN.OrginialFileName = null; //OrginialFileName
if (objPictureResourcesEN.PictureConfigerId == "[null]") objPictureResourcesEN.PictureConfigerId = null; //PictureConfigerId
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
public static void CheckPropertyNew(clsPictureResourcesEN objPictureResourcesEN)
{
 PictureResourcesDA.CheckPropertyNew(objPictureResourcesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPictureResourcesEN objPictureResourcesEN)
{
 PictureResourcesDA.CheckProperty4Condition(objPictureResourcesEN);
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
if (clsPictureResourcesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPictureResourcesBL没有刷新缓存机制(clsPictureResourcesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PictureId");
//if (arrPictureResourcesObjLstCache == null)
//{
//arrPictureResourcesObjLstCache = PictureResourcesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intPictureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPictureResourcesEN GetObjByPictureIdCache(int intPictureId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPictureResourcesEN._CurrTabName);
List<clsPictureResourcesEN> arrPictureResourcesObjLstCache = GetObjLstCache();
IEnumerable <clsPictureResourcesEN> arrPictureResourcesObjLst_Sel =
arrPictureResourcesObjLstCache
.Where(x=> x.PictureId == intPictureId 
);
if (arrPictureResourcesObjLst_Sel.Count() == 0)
{
   clsPictureResourcesEN obj = clsPictureResourcesBL.GetObjByPictureId(intPictureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPictureResourcesObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPictureResourcesEN> GetAllPictureResourcesObjLstCache()
{
//获取缓存中的对象列表
List<clsPictureResourcesEN> arrPictureResourcesObjLstCache = GetObjLstCache(); 
return arrPictureResourcesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPictureResourcesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPictureResourcesEN._CurrTabName);
List<clsPictureResourcesEN> arrPictureResourcesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPictureResourcesObjLstCache;
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
string strKey = string.Format("{0}", clsPictureResourcesEN._CurrTabName);
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPictureResourcesBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPictureResourcesEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPictureResourcesBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PictureResources(图片资源)
 /// 唯一性条件:PictureName_PictureConfigerId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPictureResourcesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPictureResourcesEN objPictureResourcesEN)
{
//检测记录是否存在
string strResult = PictureResourcesDA.GetUniCondStr(objPictureResourcesEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, int intPictureId)
{
if (strInFldName != conPictureResources.PictureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPictureResources.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPictureResources.AttributeName));
throw new Exception(strMsg);
}
var objPictureResources = clsPictureResourcesBL.GetObjByPictureIdCache(intPictureId);
if (objPictureResources == null) return "";
return objPictureResources[strOutFldName].ToString();
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
int intRecCount = clsPictureResourcesDA.GetRecCount(strTabName);
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
int intRecCount = clsPictureResourcesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPictureResourcesDA.GetRecCount();
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
int intRecCount = clsPictureResourcesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPictureResourcesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPictureResourcesEN objPictureResourcesCond)
{
List<clsPictureResourcesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPictureResourcesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPictureResources.AttributeName)
{
if (objPictureResourcesCond.IsUpdated(strFldName) == false) continue;
if (objPictureResourcesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPictureResourcesCond[strFldName].ToString());
}
else
{
if (objPictureResourcesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPictureResourcesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPictureResourcesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPictureResourcesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPictureResourcesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPictureResourcesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPictureResourcesCond[strFldName]));
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
 List<string> arrList = clsPictureResourcesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PictureResourcesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PictureResourcesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PictureResourcesDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPictureResourcesDA.SetFldValue(clsPictureResourcesEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PictureResourcesDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPictureResourcesDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPictureResourcesDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPictureResourcesDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PictureResources] "); 
 strCreateTabCode.Append(" ( "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**PictureId*/ 
 strCreateTabCode.Append(" PictureId int primary key identity, "); 
 // /**PictureName*/ 
 strCreateTabCode.Append(" PictureName varchar(100) not Null, "); 
 // /**OrginialFileName*/ 
 strCreateTabCode.Append(" OrginialFileName varchar(100) Null, "); 
 // /**OrginialFileSize*/ 
 strCreateTabCode.Append(" OrginialFileSize int Null, "); 
 // /**ResizePictureSize*/ 
 strCreateTabCode.Append(" ResizePictureSize int Null, "); 
 // /**ThumbSize*/ 
 strCreateTabCode.Append(" ThumbSize int not Null, "); 
 // /**OrginialFileWidth*/ 
 strCreateTabCode.Append(" OrginialFileWidth int not Null, "); 
 // /**PictureConfigerId*/ 
 strCreateTabCode.Append(" PictureConfigerId char(4) Null, "); 
 // /**ResizePictureName*/ 
 strCreateTabCode.Append(" ResizePictureName varchar(100) not Null, "); 
 // /**ThumbName*/ 
 strCreateTabCode.Append(" ThumbName varchar(100) not Null, "); 
 // /**OrginialFileHeight*/ 
 strCreateTabCode.Append(" OrginialFileHeight int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 图片资源(PictureResources)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PictureResources : clsCommFun4BL
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
clsPictureResourcesBL.ReFreshThisCache();
}
}

}