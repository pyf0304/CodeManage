
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseStudentRelationBL
 表名:cc_CourseStudentRelation(01120150)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
public static class  clscc_CourseStudentRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngCourseStudentRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseStudentRelationEN GetObj(this K_CourseStudentRelationId_cc_CourseStudentRelation myKey)
{
clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = clscc_CourseStudentRelationBL.cc_CourseStudentRelationDA.GetObjByCourseStudentRelationId(myKey.Value);
return objcc_CourseStudentRelationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseStudentRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_CourseStudentRelationBL.AddNewRecord)", objcc_CourseStudentRelationEN.CourseId,objcc_CourseStudentRelationEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_CourseStudentRelationBL.cc_CourseStudentRelationDA.AddNewRecordBySQL2(objcc_CourseStudentRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, bool bolIsNeedCheckUniqueness = true)
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
objcc_CourseStudentRelationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_CourseStudentRelationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课程Id(CourseId)=[{0}],学生流水号(IdStudentInfo)=[{1}])已经存在,不能重复!", objcc_CourseStudentRelationEN.CourseId, objcc_CourseStudentRelationEN.IdStudentInfo);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_CourseStudentRelationEN.AddNewRecord();
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
 /// <param name = "objcc_CourseStudentRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseStudentRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_CourseStudentRelationBL.AddNewRecordWithReturnKey)", objcc_CourseStudentRelationEN.CourseId,objcc_CourseStudentRelationEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_CourseStudentRelationBL.cc_CourseStudentRelationDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseStudentRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
 /// <param name = "objcc_CourseStudentRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseStudentRelationEN SetCourseStudentRelationId(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, long lngCourseStudentRelationId, string strComparisonOp="")
	{
objcc_CourseStudentRelationEN.CourseStudentRelationId = lngCourseStudentRelationId; //课程学生关系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseStudentRelationEN.dicFldComparisonOp.ContainsKey(concc_CourseStudentRelation.CourseStudentRelationId) == false)
{
objcc_CourseStudentRelationEN.dicFldComparisonOp.Add(concc_CourseStudentRelation.CourseStudentRelationId, strComparisonOp);
}
else
{
objcc_CourseStudentRelationEN.dicFldComparisonOp[concc_CourseStudentRelation.CourseStudentRelationId] = strComparisonOp;
}
}
return objcc_CourseStudentRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseStudentRelationEN SetCourseId(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_CourseStudentRelation.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseStudentRelation.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseStudentRelation.CourseId);
}
objcc_CourseStudentRelationEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseStudentRelationEN.dicFldComparisonOp.ContainsKey(concc_CourseStudentRelation.CourseId) == false)
{
objcc_CourseStudentRelationEN.dicFldComparisonOp.Add(concc_CourseStudentRelation.CourseId, strComparisonOp);
}
else
{
objcc_CourseStudentRelationEN.dicFldComparisonOp[concc_CourseStudentRelation.CourseId] = strComparisonOp;
}
}
return objcc_CourseStudentRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseStudentRelationEN SetIdStudentInfo(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, concc_CourseStudentRelation.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, concc_CourseStudentRelation.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, concc_CourseStudentRelation.IdStudentInfo);
}
objcc_CourseStudentRelationEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseStudentRelationEN.dicFldComparisonOp.ContainsKey(concc_CourseStudentRelation.IdStudentInfo) == false)
{
objcc_CourseStudentRelationEN.dicFldComparisonOp.Add(concc_CourseStudentRelation.IdStudentInfo, strComparisonOp);
}
else
{
objcc_CourseStudentRelationEN.dicFldComparisonOp[concc_CourseStudentRelation.IdStudentInfo] = strComparisonOp;
}
}
return objcc_CourseStudentRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseStudentRelationEN SetLastVisitedDate(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, string strLastVisitedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 14, concc_CourseStudentRelation.LastVisitedDate);
}
objcc_CourseStudentRelationEN.LastVisitedDate = strLastVisitedDate; //最后访问时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseStudentRelationEN.dicFldComparisonOp.ContainsKey(concc_CourseStudentRelation.LastVisitedDate) == false)
{
objcc_CourseStudentRelationEN.dicFldComparisonOp.Add(concc_CourseStudentRelation.LastVisitedDate, strComparisonOp);
}
else
{
objcc_CourseStudentRelationEN.dicFldComparisonOp[concc_CourseStudentRelation.LastVisitedDate] = strComparisonOp;
}
}
return objcc_CourseStudentRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseStudentRelationEN SetUpdDate(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_CourseStudentRelation.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_CourseStudentRelation.UpdDate);
}
objcc_CourseStudentRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseStudentRelationEN.dicFldComparisonOp.ContainsKey(concc_CourseStudentRelation.UpdDate) == false)
{
objcc_CourseStudentRelationEN.dicFldComparisonOp.Add(concc_CourseStudentRelation.UpdDate, strComparisonOp);
}
else
{
objcc_CourseStudentRelationEN.dicFldComparisonOp[concc_CourseStudentRelation.UpdDate] = strComparisonOp;
}
}
return objcc_CourseStudentRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseStudentRelationEN SetUpdUserId(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_CourseStudentRelation.UpdUserId);
}
objcc_CourseStudentRelationEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseStudentRelationEN.dicFldComparisonOp.ContainsKey(concc_CourseStudentRelation.UpdUserId) == false)
{
objcc_CourseStudentRelationEN.dicFldComparisonOp.Add(concc_CourseStudentRelation.UpdUserId, strComparisonOp);
}
else
{
objcc_CourseStudentRelationEN.dicFldComparisonOp[concc_CourseStudentRelation.UpdUserId] = strComparisonOp;
}
}
return objcc_CourseStudentRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseStudentRelationEN SetMemo(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_CourseStudentRelation.Memo);
}
objcc_CourseStudentRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseStudentRelationEN.dicFldComparisonOp.ContainsKey(concc_CourseStudentRelation.Memo) == false)
{
objcc_CourseStudentRelationEN.dicFldComparisonOp.Add(concc_CourseStudentRelation.Memo, strComparisonOp);
}
else
{
objcc_CourseStudentRelationEN.dicFldComparisonOp[concc_CourseStudentRelation.Memo] = strComparisonOp;
}
}
return objcc_CourseStudentRelationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_CourseStudentRelationEN.CheckPropertyNew();
clscc_CourseStudentRelationEN objcc_CourseStudentRelationCond = new clscc_CourseStudentRelationEN();
string strCondition = objcc_CourseStudentRelationCond
.SetCourseStudentRelationId(objcc_CourseStudentRelationEN.CourseStudentRelationId, "<>")
.SetCourseId(objcc_CourseStudentRelationEN.CourseId, "=")
.SetIdStudentInfo(objcc_CourseStudentRelationEN.IdStudentInfo, "=")
.GetCombineCondition();
objcc_CourseStudentRelationEN._IsCheckProperty = true;
bool bolIsExist = clscc_CourseStudentRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CourseId_id_StudentInfo)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_CourseStudentRelationEN.Update();
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
 /// <param name = "objcc_CourseStudentRelation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_CourseStudentRelationEN objcc_CourseStudentRelation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_CourseStudentRelationEN objcc_CourseStudentRelationCond = new clscc_CourseStudentRelationEN();
