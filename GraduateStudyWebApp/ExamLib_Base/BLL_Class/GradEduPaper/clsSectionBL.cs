
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSectionBL
 表名:Section(01120558)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsSectionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSectionEN GetObj(this K_SectionId_Section myKey)
{
clsSectionEN objSectionEN = clsSectionBL.SectionDA.GetObjBySectionId(myKey.Value);
return objSectionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSectionEN objSectionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSectionEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],节名 = [{1}]的数据已经存在!(in clsSectionBL.AddNewRecord)", objSectionEN.PaperId,objSectionEN.SectionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSectionEN.SectionId) == true || clsSectionBL.IsExist(objSectionEN.SectionId) == true)
 {
     objSectionEN.SectionId = clsSectionBL.GetMaxStrId_S();
 }
bool bolResult = clsSectionBL.SectionDA.AddNewRecordBySQL2(objSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
public static bool AddRecordEx(this clsSectionEN objSectionEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSectionBL.IsExist(objSectionEN.SectionId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSectionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSectionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(论文Id(PaperId)=[{0}],节名(SectionName)=[{1}])已经存在,不能重复!", objSectionEN.PaperId, objSectionEN.SectionName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSectionEN.SectionId) == true || clsSectionBL.IsExist(objSectionEN.SectionId) == true)
 {
     objSectionEN.SectionId = clsSectionBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSectionEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objSectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSectionEN objSectionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSectionEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],节名 = [{1}]的数据已经存在!(in clsSectionBL.AddNewRecordWithMaxId)", objSectionEN.PaperId,objSectionEN.SectionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSectionEN.SectionId) == true || clsSectionBL.IsExist(objSectionEN.SectionId) == true)
 {
     objSectionEN.SectionId = clsSectionBL.GetMaxStrId_S();
 }
string strSectionId = clsSectionBL.SectionDA.AddNewRecordBySQL2WithReturnKey(objSectionEN);
     objSectionEN.SectionId = strSectionId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
}
return strSectionId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objSectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSectionEN objSectionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSectionEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],节名 = [{1}]的数据已经存在!(in clsSectionBL.AddNewRecordWithReturnKey)", objSectionEN.PaperId,objSectionEN.SectionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSectionEN.SectionId) == true || clsSectionBL.IsExist(objSectionEN.SectionId) == true)
 {
     objSectionEN.SectionId = clsSectionBL.GetMaxStrId_S();
 }
string strKey = clsSectionBL.SectionDA.AddNewRecordBySQL2WithReturnKey(objSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
 /// <param name = "objSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSectionEN SetSectionId(this clsSectionEN objSectionEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, conSection.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, conSection.SectionId);
}
objSectionEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSectionEN.dicFldComparisonOp.ContainsKey(conSection.SectionId) == false)
{
objSectionEN.dicFldComparisonOp.Add(conSection.SectionId, strComparisonOp);
}
else
{
objSectionEN.dicFldComparisonOp[conSection.SectionId] = strComparisonOp;
}
}
return objSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSectionEN SetSectionName(this clsSectionEN objSectionEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, conSection.SectionName);
}
objSectionEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSectionEN.dicFldComparisonOp.ContainsKey(conSection.SectionName) == false)
{
objSectionEN.dicFldComparisonOp.Add(conSection.SectionName, strComparisonOp);
}
else
{
objSectionEN.dicFldComparisonOp[conSection.SectionName] = strComparisonOp;
}
}
return objSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSectionEN SetPaperId(this clsSectionEN objSectionEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, conSection.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conSection.PaperId);
}
objSectionEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSectionEN.dicFldComparisonOp.ContainsKey(conSection.PaperId) == false)
{
objSectionEN.dicFldComparisonOp.Add(conSection.PaperId, strComparisonOp);
}
else
{
objSectionEN.dicFldComparisonOp[conSection.PaperId] = strComparisonOp;
}
}
return objSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSectionEN SetParentId(this clsSectionEN objSectionEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, conSection.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, conSection.ParentId);
}
objSectionEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSectionEN.dicFldComparisonOp.ContainsKey(conSection.ParentId) == false)
{
objSectionEN.dicFldComparisonOp.Add(conSection.ParentId, strComparisonOp);
}
else
{
objSectionEN.dicFldComparisonOp[conSection.ParentId] = strComparisonOp;
}
}
return objSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSectionEN SetOrderNum(this clsSectionEN objSectionEN, int? intOrderNum, string strComparisonOp="")
	{
objSectionEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSectionEN.dicFldComparisonOp.ContainsKey(conSection.OrderNum) == false)
{
objSectionEN.dicFldComparisonOp.Add(conSection.OrderNum, strComparisonOp);
}
else
{
objSectionEN.dicFldComparisonOp[conSection.OrderNum] = strComparisonOp;
}
}
return objSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSectionEN SetUpdDate(this clsSectionEN objSectionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSection.UpdDate);
}
objSectionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSectionEN.dicFldComparisonOp.ContainsKey(conSection.UpdDate) == false)
{
objSectionEN.dicFldComparisonOp.Add(conSection.UpdDate, strComparisonOp);
}
else
{
objSectionEN.dicFldComparisonOp[conSection.UpdDate] = strComparisonOp;
}
}
return objSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSectionEN SetUpdUser(this clsSectionEN objSectionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conSection.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSection.UpdUser);
}
objSectionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSectionEN.dicFldComparisonOp.ContainsKey(conSection.UpdUser) == false)
{
objSectionEN.dicFldComparisonOp.Add(conSection.UpdUser, strComparisonOp);
}
else
{
objSectionEN.dicFldComparisonOp[conSection.UpdUser] = strComparisonOp;
}
}
return objSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSectionEN SetMemo(this clsSectionEN objSectionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSection.Memo);
}
objSectionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSectionEN.dicFldComparisonOp.ContainsKey(conSection.Memo) == false)
{
objSectionEN.dicFldComparisonOp.Add(conSection.Memo, strComparisonOp);
}
else
{
objSectionEN.dicFldComparisonOp[conSection.Memo] = strComparisonOp;
}
}
return objSectionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSectionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSectionEN objSectionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSectionEN.CheckPropertyNew();
clsSectionEN objSectionCond = new clsSectionEN();
string strCondition = objSectionCond
.SetSectionId(objSectionEN.SectionId, "<>")
.SetPaperId(objSectionEN.PaperId, "=")
.SetSectionName(objSectionEN.SectionName, "=")
.GetCombineCondition();
objSectionEN._IsCheckProperty = true;
bool bolIsExist = clsSectionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperId_SectionName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSectionEN.Update();
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
 /// <param name = "objSection">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSectionEN objSection)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSectionEN objSectionCond = new clsSectionEN();
