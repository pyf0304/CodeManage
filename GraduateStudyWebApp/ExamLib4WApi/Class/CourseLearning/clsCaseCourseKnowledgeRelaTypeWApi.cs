﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseKnowledgeRelaTypeWApi
 表名:CaseCourseKnowledgeRelaType(01120528)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:05
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsCaseCourseKnowledgeRelaTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaTypeEN Setid_CaseCourseKnowledgeRelaType(this clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN, string strid_CaseCourseKnowledgeRelaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CaseCourseKnowledgeRelaType, 4, conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType);
clsCheckSql.CheckFieldForeignKey(strid_CaseCourseKnowledgeRelaType, 4, conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType);
objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType = strid_CaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType) == false)
{
objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp[conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaTypeEN SetCaseCourseKnowledgeRelaTypeID(this clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN, string strCaseCourseKnowledgeRelaTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseCourseKnowledgeRelaTypeID, conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID);
clsCheckSql.CheckFieldLen(strCaseCourseKnowledgeRelaTypeID, 4, conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID);
clsCheckSql.CheckFieldForeignKey(strCaseCourseKnowledgeRelaTypeID, 4, conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID);
objCaseCourseKnowledgeRelaTypeEN.CaseCourseKnowledgeRelaTypeID = strCaseCourseKnowledgeRelaTypeID; //案例题库关系类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID) == false)
{
objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp[conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaTypeEN SetCaseCourseKnowledgeRelaTypeName(this clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN, string strCaseCourseKnowledgeRelaTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseCourseKnowledgeRelaTypeName, conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName);
clsCheckSql.CheckFieldLen(strCaseCourseKnowledgeRelaTypeName, 50, conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName);
objCaseCourseKnowledgeRelaTypeEN.CaseCourseKnowledgeRelaTypeName = strCaseCourseKnowledgeRelaTypeName; //案例知识点关系类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName) == false)
{
objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp[conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaTypeEN SetMemo(this clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseCourseKnowledgeRelaType.Memo);
objCaseCourseKnowledgeRelaTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRelaType.Memo) == false)
{
objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRelaType.Memo, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaTypeEN.dicFldComparisonOp[conCaseCourseKnowledgeRelaType.Memo] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseCourseKnowledgeRelaType_Cond.IsUpdated(conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType) == true)
{
string strComparisonOp_id_CaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaType_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType, objCaseCourseKnowledgeRelaType_Cond.id_CaseCourseKnowledgeRelaType, strComparisonOp_id_CaseCourseKnowledgeRelaType);
}
if (objCaseCourseKnowledgeRelaType_Cond.IsUpdated(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID) == true)
{
string strComparisonOp_CaseCourseKnowledgeRelaTypeID = objCaseCourseKnowledgeRelaType_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID, objCaseCourseKnowledgeRelaType_Cond.CaseCourseKnowledgeRelaTypeID, strComparisonOp_CaseCourseKnowledgeRelaTypeID);
}
if (objCaseCourseKnowledgeRelaType_Cond.IsUpdated(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName) == true)
{
string strComparisonOp_CaseCourseKnowledgeRelaTypeName = objCaseCourseKnowledgeRelaType_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName, objCaseCourseKnowledgeRelaType_Cond.CaseCourseKnowledgeRelaTypeName, strComparisonOp_CaseCourseKnowledgeRelaTypeName);
}
if (objCaseCourseKnowledgeRelaType_Cond.IsUpdated(conCaseCourseKnowledgeRelaType.Memo) == true)
{
string strComparisonOp_Memo = objCaseCourseKnowledgeRelaType_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRelaType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRelaType.Memo, objCaseCourseKnowledgeRelaType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN)
{
 if (string.IsNullOrEmpty(objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCaseCourseKnowledgeRelaTypeEN.sf_UpdFldSetStr = objCaseCourseKnowledgeRelaTypeEN.getsf_UpdFldSetStr();
clsCaseCourseKnowledgeRelaTypeWApi.CheckPropertyNew(objCaseCourseKnowledgeRelaTypeEN); 
bool bolResult = clsCaseCourseKnowledgeRelaTypeWApi.UpdateRecord(objCaseCourseKnowledgeRelaTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaTypeWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN)
{
 if (string.IsNullOrEmpty(objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCaseCourseKnowledgeRelaTypeWApi.IsExist(objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsCaseCourseKnowledgeRelaTypeWApi.CheckPropertyNew(objCaseCourseKnowledgeRelaTypeEN); 
bool bolResult = clsCaseCourseKnowledgeRelaTypeWApi.AddNewRecord(objCaseCourseKnowledgeRelaTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaTypeWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN)
{
try
{
clsCaseCourseKnowledgeRelaTypeWApi.CheckPropertyNew(objCaseCourseKnowledgeRelaTypeEN); 
string strid_CaseCourseKnowledgeRelaType = clsCaseCourseKnowledgeRelaTypeWApi.AddNewRecordWithMaxId(objCaseCourseKnowledgeRelaTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaTypeWApi.ReFreshCache();
return strid_CaseCourseKnowledgeRelaType;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN, string strWhereCond)
{
try
{
clsCaseCourseKnowledgeRelaTypeWApi.CheckPropertyNew(objCaseCourseKnowledgeRelaTypeEN); 
bool bolResult = clsCaseCourseKnowledgeRelaTypeWApi.UpdateWithCondition(objCaseCourseKnowledgeRelaTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaTypeWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 案例知识点关系类型(CaseCourseKnowledgeRelaType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCaseCourseKnowledgeRelaTypeWApi
{
private static readonly string mstrApiControllerName = "CaseCourseKnowledgeRelaTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCaseCourseKnowledgeRelaTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_CaseCourseKnowledgeRelaType(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[案例知识点关系类型]...","0");
List<clsCaseCourseKnowledgeRelaTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_CaseCourseKnowledgeRelaType";
objDDL.DataTextField="CaseCourseKnowledgeRelaTypeName";
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
public static void BindCbo_id_CaseCourseKnowledgeRelaType(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType); 
List<clsCaseCourseKnowledgeRelaTypeEN> arrObjLst = clsCaseCourseKnowledgeRelaTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN = new clsCaseCourseKnowledgeRelaTypeEN()
{
id_CaseCourseKnowledgeRelaType = "0",
CaseCourseKnowledgeRelaTypeName = "选[案例知识点关系类型]..."
};
arrObjLst.Insert(0, objCaseCourseKnowledgeRelaTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType;
objComboBox.DisplayMember = conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN)
{
if (!Object.Equals(null, objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType) && GetStrLen(objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType) > 4)
{
 throw new Exception("字段[案例知识点关系类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaTypeEN.CaseCourseKnowledgeRelaTypeID) && GetStrLen(objCaseCourseKnowledgeRelaTypeEN.CaseCourseKnowledgeRelaTypeID) > 4)
{
 throw new Exception("字段[案例题库关系类型ID]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaTypeEN.CaseCourseKnowledgeRelaTypeName) && GetStrLen(objCaseCourseKnowledgeRelaTypeEN.CaseCourseKnowledgeRelaTypeName) > 50)
{
 throw new Exception("字段[案例知识点关系类型名称]的长度不能超过50!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaTypeEN.Memo) && GetStrLen(objCaseCourseKnowledgeRelaTypeEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCaseCourseKnowledgeRelaTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_CaseCourseKnowledgeRelaType">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCourseKnowledgeRelaTypeEN GetObjByid_CaseCourseKnowledgeRelaType(string strid_CaseCourseKnowledgeRelaType)
{
string strAction = "GetObjByid_CaseCourseKnowledgeRelaType";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseKnowledgeRelaType"] = strid_CaseCourseKnowledgeRelaType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseCourseKnowledgeRelaTypeEN = JsonConvert.DeserializeObject<clsCaseCourseKnowledgeRelaTypeEN>((string)jobjReturn["ReturnObj"]);
return objCaseCourseKnowledgeRelaTypeEN;
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
 /// <param name = "strid_CaseCourseKnowledgeRelaType">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCourseKnowledgeRelaTypeEN GetObjByid_CaseCourseKnowledgeRelaType_WA_Cache(string strid_CaseCourseKnowledgeRelaType)
{
string strAction = "GetObjByid_CaseCourseKnowledgeRelaType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseKnowledgeRelaType"] = strid_CaseCourseKnowledgeRelaType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseCourseKnowledgeRelaTypeEN = JsonConvert.DeserializeObject<clsCaseCourseKnowledgeRelaTypeEN>((string)jobjReturn["ReturnObj"]);
return objCaseCourseKnowledgeRelaTypeEN;
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
public static clsCaseCourseKnowledgeRelaTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN = null;
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
objCaseCourseKnowledgeRelaTypeEN = JsonConvert.DeserializeObject<clsCaseCourseKnowledgeRelaTypeEN>((string)jobjReturn["ReturnObj"]);
return objCaseCourseKnowledgeRelaTypeEN;
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
 /// <param name = "strid_CaseCourseKnowledgeRelaType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseCourseKnowledgeRelaTypeEN GetObjByid_CaseCourseKnowledgeRelaType_Cache(string strid_CaseCourseKnowledgeRelaType)
{
if (string.IsNullOrEmpty(strid_CaseCourseKnowledgeRelaType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaTypeEN._CurrTabName_S);
List<clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Sel =
from objCaseCourseKnowledgeRelaTypeEN in arrCaseCourseKnowledgeRelaTypeObjLst_Cache
where objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType == strid_CaseCourseKnowledgeRelaType
select objCaseCourseKnowledgeRelaTypeEN;
if (arrCaseCourseKnowledgeRelaTypeObjLst_Sel.Count() == 0)
{
   clsCaseCourseKnowledgeRelaTypeEN obj = clsCaseCourseKnowledgeRelaTypeWApi.GetObjByid_CaseCourseKnowledgeRelaType(strid_CaseCourseKnowledgeRelaType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCaseCourseKnowledgeRelaTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CaseCourseKnowledgeRelaType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCaseCourseKnowledgeRelaTypeNameByid_CaseCourseKnowledgeRelaType_Cache(string strid_CaseCourseKnowledgeRelaType)
{
if (string.IsNullOrEmpty(strid_CaseCourseKnowledgeRelaType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaTypeEN._CurrTabName_S);
List<clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Sel1 =
from objCaseCourseKnowledgeRelaTypeEN in arrCaseCourseKnowledgeRelaTypeObjLst_Cache
where objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType == strid_CaseCourseKnowledgeRelaType
select objCaseCourseKnowledgeRelaTypeEN;
List <clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Sel = new List<clsCaseCourseKnowledgeRelaTypeEN>();
foreach (clsCaseCourseKnowledgeRelaTypeEN obj in arrCaseCourseKnowledgeRelaTypeObjLst_Sel1)
{
arrCaseCourseKnowledgeRelaTypeObjLst_Sel.Add(obj);
}
if (arrCaseCourseKnowledgeRelaTypeObjLst_Sel.Count > 0)
{
return arrCaseCourseKnowledgeRelaTypeObjLst_Sel[0].CaseCourseKnowledgeRelaTypeName;
}
string strErrMsgForGetObjById = string.Format("在CaseCourseKnowledgeRelaType对象缓存列表中,找不到记录[id_CaseCourseKnowledgeRelaType = {0}](函数:{1})", strid_CaseCourseKnowledgeRelaType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCaseCourseKnowledgeRelaTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CaseCourseKnowledgeRelaType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_CaseCourseKnowledgeRelaType_Cache(string strid_CaseCourseKnowledgeRelaType)
{
if (string.IsNullOrEmpty(strid_CaseCourseKnowledgeRelaType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaTypeEN._CurrTabName_S);
List<clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Sel1 =
from objCaseCourseKnowledgeRelaTypeEN in arrCaseCourseKnowledgeRelaTypeObjLst_Cache
where objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType == strid_CaseCourseKnowledgeRelaType
select objCaseCourseKnowledgeRelaTypeEN;
List <clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Sel = new List<clsCaseCourseKnowledgeRelaTypeEN>();
foreach (clsCaseCourseKnowledgeRelaTypeEN obj in arrCaseCourseKnowledgeRelaTypeObjLst_Sel1)
{
arrCaseCourseKnowledgeRelaTypeObjLst_Sel.Add(obj);
}
if (arrCaseCourseKnowledgeRelaTypeObjLst_Sel.Count > 0)
{
return arrCaseCourseKnowledgeRelaTypeObjLst_Sel[0].CaseCourseKnowledgeRelaTypeName;
}
string strErrMsgForGetObjById = string.Format("在CaseCourseKnowledgeRelaType对象缓存列表中,找不到记录的相关名称[id_CaseCourseKnowledgeRelaType = {0}](函数:{1})", strid_CaseCourseKnowledgeRelaType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCaseCourseKnowledgeRelaTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaTypeEN> GetObjLst(string strWhereCond)
{
 List<clsCaseCourseKnowledgeRelaTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseKnowledgeRelaTypeEN> GetObjLstById_CaseCourseKnowledgeRelaTypeLst(List<string> arrId_CaseCourseKnowledgeRelaType)
{
 List<clsCaseCourseKnowledgeRelaTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseCourseKnowledgeRelaTypeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseCourseKnowledgeRelaType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_CaseCourseKnowledgeRelaType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCaseCourseKnowledgeRelaTypeEN> GetObjLstById_CaseCourseKnowledgeRelaTypeLst_Cache(List<string> arrId_CaseCourseKnowledgeRelaType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaTypeEN._CurrTabName_S);
List<clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Sel =
from objCaseCourseKnowledgeRelaTypeEN in arrCaseCourseKnowledgeRelaTypeObjLst_Cache
where arrId_CaseCourseKnowledgeRelaType.Contains(objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType)
select objCaseCourseKnowledgeRelaTypeEN;
return arrCaseCourseKnowledgeRelaTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaTypeEN> GetObjLstById_CaseCourseKnowledgeRelaTypeLst_WA_Cache(List<string> arrId_CaseCourseKnowledgeRelaType)
{
 List<clsCaseCourseKnowledgeRelaTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseCourseKnowledgeRelaTypeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseCourseKnowledgeRelaType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseKnowledgeRelaTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCaseCourseKnowledgeRelaTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseKnowledgeRelaTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCaseCourseKnowledgeRelaTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseKnowledgeRelaTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCaseCourseKnowledgeRelaTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseKnowledgeRelaTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCaseCourseKnowledgeRelaTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strid_CaseCourseKnowledgeRelaType)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN = clsCaseCourseKnowledgeRelaTypeWApi.GetObjByid_CaseCourseKnowledgeRelaType(strid_CaseCourseKnowledgeRelaType);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_CaseCourseKnowledgeRelaType.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseCourseKnowledgeRelaTypeWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCaseCourseKnowledgeRelaTypes(List<string> arrid_CaseCourseKnowledgeRelaType)
{
string strAction = "DelCaseCourseKnowledgeRelaTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_CaseCourseKnowledgeRelaType);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseCourseKnowledgeRelaTypeWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCaseCourseKnowledgeRelaTypesByCond(string strWhereCond)
{
string strAction = "DelCaseCourseKnowledgeRelaTypesByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseKnowledgeRelaTypeEN>(objCaseCourseKnowledgeRelaTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaTypeWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseKnowledgeRelaTypeEN>(objCaseCourseKnowledgeRelaTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaTypeWApi.ReFreshCache();
var strid_CaseCourseKnowledgeRelaType = (string)jobjReturn["ReturnStr"];
return strid_CaseCourseKnowledgeRelaType;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN)
{
if (string.IsNullOrEmpty(objCaseCourseKnowledgeRelaTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseKnowledgeRelaTypeEN>(objCaseCourseKnowledgeRelaTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCaseCourseKnowledgeRelaTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCourseKnowledgeRelaTypeEN.id_CaseCourseKnowledgeRelaType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseKnowledgeRelaTypeEN>(objCaseCourseKnowledgeRelaTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
public static bool IsExist(string strid_CaseCourseKnowledgeRelaType)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseKnowledgeRelaType"] = strid_CaseCourseKnowledgeRelaType
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaTypeENS">源对象</param>
 /// <param name = "objCaseCourseKnowledgeRelaTypeENT">目标对象</param>
 public static void CopyTo(clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeENS, clsCaseCourseKnowledgeRelaTypeEN objCaseCourseKnowledgeRelaTypeENT)
{
try
{
objCaseCourseKnowledgeRelaTypeENT.id_CaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaTypeENS.id_CaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaTypeENT.CaseCourseKnowledgeRelaTypeID = objCaseCourseKnowledgeRelaTypeENS.CaseCourseKnowledgeRelaTypeID; //案例题库关系类型ID
objCaseCourseKnowledgeRelaTypeENT.CaseCourseKnowledgeRelaTypeName = objCaseCourseKnowledgeRelaTypeENS.CaseCourseKnowledgeRelaTypeName; //案例知识点关系类型名称
objCaseCourseKnowledgeRelaTypeENT.Memo = objCaseCourseKnowledgeRelaTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCaseCourseKnowledgeRelaTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCaseCourseKnowledgeRelaTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCaseCourseKnowledgeRelaTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCaseCourseKnowledgeRelaTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCaseCourseKnowledgeRelaTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCaseCourseKnowledgeRelaTypeEN.AttributeName)
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
if (clsCaseCourseKnowledgeRelaTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseKnowledgeRelaTypeWApi没有刷新缓存机制(clsCaseCourseKnowledgeRelaTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CaseCourseKnowledgeRelaType");
//if (arrCaseCourseKnowledgeRelaTypeObjLst_Cache == null)
//{
//arrCaseCourseKnowledgeRelaTypeObjLst_Cache = await clsCaseCourseKnowledgeRelaTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaTypeEN._CurrTabName_S);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCaseCourseKnowledgeRelaTypeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCaseCourseKnowledgeRelaTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaTypeEN._CurrTabName_S);
List<clsCaseCourseKnowledgeRelaTypeEN> arrCaseCourseKnowledgeRelaTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseCourseKnowledgeRelaTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCaseCourseKnowledgeRelaTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRelaType.Memo, Type.GetType("System.String"));
foreach (clsCaseCourseKnowledgeRelaTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType] = objInFor[conCaseCourseKnowledgeRelaType.id_CaseCourseKnowledgeRelaType];
objDR[conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID] = objInFor[conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeID];
objDR[conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName] = objInFor[conCaseCourseKnowledgeRelaType.CaseCourseKnowledgeRelaTypeName];
objDR[conCaseCourseKnowledgeRelaType.Memo] = objInFor[conCaseCourseKnowledgeRelaType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 案例知识点关系类型(CaseCourseKnowledgeRelaType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CaseCourseKnowledgeRelaType : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
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
clsCaseCourseKnowledgeRelaTypeWApi.ReFreshThisCache();
}
}

}