string strCondition = objcc_CourseStudentRelationCond
.SetCourseId(objcc_CourseStudentRelation.CourseId, "=")
.SetIdStudentInfo(objcc_CourseStudentRelation.IdStudentInfo, "=")
.GetCombineCondition();
objcc_CourseStudentRelation._IsCheckProperty = true;
bool bolIsExist = clscc_CourseStudentRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_CourseStudentRelation.CourseStudentRelationId = clscc_CourseStudentRelationBL.GetFirstID_S(strCondition);
objcc_CourseStudentRelation.UpdateWithCondition(strCondition);
}
else
{
objcc_CourseStudentRelation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
 if (objcc_CourseStudentRelationEN.CourseStudentRelationId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseStudentRelationBL.cc_CourseStudentRelationDA.UpdateBySql2(objcc_CourseStudentRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
 /// <param name = "objcc_CourseStudentRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_CourseStudentRelationEN.CourseStudentRelationId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseStudentRelationBL.cc_CourseStudentRelationDA.UpdateBySql2(objcc_CourseStudentRelationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
 /// <param name = "objcc_CourseStudentRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, string strWhereCond)
{
try
{
bool bolResult = clscc_CourseStudentRelationBL.cc_CourseStudentRelationDA.UpdateBySqlWithCondition(objcc_CourseStudentRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
 /// <param name = "objcc_CourseStudentRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_CourseStudentRelationBL.cc_CourseStudentRelationDA.UpdateBySqlWithConditionTransaction(objcc_CourseStudentRelationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
 /// <param name = "lngCourseStudentRelationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
try
{
int intRecNum = clscc_CourseStudentRelationBL.cc_CourseStudentRelationDA.DelRecord(objcc_CourseStudentRelationEN.CourseStudentRelationId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
 /// <param name = "objcc_CourseStudentRelationENS">源对象</param>
 /// <param name = "objcc_CourseStudentRelationENT">目标对象</param>
 public static void CopyTo(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationENS, clscc_CourseStudentRelationEN objcc_CourseStudentRelationENT)
{
try
{
objcc_CourseStudentRelationENT.CourseStudentRelationId = objcc_CourseStudentRelationENS.CourseStudentRelationId; //课程学生关系表流水号
objcc_CourseStudentRelationENT.CourseId = objcc_CourseStudentRelationENS.CourseId; //课程Id
objcc_CourseStudentRelationENT.IdStudentInfo = objcc_CourseStudentRelationENS.IdStudentInfo; //学生流水号
objcc_CourseStudentRelationENT.LastVisitedDate = objcc_CourseStudentRelationENS.LastVisitedDate; //最后访问时间
objcc_CourseStudentRelationENT.UpdDate = objcc_CourseStudentRelationENS.UpdDate; //修改日期
objcc_CourseStudentRelationENT.UpdUserId = objcc_CourseStudentRelationENS.UpdUserId; //修改用户Id
objcc_CourseStudentRelationENT.Memo = objcc_CourseStudentRelationENS.Memo; //备注
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
 /// <param name = "objcc_CourseStudentRelationENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseStudentRelationEN:objcc_CourseStudentRelationENT</returns>
 public static clscc_CourseStudentRelationEN CopyTo(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationENS)
{
try
{
 clscc_CourseStudentRelationEN objcc_CourseStudentRelationENT = new clscc_CourseStudentRelationEN()
{
CourseStudentRelationId = objcc_CourseStudentRelationENS.CourseStudentRelationId, //课程学生关系表流水号
CourseId = objcc_CourseStudentRelationENS.CourseId, //课程Id
IdStudentInfo = objcc_CourseStudentRelationENS.IdStudentInfo, //学生流水号
LastVisitedDate = objcc_CourseStudentRelationENS.LastVisitedDate, //最后访问时间
UpdDate = objcc_CourseStudentRelationENS.UpdDate, //修改日期
UpdUserId = objcc_CourseStudentRelationENS.UpdUserId, //修改用户Id
Memo = objcc_CourseStudentRelationENS.Memo, //备注
};
 return objcc_CourseStudentRelationENT;
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
public static void CheckPropertyNew(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
 clscc_CourseStudentRelationBL.cc_CourseStudentRelationDA.CheckPropertyNew(objcc_CourseStudentRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
 clscc_CourseStudentRelationBL.cc_CourseStudentRelationDA.CheckProperty4Condition(objcc_CourseStudentRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseStudentRelationCond.IsUpdated(concc_CourseStudentRelation.CourseStudentRelationId) == true)
{
string strComparisonOpCourseStudentRelationId = objcc_CourseStudentRelationCond.dicFldComparisonOp[concc_CourseStudentRelation.CourseStudentRelationId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseStudentRelation.CourseStudentRelationId, objcc_CourseStudentRelationCond.CourseStudentRelationId, strComparisonOpCourseStudentRelationId);
}
if (objcc_CourseStudentRelationCond.IsUpdated(concc_CourseStudentRelation.CourseId) == true)
{
string strComparisonOpCourseId = objcc_CourseStudentRelationCond.dicFldComparisonOp[concc_CourseStudentRelation.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseStudentRelation.CourseId, objcc_CourseStudentRelationCond.CourseId, strComparisonOpCourseId);
}
if (objcc_CourseStudentRelationCond.IsUpdated(concc_CourseStudentRelation.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objcc_CourseStudentRelationCond.dicFldComparisonOp[concc_CourseStudentRelation.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseStudentRelation.IdStudentInfo, objcc_CourseStudentRelationCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objcc_CourseStudentRelationCond.IsUpdated(concc_CourseStudentRelation.LastVisitedDate) == true)
{
string strComparisonOpLastVisitedDate = objcc_CourseStudentRelationCond.dicFldComparisonOp[concc_CourseStudentRelation.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseStudentRelation.LastVisitedDate, objcc_CourseStudentRelationCond.LastVisitedDate, strComparisonOpLastVisitedDate);
}
if (objcc_CourseStudentRelationCond.IsUpdated(concc_CourseStudentRelation.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_CourseStudentRelationCond.dicFldComparisonOp[concc_CourseStudentRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseStudentRelation.UpdDate, objcc_CourseStudentRelationCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_CourseStudentRelationCond.IsUpdated(concc_CourseStudentRelation.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_CourseStudentRelationCond.dicFldComparisonOp[concc_CourseStudentRelation.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseStudentRelation.UpdUserId, objcc_CourseStudentRelationCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_CourseStudentRelationCond.IsUpdated(concc_CourseStudentRelation.Memo) == true)
{
string strComparisonOpMemo = objcc_CourseStudentRelationCond.dicFldComparisonOp[concc_CourseStudentRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseStudentRelation.Memo, objcc_CourseStudentRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_CourseStudentRelation(课程学生关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseId_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseStudentRelationEN == null) return true;
if (objcc_CourseStudentRelationEN.CourseStudentRelationId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseStudentRelationEN.CourseId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_CourseStudentRelationEN.IdStudentInfo);
if (clscc_CourseStudentRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CourseStudentRelationId !=  {0}", objcc_CourseStudentRelationEN.CourseStudentRelationId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseStudentRelationEN.CourseId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_CourseStudentRelationEN.IdStudentInfo);
if (clscc_CourseStudentRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_CourseStudentRelation(课程学生关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseId_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseStudentRelationEN == null) return "";
if (objcc_CourseStudentRelationEN.CourseStudentRelationId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseStudentRelationEN.CourseId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_CourseStudentRelationEN.IdStudentInfo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CourseStudentRelationId !=  {0}", objcc_CourseStudentRelationEN.CourseStudentRelationId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseStudentRelationEN.CourseId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_CourseStudentRelationEN.IdStudentInfo);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_CourseStudentRelation
{
public virtual bool UpdRelaTabDate(long lngCourseStudentRelationId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 课程学生关系(cc_CourseStudentRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseStudentRelationBL
{
public static RelatedActions_cc_CourseStudentRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_CourseStudentRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_CourseStudentRelationDA cc_CourseStudentRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_CourseStudentRelationDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clscc_CourseStudentRelationBL()
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
if (string.IsNullOrEmpty(clscc_CourseStudentRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseStudentRelationEN._ConnectString);
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
public static DataTable GetDataTable_cc_CourseStudentRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_CourseStudentRelationDA.GetDataTable_cc_CourseStudentRelation(strWhereCond);
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
objDT = cc_CourseStudentRelationDA.GetDataTable(strWhereCond);
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
objDT = cc_CourseStudentRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_CourseStudentRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_CourseStudentRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_CourseStudentRelationDA.GetDataTable_Top(objTopPara);
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
objDT = cc_CourseStudentRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_CourseStudentRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_CourseStudentRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseStudentRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_CourseStudentRelationEN> GetObjLstByCourseStudentRelationIdLst(List<long> arrCourseStudentRelationIdLst)
{
List<clscc_CourseStudentRelationEN> arrObjLst = new List<clscc_CourseStudentRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseStudentRelationIdLst);
 string strWhereCond = string.Format("CourseStudentRelationId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = new clscc_CourseStudentRelationEN();
try
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = Int32.Parse(objRow[concc_CourseStudentRelation.CourseStudentRelationId].ToString().Trim()); //课程学生关系表流水号
objcc_CourseStudentRelationEN.CourseId = objRow[concc_CourseStudentRelation.CourseId].ToString().Trim(); //课程Id
objcc_CourseStudentRelationEN.IdStudentInfo = objRow[concc_CourseStudentRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_CourseStudentRelationEN.LastVisitedDate = objRow[concc_CourseStudentRelation.LastVisitedDate] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objcc_CourseStudentRelationEN.UpdDate = objRow[concc_CourseStudentRelation.UpdDate].ToString().Trim(); //修改日期
objcc_CourseStudentRelationEN.UpdUserId = objRow[concc_CourseStudentRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseStudentRelationEN.Memo = objRow[concc_CourseStudentRelation.Memo] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseStudentRelationEN.CourseStudentRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseStudentRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseStudentRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_CourseStudentRelationEN> GetObjLstByCourseStudentRelationIdLstCache(List<long> arrCourseStudentRelationIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clscc_CourseStudentRelationEN._CurrTabName, strCourseId);
List<clscc_CourseStudentRelationEN> arrcc_CourseStudentRelationObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseStudentRelationEN> arrcc_CourseStudentRelationObjLst_Sel =
arrcc_CourseStudentRelationObjLstCache
.Where(x => arrCourseStudentRelationIdLst.Contains(x.CourseStudentRelationId));
return arrcc_CourseStudentRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseStudentRelationEN> GetObjLst(string strWhereCond)
{
List<clscc_CourseStudentRelationEN> arrObjLst = new List<clscc_CourseStudentRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = new clscc_CourseStudentRelationEN();
try
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = Int32.Parse(objRow[concc_CourseStudentRelation.CourseStudentRelationId].ToString().Trim()); //课程学生关系表流水号
objcc_CourseStudentRelationEN.CourseId = objRow[concc_CourseStudentRelation.CourseId].ToString().Trim(); //课程Id
objcc_CourseStudentRelationEN.IdStudentInfo = objRow[concc_CourseStudentRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_CourseStudentRelationEN.LastVisitedDate = objRow[concc_CourseStudentRelation.LastVisitedDate] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objcc_CourseStudentRelationEN.UpdDate = objRow[concc_CourseStudentRelation.UpdDate].ToString().Trim(); //修改日期
objcc_CourseStudentRelationEN.UpdUserId = objRow[concc_CourseStudentRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseStudentRelationEN.Memo = objRow[concc_CourseStudentRelation.Memo] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseStudentRelationEN.CourseStudentRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseStudentRelationEN);
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
public static List<clscc_CourseStudentRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseStudentRelationEN> arrObjLst = new List<clscc_CourseStudentRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = new clscc_CourseStudentRelationEN();
try
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = Int32.Parse(objRow[concc_CourseStudentRelation.CourseStudentRelationId].ToString().Trim()); //课程学生关系表流水号
objcc_CourseStudentRelationEN.CourseId = objRow[concc_CourseStudentRelation.CourseId].ToString().Trim(); //课程Id
objcc_CourseStudentRelationEN.IdStudentInfo = objRow[concc_CourseStudentRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_CourseStudentRelationEN.LastVisitedDate = objRow[concc_CourseStudentRelation.LastVisitedDate] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objcc_CourseStudentRelationEN.UpdDate = objRow[concc_CourseStudentRelation.UpdDate].ToString().Trim(); //修改日期
objcc_CourseStudentRelationEN.UpdUserId = objRow[concc_CourseStudentRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseStudentRelationEN.Memo = objRow[concc_CourseStudentRelation.Memo] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseStudentRelationEN.CourseStudentRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseStudentRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_CourseStudentRelationEN> GetSubObjLstCache(clscc_CourseStudentRelationEN objcc_CourseStudentRelationCond)
{
 string strCourseId = objcc_CourseStudentRelationCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clscc_CourseStudentRelationBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clscc_CourseStudentRelationEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseStudentRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseStudentRelation.AttributeName)
{
if (objcc_CourseStudentRelationCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseStudentRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseStudentRelationCond[strFldName].ToString());
}
else
{
if (objcc_CourseStudentRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseStudentRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseStudentRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseStudentRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseStudentRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseStudentRelationCond[strFldName]));
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
public static List<clscc_CourseStudentRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_CourseStudentRelationEN> arrObjLst = new List<clscc_CourseStudentRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = new clscc_CourseStudentRelationEN();
try
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = Int32.Parse(objRow[concc_CourseStudentRelation.CourseStudentRelationId].ToString().Trim()); //课程学生关系表流水号
objcc_CourseStudentRelationEN.CourseId = objRow[concc_CourseStudentRelation.CourseId].ToString().Trim(); //课程Id
objcc_CourseStudentRelationEN.IdStudentInfo = objRow[concc_CourseStudentRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_CourseStudentRelationEN.LastVisitedDate = objRow[concc_CourseStudentRelation.LastVisitedDate] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objcc_CourseStudentRelationEN.UpdDate = objRow[concc_CourseStudentRelation.UpdDate].ToString().Trim(); //修改日期
objcc_CourseStudentRelationEN.UpdUserId = objRow[concc_CourseStudentRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseStudentRelationEN.Memo = objRow[concc_CourseStudentRelation.Memo] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseStudentRelationEN.CourseStudentRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseStudentRelationEN);
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
public static List<clscc_CourseStudentRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_CourseStudentRelationEN> arrObjLst = new List<clscc_CourseStudentRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = new clscc_CourseStudentRelationEN();
try
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = Int32.Parse(objRow[concc_CourseStudentRelation.CourseStudentRelationId].ToString().Trim()); //课程学生关系表流水号
objcc_CourseStudentRelationEN.CourseId = objRow[concc_CourseStudentRelation.CourseId].ToString().Trim(); //课程Id
objcc_CourseStudentRelationEN.IdStudentInfo = objRow[concc_CourseStudentRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_CourseStudentRelationEN.LastVisitedDate = objRow[concc_CourseStudentRelation.LastVisitedDate] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objcc_CourseStudentRelationEN.UpdDate = objRow[concc_CourseStudentRelation.UpdDate].ToString().Trim(); //修改日期
objcc_CourseStudentRelationEN.UpdUserId = objRow[concc_CourseStudentRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseStudentRelationEN.Memo = objRow[concc_CourseStudentRelation.Memo] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseStudentRelationEN.CourseStudentRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseStudentRelationEN);
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
List<clscc_CourseStudentRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_CourseStudentRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseStudentRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_CourseStudentRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseStudentRelationEN> arrObjLst = new List<clscc_CourseStudentRelationEN>(); 
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
	clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = new clscc_CourseStudentRelationEN();
try
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = Int32.Parse(objRow[concc_CourseStudentRelation.CourseStudentRelationId].ToString().Trim()); //课程学生关系表流水号
objcc_CourseStudentRelationEN.CourseId = objRow[concc_CourseStudentRelation.CourseId].ToString().Trim(); //课程Id
objcc_CourseStudentRelationEN.IdStudentInfo = objRow[concc_CourseStudentRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_CourseStudentRelationEN.LastVisitedDate = objRow[concc_CourseStudentRelation.LastVisitedDate] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objcc_CourseStudentRelationEN.UpdDate = objRow[concc_CourseStudentRelation.UpdDate].ToString().Trim(); //修改日期
objcc_CourseStudentRelationEN.UpdUserId = objRow[concc_CourseStudentRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseStudentRelationEN.Memo = objRow[concc_CourseStudentRelation.Memo] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseStudentRelationEN.CourseStudentRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseStudentRelationEN);
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
public static List<clscc_CourseStudentRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseStudentRelationEN> arrObjLst = new List<clscc_CourseStudentRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = new clscc_CourseStudentRelationEN();
try
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = Int32.Parse(objRow[concc_CourseStudentRelation.CourseStudentRelationId].ToString().Trim()); //课程学生关系表流水号
objcc_CourseStudentRelationEN.CourseId = objRow[concc_CourseStudentRelation.CourseId].ToString().Trim(); //课程Id
objcc_CourseStudentRelationEN.IdStudentInfo = objRow[concc_CourseStudentRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_CourseStudentRelationEN.LastVisitedDate = objRow[concc_CourseStudentRelation.LastVisitedDate] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objcc_CourseStudentRelationEN.UpdDate = objRow[concc_CourseStudentRelation.UpdDate].ToString().Trim(); //修改日期
objcc_CourseStudentRelationEN.UpdUserId = objRow[concc_CourseStudentRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseStudentRelationEN.Memo = objRow[concc_CourseStudentRelation.Memo] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseStudentRelationEN.CourseStudentRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseStudentRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_CourseStudentRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_CourseStudentRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseStudentRelationEN> arrObjLst = new List<clscc_CourseStudentRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = new clscc_CourseStudentRelationEN();
try
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = Int32.Parse(objRow[concc_CourseStudentRelation.CourseStudentRelationId].ToString().Trim()); //课程学生关系表流水号
objcc_CourseStudentRelationEN.CourseId = objRow[concc_CourseStudentRelation.CourseId].ToString().Trim(); //课程Id
objcc_CourseStudentRelationEN.IdStudentInfo = objRow[concc_CourseStudentRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_CourseStudentRelationEN.LastVisitedDate = objRow[concc_CourseStudentRelation.LastVisitedDate] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objcc_CourseStudentRelationEN.UpdDate = objRow[concc_CourseStudentRelation.UpdDate].ToString().Trim(); //修改日期
objcc_CourseStudentRelationEN.UpdUserId = objRow[concc_CourseStudentRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseStudentRelationEN.Memo = objRow[concc_CourseStudentRelation.Memo] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseStudentRelationEN.CourseStudentRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseStudentRelationEN);
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
public static List<clscc_CourseStudentRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_CourseStudentRelationEN> arrObjLst = new List<clscc_CourseStudentRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = new clscc_CourseStudentRelationEN();
try
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = Int32.Parse(objRow[concc_CourseStudentRelation.CourseStudentRelationId].ToString().Trim()); //课程学生关系表流水号
objcc_CourseStudentRelationEN.CourseId = objRow[concc_CourseStudentRelation.CourseId].ToString().Trim(); //课程Id
objcc_CourseStudentRelationEN.IdStudentInfo = objRow[concc_CourseStudentRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_CourseStudentRelationEN.LastVisitedDate = objRow[concc_CourseStudentRelation.LastVisitedDate] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objcc_CourseStudentRelationEN.UpdDate = objRow[concc_CourseStudentRelation.UpdDate].ToString().Trim(); //修改日期
objcc_CourseStudentRelationEN.UpdUserId = objRow[concc_CourseStudentRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseStudentRelationEN.Memo = objRow[concc_CourseStudentRelation.Memo] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseStudentRelationEN.CourseStudentRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseStudentRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseStudentRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_CourseStudentRelationEN> arrObjLst = new List<clscc_CourseStudentRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = new clscc_CourseStudentRelationEN();
try
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = Int32.Parse(objRow[concc_CourseStudentRelation.CourseStudentRelationId].ToString().Trim()); //课程学生关系表流水号
objcc_CourseStudentRelationEN.CourseId = objRow[concc_CourseStudentRelation.CourseId].ToString().Trim(); //课程Id
objcc_CourseStudentRelationEN.IdStudentInfo = objRow[concc_CourseStudentRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_CourseStudentRelationEN.LastVisitedDate = objRow[concc_CourseStudentRelation.LastVisitedDate] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objcc_CourseStudentRelationEN.UpdDate = objRow[concc_CourseStudentRelation.UpdDate].ToString().Trim(); //修改日期
objcc_CourseStudentRelationEN.UpdUserId = objRow[concc_CourseStudentRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseStudentRelationEN.Memo = objRow[concc_CourseStudentRelation.Memo] == DBNull.Value ? null : objRow[concc_CourseStudentRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseStudentRelationEN.CourseStudentRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseStudentRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_CourseStudentRelation(ref clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
bool bolResult = cc_CourseStudentRelationDA.Getcc_CourseStudentRelation(ref objcc_CourseStudentRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngCourseStudentRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseStudentRelationEN GetObjByCourseStudentRelationId(long lngCourseStudentRelationId)
{
clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = cc_CourseStudentRelationDA.GetObjByCourseStudentRelationId(lngCourseStudentRelationId);
return objcc_CourseStudentRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_CourseStudentRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = cc_CourseStudentRelationDA.GetFirstObj(strWhereCond);
 return objcc_CourseStudentRelationEN;
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
public static clscc_CourseStudentRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = cc_CourseStudentRelationDA.GetObjByDataRow(objRow);
 return objcc_CourseStudentRelationEN;
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
public static clscc_CourseStudentRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = cc_CourseStudentRelationDA.GetObjByDataRow(objRow);
 return objcc_CourseStudentRelationEN;
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
 /// <param name = "lngCourseStudentRelationId">所给的关键字</param>
 /// <param name = "lstcc_CourseStudentRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseStudentRelationEN GetObjByCourseStudentRelationIdFromList(long lngCourseStudentRelationId, List<clscc_CourseStudentRelationEN> lstcc_CourseStudentRelationObjLst)
{
foreach (clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN in lstcc_CourseStudentRelationObjLst)
{
if (objcc_CourseStudentRelationEN.CourseStudentRelationId == lngCourseStudentRelationId)
{
return objcc_CourseStudentRelationEN;
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
 long lngCourseStudentRelationId;
 try
 {
 lngCourseStudentRelationId = new clscc_CourseStudentRelationDA().GetFirstID(strWhereCond);
 return lngCourseStudentRelationId;
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
 arrList = cc_CourseStudentRelationDA.GetID(strWhereCond);
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
bool bolIsExist = cc_CourseStudentRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngCourseStudentRelationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngCourseStudentRelationId)
{
//检测记录是否存在
bool bolIsExist = cc_CourseStudentRelationDA.IsExist(lngCourseStudentRelationId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngCourseStudentRelationId">课程学生关系表流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngCourseStudentRelationId, string strOpUser)
{
clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = clscc_CourseStudentRelationBL.GetObjByCourseStudentRelationId(lngCourseStudentRelationId);
objcc_CourseStudentRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_CourseStudentRelationEN.UpdUserId = strOpUser;
return clscc_CourseStudentRelationBL.UpdateBySql2(objcc_CourseStudentRelationEN);
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
 bolIsExist = clscc_CourseStudentRelationDA.IsExistTable();
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
 bolIsExist = cc_CourseStudentRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_CourseStudentRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseStudentRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_CourseStudentRelationBL.AddNewRecordBySql2)", objcc_CourseStudentRelationEN.CourseId,objcc_CourseStudentRelationEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_CourseStudentRelationDA.AddNewRecordBySQL2(objcc_CourseStudentRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
 /// <param name = "objcc_CourseStudentRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseStudentRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_CourseStudentRelationBL.AddNewRecordBySql2WithReturnKey)", objcc_CourseStudentRelationEN.CourseId,objcc_CourseStudentRelationEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
string strKey = cc_CourseStudentRelationDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseStudentRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
 /// <param name = "objcc_CourseStudentRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
try
{
bool bolResult = cc_CourseStudentRelationDA.Update(objcc_CourseStudentRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
 /// <param name = "objcc_CourseStudentRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
 if (objcc_CourseStudentRelationEN.CourseStudentRelationId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_CourseStudentRelationDA.UpdateBySql2(objcc_CourseStudentRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseStudentRelationBL.ReFreshCache(objcc_CourseStudentRelationEN.CourseId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
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
 /// <param name = "lngCourseStudentRelationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngCourseStudentRelationId)
{
try
{
 clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = clscc_CourseStudentRelationBL.GetObjByCourseStudentRelationId(lngCourseStudentRelationId);

if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(objcc_CourseStudentRelationEN.CourseStudentRelationId, objcc_CourseStudentRelationEN.UpdUserId);
}
if (objcc_CourseStudentRelationEN != null)
{
int intRecNum = cc_CourseStudentRelationDA.DelRecord(lngCourseStudentRelationId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_CourseStudentRelationEN.CourseId);
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
/// <param name="lngCourseStudentRelationId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngCourseStudentRelationId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseStudentRelationDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseStudentRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_CourseStudentRelation.CourseStudentRelationId,
//lngCourseStudentRelationId);
//        clscc_CourseStudentRelationBL.Delcc_CourseStudentRelationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseStudentRelationBL.DelRecord(lngCourseStudentRelationId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseStudentRelationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngCourseStudentRelationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngCourseStudentRelationId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngCourseStudentRelationId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_CourseStudentRelationBL.relatedActions != null)
{
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(lngCourseStudentRelationId, "UpdRelaTabDate");
}
bool bolResult = cc_CourseStudentRelationDA.DelRecord(lngCourseStudentRelationId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
 /// <param name = "arrCourseStudentRelationIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_CourseStudentRelations(List<string> arrCourseStudentRelationIdLst)
{
if (arrCourseStudentRelationIdLst.Count == 0) return 0;
try
{
if (clscc_CourseStudentRelationBL.relatedActions != null)
{
foreach (var strCourseStudentRelationId in arrCourseStudentRelationIdLst)
{
long lngCourseStudentRelationId = long.Parse(strCourseStudentRelationId);
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(lngCourseStudentRelationId, "UpdRelaTabDate");
}
}
 clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN = clscc_CourseStudentRelationBL.GetObjByCourseStudentRelationId(long.Parse(arrCourseStudentRelationIdLst[0]));
int intDelRecNum = cc_CourseStudentRelationDA.Delcc_CourseStudentRelation(arrCourseStudentRelationIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_CourseStudentRelationEN.CourseId);
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
public static int Delcc_CourseStudentRelationsByCond(string strWhereCond)
{
try
{
if (clscc_CourseStudentRelationBL.relatedActions != null)
{
List<string> arrCourseStudentRelationId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCourseStudentRelationId in arrCourseStudentRelationId)
{
long lngCourseStudentRelationId = long.Parse(strCourseStudentRelationId);
clscc_CourseStudentRelationBL.relatedActions.UpdRelaTabDate(lngCourseStudentRelationId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(concc_CourseStudentRelation.CourseId, strWhereCond);
int intRecNum = cc_CourseStudentRelationDA.Delcc_CourseStudentRelation(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_CourseStudentRelation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngCourseStudentRelationId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngCourseStudentRelationId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseStudentRelationDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseStudentRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseStudentRelationBL.DelRecord(lngCourseStudentRelationId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseStudentRelationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngCourseStudentRelationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_CourseStudentRelationENS">源对象</param>
 /// <param name = "objcc_CourseStudentRelationENT">目标对象</param>
 public static void CopyTo(clscc_CourseStudentRelationEN objcc_CourseStudentRelationENS, clscc_CourseStudentRelationEN objcc_CourseStudentRelationENT)
{
try
{
objcc_CourseStudentRelationENT.CourseStudentRelationId = objcc_CourseStudentRelationENS.CourseStudentRelationId; //课程学生关系表流水号
objcc_CourseStudentRelationENT.CourseId = objcc_CourseStudentRelationENS.CourseId; //课程Id
objcc_CourseStudentRelationENT.IdStudentInfo = objcc_CourseStudentRelationENS.IdStudentInfo; //学生流水号
objcc_CourseStudentRelationENT.LastVisitedDate = objcc_CourseStudentRelationENS.LastVisitedDate; //最后访问时间
objcc_CourseStudentRelationENT.UpdDate = objcc_CourseStudentRelationENS.UpdDate; //修改日期
objcc_CourseStudentRelationENT.UpdUserId = objcc_CourseStudentRelationENS.UpdUserId; //修改用户Id
objcc_CourseStudentRelationENT.Memo = objcc_CourseStudentRelationENS.Memo; //备注
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
 /// <param name = "objcc_CourseStudentRelationEN">源简化对象</param>
 public static void SetUpdFlag(clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
try
{
objcc_CourseStudentRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_CourseStudentRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_CourseStudentRelation.CourseStudentRelationId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseStudentRelationEN.CourseStudentRelationId = objcc_CourseStudentRelationEN.CourseStudentRelationId; //课程学生关系表流水号
}
if (arrFldSet.Contains(concc_CourseStudentRelation.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseStudentRelationEN.CourseId = objcc_CourseStudentRelationEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_CourseStudentRelation.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseStudentRelationEN.IdStudentInfo = objcc_CourseStudentRelationEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(concc_CourseStudentRelation.LastVisitedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseStudentRelationEN.LastVisitedDate = objcc_CourseStudentRelationEN.LastVisitedDate == "[null]" ? null :  objcc_CourseStudentRelationEN.LastVisitedDate; //最后访问时间
}
if (arrFldSet.Contains(concc_CourseStudentRelation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseStudentRelationEN.UpdDate = objcc_CourseStudentRelationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_CourseStudentRelation.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseStudentRelationEN.UpdUserId = objcc_CourseStudentRelationEN.UpdUserId == "[null]" ? null :  objcc_CourseStudentRelationEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_CourseStudentRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseStudentRelationEN.Memo = objcc_CourseStudentRelationEN.Memo == "[null]" ? null :  objcc_CourseStudentRelationEN.Memo; //备注
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
 /// <param name = "objcc_CourseStudentRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
try
{
if (objcc_CourseStudentRelationEN.LastVisitedDate == "[null]") objcc_CourseStudentRelationEN.LastVisitedDate = null; //最后访问时间
if (objcc_CourseStudentRelationEN.UpdUserId == "[null]") objcc_CourseStudentRelationEN.UpdUserId = null; //修改用户Id
if (objcc_CourseStudentRelationEN.Memo == "[null]") objcc_CourseStudentRelationEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
 cc_CourseStudentRelationDA.CheckPropertyNew(objcc_CourseStudentRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
 cc_CourseStudentRelationDA.CheckProperty4Condition(objcc_CourseStudentRelationEN);
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
if (clscc_CourseStudentRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseStudentRelationBL没有刷新缓存机制(clscc_CourseStudentRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseStudentRelationId");
//if (arrcc_CourseStudentRelationObjLstCache == null)
//{
//arrcc_CourseStudentRelationObjLstCache = cc_CourseStudentRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngCourseStudentRelationId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseStudentRelationEN GetObjByCourseStudentRelationIdCache(long lngCourseStudentRelationId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clscc_CourseStudentRelationEN._CurrTabName, strCourseId);
List<clscc_CourseStudentRelationEN> arrcc_CourseStudentRelationObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseStudentRelationEN> arrcc_CourseStudentRelationObjLst_Sel =
arrcc_CourseStudentRelationObjLstCache
.Where(x=> x.CourseStudentRelationId == lngCourseStudentRelationId 
);
if (arrcc_CourseStudentRelationObjLst_Sel.Count() == 0)
{
   clscc_CourseStudentRelationEN obj = clscc_CourseStudentRelationBL.GetObjByCourseStudentRelationId(lngCourseStudentRelationId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngCourseStudentRelationId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrcc_CourseStudentRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseStudentRelationEN> GetAllcc_CourseStudentRelationObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clscc_CourseStudentRelationEN> arrcc_CourseStudentRelationObjLstCache = GetObjLstCache(strCourseId); 
return arrcc_CourseStudentRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseStudentRelationEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_CourseStudentRelationEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clscc_CourseStudentRelationEN> arrcc_CourseStudentRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrcc_CourseStudentRelationObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clscc_CourseStudentRelationEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseStudentRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_CourseStudentRelationEN._RefreshTimeLst.Count == 0) return "";
return clscc_CourseStudentRelationEN._RefreshTimeLst[clscc_CourseStudentRelationEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseStudentRelationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseStudentRelationEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseStudentRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_CourseStudentRelationBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_CourseStudentRelation(课程学生关系)
 /// 唯一性条件:CourseId_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_CourseStudentRelationEN objcc_CourseStudentRelationEN)
{
//检测记录是否存在
string strResult = cc_CourseStudentRelationDA.GetUniCondStr(objcc_CourseStudentRelationEN);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngCourseStudentRelationId, string strCourseId)
{
if (strInFldName != concc_CourseStudentRelation.CourseStudentRelationId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_CourseStudentRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_CourseStudentRelation.AttributeName));
throw new Exception(strMsg);
}
var objcc_CourseStudentRelation = clscc_CourseStudentRelationBL.GetObjByCourseStudentRelationIdCache(lngCourseStudentRelationId, strCourseId);
if (objcc_CourseStudentRelation == null) return "";
return objcc_CourseStudentRelation[strOutFldName].ToString();
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
int intRecCount = clscc_CourseStudentRelationDA.GetRecCount(strTabName);
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
int intRecCount = clscc_CourseStudentRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_CourseStudentRelationDA.GetRecCount();
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
int intRecCount = clscc_CourseStudentRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_CourseStudentRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_CourseStudentRelationEN objcc_CourseStudentRelationCond)
{
 string strCourseId = objcc_CourseStudentRelationCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clscc_CourseStudentRelationBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clscc_CourseStudentRelationEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseStudentRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseStudentRelation.AttributeName)
{
if (objcc_CourseStudentRelationCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseStudentRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseStudentRelationCond[strFldName].ToString());
}
else
{
if (objcc_CourseStudentRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseStudentRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseStudentRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseStudentRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseStudentRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseStudentRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseStudentRelationCond[strFldName]));
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
 List<string> arrList = clscc_CourseStudentRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseStudentRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseStudentRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_CourseStudentRelationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseStudentRelationDA.SetFldValue(clscc_CourseStudentRelationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_CourseStudentRelationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseStudentRelationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseStudentRelationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseStudentRelationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_CourseStudentRelation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**课程学生关系表流水号*/ 
 strCreateTabCode.Append(" CourseStudentRelationId bigint primary key identity, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" IdStudentInfo char(8) not Null, "); 
 // /**最后访问时间*/ 
 strCreateTabCode.Append(" LastVisitedDate varchar(14) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**姓名*/ 
 strCreateTabCode.Append(" StuName varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 课程学生关系(cc_CourseStudentRelation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_CourseStudentRelation : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clscc_CourseStudentRelationBL.ReFreshThisCache(strCourseId);
}
}

}