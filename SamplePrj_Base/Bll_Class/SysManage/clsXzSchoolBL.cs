
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchoolBL
 表名:XzSchool(01160012)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/19 02:35:47
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:简单工程样例
 工程ID:0116
 相关数据库:101.251.68.133,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:系统管理
 模块英文名:SysManage
 框架-层名:业务逻辑层(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using CommonTable.Entity;
using CommonTable.BusinessLogic;
using SimplePrj.Entity;
using System.Data; 
using System.Data.SqlClient; 
using SimplePrj.DAL;

namespace SimplePrj.BusinessLogic
{
public static class clsXzSchoolBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strid_School">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzSchoolEN GetObj(this K_id_School_XzSchool myKey)
{
clsXzSchoolEN objXzSchoolEN = clsXzSchoolBL.XzSchoolDA.GetObjByid_School(myKey.Value);
return objXzSchoolEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzSchoolEN objXzSchoolEN)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.id_School) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchoolBL.IsExist(objXzSchoolEN.id_School) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objXzSchoolEN.id_School, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsXzSchoolBL.XzSchoolDA.AddNewRecordBySQL2(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();
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
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchoolEN Setid_School(this clsXzSchoolEN objXzSchoolEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, clsXzSchoolEN.con_id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, clsXzSchoolEN.con_id_School);
objXzSchoolEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(clsXzSchoolEN.con_id_School) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(clsXzSchoolEN.con_id_School, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[clsXzSchoolEN.con_id_School] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchoolEN SetSchoolId(this clsXzSchoolEN objXzSchoolEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, clsXzSchoolEN.con_SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 20, clsXzSchoolEN.con_SchoolId);
objXzSchoolEN.SchoolId = strSchoolId; //学校Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(clsXzSchoolEN.con_SchoolId) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(clsXzSchoolEN.con_SchoolId, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[clsXzSchoolEN.con_SchoolId] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchoolEN SetSchoolName(this clsXzSchoolEN objXzSchoolEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, clsXzSchoolEN.con_SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, clsXzSchoolEN.con_SchoolName);
objXzSchoolEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(clsXzSchoolEN.con_SchoolName) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(clsXzSchoolEN.con_SchoolName, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[clsXzSchoolEN.con_SchoolName] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchoolEN SetIsCurrentUse(this clsXzSchoolEN objXzSchoolEN, bool bolIsCurrentUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCurrentUse, clsXzSchoolEN.con_IsCurrentUse);
objXzSchoolEN.IsCurrentUse = bolIsCurrentUse; //是否当前使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(clsXzSchoolEN.con_IsCurrentUse) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(clsXzSchoolEN.con_IsCurrentUse, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[clsXzSchoolEN.con_IsCurrentUse] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchoolEN SetMemo(this clsXzSchoolEN objXzSchoolEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, clsXzSchoolEN.con_Memo);
objXzSchoolEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(clsXzSchoolEN.con_Memo) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(clsXzSchoolEN.con_Memo, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[clsXzSchoolEN.con_Memo] = strComparisonOp;
}
}
return objXzSchoolEN;
	}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzSchoolEN objXzSchoolEN)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.id_School) == true)
 {
string strMsg = string.Format("(errid:Busi000085)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzSchoolBL.XzSchoolDA.UpdateBySql2(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzSchoolEN objXzSchoolEN, string strWhereCond)
{
try
{
bool bolResult = clsXzSchoolBL.XzSchoolDA.UpdateBySqlWithCondition(objXzSchoolEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();
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
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "strid_School">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzSchoolEN objXzSchoolEN)
{
try
{
int intRecNum = clsXzSchoolBL.XzSchoolDA.DelRecord(objXzSchoolEN.id_School);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolBL.ReFreshCache();
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
 /// <param name = "objXzSchoolENS">源对象</param>
 /// <param name = "objXzSchoolENT">目标对象</param>
 public static void CopyTo(this clsXzSchoolEN objXzSchoolENS, clsXzSchoolEN objXzSchoolENT)
{
try
{
clsXzSchoolBL.XzSchoolDA.CopyTo(objXzSchoolENS, objXzSchoolENT);
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000093)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objXzSchoolENS">源对象</param>
 /// <returns>目标对象=>clsXzSchoolEN:objXzSchoolENT</returns>
 public static clsXzSchoolEN CopyTo(this clsXzSchoolEN objXzSchoolENS)
{
try
{
 clsXzSchoolEN objXzSchoolENT = new clsXzSchoolEN();
clsXzSchoolBL.XzSchoolDA.CopyTo(objXzSchoolENS, objXzSchoolENT);
 return objXzSchoolENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000094)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsXzSchoolEN objXzSchoolEN)
{
 clsXzSchoolBL.XzSchoolDA.CheckPropertyNew(objXzSchoolEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzSchoolEN objXzSchoolEN)
{
 clsXzSchoolBL.XzSchoolDA.CheckProperty4Condition(objXzSchoolEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzSchoolEN objCond_XzSchoolEN)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCond_XzSchoolEN.IsUpdated(clsXzSchoolEN.con_id_School) == true)
{
string strComparisonOp_id_School = objCond_XzSchoolEN.dicFldComparisonOp[clsXzSchoolEN.con_id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsXzSchoolEN.con_id_School, objCond_XzSchoolEN.id_School, strComparisonOp_id_School);
}
if (objCond_XzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolId) == true)
{
string strComparisonOp_SchoolId = objCond_XzSchoolEN.dicFldComparisonOp[clsXzSchoolEN.con_SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsXzSchoolEN.con_SchoolId, objCond_XzSchoolEN.SchoolId, strComparisonOp_SchoolId);
}
if (objCond_XzSchoolEN.IsUpdated(clsXzSchoolEN.con_SchoolName) == true)
{
string strComparisonOp_SchoolName = objCond_XzSchoolEN.dicFldComparisonOp[clsXzSchoolEN.con_SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsXzSchoolEN.con_SchoolName, objCond_XzSchoolEN.SchoolName, strComparisonOp_SchoolName);
}
if (objCond_XzSchoolEN.IsUpdated(clsXzSchoolEN.con_IsCurrentUse) == true)
{
if (objCond_XzSchoolEN.IsCurrentUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsXzSchoolEN.con_IsCurrentUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsXzSchoolEN.con_IsCurrentUse);
}
}
if (objCond_XzSchoolEN.IsUpdated(clsXzSchoolEN.con_Memo) == true)
{
string strComparisonOp_Memo = objCond_XzSchoolEN.dicFldComparisonOp[clsXzSchoolEN.con_Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsXzSchoolEN.con_Memo, objCond_XzSchoolEN.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzSchool(学校), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objXzSchoolEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckXzSchoolUniqueness(this clsXzSchoolEN objXzSchoolEN)
{
//检测记录是否存在
bool bolIsUniqueness = true;
if (objXzSchoolEN == null) return true;
if (objXzSchoolEN.id_School == null || objXzSchoolEN.id_School == "")
{
bolIsUniqueness = clsXzSchoolBL.XzSchoolDA.CheckXzSchoolUniqueness();
}
else
{
bolIsUniqueness = clsXzSchoolBL.XzSchoolDA.CheckXzSchoolUniqueness(objXzSchoolEN.id_School);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--XzSchool(学校)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzSchoolEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniquenessConditionString(this clsXzSchoolEN objXzSchoolEN)
{
//检测记录是否存在
string strResult;
strResult = clsXzSchoolBL.XzSchoolDA.GetUniquenessConditionString(objXzSchoolEN.id_School);
return strResult;
}
}
 /// <summary>
 /// 学校(XzSchool)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzSchoolBL
{

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "XzSchoolListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "XzSchoolList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
public static List<clsXzSchoolEN> arrXzSchoolObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;
   private static string strMsg = "";

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzSchoolDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzSchoolDA XzSchoolDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzSchoolDA();
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
 public clsXzSchoolBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
 clsSpecSQLforSql objSQL = null;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsXzSchoolEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzSchoolEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS = null;
try
{
objDS = XzSchoolDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS = null;
try
{
objDS = XzSchoolDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS = null;
try
{
objDS = XzSchoolDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_V_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetV(string strWhereCond)
{
DataSet objDS = null;
try
{
objDS = XzSchoolDA.GetDataSetV(strWhereCond);
return objDS;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000004)获取表视图数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_XzSchool(string strWhereCond)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable_XzSchool(strWhereCond);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable(strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000008)获取表数据出错!(是否检查SQL攻击), {1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4TabByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4TabByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4TabByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, bool bolIsCheckSQLAttack)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable(strWhereCond, strTabName, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000063)获取表数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable4Tab)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.WhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable4Tab)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable4Tab)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager4Tab)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager4Tab)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager4Tab)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4TabByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4TabByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4TabByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTableByRange(strWhereCond, bolIsCheckSQLAttack, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取当前表视图的数据表,用DataTable表示
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4TabV)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据表,用DataTable表示</returns>
public static DataTable GetDataTableV(string strWhereCond)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTableV(strWhereCond);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000018)获取表视图数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取当前表视图的数据表,用DataTable表示
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable4TabV)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据表,用DataTable表示</returns>
public static DataTable GetDataTable_XzSchoolV(string strWhereCond)
{
DataTable objDT = null;
try
{
objDT = XzSchoolDA.GetDataTable_XzSchoolV(strWhereCond);
return objDT;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000019)获取表视图数据出错!(strWhereCond = {1}),{2}.({0})",
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
 /// <param name = "arrId_SchoolLst">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static List<clsXzSchoolEN> GetObjLstById_SchoolLst(List<string> arrId_SchoolLst)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrId_SchoolLst, true);
 string strWhereCond = string.Format("id_School in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLst(string strWhereCond)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
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
List<clsXzSchoolEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzSchoolEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.TopSize, objTopPara.WhereCond, objTopPara.OrderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 stuTopPara objTopPara = new stuTopPara()
 {
 TopSize = intTopSize,
 WhereCond = strWhereCond,
 OrderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.PageIndex, objPagerPara.PageSize, objPagerPara.WhereCond, objPagerPara.OrderBy);
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
public static List<clsXzSchoolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
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
public static List<clsXzSchoolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.WhereCond, objRangePara.OrderBy, objRangePara.MinNum, objRangePara.MaxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow[clsXzSchoolEN.con_id_School].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow[clsXzSchoolEN.con_SchoolId].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow[clsXzSchoolEN.con_SchoolName].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[clsXzSchoolEN.con_IsCurrentUse].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow[clsXzSchoolEN.con_Memo].ToString().Trim(); //备注
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzSchoolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzSchool(ref clsXzSchoolEN objXzSchoolEN)
{
bool bolResult = XzSchoolDA.GetXzSchool(ref objXzSchoolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strid_School">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzSchoolEN GetObjByid_School(string strid_School)
{
if (strid_School.IndexOf(' ') >=0)
{
strMsg = string.Format("(errid:Busi000079)在表中,关键字[strid_School]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strid_School) == true)
{
strMsg = string.Format("(errid:Busi000020)在表中,关键字[strid_School]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzSchoolEN objXzSchoolEN = XzSchoolDA.GetObjByid_School(strid_School);
return objXzSchoolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzSchoolEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzSchoolEN objXzSchoolEN = XzSchoolDA.GetFirstObj(strWhereCond);
 return objXzSchoolEN;
 }
 catch (Exception objException)
 {
strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
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
public static clsXzSchoolEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzSchoolEN objXzSchoolEN = XzSchoolDA.GetObjByDataRow(objRow);
 return objXzSchoolEN;
 }
 catch (Exception objException)
 {
strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
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
public static clsXzSchoolEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzSchoolEN objXzSchoolEN = XzSchoolDA.GetObjByDataRow(objRow);
 return objXzSchoolEN;
 }
 catch (Exception objException)
 {
strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <param name = "lstXzSchoolObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzSchoolEN GetObjByid_SchoolFromList(string strid_School, List<clsXzSchoolEN> lstXzSchoolObjLst)
{
foreach (clsXzSchoolEN objXzSchoolEN in lstXzSchoolObjLst)
{
if (objXzSchoolEN.id_School == strid_School)
{
return objXzSchoolEN;
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
 string strMaxId_School;
 try
 {
 strMaxId_School = clsXzSchoolDA.GetMaxStrId();
 return strMaxId_School;
 }
 catch (Exception objException)
 {
strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrIdByPrefix_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix_S(string strPrefix) 
{
if (string.IsNullOrEmpty(strPrefix) == true)
{
strMsg = string.Format("前缀不能为空.(from {0})",
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
 string strMaxId_School;
 try
 {
 strMaxId_School = new clsXzSchoolDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxId_School;
 }
 catch (Exception objException)
 {
strMsg = string.Format("(errid:Busi000025)根据前缀获取最大关键字值出错, {1}.(from {0})",
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
 string strid_School;
 try
 {
 strid_School = new clsXzSchoolDA().GetFirstID(strWhereCond);
 return strid_School;
 }
 catch (Exception objException)
 {
strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
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
 List<string> arrList = new List<string>();
 try
 {
 arrList = XzSchoolDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
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
bool bolIsExist = XzSchoolDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strid_School">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true)
{
strMsg = string.Format("(errid:Busi000027)在表中,关键字[strid_School]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzSchoolDA.IsExist(strid_School);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist = false;
 try
 {
 bolIsExist = clsXzSchoolDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
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
 bool bolIsExist = false;
 try
 {
 bolIsExist = XzSchoolDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzSchoolEN objXzSchoolEN)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.id_School) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchoolBL.IsExist(objXzSchoolEN.id_School) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objXzSchoolEN.id_School, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = XzSchoolDA.AddNewRecordBySQL2(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strXzSchoolObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strXzSchoolObjXml)
{
clsXzSchoolEN objXzSchoolEN = GetObjFromXmlStr(strXzSchoolObjXml);
try
{
bool bolResult = XzSchoolDA.AddNewRecordBySQL2(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000032)添加记录出错!(使用XML), {1}.(from {0})",
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzSchoolEN objXzSchoolEN)
{
try
{
bool bolResult = XzSchoolDA.Update(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzSchoolEN objXzSchoolEN)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.id_School) == true)
 {
strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzSchoolDA.UpdateBySql2(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strXzSchoolObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strXzSchoolObjXml)
{
clsXzSchoolEN objXzSchoolEN = GetObjFromXmlStr(strXzSchoolObjXml);
try
{
bool bolResult = XzSchoolDA.UpdateBySql2(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000038)修改记录(UpdateBySql_XML)出错,{1}.!(from {0})",
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
 /// <param name = "strid_School">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strid_School)
{
try
{
int intRecNum = XzSchoolDA.DelRecord(strid_School);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "strid_School">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strid_School, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = XzSchoolDA.DelRecord(strid_School,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordBySP_S)
 /// </summary>
 /// <param name = "strid_School">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strid_School) 
{
try
{
bool bolResult = XzSchoolDA.DelRecordBySP(strid_School);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000041)通过存储过程删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrid_SchoolLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzSchools(List<string> arrid_SchoolLst)
{
try
{
int intDelRecNum = XzSchoolDA.DelXzSchool(arrid_SchoolLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
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
public static int DelXzSchoolsByCond(string strWhereCond)
{
try
{
int intRecNum = XzSchoolDA.DelXzSchool(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[XzSchool]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strid_School">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strid_School)
{
clsSpecSQLforSql objSQL = null;
//获取连接对象
objSQL = clsXzSchoolDA.GetSpecSQLObj();
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
//删除与表:[XzSchool]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//constStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzSchoolBL.DelRecord(strid_School, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzSchoolBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！KeyId = {1}.({2})",
objException.Message,
strid_School, clsStackTrace.GetCurrClassFunction());
clsPubVar4BLEx4CommonTable.objErrorLog.WriteDebugLog(strMsg);
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
 /// <param name = "objXzSchoolENS">源对象</param>
 /// <param name = "objXzSchoolENT">目标对象</param>
 public static void CopyTo(clsXzSchoolEN objXzSchoolENS, clsXzSchoolEN objXzSchoolENT)
{
try
{
XzSchoolDA.CopyTo(objXzSchoolENS, objXzSchoolENT);
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objXzSchoolEN">源简化对象</param>
 public static void SetUpdFlag(clsXzSchoolEN objXzSchoolEN)
{
try
{
objXzSchoolEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objXzSchoolEN.sf_UpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(clsXzSchoolEN.con_id_School)  ==  true)
{
objXzSchoolEN.id_School = objXzSchoolEN.id_School; //学校流水号
}
if (arrFldSet.Contains(clsXzSchoolEN.con_SchoolId)  ==  true)
{
objXzSchoolEN.SchoolId = objXzSchoolEN.SchoolId; //学校Id
}
if (arrFldSet.Contains(clsXzSchoolEN.con_SchoolName)  ==  true)
{
objXzSchoolEN.SchoolName = objXzSchoolEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(clsXzSchoolEN.con_IsCurrentUse)  ==  true)
{
objXzSchoolEN.IsCurrentUse = objXzSchoolEN.IsCurrentUse; //是否当前使用
}
if (arrFldSet.Contains(clsXzSchoolEN.con_Memo)  ==  true)
{
objXzSchoolEN.Memo = objXzSchoolEN.Memo; //备注
}
}
catch (Exception objException)
{
strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
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
public static void CheckPropertyNew(clsXzSchoolEN objXzSchoolEN)
{
 XzSchoolDA.CheckPropertyNew(objXzSchoolEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzSchoolEN objXzSchoolEN)
{
 XzSchoolDA.CheckProperty4Condition(objXzSchoolEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_School(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", clsXzSchoolEN.con_id_School); 
List<clsXzSchoolEN> arrObjLst = clsXzSchoolBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN()
{
id_School = "0",
SchoolName = "请选择[学校]..."
};
arrObjLst.Insert(0, objXzSchoolEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = clsXzSchoolEN.con_id_School;
objComboBox.DisplayMember = clsXzSchoolEN.con_SchoolName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_School(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[学校]...","0");
string strCondition = string.Format("1 =1 Order By {0}", clsXzSchoolEN.con_id_School); 
IEnumerable<clsXzSchoolEN> arrObjLst = clsXzSchoolBL.GetObjLst(strCondition);
objDDL.DataValueField = clsXzSchoolEN.con_id_School;
objDDL.DataTextField = clsXzSchoolEN.con_SchoolName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunction_Cache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_School_Cache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[学校]...","0");
List<clsXzSchoolEN> arrXzSchoolObjLst = GetAllXzSchoolObjLst_Cache(); 
objDDL.DataValueField = clsXzSchoolEN.con_id_School;
objDDL.DataTextField = clsXzSchoolEN.con_SchoolName;
objDDL.DataSource = arrXzSchoolObjLst;
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
string strMsg = "";
if (clsXzSchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolBL没有刷新缓存机制(clsXzSchoolBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by id_School");
if (arrXzSchoolObjLst_Cache == null)
{
arrXzSchoolObjLst_Cache = XzSchoolDA.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzSchoolEN GetObjByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return null;
//初始化列表缓存
InitListCache(); 
IEnumerable <clsXzSchoolEN> arrXzSchoolObjLst_Sel =
clsXzSchoolBL.arrXzSchoolObjLst_Cache
.Where(x => x.id_School == strid_School);
if (arrXzSchoolObjLst_Sel.Count() == 0)
{
   clsXzSchoolEN obj = clsXzSchoolBL.GetObjByid_School(strid_School);
   if (obj != null)
 {
     clsXzSchoolBL.arrXzSchoolObjLst_Cache = null;
     return obj;
 }
return null;
}
return arrXzSchoolObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.(再试一次)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache_TryOnce)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzSchoolEN GetObjByid_School_Cache_TryOnce(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return null;
//初始化列表缓存
InitListCache(); 
IEnumerable <clsXzSchoolEN> arrXzSchoolObjLst_Sel =
clsXzSchoolBL.arrXzSchoolObjLst_Cache
.Where(x=>x.id_School == strid_School);
if (arrXzSchoolObjLst_Sel.Count() >= 0)
{
return arrXzSchoolObjLst_Sel.First();
}
intFindFailCount++;
// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
arrXzSchoolObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByid_School_Cache_TryOnce(strid_School);
string strErrMsgForGetObjById = string.Format("在XzSchool对象缓存列表中,找不到记录[id_School = {0}][intFindFailCount = {1}](函数:{2})", strid_School, intFindFailCount, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzSchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSchoolNameByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return "";
//初始化列表缓存
InitListCache(); 
IEnumerable <clsXzSchoolEN> arrXzSchoolObjLst_Sel1 =
from objXzSchoolEN in clsXzSchoolBL.arrXzSchoolObjLst_Cache
where objXzSchoolEN.id_School == strid_School
select objXzSchoolEN;
List <clsXzSchoolEN> arrXzSchoolObjLst_Sel = new List<clsXzSchoolEN>();
foreach (clsXzSchoolEN obj in arrXzSchoolObjLst_Sel1)
{
arrXzSchoolObjLst_Sel.Add(obj);
}
if (arrXzSchoolObjLst_Sel.Count > 0)
{
return arrXzSchoolObjLst_Sel[0].SchoolName;
}
string strErrMsgForGetObjById = string.Format("在XzSchool对象缓存列表中,找不到记录[id_School = {0}](函数:{1})", strid_School, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzSchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return "";
//初始化列表缓存
InitListCache(); 
IEnumerable <clsXzSchoolEN> arrXzSchoolObjLst_Sel1 =
from objXzSchoolEN in clsXzSchoolBL.arrXzSchoolObjLst_Cache
where objXzSchoolEN.id_School == strid_School
select objXzSchoolEN;
List <clsXzSchoolEN> arrXzSchoolObjLst_Sel = new List<clsXzSchoolEN>();
foreach (clsXzSchoolEN obj in arrXzSchoolObjLst_Sel1)
{
arrXzSchoolObjLst_Sel.Add(obj);
}
if (arrXzSchoolObjLst_Sel.Count > 0)
{
return arrXzSchoolObjLst_Sel[0].SchoolName;
}
string strErrMsgForGetObjById = string.Format("在XzSchool对象缓存列表中,找不到记录的相关名称[id_School = {0}](函数:{1})", strid_School, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzSchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzSchoolEN> GetAllXzSchoolObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
return arrXzSchoolObjLst_Cache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzSchoolEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
return arrXzSchoolObjLst_Cache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
arrXzSchoolObjLst_Cache = null;
strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
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
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
clsDynamicFunction objDynamicFunction = new clsDynamicFunction()
{
NameSpace = "SimplePrj.BusinessLogic",
ClassName = "clsXzSchoolBL",
AssemblyType = typeof(SimplePrj.BusinessLogic.clsXzSchoolBL),
FunctionName = clsStackTrace.GetCurrFunction()
};
if (clsDynamicFunction.IsExistSameFunction(clsSysParaEN.arrFunctionLst4Queue, objDynamicFunction) == true)
{
return;
}
clsSysParaEN.arrFunctionLst4Queue.Enqueue(objDynamicFunction);
return;
}
if (clsXzSchoolBL.objCommFun4BL != null) 
{
 string strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrXzSchoolObjLst_Cache = null;
clsXzSchoolBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzSchool(学校), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objXzSchoolEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckXzSchoolUniqueness(clsXzSchoolEN objXzSchoolEN)
{
//检测记录是否存在
bool bolIsUniqueness = true;
if (objXzSchoolEN == null) return true;
if (objXzSchoolEN.id_School == null || objXzSchoolEN.id_School == "")
{
bolIsUniqueness = XzSchoolDA.CheckXzSchoolUniqueness();
}
else
{
bolIsUniqueness = XzSchoolDA.CheckXzSchoolUniqueness(objXzSchoolEN.id_School);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--XzSchool(学校)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzSchoolEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniquenessConditionString(clsXzSchoolEN objXzSchoolEN)
{
//检测记录是否存在
string strResult;
strResult = XzSchoolDA.GetUniquenessConditionString(objXzSchoolEN.id_School);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:
 /// 日期:2019-10-19023547
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstXzSchoolObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsXzSchoolEN> lstXzSchoolObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstXzSchoolObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:
 /// 日期:2019-10-19023547
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstXzSchoolObjLst">[clsXzSchoolEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsXzSchoolEN> lstXzSchoolObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsXzSchoolBL.listXmlNode);
writer.WriteStartElement(clsXzSchoolBL.itemsXmlNode);
foreach (clsXzSchoolEN objXzSchoolEN in lstXzSchoolObjLst)
{
clsXzSchoolBL.SerializeXML(writer, objXzSchoolEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:
 /// 日期:2019-10-19023547
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objXzSchoolEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsXzSchoolEN objXzSchoolEN)
{
writer.WriteStartElement(clsXzSchoolBL.itemXmlNode);
 
if (objXzSchoolEN.id_School != null)
{
writer.WriteElementString(clsXzSchoolEN.con_id_School, objXzSchoolEN.id_School.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzSchoolEN.SchoolId != null)
{
writer.WriteElementString(clsXzSchoolEN.con_SchoolId, objXzSchoolEN.SchoolId.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzSchoolEN.SchoolName != null)
{
writer.WriteElementString(clsXzSchoolEN.con_SchoolName, objXzSchoolEN.SchoolName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(clsXzSchoolEN.con_IsCurrentUse, objXzSchoolEN.IsCurrentUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objXzSchoolEN.Memo != null)
{
writer.WriteElementString(clsXzSchoolEN.con_Memo, objXzSchoolEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:
 /// 日期:2019-10-19023547
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsXzSchoolEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
reader.Read();
while (!(reader.Name == clsXzSchoolBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(clsXzSchoolEN.con_id_School))
{
objXzSchoolEN.id_School = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(clsXzSchoolEN.con_SchoolId))
{
objXzSchoolEN.SchoolId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(clsXzSchoolEN.con_SchoolName))
{
objXzSchoolEN.SchoolName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(clsXzSchoolEN.con_IsCurrentUse))
{
objXzSchoolEN.IsCurrentUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(clsXzSchoolEN.con_Memo))
{
objXzSchoolEN.Memo = reader.ReadElementContentAsString();
}
}
return objXzSchoolEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strXzSchoolObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsXzSchoolEN GetObjFromXmlStr(string strXzSchoolObjXmlStr)
{
clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strXzSchoolObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsXzSchoolBL.itemXmlNode))
{
objXzSchoolEN = GetObjFromXml(reader);
return objXzSchoolEN;
}
}
return objXzSchoolEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:
 /// 日期:2019-10-19023547
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsXzSchoolEN objXzSchoolEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objXzSchoolEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:
 /// 日期:2019-10-19023547
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsXzSchoolEN objXzSchoolEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsXzSchoolEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objXzSchoolEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:
 /// 日期:2019-10-19023547
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstXzSchoolObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsXzSchoolEN> lstXzSchoolObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstXzSchoolObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsXzSchoolEN objXzSchoolEN in lstXzSchoolObjLst)
{
string strJSON_One = SerializeObjToJSON(objXzSchoolEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsXzSchoolDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsXzSchoolDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzSchoolDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funGetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsXzSchoolDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsXzSchoolDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funGetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = XzSchoolDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funGetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = XzSchoolDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzSchoolDA.SetFldValue(strFldName, strValue, strWhereCond);
ReFreshCache();
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
int intRecCount = clsXzSchoolDA.SetFldValue(clsXzSchoolEN._CurrTabName_S, strFldName, fltValue, strWhereCond);
ReFreshCache();
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
int intRecCount = XzSchoolDA.SetFldValue( strFldName, intValue, strWhereCond);
ReFreshCache();
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
int intRecCount = clsXzSchoolDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
ReFreshCache();
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
int intRecCount = clsXzSchoolDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
ReFreshCache();
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
int intRecCount = clsXzSchoolDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
ReFreshCache();
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
  strCreateTabCode.Append("CREATE table [dbo].[XzSchool] "); 
 strCreateTabCode.Append(" ( "); 
 // /*学校流水号*/ 
 strCreateTabCode.Append(" id_School char(4) primary key, "); 
 // /*学校Id*/ 
 strCreateTabCode.Append(" SchoolId varchar(20) not Null, "); 
 // /*学校名称*/ 
 strCreateTabCode.Append(" SchoolName varchar(50) not Null, "); 
 // /*是否当前使用*/ 
 strCreateTabCode.Append(" IsCurrentUse bit not Null, "); 
 // /*备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步


 #region 排序相关函数


 #endregion 排序相关函数
}
}