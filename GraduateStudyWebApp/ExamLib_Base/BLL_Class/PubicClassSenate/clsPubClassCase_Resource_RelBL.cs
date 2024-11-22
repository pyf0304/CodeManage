
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCase_Resource_RelBL
 表名:PubClassCase_Resource_Rel(01120408)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsPubClassCase_Resource_RelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCase_Resource_RelEN GetObj(this K_IdPubClassCaseResourceRel_PubClassCase_Resource_Rel myKey)
{
clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.GetObjByIdPubClassCaseResourceRel(myKey.Value);
return objPubClassCase_Resource_RelEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
if (CheckUniqueness(objPubClassCase_Resource_RelEN) == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsPubClassCase_Resource_RelBL.AddNewRecord)", objPubClassCase_Resource_RelEN.IdPubClassCase,objPubClassCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.AddNewRecordBySQL2(objPubClassCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
public static bool AddRecordEx(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
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
objPubClassCase_Resource_RelEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objPubClassCase_Resource_RelEN.CheckUniqueness() == false)
{
strMsg = string.Format("(案例流水号(IdPubClassCase)=[{0}],资源流水号(IdResource)=[{1}])已经存在,不能重复!", objPubClassCase_Resource_RelEN.IdPubClassCase, objPubClassCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPubClassCase_Resource_RelEN.AddNewRecord();
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
 /// <param name = "objPubClassCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
if (CheckUniqueness(objPubClassCase_Resource_RelEN) == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsPubClassCase_Resource_RelBL.AddNewRecordWithReturnKey)", objPubClassCase_Resource_RelEN.IdPubClassCase,objPubClassCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
string strKey = clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.AddNewRecordBySQL2WithReturnKey(objPubClassCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCase_Resource_RelEN SetIdPubClassCaseResourceRel(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, long lngIdPubClassCaseResourceRel, string strComparisonOp="")
	{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = lngIdPubClassCaseResourceRel; //案例与资源关系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel) == false)
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel, strComparisonOp);
}
else
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel] = strComparisonOp;
}
}
return objPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCase_Resource_RelEN SetIdPubClassCase(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, string strIdPubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCase, conPubClassCase_Resource_Rel.IdPubClassCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, conPubClassCase_Resource_Rel.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, conPubClassCase_Resource_Rel.IdPubClassCase);
}
objPubClassCase_Resource_RelEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conPubClassCase_Resource_Rel.IdPubClassCase) == false)
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(conPubClassCase_Resource_Rel.IdPubClassCase, strComparisonOp);
}
else
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp[conPubClassCase_Resource_Rel.IdPubClassCase] = strComparisonOp;
}
}
return objPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCase_Resource_RelEN SetIdResource(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, conPubClassCase_Resource_Rel.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, conPubClassCase_Resource_Rel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, conPubClassCase_Resource_Rel.IdResource);
}
objPubClassCase_Resource_RelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conPubClassCase_Resource_Rel.IdResource) == false)
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(conPubClassCase_Resource_Rel.IdResource, strComparisonOp);
}
else
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp[conPubClassCase_Resource_Rel.IdResource] = strComparisonOp;
}
}
return objPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCase_Resource_RelEN SetIsMain(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objPubClassCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conPubClassCase_Resource_Rel.IsMain) == false)
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(conPubClassCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp[conPubClassCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCase_Resource_RelEN SetIndexNO(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, int? intIndexNO, string strComparisonOp="")
	{
objPubClassCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conPubClassCase_Resource_Rel.IndexNO) == false)
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(conPubClassCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp[conPubClassCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCase_Resource_RelEN SetMemo(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPubClassCase_Resource_Rel.Memo);
}
objPubClassCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conPubClassCase_Resource_Rel.Memo) == false)
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(conPubClassCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp[conPubClassCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCase_Resource_RelEN SetIsVisible(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objPubClassCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conPubClassCase_Resource_Rel.IsVisible) == false)
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(conPubClassCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp[conPubClassCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCase_Resource_RelEN SetBrowseCount(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, int? intBrowseCount, string strComparisonOp="")
	{
objPubClassCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conPubClassCase_Resource_Rel.BrowseCount) == false)
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(conPubClassCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objPubClassCase_Resource_RelEN.dicFldComparisonOp[conPubClassCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objPubClassCase_Resource_RelEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPubClassCase_Resource_RelEN.CheckPropertyNew();
clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelCond = new clsPubClassCase_Resource_RelEN();
string strCondition = objPubClassCase_Resource_RelCond
.SetIdPubClassCaseResourceRel(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "<>")
.SetIdPubClassCase(objPubClassCase_Resource_RelEN.IdPubClassCase, "=")
.SetIdResource(objPubClassCase_Resource_RelEN.IdResource, "=")
.GetCombineCondition();
objPubClassCase_Resource_RelEN._IsCheckProperty = true;
bool bolIsExist = clsPubClassCase_Resource_RelBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_PubClassCase_id_Resource)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPubClassCase_Resource_RelEN.Update();
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
 /// <param name = "objPubClassCase_Resource_Rel">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_Rel)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelCond = new clsPubClassCase_Resource_RelEN();
string strCondition = objPubClassCase_Resource_RelCond
.SetIdPubClassCase(objPubClassCase_Resource_Rel.IdPubClassCase, "=")
.SetIdResource(objPubClassCase_Resource_Rel.IdResource, "=")
.GetCombineCondition();
objPubClassCase_Resource_Rel._IsCheckProperty = true;
bool bolIsExist = clsPubClassCase_Resource_RelBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPubClassCase_Resource_Rel.IdPubClassCaseResourceRel = clsPubClassCase_Resource_RelBL.GetFirstID_S(strCondition);
objPubClassCase_Resource_Rel.UpdateWithCondition(strCondition);
}
else
{
objPubClassCase_Resource_Rel.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
 if (objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.UpdateBySql2(objPubClassCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objPubClassCase_Resource_RelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.UpdateBySql2(objPubClassCase_Resource_RelEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objPubClassCase_Resource_RelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, string strWhereCond)
{
try
{
bool bolResult = clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.UpdateBySqlWithCondition(objPubClassCase_Resource_RelEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objPubClassCase_Resource_RelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.UpdateBySqlWithConditionTransaction(objPubClassCase_Resource_RelEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
 /// <param name = "lngIdPubClassCaseResourceRel">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
try
{
int intRecNum = clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.DelRecord(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objPubClassCase_Resource_RelENS">源对象</param>
 /// <param name = "objPubClassCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelENS, clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelENT)
{
try
{
objPubClassCase_Resource_RelENT.IdPubClassCaseResourceRel = objPubClassCase_Resource_RelENS.IdPubClassCaseResourceRel; //案例与资源关系表流水号
objPubClassCase_Resource_RelENT.IdPubClassCase = objPubClassCase_Resource_RelENS.IdPubClassCase; //案例流水号
objPubClassCase_Resource_RelENT.IdResource = objPubClassCase_Resource_RelENS.IdResource; //资源流水号
objPubClassCase_Resource_RelENT.IsMain = objPubClassCase_Resource_RelENS.IsMain; //是否主资源
objPubClassCase_Resource_RelENT.IndexNO = objPubClassCase_Resource_RelENS.IndexNO; //序号
objPubClassCase_Resource_RelENT.Memo = objPubClassCase_Resource_RelENS.Memo; //备注
objPubClassCase_Resource_RelENT.IsVisible = objPubClassCase_Resource_RelENS.IsVisible; //是否显示
objPubClassCase_Resource_RelENT.BrowseCount = objPubClassCase_Resource_RelENS.BrowseCount; //浏览次数
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
 /// <param name = "objPubClassCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsPubClassCase_Resource_RelEN:objPubClassCase_Resource_RelENT</returns>
 public static clsPubClassCase_Resource_RelEN CopyTo(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelENS)
{
try
{
 clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelENT = new clsPubClassCase_Resource_RelEN()
{
IdPubClassCaseResourceRel = objPubClassCase_Resource_RelENS.IdPubClassCaseResourceRel, //案例与资源关系表流水号
IdPubClassCase = objPubClassCase_Resource_RelENS.IdPubClassCase, //案例流水号
IdResource = objPubClassCase_Resource_RelENS.IdResource, //资源流水号
IsMain = objPubClassCase_Resource_RelENS.IsMain, //是否主资源
IndexNO = objPubClassCase_Resource_RelENS.IndexNO, //序号
Memo = objPubClassCase_Resource_RelENS.Memo, //备注
IsVisible = objPubClassCase_Resource_RelENS.IsVisible, //是否显示
BrowseCount = objPubClassCase_Resource_RelENS.BrowseCount, //浏览次数
};
 return objPubClassCase_Resource_RelENT;
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
public static void CheckPropertyNew(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
 clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.CheckPropertyNew(objPubClassCase_Resource_RelEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
 clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.CheckProperty4Condition(objPubClassCase_Resource_RelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPubClassCase_Resource_RelCond.IsUpdated(conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel) == true)
{
string strComparisonOpIdPubClassCaseResourceRel = objPubClassCase_Resource_RelCond.dicFldComparisonOp[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel, objPubClassCase_Resource_RelCond.IdPubClassCaseResourceRel, strComparisonOpIdPubClassCaseResourceRel);
}
if (objPubClassCase_Resource_RelCond.IsUpdated(conPubClassCase_Resource_Rel.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objPubClassCase_Resource_RelCond.dicFldComparisonOp[conPubClassCase_Resource_Rel.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase_Resource_Rel.IdPubClassCase, objPubClassCase_Resource_RelCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objPubClassCase_Resource_RelCond.IsUpdated(conPubClassCase_Resource_Rel.IdResource) == true)
{
string strComparisonOpIdResource = objPubClassCase_Resource_RelCond.dicFldComparisonOp[conPubClassCase_Resource_Rel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase_Resource_Rel.IdResource, objPubClassCase_Resource_RelCond.IdResource, strComparisonOpIdResource);
}
if (objPubClassCase_Resource_RelCond.IsUpdated(conPubClassCase_Resource_Rel.IsMain) == true)
{
if (objPubClassCase_Resource_RelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCase_Resource_Rel.IsMain);
}
}
if (objPubClassCase_Resource_RelCond.IsUpdated(conPubClassCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOpIndexNO = objPubClassCase_Resource_RelCond.dicFldComparisonOp[conPubClassCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCase_Resource_Rel.IndexNO, objPubClassCase_Resource_RelCond.IndexNO, strComparisonOpIndexNO);
}
if (objPubClassCase_Resource_RelCond.IsUpdated(conPubClassCase_Resource_Rel.Memo) == true)
{
string strComparisonOpMemo = objPubClassCase_Resource_RelCond.dicFldComparisonOp[conPubClassCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase_Resource_Rel.Memo, objPubClassCase_Resource_RelCond.Memo, strComparisonOpMemo);
}
if (objPubClassCase_Resource_RelCond.IsUpdated(conPubClassCase_Resource_Rel.IsVisible) == true)
{
if (objPubClassCase_Resource_RelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCase_Resource_Rel.IsVisible);
}
}
if (objPubClassCase_Resource_RelCond.IsUpdated(conPubClassCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objPubClassCase_Resource_RelCond.dicFldComparisonOp[conPubClassCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCase_Resource_Rel.BrowseCount, objPubClassCase_Resource_RelCond.BrowseCount, strComparisonOpBrowseCount);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PubClassCase_Resource_Rel(案例与资源关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_PubClassCase_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPubClassCase_Resource_RelEN == null) return true;
if (objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCase_Resource_RelEN.IdPubClassCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objPubClassCase_Resource_RelEN.IdResource);
if (clsPubClassCase_Resource_RelBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdPubClassCaseResourceRel !=  {0}", objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel);
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCase_Resource_RelEN.IdPubClassCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objPubClassCase_Resource_RelEN.IdResource);
if (clsPubClassCase_Resource_RelBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PubClassCase_Resource_Rel(案例与资源关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_PubClassCase_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPubClassCase_Resource_RelEN == null) return "";
if (objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCase_Resource_RelEN.IdPubClassCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objPubClassCase_Resource_RelEN.IdResource);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdPubClassCaseResourceRel !=  {0}", objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel);
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCase_Resource_RelEN.IdPubClassCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objPubClassCase_Resource_RelEN.IdResource);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PubClassCase_Resource_Rel
{
public virtual bool UpdRelaTabDate(long lngIdPubClassCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例与资源关系(PubClassCase_Resource_Rel)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPubClassCase_Resource_RelBL
{
public static RelatedActions_PubClassCase_Resource_Rel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPubClassCase_Resource_RelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPubClassCase_Resource_RelDA PubClassCase_Resource_RelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPubClassCase_Resource_RelDA();
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
 public clsPubClassCase_Resource_RelBL()
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
if (string.IsNullOrEmpty(clsPubClassCase_Resource_RelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPubClassCase_Resource_RelEN._ConnectString);
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
public static DataTable GetDataTable_PubClassCase_Resource_Rel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PubClassCase_Resource_RelDA.GetDataTable_PubClassCase_Resource_Rel(strWhereCond);
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
objDT = PubClassCase_Resource_RelDA.GetDataTable(strWhereCond);
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
objDT = PubClassCase_Resource_RelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PubClassCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PubClassCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PubClassCase_Resource_RelDA.GetDataTable_Top(objTopPara);
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
objDT = PubClassCase_Resource_RelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PubClassCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PubClassCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubClassCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPubClassCase_Resource_RelEN> GetObjLstByIdPubClassCaseResourceRelLst(List<long> arrIdPubClassCaseResourceRelLst)
{
List<clsPubClassCase_Resource_RelEN> arrObjLst = new List<clsPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseResourceRelLst);
 string strWhereCond = string.Format("IdPubClassCaseResourceRel in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = new clsPubClassCase_Resource_RelEN();
try
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objPubClassCase_Resource_RelEN.IdPubClassCase = objRow[conPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCase_Resource_RelEN.IdResource = objRow[conPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objPubClassCase_Resource_RelEN.IndexNO = objRow[conPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objPubClassCase_Resource_RelEN.Memo = objRow[conPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objPubClassCase_Resource_RelEN.BrowseCount = objRow[conPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPubClassCase_Resource_RelEN> GetObjLstByIdPubClassCaseResourceRelLstCache(List<long> arrIdPubClassCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsPubClassCase_Resource_RelEN._CurrTabName);
List<clsPubClassCase_Resource_RelEN> arrPubClassCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCase_Resource_RelEN> arrPubClassCase_Resource_RelObjLst_Sel =
arrPubClassCase_Resource_RelObjLstCache
.Where(x => arrIdPubClassCaseResourceRelLst.Contains(x.IdPubClassCaseResourceRel));
return arrPubClassCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
List<clsPubClassCase_Resource_RelEN> arrObjLst = new List<clsPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = new clsPubClassCase_Resource_RelEN();
try
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objPubClassCase_Resource_RelEN.IdPubClassCase = objRow[conPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCase_Resource_RelEN.IdResource = objRow[conPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objPubClassCase_Resource_RelEN.IndexNO = objRow[conPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objPubClassCase_Resource_RelEN.Memo = objRow[conPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objPubClassCase_Resource_RelEN.BrowseCount = objRow[conPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCase_Resource_RelEN);
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
public static List<clsPubClassCase_Resource_RelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPubClassCase_Resource_RelEN> arrObjLst = new List<clsPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = new clsPubClassCase_Resource_RelEN();
try
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objPubClassCase_Resource_RelEN.IdPubClassCase = objRow[conPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCase_Resource_RelEN.IdResource = objRow[conPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objPubClassCase_Resource_RelEN.IndexNO = objRow[conPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objPubClassCase_Resource_RelEN.Memo = objRow[conPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objPubClassCase_Resource_RelEN.BrowseCount = objRow[conPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPubClassCase_Resource_RelEN> GetSubObjLstCache(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelCond)
{
List<clsPubClassCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPubClassCase_Resource_Rel.AttributeName)
{
if (objPubClassCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objPubClassCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objPubClassCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPubClassCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPubClassCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPubClassCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPubClassCase_Resource_RelCond[strFldName]));
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
public static List<clsPubClassCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPubClassCase_Resource_RelEN> arrObjLst = new List<clsPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = new clsPubClassCase_Resource_RelEN();
try
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objPubClassCase_Resource_RelEN.IdPubClassCase = objRow[conPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCase_Resource_RelEN.IdResource = objRow[conPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objPubClassCase_Resource_RelEN.IndexNO = objRow[conPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objPubClassCase_Resource_RelEN.Memo = objRow[conPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objPubClassCase_Resource_RelEN.BrowseCount = objRow[conPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCase_Resource_RelEN);
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
public static List<clsPubClassCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPubClassCase_Resource_RelEN> arrObjLst = new List<clsPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = new clsPubClassCase_Resource_RelEN();
try
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objPubClassCase_Resource_RelEN.IdPubClassCase = objRow[conPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCase_Resource_RelEN.IdResource = objRow[conPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objPubClassCase_Resource_RelEN.IndexNO = objRow[conPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objPubClassCase_Resource_RelEN.Memo = objRow[conPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objPubClassCase_Resource_RelEN.BrowseCount = objRow[conPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCase_Resource_RelEN);
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
List<clsPubClassCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPubClassCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPubClassCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPubClassCase_Resource_RelEN> arrObjLst = new List<clsPubClassCase_Resource_RelEN>(); 
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
	clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = new clsPubClassCase_Resource_RelEN();
try
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objPubClassCase_Resource_RelEN.IdPubClassCase = objRow[conPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCase_Resource_RelEN.IdResource = objRow[conPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objPubClassCase_Resource_RelEN.IndexNO = objRow[conPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objPubClassCase_Resource_RelEN.Memo = objRow[conPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objPubClassCase_Resource_RelEN.BrowseCount = objRow[conPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCase_Resource_RelEN);
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
public static List<clsPubClassCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPubClassCase_Resource_RelEN> arrObjLst = new List<clsPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = new clsPubClassCase_Resource_RelEN();
try
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objPubClassCase_Resource_RelEN.IdPubClassCase = objRow[conPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCase_Resource_RelEN.IdResource = objRow[conPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objPubClassCase_Resource_RelEN.IndexNO = objRow[conPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objPubClassCase_Resource_RelEN.Memo = objRow[conPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objPubClassCase_Resource_RelEN.BrowseCount = objRow[conPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPubClassCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPubClassCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPubClassCase_Resource_RelEN> arrObjLst = new List<clsPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = new clsPubClassCase_Resource_RelEN();
try
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objPubClassCase_Resource_RelEN.IdPubClassCase = objRow[conPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCase_Resource_RelEN.IdResource = objRow[conPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objPubClassCase_Resource_RelEN.IndexNO = objRow[conPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objPubClassCase_Resource_RelEN.Memo = objRow[conPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objPubClassCase_Resource_RelEN.BrowseCount = objRow[conPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCase_Resource_RelEN);
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
public static List<clsPubClassCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPubClassCase_Resource_RelEN> arrObjLst = new List<clsPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = new clsPubClassCase_Resource_RelEN();
try
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objPubClassCase_Resource_RelEN.IdPubClassCase = objRow[conPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCase_Resource_RelEN.IdResource = objRow[conPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objPubClassCase_Resource_RelEN.IndexNO = objRow[conPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objPubClassCase_Resource_RelEN.Memo = objRow[conPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objPubClassCase_Resource_RelEN.BrowseCount = objRow[conPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCase_Resource_RelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPubClassCase_Resource_RelEN> arrObjLst = new List<clsPubClassCase_Resource_RelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = new clsPubClassCase_Resource_RelEN();
try
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objPubClassCase_Resource_RelEN.IdPubClassCase = objRow[conPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCase_Resource_RelEN.IdResource = objRow[conPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objPubClassCase_Resource_RelEN.IndexNO = objRow[conPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objPubClassCase_Resource_RelEN.Memo = objRow[conPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objPubClassCase_Resource_RelEN.BrowseCount = objRow[conPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPubClassCase_Resource_Rel(ref clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
bool bolResult = PubClassCase_Resource_RelDA.GetPubClassCase_Resource_Rel(ref objPubClassCase_Resource_RelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCase_Resource_RelEN GetObjByIdPubClassCaseResourceRel(long lngIdPubClassCaseResourceRel)
{
clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = PubClassCase_Resource_RelDA.GetObjByIdPubClassCaseResourceRel(lngIdPubClassCaseResourceRel);
return objPubClassCase_Resource_RelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPubClassCase_Resource_RelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = PubClassCase_Resource_RelDA.GetFirstObj(strWhereCond);
 return objPubClassCase_Resource_RelEN;
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
public static clsPubClassCase_Resource_RelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = PubClassCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objPubClassCase_Resource_RelEN;
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
public static clsPubClassCase_Resource_RelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = PubClassCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objPubClassCase_Resource_RelEN;
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
 /// <param name = "lngIdPubClassCaseResourceRel">所给的关键字</param>
 /// <param name = "lstPubClassCase_Resource_RelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCase_Resource_RelEN GetObjByIdPubClassCaseResourceRelFromList(long lngIdPubClassCaseResourceRel, List<clsPubClassCase_Resource_RelEN> lstPubClassCase_Resource_RelObjLst)
{
foreach (clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN in lstPubClassCase_Resource_RelObjLst)
{
if (objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel == lngIdPubClassCaseResourceRel)
{
return objPubClassCase_Resource_RelEN;
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
 long lngIdPubClassCaseResourceRel;
 try
 {
 lngIdPubClassCaseResourceRel = new clsPubClassCase_Resource_RelDA().GetFirstID(strWhereCond);
 return lngIdPubClassCaseResourceRel;
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
 arrList = PubClassCase_Resource_RelDA.GetID(strWhereCond);
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
bool bolIsExist = PubClassCase_Resource_RelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdPubClassCaseResourceRel)
{
//检测记录是否存在
bool bolIsExist = PubClassCase_Resource_RelDA.IsExist(lngIdPubClassCaseResourceRel);
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
 bolIsExist = clsPubClassCase_Resource_RelDA.IsExistTable();
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
 bolIsExist = PubClassCase_Resource_RelDA.IsExistTable(strTabName);
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
 /// <param name = "objPubClassCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
if (objPubClassCase_Resource_RelEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsPubClassCase_Resource_RelBL.AddNewRecordBySql2)", objPubClassCase_Resource_RelEN.IdPubClassCase,objPubClassCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
bool bolResult = PubClassCase_Resource_RelDA.AddNewRecordBySQL2(objPubClassCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objPubClassCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
if (objPubClassCase_Resource_RelEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsPubClassCase_Resource_RelBL.AddNewRecordBySql2WithReturnKey)", objPubClassCase_Resource_RelEN.IdPubClassCase,objPubClassCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
string strKey = PubClassCase_Resource_RelDA.AddNewRecordBySQL2WithReturnKey(objPubClassCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objPubClassCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
try
{
bool bolResult = PubClassCase_Resource_RelDA.Update(objPubClassCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objPubClassCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
 if (objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PubClassCase_Resource_RelDA.UpdateBySql2(objPubClassCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCase_Resource_RelBL.ReFreshCache();

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
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
 /// <param name = "lngIdPubClassCaseResourceRel">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdPubClassCaseResourceRel)
{
try
{
 clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = clsPubClassCase_Resource_RelBL.GetObjByIdPubClassCaseResourceRel(lngIdPubClassCaseResourceRel);

if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, "SetUpdDate");
}
if (objPubClassCase_Resource_RelEN != null)
{
int intRecNum = PubClassCase_Resource_RelDA.DelRecord(lngIdPubClassCaseResourceRel);
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
/// <param name="lngIdPubClassCaseResourceRel">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdPubClassCaseResourceRel )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPubClassCase_Resource_RelDA.GetSpecSQLObj();
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
//删除与表:[PubClassCase_Resource_Rel]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel,
//lngIdPubClassCaseResourceRel);
//        clsPubClassCase_Resource_RelBL.DelPubClassCase_Resource_RelsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPubClassCase_Resource_RelBL.DelRecord(lngIdPubClassCaseResourceRel, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPubClassCase_Resource_RelBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdPubClassCaseResourceRel, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdPubClassCaseResourceRel">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdPubClassCaseResourceRel, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(lngIdPubClassCaseResourceRel, "UpdRelaTabDate");
}
bool bolResult = PubClassCase_Resource_RelDA.DelRecord(lngIdPubClassCaseResourceRel,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdPubClassCaseResourceRelLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPubClassCase_Resource_Rels(List<string> arrIdPubClassCaseResourceRelLst)
{
if (arrIdPubClassCaseResourceRelLst.Count == 0) return 0;
try
{
if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
foreach (var strIdPubClassCaseResourceRel in arrIdPubClassCaseResourceRelLst)
{
long lngIdPubClassCaseResourceRel = long.Parse(strIdPubClassCaseResourceRel);
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(lngIdPubClassCaseResourceRel, "UpdRelaTabDate");
}
}
int intDelRecNum = PubClassCase_Resource_RelDA.DelPubClassCase_Resource_Rel(arrIdPubClassCaseResourceRelLst);
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
public static int DelPubClassCase_Resource_RelsByCond(string strWhereCond)
{
try
{
if (clsPubClassCase_Resource_RelBL.relatedActions != null)
{
List<string> arrIdPubClassCaseResourceRel = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdPubClassCaseResourceRel in arrIdPubClassCaseResourceRel)
{
long lngIdPubClassCaseResourceRel = long.Parse(strIdPubClassCaseResourceRel);
clsPubClassCase_Resource_RelBL.relatedActions.UpdRelaTabDate(lngIdPubClassCaseResourceRel, "UpdRelaTabDate");
}
}
int intRecNum = PubClassCase_Resource_RelDA.DelPubClassCase_Resource_Rel(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PubClassCase_Resource_Rel]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdPubClassCaseResourceRel">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdPubClassCaseResourceRel)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPubClassCase_Resource_RelDA.GetSpecSQLObj();
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
//删除与表:[PubClassCase_Resource_Rel]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPubClassCase_Resource_RelBL.DelRecord(lngIdPubClassCaseResourceRel, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPubClassCase_Resource_RelBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdPubClassCaseResourceRel, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPubClassCase_Resource_RelENS">源对象</param>
 /// <param name = "objPubClassCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelENS, clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelENT)
{
try
{
objPubClassCase_Resource_RelENT.IdPubClassCaseResourceRel = objPubClassCase_Resource_RelENS.IdPubClassCaseResourceRel; //案例与资源关系表流水号
objPubClassCase_Resource_RelENT.IdPubClassCase = objPubClassCase_Resource_RelENS.IdPubClassCase; //案例流水号
objPubClassCase_Resource_RelENT.IdResource = objPubClassCase_Resource_RelENS.IdResource; //资源流水号
objPubClassCase_Resource_RelENT.IsMain = objPubClassCase_Resource_RelENS.IsMain; //是否主资源
objPubClassCase_Resource_RelENT.IndexNO = objPubClassCase_Resource_RelENS.IndexNO; //序号
objPubClassCase_Resource_RelENT.Memo = objPubClassCase_Resource_RelENS.Memo; //备注
objPubClassCase_Resource_RelENT.IsVisible = objPubClassCase_Resource_RelENS.IsVisible; //是否显示
objPubClassCase_Resource_RelENT.BrowseCount = objPubClassCase_Resource_RelENS.BrowseCount; //浏览次数
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
 /// <param name = "objPubClassCase_Resource_RelEN">源简化对象</param>
 public static void SetUpdFlag(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
try
{
objPubClassCase_Resource_RelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPubClassCase_Resource_RelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = objPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel; //案例与资源关系表流水号
}
if (arrFldSet.Contains(conPubClassCase_Resource_Rel.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCase_Resource_RelEN.IdPubClassCase = objPubClassCase_Resource_RelEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(conPubClassCase_Resource_Rel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCase_Resource_RelEN.IdResource = objPubClassCase_Resource_RelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(conPubClassCase_Resource_Rel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCase_Resource_RelEN.IsMain = objPubClassCase_Resource_RelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(conPubClassCase_Resource_Rel.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCase_Resource_RelEN.IndexNO = objPubClassCase_Resource_RelEN.IndexNO; //序号
}
if (arrFldSet.Contains(conPubClassCase_Resource_Rel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCase_Resource_RelEN.Memo = objPubClassCase_Resource_RelEN.Memo == "[null]" ? null :  objPubClassCase_Resource_RelEN.Memo; //备注
}
if (arrFldSet.Contains(conPubClassCase_Resource_Rel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCase_Resource_RelEN.IsVisible = objPubClassCase_Resource_RelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conPubClassCase_Resource_Rel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCase_Resource_RelEN.BrowseCount = objPubClassCase_Resource_RelEN.BrowseCount; //浏览次数
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
 /// <param name = "objPubClassCase_Resource_RelEN">源简化对象</param>
 public static void AccessFldValueNull(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
try
{
if (objPubClassCase_Resource_RelEN.Memo == "[null]") objPubClassCase_Resource_RelEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
 PubClassCase_Resource_RelDA.CheckPropertyNew(objPubClassCase_Resource_RelEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
 PubClassCase_Resource_RelDA.CheckProperty4Condition(objPubClassCase_Resource_RelEN);
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
if (clsPubClassCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCase_Resource_RelBL没有刷新缓存机制(clsPubClassCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCaseResourceRel");
//if (arrPubClassCase_Resource_RelObjLstCache == null)
//{
//arrPubClassCase_Resource_RelObjLstCache = PubClassCase_Resource_RelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCase_Resource_RelEN GetObjByIdPubClassCaseResourceRelCache(long lngIdPubClassCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPubClassCase_Resource_RelEN._CurrTabName);
List<clsPubClassCase_Resource_RelEN> arrPubClassCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCase_Resource_RelEN> arrPubClassCase_Resource_RelObjLst_Sel =
arrPubClassCase_Resource_RelObjLstCache
.Where(x=> x.IdPubClassCaseResourceRel == lngIdPubClassCaseResourceRel 
);
if (arrPubClassCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsPubClassCase_Resource_RelEN obj = clsPubClassCase_Resource_RelBL.GetObjByIdPubClassCaseResourceRel(lngIdPubClassCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPubClassCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCase_Resource_RelEN> GetAllPubClassCase_Resource_RelObjLstCache()
{
//获取缓存中的对象列表
List<clsPubClassCase_Resource_RelEN> arrPubClassCase_Resource_RelObjLstCache = GetObjLstCache(); 
return arrPubClassCase_Resource_RelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCase_Resource_RelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPubClassCase_Resource_RelEN._CurrTabName);
List<clsPubClassCase_Resource_RelEN> arrPubClassCase_Resource_RelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPubClassCase_Resource_RelObjLstCache;
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
string strKey = string.Format("{0}", clsPubClassCase_Resource_RelEN._CurrTabName);
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
if (clsPubClassCase_Resource_RelBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPubClassCase_Resource_RelEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPubClassCase_Resource_RelBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PubClassCase_Resource_Rel(案例与资源关系)
 /// 唯一性条件:id_PubClassCase_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN)
{
//检测记录是否存在
string strResult = PubClassCase_Resource_RelDA.GetUniCondStr(objPubClassCase_Resource_RelEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdPubClassCaseResourceRel)
{
if (strInFldName != conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPubClassCase_Resource_Rel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPubClassCase_Resource_Rel.AttributeName));
throw new Exception(strMsg);
}
var objPubClassCase_Resource_Rel = clsPubClassCase_Resource_RelBL.GetObjByIdPubClassCaseResourceRelCache(lngIdPubClassCaseResourceRel);
if (objPubClassCase_Resource_Rel == null) return "";
return objPubClassCase_Resource_Rel[strOutFldName].ToString();
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
int intRecCount = clsPubClassCase_Resource_RelDA.GetRecCount(strTabName);
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
int intRecCount = clsPubClassCase_Resource_RelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPubClassCase_Resource_RelDA.GetRecCount();
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
int intRecCount = clsPubClassCase_Resource_RelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelCond)
{
List<clsPubClassCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPubClassCase_Resource_Rel.AttributeName)
{
if (objPubClassCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objPubClassCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objPubClassCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPubClassCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPubClassCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPubClassCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPubClassCase_Resource_RelCond[strFldName]));
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
 List<string> arrList = clsPubClassCase_Resource_RelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PubClassCase_Resource_RelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PubClassCase_Resource_RelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PubClassCase_Resource_RelDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPubClassCase_Resource_RelDA.SetFldValue(clsPubClassCase_Resource_RelEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PubClassCase_Resource_RelDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPubClassCase_Resource_RelDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPubClassCase_Resource_RelDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPubClassCase_Resource_RelDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PubClassCase_Resource_Rel] "); 
 strCreateTabCode.Append(" ( "); 
 // /**案例与资源关系表流水号*/ 
 strCreateTabCode.Append(" IdPubClassCaseResourceRel bigint primary key identity, "); 
 // /**案例流水号*/ 
 strCreateTabCode.Append(" IdPubClassCase char(8) not Null, "); 
 // /**资源流水号*/ 
 strCreateTabCode.Append(" IdResource char(8) not Null, "); 
 // /**是否主资源*/ 
 strCreateTabCode.Append(" IsMain bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" IndexNO int Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 案例与资源关系(PubClassCase_Resource_Rel)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PubClassCase_Resource_Rel : clsCommFun4BL
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
clsPubClassCase_Resource_RelBL.ReFreshThisCache();
}
}

}