string strCondition = objSectionCond
.SetPaperId(objSection.PaperId, "=")
.SetSectionName(objSection.SectionName, "=")
.GetCombineCondition();
objSection._IsCheckProperty = true;
bool bolIsExist = clsSectionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSection.SectionId = clsSectionBL.GetFirstID_S(strCondition);
objSection.UpdateWithCondition(strCondition);
}
else
{
objSection.SectionId = clsSectionBL.GetMaxStrId_S();
objSection.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSectionEN objSectionEN)
{
 if (string.IsNullOrEmpty(objSectionEN.SectionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSectionBL.SectionDA.UpdateBySql2(objSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
 /// <param name = "objSectionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSectionEN objSectionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSectionEN.SectionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSectionBL.SectionDA.UpdateBySql2(objSectionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
 /// <param name = "objSectionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSectionEN objSectionEN, string strWhereCond)
{
try
{
bool bolResult = clsSectionBL.SectionDA.UpdateBySqlWithCondition(objSectionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
 /// <param name = "objSectionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSectionEN objSectionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSectionBL.SectionDA.UpdateBySqlWithConditionTransaction(objSectionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
 /// <param name = "strSectionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSectionEN objSectionEN)
{
try
{
int intRecNum = clsSectionBL.SectionDA.DelRecord(objSectionEN.SectionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
 /// <param name = "objSectionENS">源对象</param>
 /// <param name = "objSectionENT">目标对象</param>
 public static void CopyTo(this clsSectionEN objSectionENS, clsSectionEN objSectionENT)
{
try
{
objSectionENT.SectionId = objSectionENS.SectionId; //节Id
objSectionENT.SectionName = objSectionENS.SectionName; //节名
objSectionENT.PaperId = objSectionENS.PaperId; //论文Id
objSectionENT.ParentId = objSectionENS.ParentId; //父节点Id
objSectionENT.OrderNum = objSectionENS.OrderNum; //序号
objSectionENT.UpdDate = objSectionENS.UpdDate; //修改日期
objSectionENT.UpdUser = objSectionENS.UpdUser; //修改人
objSectionENT.Memo = objSectionENS.Memo; //备注
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
 /// <param name = "objSectionENS">源对象</param>
 /// <returns>目标对象=>clsSectionEN:objSectionENT</returns>
 public static clsSectionEN CopyTo(this clsSectionEN objSectionENS)
{
try
{
 clsSectionEN objSectionENT = new clsSectionEN()
{
SectionId = objSectionENS.SectionId, //节Id
SectionName = objSectionENS.SectionName, //节名
PaperId = objSectionENS.PaperId, //论文Id
ParentId = objSectionENS.ParentId, //父节点Id
OrderNum = objSectionENS.OrderNum, //序号
UpdDate = objSectionENS.UpdDate, //修改日期
UpdUser = objSectionENS.UpdUser, //修改人
Memo = objSectionENS.Memo, //备注
};
 return objSectionENT;
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
public static void CheckPropertyNew(this clsSectionEN objSectionEN)
{
 clsSectionBL.SectionDA.CheckPropertyNew(objSectionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSectionEN objSectionEN)
{
 clsSectionBL.SectionDA.CheckProperty4Condition(objSectionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSectionEN objSectionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSectionCond.IsUpdated(conSection.SectionId) == true)
{
string strComparisonOpSectionId = objSectionCond.dicFldComparisonOp[conSection.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSection.SectionId, objSectionCond.SectionId, strComparisonOpSectionId);
}
if (objSectionCond.IsUpdated(conSection.SectionName) == true)
{
string strComparisonOpSectionName = objSectionCond.dicFldComparisonOp[conSection.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSection.SectionName, objSectionCond.SectionName, strComparisonOpSectionName);
}
if (objSectionCond.IsUpdated(conSection.PaperId) == true)
{
string strComparisonOpPaperId = objSectionCond.dicFldComparisonOp[conSection.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSection.PaperId, objSectionCond.PaperId, strComparisonOpPaperId);
}
if (objSectionCond.IsUpdated(conSection.ParentId) == true)
{
string strComparisonOpParentId = objSectionCond.dicFldComparisonOp[conSection.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSection.ParentId, objSectionCond.ParentId, strComparisonOpParentId);
}
if (objSectionCond.IsUpdated(conSection.OrderNum) == true)
{
string strComparisonOpOrderNum = objSectionCond.dicFldComparisonOp[conSection.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSection.OrderNum, objSectionCond.OrderNum, strComparisonOpOrderNum);
}
if (objSectionCond.IsUpdated(conSection.UpdDate) == true)
{
string strComparisonOpUpdDate = objSectionCond.dicFldComparisonOp[conSection.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSection.UpdDate, objSectionCond.UpdDate, strComparisonOpUpdDate);
}
if (objSectionCond.IsUpdated(conSection.UpdUser) == true)
{
string strComparisonOpUpdUser = objSectionCond.dicFldComparisonOp[conSection.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSection.UpdUser, objSectionCond.UpdUser, strComparisonOpUpdUser);
}
if (objSectionCond.IsUpdated(conSection.Memo) == true)
{
string strComparisonOpMemo = objSectionCond.dicFldComparisonOp[conSection.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSection.Memo, objSectionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Section(论文节表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperId_SectionName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSectionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSectionEN objSectionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSectionEN == null) return true;
if (objSectionEN.SectionId == null || objSectionEN.SectionId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objSectionEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objSectionEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objSectionEN.PaperId);
}
 if (objSectionEN.SectionName == null)
{
 sbCondition.AppendFormat(" and SectionName is null", objSectionEN.SectionName);
}
else
{
 sbCondition.AppendFormat(" and SectionName = '{0}'", objSectionEN.SectionName);
}
if (clsSectionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SectionId !=  '{0}'", objSectionEN.SectionId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objSectionEN.PaperId);
 sbCondition.AppendFormat(" and SectionName = '{0}'", objSectionEN.SectionName);
if (clsSectionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Section(论文节表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperId_SectionName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSectionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSectionEN objSectionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSectionEN == null) return "";
if (objSectionEN.SectionId == null || objSectionEN.SectionId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objSectionEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objSectionEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objSectionEN.PaperId);
}
 if (objSectionEN.SectionName == null)
{
 sbCondition.AppendFormat(" and SectionName is null", objSectionEN.SectionName);
}
else
{
 sbCondition.AppendFormat(" and SectionName = '{0}'", objSectionEN.SectionName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SectionId !=  '{0}'", objSectionEN.SectionId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objSectionEN.PaperId);
 sbCondition.AppendFormat(" and SectionName = '{0}'", objSectionEN.SectionName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Section
{
public virtual bool UpdRelaTabDate(string strSectionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文节表(Section)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSectionBL
{
public static RelatedActions_Section relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSectionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSectionDA SectionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSectionDA();
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
 public clsSectionBL()
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
if (string.IsNullOrEmpty(clsSectionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSectionEN._ConnectString);
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
public static DataTable GetDataTable_Section(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SectionDA.GetDataTable_Section(strWhereCond);
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
objDT = SectionDA.GetDataTable(strWhereCond);
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
objDT = SectionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SectionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SectionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SectionDA.GetDataTable_Top(objTopPara);
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
objDT = SectionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSectionEN> GetObjLstBySectionIdLst(List<string> arrSectionIdLst)
{
List<clsSectionEN> arrObjLst = new List<clsSectionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSectionIdLst, true);
 string strWhereCond = string.Format("SectionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSectionEN objSectionEN = new clsSectionEN();
try
{
objSectionEN.SectionId = objRow[conSection.SectionId].ToString().Trim(); //节Id
objSectionEN.SectionName = objRow[conSection.SectionName] == DBNull.Value ? null : objRow[conSection.SectionName].ToString().Trim(); //节名
objSectionEN.PaperId = objRow[conSection.PaperId] == DBNull.Value ? null : objRow[conSection.PaperId].ToString().Trim(); //论文Id
objSectionEN.ParentId = objRow[conSection.ParentId] == DBNull.Value ? null : objRow[conSection.ParentId].ToString().Trim(); //父节点Id
objSectionEN.OrderNum = objRow[conSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSection.OrderNum].ToString().Trim()); //序号
objSectionEN.UpdDate = objRow[conSection.UpdDate] == DBNull.Value ? null : objRow[conSection.UpdDate].ToString().Trim(); //修改日期
objSectionEN.UpdUser = objRow[conSection.UpdUser].ToString().Trim(); //修改人
objSectionEN.Memo = objRow[conSection.Memo] == DBNull.Value ? null : objRow[conSection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSectionEN> GetObjLstBySectionIdLstCache(List<string> arrSectionIdLst)
{
string strKey = string.Format("{0}", clsSectionEN._CurrTabName);
List<clsSectionEN> arrSectionObjLstCache = GetObjLstCache();
IEnumerable <clsSectionEN> arrSectionObjLst_Sel =
arrSectionObjLstCache
.Where(x => arrSectionIdLst.Contains(x.SectionId));
return arrSectionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSectionEN> GetObjLst(string strWhereCond)
{
List<clsSectionEN> arrObjLst = new List<clsSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSectionEN objSectionEN = new clsSectionEN();
try
{
objSectionEN.SectionId = objRow[conSection.SectionId].ToString().Trim(); //节Id
objSectionEN.SectionName = objRow[conSection.SectionName] == DBNull.Value ? null : objRow[conSection.SectionName].ToString().Trim(); //节名
objSectionEN.PaperId = objRow[conSection.PaperId] == DBNull.Value ? null : objRow[conSection.PaperId].ToString().Trim(); //论文Id
objSectionEN.ParentId = objRow[conSection.ParentId] == DBNull.Value ? null : objRow[conSection.ParentId].ToString().Trim(); //父节点Id
objSectionEN.OrderNum = objRow[conSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSection.OrderNum].ToString().Trim()); //序号
objSectionEN.UpdDate = objRow[conSection.UpdDate] == DBNull.Value ? null : objRow[conSection.UpdDate].ToString().Trim(); //修改日期
objSectionEN.UpdUser = objRow[conSection.UpdUser].ToString().Trim(); //修改人
objSectionEN.Memo = objRow[conSection.Memo] == DBNull.Value ? null : objRow[conSection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSectionEN);
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
public static List<clsSectionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSectionEN> arrObjLst = new List<clsSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSectionEN objSectionEN = new clsSectionEN();
try
{
objSectionEN.SectionId = objRow[conSection.SectionId].ToString().Trim(); //节Id
objSectionEN.SectionName = objRow[conSection.SectionName] == DBNull.Value ? null : objRow[conSection.SectionName].ToString().Trim(); //节名
objSectionEN.PaperId = objRow[conSection.PaperId] == DBNull.Value ? null : objRow[conSection.PaperId].ToString().Trim(); //论文Id
objSectionEN.ParentId = objRow[conSection.ParentId] == DBNull.Value ? null : objRow[conSection.ParentId].ToString().Trim(); //父节点Id
objSectionEN.OrderNum = objRow[conSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSection.OrderNum].ToString().Trim()); //序号
objSectionEN.UpdDate = objRow[conSection.UpdDate] == DBNull.Value ? null : objRow[conSection.UpdDate].ToString().Trim(); //修改日期
objSectionEN.UpdUser = objRow[conSection.UpdUser].ToString().Trim(); //修改人
objSectionEN.Memo = objRow[conSection.Memo] == DBNull.Value ? null : objRow[conSection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSectionEN> GetSubObjLstCache(clsSectionEN objSectionCond)
{
List<clsSectionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSection.AttributeName)
{
if (objSectionCond.IsUpdated(strFldName) == false) continue;
if (objSectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSectionCond[strFldName].ToString());
}
else
{
if (objSectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSectionCond[strFldName]));
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
public static List<clsSectionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSectionEN> arrObjLst = new List<clsSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSectionEN objSectionEN = new clsSectionEN();
try
{
objSectionEN.SectionId = objRow[conSection.SectionId].ToString().Trim(); //节Id
objSectionEN.SectionName = objRow[conSection.SectionName] == DBNull.Value ? null : objRow[conSection.SectionName].ToString().Trim(); //节名
objSectionEN.PaperId = objRow[conSection.PaperId] == DBNull.Value ? null : objRow[conSection.PaperId].ToString().Trim(); //论文Id
objSectionEN.ParentId = objRow[conSection.ParentId] == DBNull.Value ? null : objRow[conSection.ParentId].ToString().Trim(); //父节点Id
objSectionEN.OrderNum = objRow[conSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSection.OrderNum].ToString().Trim()); //序号
objSectionEN.UpdDate = objRow[conSection.UpdDate] == DBNull.Value ? null : objRow[conSection.UpdDate].ToString().Trim(); //修改日期
objSectionEN.UpdUser = objRow[conSection.UpdUser].ToString().Trim(); //修改人
objSectionEN.Memo = objRow[conSection.Memo] == DBNull.Value ? null : objRow[conSection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSectionEN);
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
public static List<clsSectionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSectionEN> arrObjLst = new List<clsSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSectionEN objSectionEN = new clsSectionEN();
try
{
objSectionEN.SectionId = objRow[conSection.SectionId].ToString().Trim(); //节Id
objSectionEN.SectionName = objRow[conSection.SectionName] == DBNull.Value ? null : objRow[conSection.SectionName].ToString().Trim(); //节名
objSectionEN.PaperId = objRow[conSection.PaperId] == DBNull.Value ? null : objRow[conSection.PaperId].ToString().Trim(); //论文Id
objSectionEN.ParentId = objRow[conSection.ParentId] == DBNull.Value ? null : objRow[conSection.ParentId].ToString().Trim(); //父节点Id
objSectionEN.OrderNum = objRow[conSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSection.OrderNum].ToString().Trim()); //序号
objSectionEN.UpdDate = objRow[conSection.UpdDate] == DBNull.Value ? null : objRow[conSection.UpdDate].ToString().Trim(); //修改日期
objSectionEN.UpdUser = objRow[conSection.UpdUser].ToString().Trim(); //修改人
objSectionEN.Memo = objRow[conSection.Memo] == DBNull.Value ? null : objRow[conSection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSectionEN);
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
List<clsSectionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSectionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSectionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSectionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSectionEN> arrObjLst = new List<clsSectionEN>(); 
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
	clsSectionEN objSectionEN = new clsSectionEN();
try
{
objSectionEN.SectionId = objRow[conSection.SectionId].ToString().Trim(); //节Id
objSectionEN.SectionName = objRow[conSection.SectionName] == DBNull.Value ? null : objRow[conSection.SectionName].ToString().Trim(); //节名
objSectionEN.PaperId = objRow[conSection.PaperId] == DBNull.Value ? null : objRow[conSection.PaperId].ToString().Trim(); //论文Id
objSectionEN.ParentId = objRow[conSection.ParentId] == DBNull.Value ? null : objRow[conSection.ParentId].ToString().Trim(); //父节点Id
objSectionEN.OrderNum = objRow[conSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSection.OrderNum].ToString().Trim()); //序号
objSectionEN.UpdDate = objRow[conSection.UpdDate] == DBNull.Value ? null : objRow[conSection.UpdDate].ToString().Trim(); //修改日期
objSectionEN.UpdUser = objRow[conSection.UpdUser].ToString().Trim(); //修改人
objSectionEN.Memo = objRow[conSection.Memo] == DBNull.Value ? null : objRow[conSection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSectionEN);
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
public static List<clsSectionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSectionEN> arrObjLst = new List<clsSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSectionEN objSectionEN = new clsSectionEN();
try
{
objSectionEN.SectionId = objRow[conSection.SectionId].ToString().Trim(); //节Id
objSectionEN.SectionName = objRow[conSection.SectionName] == DBNull.Value ? null : objRow[conSection.SectionName].ToString().Trim(); //节名
objSectionEN.PaperId = objRow[conSection.PaperId] == DBNull.Value ? null : objRow[conSection.PaperId].ToString().Trim(); //论文Id
objSectionEN.ParentId = objRow[conSection.ParentId] == DBNull.Value ? null : objRow[conSection.ParentId].ToString().Trim(); //父节点Id
objSectionEN.OrderNum = objRow[conSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSection.OrderNum].ToString().Trim()); //序号
objSectionEN.UpdDate = objRow[conSection.UpdDate] == DBNull.Value ? null : objRow[conSection.UpdDate].ToString().Trim(); //修改日期
objSectionEN.UpdUser = objRow[conSection.UpdUser].ToString().Trim(); //修改人
objSectionEN.Memo = objRow[conSection.Memo] == DBNull.Value ? null : objRow[conSection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSectionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSectionEN> arrObjLst = new List<clsSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSectionEN objSectionEN = new clsSectionEN();
try
{
objSectionEN.SectionId = objRow[conSection.SectionId].ToString().Trim(); //节Id
objSectionEN.SectionName = objRow[conSection.SectionName] == DBNull.Value ? null : objRow[conSection.SectionName].ToString().Trim(); //节名
objSectionEN.PaperId = objRow[conSection.PaperId] == DBNull.Value ? null : objRow[conSection.PaperId].ToString().Trim(); //论文Id
objSectionEN.ParentId = objRow[conSection.ParentId] == DBNull.Value ? null : objRow[conSection.ParentId].ToString().Trim(); //父节点Id
objSectionEN.OrderNum = objRow[conSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSection.OrderNum].ToString().Trim()); //序号
objSectionEN.UpdDate = objRow[conSection.UpdDate] == DBNull.Value ? null : objRow[conSection.UpdDate].ToString().Trim(); //修改日期
objSectionEN.UpdUser = objRow[conSection.UpdUser].ToString().Trim(); //修改人
objSectionEN.Memo = objRow[conSection.Memo] == DBNull.Value ? null : objRow[conSection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSectionEN);
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
public static List<clsSectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSectionEN> arrObjLst = new List<clsSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSectionEN objSectionEN = new clsSectionEN();
try
{
objSectionEN.SectionId = objRow[conSection.SectionId].ToString().Trim(); //节Id
objSectionEN.SectionName = objRow[conSection.SectionName] == DBNull.Value ? null : objRow[conSection.SectionName].ToString().Trim(); //节名
objSectionEN.PaperId = objRow[conSection.PaperId] == DBNull.Value ? null : objRow[conSection.PaperId].ToString().Trim(); //论文Id
objSectionEN.ParentId = objRow[conSection.ParentId] == DBNull.Value ? null : objRow[conSection.ParentId].ToString().Trim(); //父节点Id
objSectionEN.OrderNum = objRow[conSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSection.OrderNum].ToString().Trim()); //序号
objSectionEN.UpdDate = objRow[conSection.UpdDate] == DBNull.Value ? null : objRow[conSection.UpdDate].ToString().Trim(); //修改日期
objSectionEN.UpdUser = objRow[conSection.UpdUser].ToString().Trim(); //修改人
objSectionEN.Memo = objRow[conSection.Memo] == DBNull.Value ? null : objRow[conSection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSectionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSectionEN> arrObjLst = new List<clsSectionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSectionEN objSectionEN = new clsSectionEN();
try
{
objSectionEN.SectionId = objRow[conSection.SectionId].ToString().Trim(); //节Id
objSectionEN.SectionName = objRow[conSection.SectionName] == DBNull.Value ? null : objRow[conSection.SectionName].ToString().Trim(); //节名
objSectionEN.PaperId = objRow[conSection.PaperId] == DBNull.Value ? null : objRow[conSection.PaperId].ToString().Trim(); //论文Id
objSectionEN.ParentId = objRow[conSection.ParentId] == DBNull.Value ? null : objRow[conSection.ParentId].ToString().Trim(); //父节点Id
objSectionEN.OrderNum = objRow[conSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSection.OrderNum].ToString().Trim()); //序号
objSectionEN.UpdDate = objRow[conSection.UpdDate] == DBNull.Value ? null : objRow[conSection.UpdDate].ToString().Trim(); //修改日期
objSectionEN.UpdUser = objRow[conSection.UpdUser].ToString().Trim(); //修改人
objSectionEN.Memo = objRow[conSection.Memo] == DBNull.Value ? null : objRow[conSection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSectionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSectionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSection(ref clsSectionEN objSectionEN)
{
bool bolResult = SectionDA.GetSection(ref objSectionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSectionEN GetObjBySectionId(string strSectionId)
{
if (strSectionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSectionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSectionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSectionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSectionEN objSectionEN = SectionDA.GetObjBySectionId(strSectionId);
return objSectionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSectionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSectionEN objSectionEN = SectionDA.GetFirstObj(strWhereCond);
 return objSectionEN;
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
public static clsSectionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSectionEN objSectionEN = SectionDA.GetObjByDataRow(objRow);
 return objSectionEN;
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
public static clsSectionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSectionEN objSectionEN = SectionDA.GetObjByDataRow(objRow);
 return objSectionEN;
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
 /// <param name = "strSectionId">所给的关键字</param>
 /// <param name = "lstSectionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSectionEN GetObjBySectionIdFromList(string strSectionId, List<clsSectionEN> lstSectionObjLst)
{
foreach (clsSectionEN objSectionEN in lstSectionObjLst)
{
if (objSectionEN.SectionId == strSectionId)
{
return objSectionEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxSectionId;
 try
 {
 strMaxSectionId = clsSectionDA.GetMaxStrId();
 return strMaxSectionId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strSectionId;
 try
 {
 strSectionId = new clsSectionDA().GetFirstID(strWhereCond);
 return strSectionId;
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
 arrList = SectionDA.GetID(strWhereCond);
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
bool bolIsExist = SectionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSectionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSectionId)
{
if (string.IsNullOrEmpty(strSectionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSectionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SectionDA.IsExist(strSectionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strSectionId">节Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strSectionId, string strOpUser)
{
clsSectionEN objSectionEN = clsSectionBL.GetObjBySectionId(strSectionId);
objSectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSectionEN.UpdUser = strOpUser;
return clsSectionBL.UpdateBySql2(objSectionEN);
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
 bolIsExist = clsSectionDA.IsExistTable();
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
 bolIsExist = SectionDA.IsExistTable(strTabName);
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
 /// <param name = "objSectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSectionEN objSectionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSectionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],节名 = [{1}]的数据已经存在!(in clsSectionBL.AddNewRecordBySql2)", objSectionEN.PaperId,objSectionEN.SectionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSectionEN.SectionId) == true || clsSectionBL.IsExist(objSectionEN.SectionId) == true)
 {
     objSectionEN.SectionId = clsSectionBL.GetMaxStrId_S();
 }
bool bolResult = SectionDA.AddNewRecordBySQL2(objSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
 /// <param name = "objSectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSectionEN objSectionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSectionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],节名 = [{1}]的数据已经存在!(in clsSectionBL.AddNewRecordBySql2WithReturnKey)", objSectionEN.PaperId,objSectionEN.SectionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSectionEN.SectionId) == true || clsSectionBL.IsExist(objSectionEN.SectionId) == true)
 {
     objSectionEN.SectionId = clsSectionBL.GetMaxStrId_S();
 }
string strKey = SectionDA.AddNewRecordBySQL2WithReturnKey(objSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
 /// <param name = "objSectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSectionEN objSectionEN)
{
try
{
bool bolResult = SectionDA.Update(objSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
 /// <param name = "objSectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSectionEN objSectionEN)
{
 if (string.IsNullOrEmpty(objSectionEN.SectionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SectionDA.UpdateBySql2(objSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSectionBL.ReFreshCache();

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
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
 /// <param name = "strSectionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strSectionId)
{
try
{
 clsSectionEN objSectionEN = clsSectionBL.GetObjBySectionId(strSectionId);

if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(objSectionEN.SectionId, objSectionEN.UpdUser);
}
if (objSectionEN != null)
{
int intRecNum = SectionDA.DelRecord(strSectionId);
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
/// <param name="strSectionId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strSectionId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSectionDA.GetSpecSQLObj();
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
//删除与表:[Section]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSection.SectionId,
//strSectionId);
//        clsSectionBL.DelSectionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSectionBL.DelRecord(strSectionId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSectionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSectionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strSectionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strSectionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSectionBL.relatedActions != null)
{
clsSectionBL.relatedActions.UpdRelaTabDate(strSectionId, "UpdRelaTabDate");
}
bool bolResult = SectionDA.DelRecord(strSectionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSectionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSections(List<string> arrSectionIdLst)
{
if (arrSectionIdLst.Count == 0) return 0;
try
{
if (clsSectionBL.relatedActions != null)
{
foreach (var strSectionId in arrSectionIdLst)
{
clsSectionBL.relatedActions.UpdRelaTabDate(strSectionId, "UpdRelaTabDate");
}
}
int intDelRecNum = SectionDA.DelSection(arrSectionIdLst);
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
public static int DelSectionsByCond(string strWhereCond)
{
try
{
if (clsSectionBL.relatedActions != null)
{
List<string> arrSectionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSectionId in arrSectionId)
{
clsSectionBL.relatedActions.UpdRelaTabDate(strSectionId, "UpdRelaTabDate");
}
}
int intRecNum = SectionDA.DelSection(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Section]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strSectionId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strSectionId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSectionDA.GetSpecSQLObj();
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
//删除与表:[Section]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSectionBL.DelRecord(strSectionId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSectionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSectionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSectionENS">源对象</param>
 /// <param name = "objSectionENT">目标对象</param>
 public static void CopyTo(clsSectionEN objSectionENS, clsSectionEN objSectionENT)
{
try
{
objSectionENT.SectionId = objSectionENS.SectionId; //节Id
objSectionENT.SectionName = objSectionENS.SectionName; //节名
objSectionENT.PaperId = objSectionENS.PaperId; //论文Id
objSectionENT.ParentId = objSectionENS.ParentId; //父节点Id
objSectionENT.OrderNum = objSectionENS.OrderNum; //序号
objSectionENT.UpdDate = objSectionENS.UpdDate; //修改日期
objSectionENT.UpdUser = objSectionENS.UpdUser; //修改人
objSectionENT.Memo = objSectionENS.Memo; //备注
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
 /// <param name = "objSectionEN">源简化对象</param>
 public static void SetUpdFlag(clsSectionEN objSectionEN)
{
try
{
objSectionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSectionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSection.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objSectionEN.SectionId = objSectionEN.SectionId; //节Id
}
if (arrFldSet.Contains(conSection.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objSectionEN.SectionName = objSectionEN.SectionName == "[null]" ? null :  objSectionEN.SectionName; //节名
}
if (arrFldSet.Contains(conSection.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objSectionEN.PaperId = objSectionEN.PaperId == "[null]" ? null :  objSectionEN.PaperId; //论文Id
}
if (arrFldSet.Contains(conSection.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objSectionEN.ParentId = objSectionEN.ParentId == "[null]" ? null :  objSectionEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(conSection.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objSectionEN.OrderNum = objSectionEN.OrderNum; //序号
}
if (arrFldSet.Contains(conSection.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSectionEN.UpdDate = objSectionEN.UpdDate == "[null]" ? null :  objSectionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSection.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objSectionEN.UpdUser = objSectionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conSection.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSectionEN.Memo = objSectionEN.Memo == "[null]" ? null :  objSectionEN.Memo; //备注
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
 /// <param name = "objSectionEN">源简化对象</param>
 public static void AccessFldValueNull(clsSectionEN objSectionEN)
{
try
{
if (objSectionEN.SectionName == "[null]") objSectionEN.SectionName = null; //节名
if (objSectionEN.PaperId == "[null]") objSectionEN.PaperId = null; //论文Id
if (objSectionEN.ParentId == "[null]") objSectionEN.ParentId = null; //父节点Id
if (objSectionEN.UpdDate == "[null]") objSectionEN.UpdDate = null; //修改日期
if (objSectionEN.Memo == "[null]") objSectionEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsSectionEN objSectionEN)
{
 SectionDA.CheckPropertyNew(objSectionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSectionEN objSectionEN)
{
 SectionDA.CheckProperty4Condition(objSectionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SectionIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文节表]...","0");
List<clsSectionEN> arrSectionObjLst = GetAllSectionObjLstCache(); 
arrSectionObjLst = arrSectionObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conSection.SectionId;
objDDL.DataTextField = conSection.SectionName;
objDDL.DataSource = arrSectionObjLst;
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
if (clsSectionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSectionBL没有刷新缓存机制(clsSectionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SectionId");
//if (arrSectionObjLstCache == null)
//{
//arrSectionObjLstCache = SectionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSectionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSectionEN GetObjBySectionIdCache(string strSectionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSectionEN._CurrTabName);
List<clsSectionEN> arrSectionObjLstCache = GetObjLstCache();
IEnumerable <clsSectionEN> arrSectionObjLst_Sel =
arrSectionObjLstCache
.Where(x=> x.SectionId == strSectionId 
);
if (arrSectionObjLst_Sel.Count() == 0)
{
   clsSectionEN obj = clsSectionBL.GetObjBySectionId(strSectionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSectionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSectionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSectionNameBySectionIdCache(string strSectionId)
{
if (string.IsNullOrEmpty(strSectionId) == true) return "";
//获取缓存中的对象列表
clsSectionEN objSection = GetObjBySectionIdCache(strSectionId);
if (objSection == null) return "";
return objSection.SectionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSectionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySectionIdCache(string strSectionId)
{
if (string.IsNullOrEmpty(strSectionId) == true) return "";
//获取缓存中的对象列表
clsSectionEN objSection = GetObjBySectionIdCache(strSectionId);
if (objSection == null) return "";
return objSection.SectionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSectionEN> GetAllSectionObjLstCache()
{
//获取缓存中的对象列表
List<clsSectionEN> arrSectionObjLstCache = GetObjLstCache(); 
return arrSectionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSectionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSectionEN._CurrTabName);
List<clsSectionEN> arrSectionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSectionObjLstCache;
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
string strKey = string.Format("{0}", clsSectionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSectionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSectionEN._RefreshTimeLst.Count == 0) return "";
return clsSectionEN._RefreshTimeLst[clsSectionEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSectionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSectionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSectionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSectionBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Section(论文节表)
 /// 唯一性条件:PaperId_SectionName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSectionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSectionEN objSectionEN)
{
//检测记录是否存在
string strResult = SectionDA.GetUniCondStr(objSectionEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, string strSectionId)
{
if (strInFldName != conSection.SectionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSection.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSection.AttributeName));
throw new Exception(strMsg);
}
var objSection = clsSectionBL.GetObjBySectionIdCache(strSectionId);
if (objSection == null) return "";
return objSection[strOutFldName].ToString();
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
int intRecCount = clsSectionDA.GetRecCount(strTabName);
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
int intRecCount = clsSectionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSectionDA.GetRecCount();
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
int intRecCount = clsSectionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSectionEN objSectionCond)
{
List<clsSectionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSection.AttributeName)
{
if (objSectionCond.IsUpdated(strFldName) == false) continue;
if (objSectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSectionCond[strFldName].ToString());
}
else
{
if (objSectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSectionCond[strFldName]));
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
 List<string> arrList = clsSectionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SectionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SectionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SectionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSectionDA.SetFldValue(clsSectionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SectionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSectionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSectionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSectionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Section] "); 
 strCreateTabCode.Append(" ( "); 
 // /**节Id*/ 
 strCreateTabCode.Append(" SectionId char(8) primary key, "); 
 // /**节名*/ 
 strCreateTabCode.Append(" SectionName varchar(100) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**父节点Id*/ 
 strCreateTabCode.Append(" ParentId char(10) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：ParentId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strParentId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strParentId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conSection.ParentId, strParentId);
 strCondition += string.Format(" order by OrderNum ");
List<clsSectionEN> arrSectionObjList = new clsSectionDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsSectionEN objSection in arrSectionObjList)
{
objSection.OrderNum = intIndex;
UpdateBySql2(objSection);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：ParentId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strSectionId">所给的关键字</param>
/// <param name="strParentId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strSectionId ,string strParentId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[SectionId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字SectionId
//5、把当前关键字SectionId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字SectionId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevSectionId = "";    //上一条序号的关键字SectionId
string strNextSectionId = "";    //下一条序号的关键字SectionId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[SectionId],获取相应的序号[OrderNum]。

clsSectionEN objSection = clsSectionBL.GetObjBySectionId(strSectionId);

intOrderNum = objSection.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conSection.ParentId, strParentId);
intTabRecNum = clsSectionBL.GetRecCountByCond(clsSectionEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conSection.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conSection.ParentId, strParentId);
//4、获取上一个序号字段的关键字SectionId
strPrevSectionId = clsSectionBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevSectionId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字SectionId所对应记录的序号减1
//6、把下(上)一个序号关键字SectionId所对应的记录序号加1
clsSectionBL.SetFldValue(clsSectionEN._CurrTabName, conSection.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conSection.SectionId, strSectionId));
clsSectionBL.SetFldValue(clsSectionEN._CurrTabName, conSection.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conSection.SectionId, strPrevSectionId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字SectionId
sbCondition.AppendFormat(" {0} = {1} ", conSection.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conSection.ParentId, strParentId);

strNextSectionId = clsSectionBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextSectionId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字SectionId所对应记录的序号加1
//6、把下(上)一个序号关键字SectionId所对应的记录序号减1
clsSectionBL.SetFldValue(clsSectionEN._CurrTabName, conSection.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conSection.SectionId, strSectionId));
clsSectionBL.SetFldValue(clsSectionEN._CurrTabName, conSection.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conSection.SectionId, strNextSectionId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：ParentId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,string strParentId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conSection.SectionId, strKeyList);
List<clsSectionEN> arrSectionLst = GetObjLst(strCondition);
foreach (clsSectionEN objSection in arrSectionLst)
{
objSection.OrderNum = objSection.OrderNum + 10000;
UpdateBySql2(objSection);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conSection.ParentId, strParentId);
 strCondition += string.Format(" order by OrderNum ");
List<clsSectionEN> arrSectionObjList = new clsSectionDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsSectionEN objSection in arrSectionObjList)
{
objSection.OrderNum = intIndex;
UpdateBySql2(objSection);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：ParentId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strParentId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,string strParentId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conSection.SectionId, strKeyList);
List<clsSectionEN> arrSectionLst = GetObjLst(strCondition);
foreach (clsSectionEN objSection in arrSectionLst)
{
objSection.OrderNum = objSection.OrderNum - 10000;
UpdateBySql2(objSection);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conSection.ParentId, strParentId);
 strCondition += string.Format(" order by OrderNum ");
List<clsSectionEN> arrSectionObjList = new clsSectionDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsSectionEN objSection in arrSectionObjList)
{
objSection.OrderNum = intIndex;
UpdateBySql2(objSection);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 论文节表(Section)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Section : clsCommFun4BL
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
clsSectionBL.ReFreshThisCache();
}
}

}