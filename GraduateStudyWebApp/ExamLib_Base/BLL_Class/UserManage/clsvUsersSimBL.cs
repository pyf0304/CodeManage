
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersSimBL
 表名:vUsersSim(01120699)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:20:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
public static class  clsvUsersSimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsersSimEN GetObj(this K_UserId_vUsersSim myKey)
{
clsvUsersSimEN objvUsersSimEN = clsvUsersSimBL.vUsersSimDA.GetObjByUserId(myKey.Value);
return objvUsersSimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersSimEN SetUserId(this clsvUsersSimEN objvUsersSimEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convUsersSim.UserId);
}
objvUsersSimEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.UserId) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.UserId, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.UserId] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersSimEN SetUserName(this clsvUsersSimEN objvUsersSimEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convUsersSim.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convUsersSim.UserName);
}
objvUsersSimEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.UserName) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.UserName, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.UserName] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersSimEN SetIdXzCollege(this clsvUsersSimEN objvUsersSimEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convUsersSim.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convUsersSim.IdXzCollege);
}
objvUsersSimEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.IdXzCollege) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.IdXzCollege, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.IdXzCollege] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersSimEN SetCollegeName(this clsvUsersSimEN objvUsersSimEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convUsersSim.CollegeName);
}
objvUsersSimEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.CollegeName) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.CollegeName, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.CollegeName] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersSimEN SetIdXzMajor(this clsvUsersSimEN objvUsersSimEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convUsersSim.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convUsersSim.IdXzMajor);
}
objvUsersSimEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.IdXzMajor) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.IdXzMajor, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.IdXzMajor] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersSimEN SetMajorName(this clsvUsersSimEN objvUsersSimEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convUsersSim.MajorName);
}
objvUsersSimEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.MajorName) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.MajorName, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.MajorName] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersSimEN SetHeadPic(this clsvUsersSimEN objvUsersSimEN, string strHeadPic, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHeadPic, 500, convUsersSim.HeadPic);
}
objvUsersSimEN.HeadPic = strHeadPic; //头像
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.HeadPic) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.HeadPic, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.HeadPic] = strComparisonOp;
}
}
return objvUsersSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersSimEN SetIsGSuser(this clsvUsersSimEN objvUsersSimEN, bool bolIsGSuser, string strComparisonOp="")
	{
objvUsersSimEN.IsGSuser = bolIsGSuser; //是否GS用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersSimEN.dicFldComparisonOp.ContainsKey(convUsersSim.IsGSuser) == false)
{
objvUsersSimEN.dicFldComparisonOp.Add(convUsersSim.IsGSuser, strComparisonOp);
}
else
{
objvUsersSimEN.dicFldComparisonOp[convUsersSim.IsGSuser] = strComparisonOp;
}
}
return objvUsersSimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUsersSimENS">源对象</param>
 /// <param name = "objvUsersSimENT">目标对象</param>
 public static void CopyTo(this clsvUsersSimEN objvUsersSimENS, clsvUsersSimEN objvUsersSimENT)
{
try
{
objvUsersSimENT.UserId = objvUsersSimENS.UserId; //用户ID
objvUsersSimENT.UserName = objvUsersSimENS.UserName; //用户名
objvUsersSimENT.IdXzCollege = objvUsersSimENS.IdXzCollege; //学院流水号
objvUsersSimENT.CollegeName = objvUsersSimENS.CollegeName; //学院名称
objvUsersSimENT.IdXzMajor = objvUsersSimENS.IdXzMajor; //专业流水号
objvUsersSimENT.MajorName = objvUsersSimENS.MajorName; //专业名称
objvUsersSimENT.HeadPic = objvUsersSimENS.HeadPic; //头像
objvUsersSimENT.IsGSuser = objvUsersSimENS.IsGSuser; //是否GS用户
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
 /// <param name = "objvUsersSimENS">源对象</param>
 /// <returns>目标对象=>clsvUsersSimEN:objvUsersSimENT</returns>
 public static clsvUsersSimEN CopyTo(this clsvUsersSimEN objvUsersSimENS)
{
try
{
 clsvUsersSimEN objvUsersSimENT = new clsvUsersSimEN()
{
UserId = objvUsersSimENS.UserId, //用户ID
UserName = objvUsersSimENS.UserName, //用户名
IdXzCollege = objvUsersSimENS.IdXzCollege, //学院流水号
CollegeName = objvUsersSimENS.CollegeName, //学院名称
IdXzMajor = objvUsersSimENS.IdXzMajor, //专业流水号
MajorName = objvUsersSimENS.MajorName, //专业名称
HeadPic = objvUsersSimENS.HeadPic, //头像
IsGSuser = objvUsersSimENS.IsGSuser, //是否GS用户
};
 return objvUsersSimENT;
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
public static void CheckProperty4Condition(this clsvUsersSimEN objvUsersSimEN)
{
 clsvUsersSimBL.vUsersSimDA.CheckProperty4Condition(objvUsersSimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUsersSimEN objvUsersSimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUsersSimCond.IsUpdated(convUsersSim.UserId) == true)
{
string strComparisonOpUserId = objvUsersSimCond.dicFldComparisonOp[convUsersSim.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.UserId, objvUsersSimCond.UserId, strComparisonOpUserId);
}
if (objvUsersSimCond.IsUpdated(convUsersSim.UserName) == true)
{
string strComparisonOpUserName = objvUsersSimCond.dicFldComparisonOp[convUsersSim.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.UserName, objvUsersSimCond.UserName, strComparisonOpUserName);
}
if (objvUsersSimCond.IsUpdated(convUsersSim.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvUsersSimCond.dicFldComparisonOp[convUsersSim.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.IdXzCollege, objvUsersSimCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvUsersSimCond.IsUpdated(convUsersSim.CollegeName) == true)
{
string strComparisonOpCollegeName = objvUsersSimCond.dicFldComparisonOp[convUsersSim.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.CollegeName, objvUsersSimCond.CollegeName, strComparisonOpCollegeName);
}
if (objvUsersSimCond.IsUpdated(convUsersSim.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvUsersSimCond.dicFldComparisonOp[convUsersSim.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.IdXzMajor, objvUsersSimCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvUsersSimCond.IsUpdated(convUsersSim.MajorName) == true)
{
string strComparisonOpMajorName = objvUsersSimCond.dicFldComparisonOp[convUsersSim.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.MajorName, objvUsersSimCond.MajorName, strComparisonOpMajorName);
}
if (objvUsersSimCond.IsUpdated(convUsersSim.HeadPic) == true)
{
string strComparisonOpHeadPic = objvUsersSimCond.dicFldComparisonOp[convUsersSim.HeadPic];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsersSim.HeadPic, objvUsersSimCond.HeadPic, strComparisonOpHeadPic);
}
if (objvUsersSimCond.IsUpdated(convUsersSim.IsGSuser) == true)
{
if (objvUsersSimCond.IsGSuser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsersSim.IsGSuser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsersSim.IsGSuser);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUsersSim
{
public virtual bool UpdRelaTabDate(string strUserId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vUsersSim(vUsersSim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUsersSimBL
{
public static RelatedActions_vUsersSim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUsersSimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUsersSimDA vUsersSimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUsersSimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUsersSimBL()
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
if (string.IsNullOrEmpty(clsvUsersSimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUsersSimEN._ConnectString);
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
public static DataTable GetDataTable_vUsersSim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUsersSimDA.GetDataTable_vUsersSim(strWhereCond);
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
objDT = vUsersSimDA.GetDataTable(strWhereCond);
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
objDT = vUsersSimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vUsersSimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vUsersSimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vUsersSimDA.GetDataTable_Top(objTopPara);
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
objDT = vUsersSimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vUsersSimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vUsersSimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvUsersSimEN> GetObjLstByUserIdLst(List<string> arrUserIdLst)
{
List<clsvUsersSimEN> arrObjLst = new List<clsvUsersSimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrUserIdLst, true);
 string strWhereCond = string.Format("UserId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN();
try
{
objvUsersSimEN.UserId = objRow[convUsersSim.UserId].ToString().Trim(); //用户ID
objvUsersSimEN.UserName = objRow[convUsersSim.UserName].ToString().Trim(); //用户名
objvUsersSimEN.IdXzCollege = objRow[convUsersSim.IdXzCollege] == DBNull.Value ? null : objRow[convUsersSim.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersSimEN.CollegeName = objRow[convUsersSim.CollegeName] == DBNull.Value ? null : objRow[convUsersSim.CollegeName].ToString().Trim(); //学院名称
objvUsersSimEN.IdXzMajor = objRow[convUsersSim.IdXzMajor] == DBNull.Value ? null : objRow[convUsersSim.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersSimEN.MajorName = objRow[convUsersSim.MajorName] == DBNull.Value ? null : objRow[convUsersSim.MajorName].ToString().Trim(); //专业名称
objvUsersSimEN.HeadPic = objRow[convUsersSim.HeadPic] == DBNull.Value ? null : objRow[convUsersSim.HeadPic].ToString().Trim(); //头像
objvUsersSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsersSim.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersSimEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUsersSimEN> GetObjLstByUserIdLstCache(List<string> arrUserIdLst)
{
string strKey = string.Format("{0}", clsvUsersSimEN._CurrTabName);
List<clsvUsersSimEN> arrvUsersSimObjLstCache = GetObjLstCache();
IEnumerable <clsvUsersSimEN> arrvUsersSimObjLst_Sel =
arrvUsersSimObjLstCache
.Where(x => arrUserIdLst.Contains(x.UserId));
return arrvUsersSimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersSimEN> GetObjLst(string strWhereCond)
{
List<clsvUsersSimEN> arrObjLst = new List<clsvUsersSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN();
try
{
objvUsersSimEN.UserId = objRow[convUsersSim.UserId].ToString().Trim(); //用户ID
objvUsersSimEN.UserName = objRow[convUsersSim.UserName].ToString().Trim(); //用户名
objvUsersSimEN.IdXzCollege = objRow[convUsersSim.IdXzCollege] == DBNull.Value ? null : objRow[convUsersSim.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersSimEN.CollegeName = objRow[convUsersSim.CollegeName] == DBNull.Value ? null : objRow[convUsersSim.CollegeName].ToString().Trim(); //学院名称
objvUsersSimEN.IdXzMajor = objRow[convUsersSim.IdXzMajor] == DBNull.Value ? null : objRow[convUsersSim.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersSimEN.MajorName = objRow[convUsersSim.MajorName] == DBNull.Value ? null : objRow[convUsersSim.MajorName].ToString().Trim(); //专业名称
objvUsersSimEN.HeadPic = objRow[convUsersSim.HeadPic] == DBNull.Value ? null : objRow[convUsersSim.HeadPic].ToString().Trim(); //头像
objvUsersSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsersSim.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersSimEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersSimEN);
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
public static List<clsvUsersSimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUsersSimEN> arrObjLst = new List<clsvUsersSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN();
try
{
objvUsersSimEN.UserId = objRow[convUsersSim.UserId].ToString().Trim(); //用户ID
objvUsersSimEN.UserName = objRow[convUsersSim.UserName].ToString().Trim(); //用户名
objvUsersSimEN.IdXzCollege = objRow[convUsersSim.IdXzCollege] == DBNull.Value ? null : objRow[convUsersSim.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersSimEN.CollegeName = objRow[convUsersSim.CollegeName] == DBNull.Value ? null : objRow[convUsersSim.CollegeName].ToString().Trim(); //学院名称
objvUsersSimEN.IdXzMajor = objRow[convUsersSim.IdXzMajor] == DBNull.Value ? null : objRow[convUsersSim.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersSimEN.MajorName = objRow[convUsersSim.MajorName] == DBNull.Value ? null : objRow[convUsersSim.MajorName].ToString().Trim(); //专业名称
objvUsersSimEN.HeadPic = objRow[convUsersSim.HeadPic] == DBNull.Value ? null : objRow[convUsersSim.HeadPic].ToString().Trim(); //头像
objvUsersSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsersSim.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersSimEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUsersSimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUsersSimEN> GetSubObjLstCache(clsvUsersSimEN objvUsersSimCond)
{
List<clsvUsersSimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUsersSimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUsersSim.AttributeName)
{
if (objvUsersSimCond.IsUpdated(strFldName) == false) continue;
if (objvUsersSimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsersSimCond[strFldName].ToString());
}
else
{
if (objvUsersSimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUsersSimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsersSimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUsersSimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUsersSimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUsersSimCond[strFldName]));
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
public static List<clsvUsersSimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUsersSimEN> arrObjLst = new List<clsvUsersSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN();
try
{
objvUsersSimEN.UserId = objRow[convUsersSim.UserId].ToString().Trim(); //用户ID
objvUsersSimEN.UserName = objRow[convUsersSim.UserName].ToString().Trim(); //用户名
objvUsersSimEN.IdXzCollege = objRow[convUsersSim.IdXzCollege] == DBNull.Value ? null : objRow[convUsersSim.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersSimEN.CollegeName = objRow[convUsersSim.CollegeName] == DBNull.Value ? null : objRow[convUsersSim.CollegeName].ToString().Trim(); //学院名称
objvUsersSimEN.IdXzMajor = objRow[convUsersSim.IdXzMajor] == DBNull.Value ? null : objRow[convUsersSim.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersSimEN.MajorName = objRow[convUsersSim.MajorName] == DBNull.Value ? null : objRow[convUsersSim.MajorName].ToString().Trim(); //专业名称
objvUsersSimEN.HeadPic = objRow[convUsersSim.HeadPic] == DBNull.Value ? null : objRow[convUsersSim.HeadPic].ToString().Trim(); //头像
objvUsersSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsersSim.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersSimEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersSimEN);
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
public static List<clsvUsersSimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUsersSimEN> arrObjLst = new List<clsvUsersSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN();
try
{
objvUsersSimEN.UserId = objRow[convUsersSim.UserId].ToString().Trim(); //用户ID
objvUsersSimEN.UserName = objRow[convUsersSim.UserName].ToString().Trim(); //用户名
objvUsersSimEN.IdXzCollege = objRow[convUsersSim.IdXzCollege] == DBNull.Value ? null : objRow[convUsersSim.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersSimEN.CollegeName = objRow[convUsersSim.CollegeName] == DBNull.Value ? null : objRow[convUsersSim.CollegeName].ToString().Trim(); //学院名称
objvUsersSimEN.IdXzMajor = objRow[convUsersSim.IdXzMajor] == DBNull.Value ? null : objRow[convUsersSim.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersSimEN.MajorName = objRow[convUsersSim.MajorName] == DBNull.Value ? null : objRow[convUsersSim.MajorName].ToString().Trim(); //专业名称
objvUsersSimEN.HeadPic = objRow[convUsersSim.HeadPic] == DBNull.Value ? null : objRow[convUsersSim.HeadPic].ToString().Trim(); //头像
objvUsersSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsersSim.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersSimEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersSimEN);
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
List<clsvUsersSimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvUsersSimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersSimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvUsersSimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUsersSimEN> arrObjLst = new List<clsvUsersSimEN>(); 
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
	clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN();
try
{
objvUsersSimEN.UserId = objRow[convUsersSim.UserId].ToString().Trim(); //用户ID
objvUsersSimEN.UserName = objRow[convUsersSim.UserName].ToString().Trim(); //用户名
objvUsersSimEN.IdXzCollege = objRow[convUsersSim.IdXzCollege] == DBNull.Value ? null : objRow[convUsersSim.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersSimEN.CollegeName = objRow[convUsersSim.CollegeName] == DBNull.Value ? null : objRow[convUsersSim.CollegeName].ToString().Trim(); //学院名称
objvUsersSimEN.IdXzMajor = objRow[convUsersSim.IdXzMajor] == DBNull.Value ? null : objRow[convUsersSim.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersSimEN.MajorName = objRow[convUsersSim.MajorName] == DBNull.Value ? null : objRow[convUsersSim.MajorName].ToString().Trim(); //专业名称
objvUsersSimEN.HeadPic = objRow[convUsersSim.HeadPic] == DBNull.Value ? null : objRow[convUsersSim.HeadPic].ToString().Trim(); //头像
objvUsersSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsersSim.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersSimEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersSimEN);
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
public static List<clsvUsersSimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUsersSimEN> arrObjLst = new List<clsvUsersSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN();
try
{
objvUsersSimEN.UserId = objRow[convUsersSim.UserId].ToString().Trim(); //用户ID
objvUsersSimEN.UserName = objRow[convUsersSim.UserName].ToString().Trim(); //用户名
objvUsersSimEN.IdXzCollege = objRow[convUsersSim.IdXzCollege] == DBNull.Value ? null : objRow[convUsersSim.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersSimEN.CollegeName = objRow[convUsersSim.CollegeName] == DBNull.Value ? null : objRow[convUsersSim.CollegeName].ToString().Trim(); //学院名称
objvUsersSimEN.IdXzMajor = objRow[convUsersSim.IdXzMajor] == DBNull.Value ? null : objRow[convUsersSim.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersSimEN.MajorName = objRow[convUsersSim.MajorName] == DBNull.Value ? null : objRow[convUsersSim.MajorName].ToString().Trim(); //专业名称
objvUsersSimEN.HeadPic = objRow[convUsersSim.HeadPic] == DBNull.Value ? null : objRow[convUsersSim.HeadPic].ToString().Trim(); //头像
objvUsersSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsersSim.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersSimEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUsersSimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvUsersSimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUsersSimEN> arrObjLst = new List<clsvUsersSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN();
try
{
objvUsersSimEN.UserId = objRow[convUsersSim.UserId].ToString().Trim(); //用户ID
objvUsersSimEN.UserName = objRow[convUsersSim.UserName].ToString().Trim(); //用户名
objvUsersSimEN.IdXzCollege = objRow[convUsersSim.IdXzCollege] == DBNull.Value ? null : objRow[convUsersSim.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersSimEN.CollegeName = objRow[convUsersSim.CollegeName] == DBNull.Value ? null : objRow[convUsersSim.CollegeName].ToString().Trim(); //学院名称
objvUsersSimEN.IdXzMajor = objRow[convUsersSim.IdXzMajor] == DBNull.Value ? null : objRow[convUsersSim.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersSimEN.MajorName = objRow[convUsersSim.MajorName] == DBNull.Value ? null : objRow[convUsersSim.MajorName].ToString().Trim(); //专业名称
objvUsersSimEN.HeadPic = objRow[convUsersSim.HeadPic] == DBNull.Value ? null : objRow[convUsersSim.HeadPic].ToString().Trim(); //头像
objvUsersSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsersSim.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersSimEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersSimEN);
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
public static List<clsvUsersSimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUsersSimEN> arrObjLst = new List<clsvUsersSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN();
try
{
objvUsersSimEN.UserId = objRow[convUsersSim.UserId].ToString().Trim(); //用户ID
objvUsersSimEN.UserName = objRow[convUsersSim.UserName].ToString().Trim(); //用户名
objvUsersSimEN.IdXzCollege = objRow[convUsersSim.IdXzCollege] == DBNull.Value ? null : objRow[convUsersSim.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersSimEN.CollegeName = objRow[convUsersSim.CollegeName] == DBNull.Value ? null : objRow[convUsersSim.CollegeName].ToString().Trim(); //学院名称
objvUsersSimEN.IdXzMajor = objRow[convUsersSim.IdXzMajor] == DBNull.Value ? null : objRow[convUsersSim.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersSimEN.MajorName = objRow[convUsersSim.MajorName] == DBNull.Value ? null : objRow[convUsersSim.MajorName].ToString().Trim(); //专业名称
objvUsersSimEN.HeadPic = objRow[convUsersSim.HeadPic] == DBNull.Value ? null : objRow[convUsersSim.HeadPic].ToString().Trim(); //头像
objvUsersSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsersSim.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersSimEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersSimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUsersSimEN> arrObjLst = new List<clsvUsersSimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersSimEN objvUsersSimEN = new clsvUsersSimEN();
try
{
objvUsersSimEN.UserId = objRow[convUsersSim.UserId].ToString().Trim(); //用户ID
objvUsersSimEN.UserName = objRow[convUsersSim.UserName].ToString().Trim(); //用户名
objvUsersSimEN.IdXzCollege = objRow[convUsersSim.IdXzCollege] == DBNull.Value ? null : objRow[convUsersSim.IdXzCollege].ToString().Trim(); //学院流水号
objvUsersSimEN.CollegeName = objRow[convUsersSim.CollegeName] == DBNull.Value ? null : objRow[convUsersSim.CollegeName].ToString().Trim(); //学院名称
objvUsersSimEN.IdXzMajor = objRow[convUsersSim.IdXzMajor] == DBNull.Value ? null : objRow[convUsersSim.IdXzMajor].ToString().Trim(); //专业流水号
objvUsersSimEN.MajorName = objRow[convUsersSim.MajorName] == DBNull.Value ? null : objRow[convUsersSim.MajorName].ToString().Trim(); //专业名称
objvUsersSimEN.HeadPic = objRow[convUsersSim.HeadPic] == DBNull.Value ? null : objRow[convUsersSim.HeadPic].ToString().Trim(); //头像
objvUsersSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convUsersSim.IsGSuser].ToString().Trim()); //是否GS用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUsersSimEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUsersSimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUsersSimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUsersSim(ref clsvUsersSimEN objvUsersSimEN)
{
bool bolResult = vUsersSimDA.GetvUsersSim(ref objvUsersSimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsersSimEN GetObjByUserId(string strUserId)
{
if (strUserId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strUserId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strUserId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvUsersSimEN objvUsersSimEN = vUsersSimDA.GetObjByUserId(strUserId);
return objvUsersSimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUsersSimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUsersSimEN objvUsersSimEN = vUsersSimDA.GetFirstObj(strWhereCond);
 return objvUsersSimEN;
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
public static clsvUsersSimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUsersSimEN objvUsersSimEN = vUsersSimDA.GetObjByDataRow(objRow);
 return objvUsersSimEN;
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
public static clsvUsersSimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUsersSimEN objvUsersSimEN = vUsersSimDA.GetObjByDataRow(objRow);
 return objvUsersSimEN;
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
 /// <param name = "strUserId">所给的关键字</param>
 /// <param name = "lstvUsersSimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUsersSimEN GetObjByUserIdFromList(string strUserId, List<clsvUsersSimEN> lstvUsersSimObjLst)
{
foreach (clsvUsersSimEN objvUsersSimEN in lstvUsersSimObjLst)
{
if (objvUsersSimEN.UserId == strUserId)
{
return objvUsersSimEN;
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
 string strMaxUserId;
 try
 {
 strMaxUserId = clsvUsersSimDA.GetMaxStrId();
 return strMaxUserId;
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
 string strUserId;
 try
 {
 strUserId = new clsvUsersSimDA().GetFirstID(strWhereCond);
 return strUserId;
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
 arrList = vUsersSimDA.GetID(strWhereCond);
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
bool bolIsExist = vUsersSimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strUserId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vUsersSimDA.IsExist(strUserId);
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
 bolIsExist = clsvUsersSimDA.IsExistTable();
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
 bolIsExist = vUsersSimDA.IsExistTable(strTabName);
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
 /// <param name = "objvUsersSimENS">源对象</param>
 /// <param name = "objvUsersSimENT">目标对象</param>
 public static void CopyTo(clsvUsersSimEN objvUsersSimENS, clsvUsersSimEN objvUsersSimENT)
{
try
{
objvUsersSimENT.UserId = objvUsersSimENS.UserId; //用户ID
objvUsersSimENT.UserName = objvUsersSimENS.UserName; //用户名
objvUsersSimENT.IdXzCollege = objvUsersSimENS.IdXzCollege; //学院流水号
objvUsersSimENT.CollegeName = objvUsersSimENS.CollegeName; //学院名称
objvUsersSimENT.IdXzMajor = objvUsersSimENS.IdXzMajor; //专业流水号
objvUsersSimENT.MajorName = objvUsersSimENS.MajorName; //专业名称
objvUsersSimENT.HeadPic = objvUsersSimENS.HeadPic; //头像
objvUsersSimENT.IsGSuser = objvUsersSimENS.IsGSuser; //是否GS用户
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
 /// <param name = "objvUsersSimEN">源简化对象</param>
 public static void SetUpdFlag(clsvUsersSimEN objvUsersSimEN)
{
try
{
objvUsersSimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvUsersSimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUsersSim.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersSimEN.UserId = objvUsersSimEN.UserId; //用户ID
}
if (arrFldSet.Contains(convUsersSim.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersSimEN.UserName = objvUsersSimEN.UserName; //用户名
}
if (arrFldSet.Contains(convUsersSim.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersSimEN.IdXzCollege = objvUsersSimEN.IdXzCollege == "[null]" ? null :  objvUsersSimEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convUsersSim.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersSimEN.CollegeName = objvUsersSimEN.CollegeName == "[null]" ? null :  objvUsersSimEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convUsersSim.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersSimEN.IdXzMajor = objvUsersSimEN.IdXzMajor == "[null]" ? null :  objvUsersSimEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convUsersSim.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersSimEN.MajorName = objvUsersSimEN.MajorName == "[null]" ? null :  objvUsersSimEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convUsersSim.HeadPic, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersSimEN.HeadPic = objvUsersSimEN.HeadPic == "[null]" ? null :  objvUsersSimEN.HeadPic; //头像
}
if (arrFldSet.Contains(convUsersSim.IsGSuser, new clsStrCompareIgnoreCase())  ==  true)
{
objvUsersSimEN.IsGSuser = objvUsersSimEN.IsGSuser; //是否GS用户
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
 /// <param name = "objvUsersSimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUsersSimEN objvUsersSimEN)
{
try
{
if (objvUsersSimEN.IdXzCollege == "[null]") objvUsersSimEN.IdXzCollege = null; //学院流水号
if (objvUsersSimEN.CollegeName == "[null]") objvUsersSimEN.CollegeName = null; //学院名称
if (objvUsersSimEN.IdXzMajor == "[null]") objvUsersSimEN.IdXzMajor = null; //专业流水号
if (objvUsersSimEN.MajorName == "[null]") objvUsersSimEN.MajorName = null; //专业名称
if (objvUsersSimEN.HeadPic == "[null]") objvUsersSimEN.HeadPic = null; //头像
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
public static void CheckProperty4Condition(clsvUsersSimEN objvUsersSimEN)
{
 vUsersSimDA.CheckProperty4Condition(objvUsersSimEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_UserIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vUsersSim]...","0");
List<clsvUsersSimEN> arrvUsersSimObjLst = GetAllvUsersSimObjLstCache(); 
objDDL.DataValueField = convUsersSim.UserId;
objDDL.DataTextField = convUsersSim.UserName;
objDDL.DataSource = arrvUsersSimObjLst;
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrvUsersSimObjLstCache == null)
//{
//arrvUsersSimObjLstCache = vUsersSimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUsersSimEN GetObjByUserIdCache(string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvUsersSimEN._CurrTabName);
List<clsvUsersSimEN> arrvUsersSimObjLstCache = GetObjLstCache();
IEnumerable <clsvUsersSimEN> arrvUsersSimObjLst_Sel =
arrvUsersSimObjLstCache
.Where(x=> x.UserId == strUserId 
);
if (arrvUsersSimObjLst_Sel.Count() == 0)
{
   clsvUsersSimEN obj = clsvUsersSimBL.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvUsersSimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserNameByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//获取缓存中的对象列表
clsvUsersSimEN objvUsersSim = GetObjByUserIdCache(strUserId);
if (objvUsersSim == null) return "";
return objvUsersSim.UserName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//获取缓存中的对象列表
clsvUsersSimEN objvUsersSim = GetObjByUserIdCache(strUserId);
if (objvUsersSim == null) return "";
return objvUsersSim.UserName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUsersSimEN> GetAllvUsersSimObjLstCache()
{
//获取缓存中的对象列表
List<clsvUsersSimEN> arrvUsersSimObjLstCache = GetObjLstCache(); 
return arrvUsersSimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUsersSimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvUsersSimEN._CurrTabName);
List<clsvUsersSimEN> arrvUsersSimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUsersSimObjLstCache;
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
string strKey = string.Format("{0}", clsvUsersSimEN._CurrTabName);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strUserId)
{
if (strInFldName != convUsersSim.UserId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUsersSim.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUsersSim.AttributeName));
throw new Exception(strMsg);
}
var objvUsersSim = clsvUsersSimBL.GetObjByUserIdCache(strUserId);
if (objvUsersSim == null) return "";
return objvUsersSim[strOutFldName].ToString();
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
int intRecCount = clsvUsersSimDA.GetRecCount(strTabName);
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
int intRecCount = clsvUsersSimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUsersSimDA.GetRecCount();
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
int intRecCount = clsvUsersSimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUsersSimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUsersSimEN objvUsersSimCond)
{
List<clsvUsersSimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUsersSimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUsersSim.AttributeName)
{
if (objvUsersSimCond.IsUpdated(strFldName) == false) continue;
if (objvUsersSimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsersSimCond[strFldName].ToString());
}
else
{
if (objvUsersSimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUsersSimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUsersSimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUsersSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUsersSimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUsersSimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUsersSimCond[strFldName]));
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
 List<string> arrList = clsvUsersSimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vUsersSimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vUsersSimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}