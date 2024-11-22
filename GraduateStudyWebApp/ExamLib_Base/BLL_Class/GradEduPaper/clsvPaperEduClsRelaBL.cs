
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperEduClsRelaBL
 表名:vPaperEduClsRela(01120932)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsvPaperEduClsRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperEduClsRelaEN GetObj(this K_mId_vPaperEduClsRela myKey)
{
clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = clsvPaperEduClsRelaBL.vPaperEduClsRelaDA.GetObjBymId(myKey.Value);
return objvPaperEduClsRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEduClsRelaEN SetmId(this clsvPaperEduClsRelaEN objvPaperEduClsRelaEN, long lngmId, string strComparisonOp="")
	{
objvPaperEduClsRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convPaperEduClsRela.mId) == false)
{
objvPaperEduClsRelaEN.dicFldComparisonOp.Add(convPaperEduClsRela.mId, strComparisonOp);
}
else
{
objvPaperEduClsRelaEN.dicFldComparisonOp[convPaperEduClsRela.mId] = strComparisonOp;
}
}
return objvPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEduClsRelaEN SetPaperId(this clsvPaperEduClsRelaEN objvPaperEduClsRelaEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperEduClsRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperEduClsRela.PaperId);
}
objvPaperEduClsRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convPaperEduClsRela.PaperId) == false)
{
objvPaperEduClsRelaEN.dicFldComparisonOp.Add(convPaperEduClsRela.PaperId, strComparisonOp);
}
else
{
objvPaperEduClsRelaEN.dicFldComparisonOp[convPaperEduClsRela.PaperId] = strComparisonOp;
}
}
return objvPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEduClsRelaEN SetPaperTitle(this clsvPaperEduClsRelaEN objvPaperEduClsRelaEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, convPaperEduClsRela.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperEduClsRela.PaperTitle);
}
objvPaperEduClsRelaEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convPaperEduClsRela.PaperTitle) == false)
{
objvPaperEduClsRelaEN.dicFldComparisonOp.Add(convPaperEduClsRela.PaperTitle, strComparisonOp);
}
else
{
objvPaperEduClsRelaEN.dicFldComparisonOp[convPaperEduClsRela.PaperTitle] = strComparisonOp;
}
}
return objvPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEduClsRelaEN SetAuthor(this clsvPaperEduClsRelaEN objvPaperEduClsRelaEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaperEduClsRela.Author);
}
objvPaperEduClsRelaEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convPaperEduClsRela.Author) == false)
{
objvPaperEduClsRelaEN.dicFldComparisonOp.Add(convPaperEduClsRela.Author, strComparisonOp);
}
else
{
objvPaperEduClsRelaEN.dicFldComparisonOp[convPaperEduClsRela.Author] = strComparisonOp;
}
}
return objvPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEduClsRelaEN SetIdCurrEduCls(this clsvPaperEduClsRelaEN objvPaperEduClsRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convPaperEduClsRela.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convPaperEduClsRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convPaperEduClsRela.IdCurrEduCls);
}
objvPaperEduClsRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convPaperEduClsRela.IdCurrEduCls) == false)
{
objvPaperEduClsRelaEN.dicFldComparisonOp.Add(convPaperEduClsRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvPaperEduClsRelaEN.dicFldComparisonOp[convPaperEduClsRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEduClsRelaEN SetUpdUser(this clsvPaperEduClsRelaEN objvPaperEduClsRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperEduClsRela.UpdUser);
}
objvPaperEduClsRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convPaperEduClsRela.UpdUser) == false)
{
objvPaperEduClsRelaEN.dicFldComparisonOp.Add(convPaperEduClsRela.UpdUser, strComparisonOp);
}
else
{
objvPaperEduClsRelaEN.dicFldComparisonOp[convPaperEduClsRela.UpdUser] = strComparisonOp;
}
}
return objvPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEduClsRelaEN SetUpdDate(this clsvPaperEduClsRelaEN objvPaperEduClsRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperEduClsRela.UpdDate);
}
objvPaperEduClsRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convPaperEduClsRela.UpdDate) == false)
{
objvPaperEduClsRelaEN.dicFldComparisonOp.Add(convPaperEduClsRela.UpdDate, strComparisonOp);
}
else
{
objvPaperEduClsRelaEN.dicFldComparisonOp[convPaperEduClsRela.UpdDate] = strComparisonOp;
}
}
return objvPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperEduClsRelaEN SetMemo(this clsvPaperEduClsRelaEN objvPaperEduClsRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperEduClsRela.Memo);
}
objvPaperEduClsRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(convPaperEduClsRela.Memo) == false)
{
objvPaperEduClsRelaEN.dicFldComparisonOp.Add(convPaperEduClsRela.Memo, strComparisonOp);
}
else
{
objvPaperEduClsRelaEN.dicFldComparisonOp[convPaperEduClsRela.Memo] = strComparisonOp;
}
}
return objvPaperEduClsRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaENS">源对象</param>
 /// <param name = "objvPaperEduClsRelaENT">目标对象</param>
 public static void CopyTo(this clsvPaperEduClsRelaEN objvPaperEduClsRelaENS, clsvPaperEduClsRelaEN objvPaperEduClsRelaENT)
{
try
{
objvPaperEduClsRelaENT.mId = objvPaperEduClsRelaENS.mId; //mId
objvPaperEduClsRelaENT.PaperId = objvPaperEduClsRelaENS.PaperId; //论文Id
objvPaperEduClsRelaENT.PaperTitle = objvPaperEduClsRelaENS.PaperTitle; //论文标题
objvPaperEduClsRelaENT.Author = objvPaperEduClsRelaENS.Author; //作者
objvPaperEduClsRelaENT.IdCurrEduCls = objvPaperEduClsRelaENS.IdCurrEduCls; //教学班流水号
objvPaperEduClsRelaENT.UpdUser = objvPaperEduClsRelaENS.UpdUser; //修改人
objvPaperEduClsRelaENT.UpdDate = objvPaperEduClsRelaENS.UpdDate; //修改日期
objvPaperEduClsRelaENT.Memo = objvPaperEduClsRelaENS.Memo; //备注
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
 /// <param name = "objvPaperEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clsvPaperEduClsRelaEN:objvPaperEduClsRelaENT</returns>
 public static clsvPaperEduClsRelaEN CopyTo(this clsvPaperEduClsRelaEN objvPaperEduClsRelaENS)
{
try
{
 clsvPaperEduClsRelaEN objvPaperEduClsRelaENT = new clsvPaperEduClsRelaEN()
{
mId = objvPaperEduClsRelaENS.mId, //mId
PaperId = objvPaperEduClsRelaENS.PaperId, //论文Id
PaperTitle = objvPaperEduClsRelaENS.PaperTitle, //论文标题
Author = objvPaperEduClsRelaENS.Author, //作者
IdCurrEduCls = objvPaperEduClsRelaENS.IdCurrEduCls, //教学班流水号
UpdUser = objvPaperEduClsRelaENS.UpdUser, //修改人
UpdDate = objvPaperEduClsRelaENS.UpdDate, //修改日期
Memo = objvPaperEduClsRelaENS.Memo, //备注
};
 return objvPaperEduClsRelaENT;
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
public static void CheckProperty4Condition(this clsvPaperEduClsRelaEN objvPaperEduClsRelaEN)
{
 clsvPaperEduClsRelaBL.vPaperEduClsRelaDA.CheckProperty4Condition(objvPaperEduClsRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperEduClsRelaEN objvPaperEduClsRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperEduClsRelaCond.IsUpdated(convPaperEduClsRela.mId) == true)
{
string strComparisonOpmId = objvPaperEduClsRelaCond.dicFldComparisonOp[convPaperEduClsRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperEduClsRela.mId, objvPaperEduClsRelaCond.mId, strComparisonOpmId);
}
if (objvPaperEduClsRelaCond.IsUpdated(convPaperEduClsRela.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperEduClsRelaCond.dicFldComparisonOp[convPaperEduClsRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperEduClsRela.PaperId, objvPaperEduClsRelaCond.PaperId, strComparisonOpPaperId);
}
if (objvPaperEduClsRelaCond.IsUpdated(convPaperEduClsRela.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvPaperEduClsRelaCond.dicFldComparisonOp[convPaperEduClsRela.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperEduClsRela.PaperTitle, objvPaperEduClsRelaCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvPaperEduClsRelaCond.IsUpdated(convPaperEduClsRela.Author) == true)
{
string strComparisonOpAuthor = objvPaperEduClsRelaCond.dicFldComparisonOp[convPaperEduClsRela.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperEduClsRela.Author, objvPaperEduClsRelaCond.Author, strComparisonOpAuthor);
}
if (objvPaperEduClsRelaCond.IsUpdated(convPaperEduClsRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvPaperEduClsRelaCond.dicFldComparisonOp[convPaperEduClsRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperEduClsRela.IdCurrEduCls, objvPaperEduClsRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvPaperEduClsRelaCond.IsUpdated(convPaperEduClsRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperEduClsRelaCond.dicFldComparisonOp[convPaperEduClsRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperEduClsRela.UpdUser, objvPaperEduClsRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPaperEduClsRelaCond.IsUpdated(convPaperEduClsRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperEduClsRelaCond.dicFldComparisonOp[convPaperEduClsRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperEduClsRela.UpdDate, objvPaperEduClsRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperEduClsRelaCond.IsUpdated(convPaperEduClsRela.Memo) == true)
{
string strComparisonOpMemo = objvPaperEduClsRelaCond.dicFldComparisonOp[convPaperEduClsRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperEduClsRela.Memo, objvPaperEduClsRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperEduClsRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPaperEduClsRela(vPaperEduClsRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperEduClsRelaBL
{
public static RelatedActions_vPaperEduClsRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperEduClsRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperEduClsRelaDA vPaperEduClsRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperEduClsRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperEduClsRelaBL()
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
if (string.IsNullOrEmpty(clsvPaperEduClsRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperEduClsRelaEN._ConnectString);
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
public static DataTable GetDataTable_vPaperEduClsRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperEduClsRelaDA.GetDataTable_vPaperEduClsRela(strWhereCond);
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
objDT = vPaperEduClsRelaDA.GetDataTable(strWhereCond);
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
objDT = vPaperEduClsRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperEduClsRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperEduClsRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperEduClsRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperEduClsRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperEduClsRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperEduClsRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvPaperEduClsRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
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
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEduClsRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperEduClsRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvPaperEduClsRelaEN._CurrTabName);
List<clsvPaperEduClsRelaEN> arrvPaperEduClsRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperEduClsRelaEN> arrvPaperEduClsRelaObjLst_Sel =
arrvPaperEduClsRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvPaperEduClsRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperEduClsRelaEN> GetObjLst(string strWhereCond)
{
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEduClsRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEduClsRelaEN);
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
public static List<clsvPaperEduClsRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEduClsRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperEduClsRelaEN> GetSubObjLstCache(clsvPaperEduClsRelaEN objvPaperEduClsRelaCond)
{
List<clsvPaperEduClsRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperEduClsRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperEduClsRela.AttributeName)
{
if (objvPaperEduClsRelaCond.IsUpdated(strFldName) == false) continue;
if (objvPaperEduClsRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperEduClsRelaCond[strFldName].ToString());
}
else
{
if (objvPaperEduClsRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperEduClsRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperEduClsRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperEduClsRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperEduClsRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperEduClsRelaCond[strFldName]));
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
public static List<clsvPaperEduClsRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEduClsRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEduClsRelaEN);
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
public static List<clsvPaperEduClsRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEduClsRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEduClsRelaEN);
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
List<clsvPaperEduClsRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperEduClsRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperEduClsRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperEduClsRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
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
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEduClsRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEduClsRelaEN);
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
public static List<clsvPaperEduClsRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEduClsRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperEduClsRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperEduClsRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEduClsRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEduClsRelaEN);
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
public static List<clsvPaperEduClsRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEduClsRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperEduClsRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperEduClsRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperEduClsRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperEduClsRela(ref clsvPaperEduClsRelaEN objvPaperEduClsRelaEN)
{
bool bolResult = vPaperEduClsRelaDA.GetvPaperEduClsRela(ref objvPaperEduClsRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperEduClsRelaEN GetObjBymId(long lngmId)
{
clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = vPaperEduClsRelaDA.GetObjBymId(lngmId);
return objvPaperEduClsRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperEduClsRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = vPaperEduClsRelaDA.GetFirstObj(strWhereCond);
 return objvPaperEduClsRelaEN;
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
public static clsvPaperEduClsRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = vPaperEduClsRelaDA.GetObjByDataRow(objRow);
 return objvPaperEduClsRelaEN;
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
public static clsvPaperEduClsRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = vPaperEduClsRelaDA.GetObjByDataRow(objRow);
 return objvPaperEduClsRelaEN;
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
 /// <param name = "lstvPaperEduClsRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperEduClsRelaEN GetObjBymIdFromList(long lngmId, List<clsvPaperEduClsRelaEN> lstvPaperEduClsRelaObjLst)
{
foreach (clsvPaperEduClsRelaEN objvPaperEduClsRelaEN in lstvPaperEduClsRelaObjLst)
{
if (objvPaperEduClsRelaEN.mId == lngmId)
{
return objvPaperEduClsRelaEN;
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
 lngmId = new clsvPaperEduClsRelaDA().GetFirstID(strWhereCond);
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
 arrList = vPaperEduClsRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperEduClsRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vPaperEduClsRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvPaperEduClsRelaDA.IsExistTable();
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
 bolIsExist = vPaperEduClsRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperEduClsRelaENS">源对象</param>
 /// <param name = "objvPaperEduClsRelaENT">目标对象</param>
 public static void CopyTo(clsvPaperEduClsRelaEN objvPaperEduClsRelaENS, clsvPaperEduClsRelaEN objvPaperEduClsRelaENT)
{
try
{
objvPaperEduClsRelaENT.mId = objvPaperEduClsRelaENS.mId; //mId
objvPaperEduClsRelaENT.PaperId = objvPaperEduClsRelaENS.PaperId; //论文Id
objvPaperEduClsRelaENT.PaperTitle = objvPaperEduClsRelaENS.PaperTitle; //论文标题
objvPaperEduClsRelaENT.Author = objvPaperEduClsRelaENS.Author; //作者
objvPaperEduClsRelaENT.IdCurrEduCls = objvPaperEduClsRelaENS.IdCurrEduCls; //教学班流水号
objvPaperEduClsRelaENT.UpdUser = objvPaperEduClsRelaENS.UpdUser; //修改人
objvPaperEduClsRelaENT.UpdDate = objvPaperEduClsRelaENS.UpdDate; //修改日期
objvPaperEduClsRelaENT.Memo = objvPaperEduClsRelaENS.Memo; //备注
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
 /// <param name = "objvPaperEduClsRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperEduClsRelaEN objvPaperEduClsRelaEN)
{
try
{
objvPaperEduClsRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperEduClsRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperEduClsRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEduClsRelaEN.mId = objvPaperEduClsRelaEN.mId; //mId
}
if (arrFldSet.Contains(convPaperEduClsRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEduClsRelaEN.PaperId = objvPaperEduClsRelaEN.PaperId == "[null]" ? null :  objvPaperEduClsRelaEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaperEduClsRela.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEduClsRelaEN.PaperTitle = objvPaperEduClsRelaEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convPaperEduClsRela.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEduClsRelaEN.Author = objvPaperEduClsRelaEN.Author == "[null]" ? null :  objvPaperEduClsRelaEN.Author; //作者
}
if (arrFldSet.Contains(convPaperEduClsRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEduClsRelaEN.IdCurrEduCls = objvPaperEduClsRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convPaperEduClsRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEduClsRelaEN.UpdUser = objvPaperEduClsRelaEN.UpdUser == "[null]" ? null :  objvPaperEduClsRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convPaperEduClsRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEduClsRelaEN.UpdDate = objvPaperEduClsRelaEN.UpdDate == "[null]" ? null :  objvPaperEduClsRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperEduClsRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperEduClsRelaEN.Memo = objvPaperEduClsRelaEN.Memo == "[null]" ? null :  objvPaperEduClsRelaEN.Memo; //备注
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
 /// <param name = "objvPaperEduClsRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperEduClsRelaEN objvPaperEduClsRelaEN)
{
try
{
if (objvPaperEduClsRelaEN.PaperId == "[null]") objvPaperEduClsRelaEN.PaperId = null; //论文Id
if (objvPaperEduClsRelaEN.Author == "[null]") objvPaperEduClsRelaEN.Author = null; //作者
if (objvPaperEduClsRelaEN.UpdUser == "[null]") objvPaperEduClsRelaEN.UpdUser = null; //修改人
if (objvPaperEduClsRelaEN.UpdDate == "[null]") objvPaperEduClsRelaEN.UpdDate = null; //修改日期
if (objvPaperEduClsRelaEN.Memo == "[null]") objvPaperEduClsRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvPaperEduClsRelaEN objvPaperEduClsRelaEN)
{
 vPaperEduClsRelaDA.CheckProperty4Condition(objvPaperEduClsRelaEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindCbo_PaperId(System.Windows.Forms.ComboBox objComboBox , string strIdCurrEduCls)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPaperEduClsRela.PaperId); 
List<clsvPaperEduClsRelaEN> arrObjLst = clsvPaperEduClsRelaBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdCurrEduCls == strIdCurrEduCls).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN()
{
PaperId = "0",
PaperTitle = "选[vPaperEduClsRela]..."
};
arrObjLstSel.Insert(0, objvPaperEduClsRelaEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPaperEduClsRela.PaperId;
objComboBox.DisplayMember = convPaperEduClsRela.PaperTitle;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindDdl_PaperId(System.Web.UI.WebControls.DropDownList objDDL , string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vPaperEduClsRela]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convPaperEduClsRela.PaperId); 
IEnumerable<clsvPaperEduClsRelaEN> arrObjLst = clsvPaperEduClsRelaBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdCurrEduCls == strIdCurrEduCls).ToList();
objDDL.DataValueField = convPaperEduClsRela.PaperId;
objDDL.DataTextField = convPaperEduClsRela.PaperTitle;
objDDL.DataSource = arrObjLstSel;
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
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperEduClsRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperEduClsRelaBL没有刷新缓存机制(clsPaperEduClsRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvPaperEduClsRelaObjLstCache == null)
//{
//arrvPaperEduClsRelaObjLstCache = vPaperEduClsRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperEduClsRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperEduClsRelaEN._CurrTabName);
List<clsvPaperEduClsRelaEN> arrvPaperEduClsRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperEduClsRelaEN> arrvPaperEduClsRelaObjLst_Sel =
arrvPaperEduClsRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvPaperEduClsRelaObjLst_Sel.Count() == 0)
{
   clsvPaperEduClsRelaEN obj = clsvPaperEduClsRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperEduClsRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperEduClsRelaEN> GetAllvPaperEduClsRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperEduClsRelaEN> arrvPaperEduClsRelaObjLstCache = GetObjLstCache(); 
return arrvPaperEduClsRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperEduClsRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperEduClsRelaEN._CurrTabName);
List<clsvPaperEduClsRelaEN> arrvPaperEduClsRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperEduClsRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperEduClsRelaEN._CurrTabName);
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
if (strInFldName != convPaperEduClsRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperEduClsRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperEduClsRela.AttributeName));
throw new Exception(strMsg);
}
var objvPaperEduClsRela = clsvPaperEduClsRelaBL.GetObjBymIdCache(lngmId);
if (objvPaperEduClsRela == null) return "";
return objvPaperEduClsRela[strOutFldName].ToString();
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
int intRecCount = clsvPaperEduClsRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperEduClsRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperEduClsRelaDA.GetRecCount();
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
int intRecCount = clsvPaperEduClsRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperEduClsRelaEN objvPaperEduClsRelaCond)
{
List<clsvPaperEduClsRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperEduClsRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperEduClsRela.AttributeName)
{
if (objvPaperEduClsRelaCond.IsUpdated(strFldName) == false) continue;
if (objvPaperEduClsRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperEduClsRelaCond[strFldName].ToString());
}
else
{
if (objvPaperEduClsRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperEduClsRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperEduClsRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperEduClsRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperEduClsRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperEduClsRelaCond[strFldName]));
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
 List<string> arrList = clsvPaperEduClsRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperEduClsRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperEduClsRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}