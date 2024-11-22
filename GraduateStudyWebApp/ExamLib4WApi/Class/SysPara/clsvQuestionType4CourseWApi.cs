
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionType4CourseWApi
 表名:vQuestionType4Course(01120340)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:02
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsvQuestionType4CourseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionType4CourseEN SetQuestionTypeId4Course(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convQuestionType4Course.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convQuestionType4Course.QuestionTypeId4Course);
objvQuestionType4CourseEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.QuestionTypeId4Course) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionType4CourseEN SetQuestionTypeName4Course(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeName4Course, convQuestionType4Course.QuestionTypeName4Course);
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, convQuestionType4Course.QuestionTypeName4Course);
objvQuestionType4CourseEN.QuestionTypeName4Course = strQuestionTypeName4Course; //题目类型名4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.QuestionTypeName4Course) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.QuestionTypeName4Course, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.QuestionTypeName4Course] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionType4CourseEN SetCourseId(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionType4Course.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionType4Course.CourseId);
objvQuestionType4CourseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.CourseId) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.CourseId, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.CourseId] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionType4CourseEN SetCourseName(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionType4Course.CourseName);
objvQuestionType4CourseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.CourseName) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.CourseName, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.CourseName] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionType4CourseEN SetOrderNum(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, int intOrderNum, string strComparisonOp="")
	{
objvQuestionType4CourseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.OrderNum) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.OrderNum, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.OrderNum] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionType4CourseEN SetIsUse(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, bool bolIsUse, string strComparisonOp="")
	{
objvQuestionType4CourseEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.IsUse) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.IsUse, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.IsUse] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionType4CourseEN SetUpdDate(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionType4Course.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionType4Course.UpdDate);
objvQuestionType4CourseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.UpdDate) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.UpdDate, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.UpdDate] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionType4CourseEN SetUpdUser(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionType4Course.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionType4Course.UpdUser);
objvQuestionType4CourseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.UpdUser) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.UpdUser, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.UpdUser] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionType4CourseEN SetMemo(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionType4Course.Memo);
objvQuestionType4CourseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.Memo) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.Memo, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.Memo] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionType4CourseEN objvQuestionType4Course_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionType4Course_Cond.IsUpdated(convQuestionType4Course.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objvQuestionType4Course_Cond.dicFldComparisonOp[convQuestionType4Course.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.QuestionTypeId4Course, objvQuestionType4Course_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
if (objvQuestionType4Course_Cond.IsUpdated(convQuestionType4Course.QuestionTypeName4Course) == true)
{
string strComparisonOp_QuestionTypeName4Course = objvQuestionType4Course_Cond.dicFldComparisonOp[convQuestionType4Course.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.QuestionTypeName4Course, objvQuestionType4Course_Cond.QuestionTypeName4Course, strComparisonOp_QuestionTypeName4Course);
}
if (objvQuestionType4Course_Cond.IsUpdated(convQuestionType4Course.CourseId) == true)
{
string strComparisonOp_CourseId = objvQuestionType4Course_Cond.dicFldComparisonOp[convQuestionType4Course.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.CourseId, objvQuestionType4Course_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvQuestionType4Course_Cond.IsUpdated(convQuestionType4Course.CourseName) == true)
{
string strComparisonOp_CourseName = objvQuestionType4Course_Cond.dicFldComparisonOp[convQuestionType4Course.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.CourseName, objvQuestionType4Course_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvQuestionType4Course_Cond.IsUpdated(convQuestionType4Course.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvQuestionType4Course_Cond.dicFldComparisonOp[convQuestionType4Course.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionType4Course.OrderNum, objvQuestionType4Course_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvQuestionType4Course_Cond.IsUpdated(convQuestionType4Course.IsUse) == true)
{
if (objvQuestionType4Course_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionType4Course.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionType4Course.IsUse);
}
}
if (objvQuestionType4Course_Cond.IsUpdated(convQuestionType4Course.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvQuestionType4Course_Cond.dicFldComparisonOp[convQuestionType4Course.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.UpdDate, objvQuestionType4Course_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvQuestionType4Course_Cond.IsUpdated(convQuestionType4Course.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvQuestionType4Course_Cond.dicFldComparisonOp[convQuestionType4Course.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.UpdUser, objvQuestionType4Course_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvQuestionType4Course_Cond.IsUpdated(convQuestionType4Course.Memo) == true)
{
string strComparisonOp_Memo = objvQuestionType4Course_Cond.dicFldComparisonOp[convQuestionType4Course.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.Memo, objvQuestionType4Course_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目类型4课程(vQuestionType4Course)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionType4CourseWApi
{
private static readonly string mstrApiControllerName = "vQuestionType4CourseApi";

 public clsvQuestionType4CourseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionTypeId4Course(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目类型4课程]...","0");
List<clsvQuestionType4CourseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="QuestionTypeId4Course";
objDDL.DataTextField="QuestionTypeName4Course";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_QuestionTypeId4Course(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQuestionType4Course.QuestionTypeId4Course); 
List<clsvQuestionType4CourseEN> arrObjLst = clsvQuestionType4CourseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN()
{
QuestionTypeId4Course = "0",
QuestionTypeName4Course = "选[v题目类型4课程]..."
};
arrObjLst.Insert(0, objvQuestionType4CourseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionType4Course.QuestionTypeId4Course;
objComboBox.DisplayMember = convQuestionType4Course.QuestionTypeName4Course;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionType4CourseEN GetObjByQuestionTypeId4Course(string strQuestionTypeId4Course)
{
string strAction = "GetObjByQuestionTypeId4Course";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionType4CourseEN objvQuestionType4CourseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId4Course"] = strQuestionTypeId4Course
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionType4CourseEN = JsonConvert.DeserializeObject<clsvQuestionType4CourseEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionType4CourseEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionType4CourseEN GetObjByQuestionTypeId4Course_WA_Cache(string strQuestionTypeId4Course)
{
string strAction = "GetObjByQuestionTypeId4Course_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionType4CourseEN objvQuestionType4CourseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId4Course"] = strQuestionTypeId4Course
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionType4CourseEN = JsonConvert.DeserializeObject<clsvQuestionType4CourseEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionType4CourseEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvQuestionType4CourseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionType4CourseEN objvQuestionType4CourseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionType4CourseEN = JsonConvert.DeserializeObject<clsvQuestionType4CourseEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionType4CourseEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionType4CourseEN GetObjByQuestionTypeId4Course_Cache(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionType4CourseEN._CurrTabName_S);
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Sel =
from objvQuestionType4CourseEN in arrvQuestionType4CourseObjLst_Cache
where objvQuestionType4CourseEN.QuestionTypeId4Course == strQuestionTypeId4Course
select objvQuestionType4CourseEN;
if (arrvQuestionType4CourseObjLst_Sel.Count() == 0)
{
   clsvQuestionType4CourseEN obj = clsvQuestionType4CourseWApi.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionType4CourseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionTypeName4CourseByQuestionTypeId4Course_Cache(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionType4CourseEN._CurrTabName_S);
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Sel1 =
from objvQuestionType4CourseEN in arrvQuestionType4CourseObjLst_Cache
where objvQuestionType4CourseEN.QuestionTypeId4Course == strQuestionTypeId4Course
select objvQuestionType4CourseEN;
List <clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Sel = new List<clsvQuestionType4CourseEN>();
foreach (clsvQuestionType4CourseEN obj in arrvQuestionType4CourseObjLst_Sel1)
{
arrvQuestionType4CourseObjLst_Sel.Add(obj);
}
if (arrvQuestionType4CourseObjLst_Sel.Count > 0)
{
return arrvQuestionType4CourseObjLst_Sel[0].QuestionTypeName4Course;
}
string strErrMsgForGetObjById = string.Format("在vQuestionType4Course对象缓存列表中,找不到记录[QuestionTypeId4Course = {0}](函数:{1})", strQuestionTypeId4Course, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionType4CourseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionTypeId4Course_Cache(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionType4CourseEN._CurrTabName_S);
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Sel1 =
from objvQuestionType4CourseEN in arrvQuestionType4CourseObjLst_Cache
where objvQuestionType4CourseEN.QuestionTypeId4Course == strQuestionTypeId4Course
select objvQuestionType4CourseEN;
List <clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Sel = new List<clsvQuestionType4CourseEN>();
foreach (clsvQuestionType4CourseEN obj in arrvQuestionType4CourseObjLst_Sel1)
{
arrvQuestionType4CourseObjLst_Sel.Add(obj);
}
if (arrvQuestionType4CourseObjLst_Sel.Count > 0)
{
return arrvQuestionType4CourseObjLst_Sel[0].QuestionTypeName4Course;
}
string strErrMsgForGetObjById = string.Format("在vQuestionType4Course对象缓存列表中,找不到记录的相关名称[QuestionTypeId4Course = {0}](函数:{1})", strQuestionTypeId4Course, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionType4CourseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionType4CourseEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLstByQuestionTypeId4CourseLst(List<string> arrQuestionTypeId4Course)
{
 List<clsvQuestionType4CourseEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionTypeId4CourseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId4Course);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQuestionType4CourseEN> GetObjLstByQuestionTypeId4CourseLst_Cache(List<string> arrQuestionTypeId4Course)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionType4CourseEN._CurrTabName_S);
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Sel =
from objvQuestionType4CourseEN in arrvQuestionType4CourseObjLst_Cache
where arrQuestionTypeId4Course.Contains(objvQuestionType4CourseEN.QuestionTypeId4Course)
select objvQuestionType4CourseEN;
return arrvQuestionType4CourseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLstByQuestionTypeId4CourseLst_WA_Cache(List<string> arrQuestionTypeId4Course)
{
 List<clsvQuestionType4CourseEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionTypeId4CourseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId4Course);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionType4CourseEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionType4CourseEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionType4CourseEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionType4CourseEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strQuestionTypeId4Course)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId4Course"] = strQuestionTypeId4Course
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionType4CourseENS">源对象</param>
 /// <param name = "objvQuestionType4CourseENT">目标对象</param>
 public static void CopyTo(clsvQuestionType4CourseEN objvQuestionType4CourseENS, clsvQuestionType4CourseEN objvQuestionType4CourseENT)
{
try
{
objvQuestionType4CourseENT.QuestionTypeId4Course = objvQuestionType4CourseENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionType4CourseENT.QuestionTypeName4Course = objvQuestionType4CourseENS.QuestionTypeName4Course; //题目类型名4课程
objvQuestionType4CourseENT.CourseId = objvQuestionType4CourseENS.CourseId; //课程Id
objvQuestionType4CourseENT.CourseName = objvQuestionType4CourseENS.CourseName; //课程名称
objvQuestionType4CourseENT.OrderNum = objvQuestionType4CourseENS.OrderNum; //序号
objvQuestionType4CourseENT.IsUse = objvQuestionType4CourseENS.IsUse; //是否使用
objvQuestionType4CourseENT.UpdDate = objvQuestionType4CourseENS.UpdDate; //修改日期
objvQuestionType4CourseENT.UpdUser = objvQuestionType4CourseENS.UpdUser; //修改人
objvQuestionType4CourseENT.Memo = objvQuestionType4CourseENS.Memo; //备注
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvQuestionType4CourseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionType4CourseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionType4CourseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionType4CourseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionType4CourseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionType4CourseEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionTypeId4Course");
//if (arrvQuestionType4CourseObjLst_Cache == null)
//{
//arrvQuestionType4CourseObjLst_Cache = await clsvQuestionType4CourseWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvQuestionType4CourseEN._CurrTabName_S);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionType4CourseEN._CurrTabName_S);
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionType4CourseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionType4CourseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionType4Course.QuestionTypeId4Course, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType4Course.QuestionTypeName4Course, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType4Course.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType4Course.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType4Course.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionType4Course.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionType4Course.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType4Course.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType4Course.Memo, Type.GetType("System.String"));
foreach (clsvQuestionType4CourseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionType4Course.QuestionTypeId4Course] = objInFor[convQuestionType4Course.QuestionTypeId4Course];
objDR[convQuestionType4Course.QuestionTypeName4Course] = objInFor[convQuestionType4Course.QuestionTypeName4Course];
objDR[convQuestionType4Course.CourseId] = objInFor[convQuestionType4Course.CourseId];
objDR[convQuestionType4Course.CourseName] = objInFor[convQuestionType4Course.CourseName];
objDR[convQuestionType4Course.OrderNum] = objInFor[convQuestionType4Course.OrderNum];
objDR[convQuestionType4Course.IsUse] = objInFor[convQuestionType4Course.IsUse];
objDR[convQuestionType4Course.UpdDate] = objInFor[convQuestionType4Course.UpdDate];
objDR[convQuestionType4Course.UpdUser] = objInFor[convQuestionType4Course.UpdUser];
objDR[convQuestionType4Course.Memo] = objInFor[convQuestionType4Course.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}