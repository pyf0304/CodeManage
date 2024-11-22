
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExportExcelSetWApi
 表名:vExportExcelSet(01120116)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:39
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
public static class clsvExportExcelSetWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN Setid_ExportExcel4Users(this clsvExportExcelSetEN objvExportExcelSetEN, string strid_ExportExcel4Users, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ExportExcel4Users, 8, convExportExcelSet.id_ExportExcel4Users);
clsCheckSql.CheckFieldForeignKey(strid_ExportExcel4Users, 8, convExportExcelSet.id_ExportExcel4Users);
objvExportExcelSetEN.id_ExportExcel4Users = strid_ExportExcel4Users; //导出Excel用户字段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.id_ExportExcel4Users) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.id_ExportExcel4Users, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.id_ExportExcel4Users] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN SetViewName(this clsvExportExcelSetEN objvExportExcelSetEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewName, 50, convExportExcelSet.ViewName);
objvExportExcelSetEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.ViewName) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.ViewName, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.ViewName] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN SetTabName(this clsvExportExcelSetEN objvExportExcelSetEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName, 50, convExportExcelSet.TabName);
objvExportExcelSetEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.TabName) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.TabName, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.TabName] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN SetViewTabName(this clsvExportExcelSetEN objvExportExcelSetEN, string strViewTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTabName, convExportExcelSet.ViewTabName);
clsCheckSql.CheckFieldLen(strViewTabName, 101, convExportExcelSet.ViewTabName);
objvExportExcelSetEN.ViewTabName = strViewTabName; //ViewTabName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.ViewTabName) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.ViewTabName, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.ViewTabName] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN SetUserId(this clsvExportExcelSetEN objvExportExcelSetEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convExportExcelSet.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convExportExcelSet.UserId);
objvExportExcelSetEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.UserId) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.UserId, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.UserId] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN SetUserName(this clsvExportExcelSetEN objvExportExcelSetEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convExportExcelSet.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convExportExcelSet.UserName);
objvExportExcelSetEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.UserName) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.UserName, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.UserName] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN SetIsDefaultUser(this clsvExportExcelSetEN objvExportExcelSetEN, bool bolIsDefaultUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultUser, convExportExcelSet.IsDefaultUser);
objvExportExcelSetEN.IsDefaultUser = bolIsDefaultUser; //是否默认用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.IsDefaultUser) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.IsDefaultUser, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.IsDefaultUser] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN SetExportFileName(this clsvExportExcelSetEN objvExportExcelSetEN, string strExportFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExportFileName, convExportExcelSet.ExportFileName);
clsCheckSql.CheckFieldLen(strExportFileName, 100, convExportExcelSet.ExportFileName);
objvExportExcelSetEN.ExportFileName = strExportFileName; //导出文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.ExportFileName) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.ExportFileName, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.ExportFileName] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN SetUpdDate(this clsvExportExcelSetEN objvExportExcelSetEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convExportExcelSet.UpdDate);
objvExportExcelSetEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.UpdDate) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.UpdDate, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.UpdDate] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN SetUpdUserId(this clsvExportExcelSetEN objvExportExcelSetEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convExportExcelSet.UpdUserId);
objvExportExcelSetEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.UpdUserId) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.UpdUserId, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.UpdUserId] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcelSetEN SetMemo(this clsvExportExcelSetEN objvExportExcelSetEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convExportExcelSet.Memo);
objvExportExcelSetEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.Memo) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.Memo, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.Memo] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvExportExcelSetEN objvExportExcelSet_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.id_ExportExcel4Users) == true)
{
string strComparisonOp_id_ExportExcel4Users = objvExportExcelSet_Cond.dicFldComparisonOp[convExportExcelSet.id_ExportExcel4Users];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.id_ExportExcel4Users, objvExportExcelSet_Cond.id_ExportExcel4Users, strComparisonOp_id_ExportExcel4Users);
}
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.ViewName) == true)
{
string strComparisonOp_ViewName = objvExportExcelSet_Cond.dicFldComparisonOp[convExportExcelSet.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.ViewName, objvExportExcelSet_Cond.ViewName, strComparisonOp_ViewName);
}
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.TabName) == true)
{
string strComparisonOp_TabName = objvExportExcelSet_Cond.dicFldComparisonOp[convExportExcelSet.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.TabName, objvExportExcelSet_Cond.TabName, strComparisonOp_TabName);
}
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.ViewTabName) == true)
{
string strComparisonOp_ViewTabName = objvExportExcelSet_Cond.dicFldComparisonOp[convExportExcelSet.ViewTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.ViewTabName, objvExportExcelSet_Cond.ViewTabName, strComparisonOp_ViewTabName);
}
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.UserId) == true)
{
string strComparisonOp_UserId = objvExportExcelSet_Cond.dicFldComparisonOp[convExportExcelSet.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.UserId, objvExportExcelSet_Cond.UserId, strComparisonOp_UserId);
}
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.UserName) == true)
{
string strComparisonOp_UserName = objvExportExcelSet_Cond.dicFldComparisonOp[convExportExcelSet.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.UserName, objvExportExcelSet_Cond.UserName, strComparisonOp_UserName);
}
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.IsDefaultUser) == true)
{
if (objvExportExcelSet_Cond.IsDefaultUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convExportExcelSet.IsDefaultUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convExportExcelSet.IsDefaultUser);
}
}
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.ExportFileName) == true)
{
string strComparisonOp_ExportFileName = objvExportExcelSet_Cond.dicFldComparisonOp[convExportExcelSet.ExportFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.ExportFileName, objvExportExcelSet_Cond.ExportFileName, strComparisonOp_ExportFileName);
}
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvExportExcelSet_Cond.dicFldComparisonOp[convExportExcelSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.UpdDate, objvExportExcelSet_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvExportExcelSet_Cond.dicFldComparisonOp[convExportExcelSet.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.UpdUserId, objvExportExcelSet_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvExportExcelSet_Cond.IsUpdated(convExportExcelSet.Memo) == true)
{
string strComparisonOp_Memo = objvExportExcelSet_Cond.dicFldComparisonOp[convExportExcelSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.Memo, objvExportExcelSet_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v导出Excel设置(vExportExcelSet)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvExportExcelSetWApi
{
private static readonly string mstrApiControllerName = "vExportExcelSetApi";

 public clsvExportExcelSetWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_ExportExcel4Users(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v导出Excel设置]...","0");
List<clsvExportExcelSetEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_ExportExcel4Users";
objDDL.DataTextField="ViewTabName";
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
public static void BindCbo_id_ExportExcel4Users(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convExportExcelSet.id_ExportExcel4Users); 
List<clsvExportExcelSetEN> arrObjLst = clsvExportExcelSetWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN()
{
id_ExportExcel4Users = "0",
ViewTabName = "选[v导出Excel设置]..."
};
arrObjLst.Insert(0, objvExportExcelSetEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convExportExcelSet.id_ExportExcel4Users;
objComboBox.DisplayMember = convExportExcelSet.ViewTabName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExportExcelSetEN GetObjByid_ExportExcel4Users(string strid_ExportExcel4Users)
{
string strAction = "GetObjByid_ExportExcel4Users";
string strErrMsg = string.Empty;
string strResult = "";
clsvExportExcelSetEN objvExportExcelSetEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_ExportExcel4Users"] = strid_ExportExcel4Users
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvExportExcelSetEN = JsonConvert.DeserializeObject<clsvExportExcelSetEN>((string)jobjReturn["ReturnObj"]);
return objvExportExcelSetEN;
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
 /// <param name = "strid_ExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExportExcelSetEN GetObjByid_ExportExcel4Users_WA_Cache(string strid_ExportExcel4Users)
{
string strAction = "GetObjByid_ExportExcel4Users_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvExportExcelSetEN objvExportExcelSetEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_ExportExcel4Users"] = strid_ExportExcel4Users
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvExportExcelSetEN = JsonConvert.DeserializeObject<clsvExportExcelSetEN>((string)jobjReturn["ReturnObj"]);
return objvExportExcelSetEN;
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
public static clsvExportExcelSetEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvExportExcelSetEN objvExportExcelSetEN = null;
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
objvExportExcelSetEN = JsonConvert.DeserializeObject<clsvExportExcelSetEN>((string)jobjReturn["ReturnObj"]);
return objvExportExcelSetEN;
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
 /// <param name = "strid_ExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExportExcelSetEN GetObjByid_ExportExcel4Users_Cache(string strid_ExportExcel4Users)
{
if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvExportExcelSetEN._CurrTabName_S);
List<clsvExportExcelSetEN> arrvExportExcelSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvExportExcelSetEN> arrvExportExcelSetObjLst_Sel =
from objvExportExcelSetEN in arrvExportExcelSetObjLst_Cache
where objvExportExcelSetEN.id_ExportExcel4Users == strid_ExportExcel4Users
select objvExportExcelSetEN;
if (arrvExportExcelSetObjLst_Sel.Count() == 0)
{
   clsvExportExcelSetEN obj = clsvExportExcelSetWApi.GetObjByid_ExportExcel4Users(strid_ExportExcel4Users);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvExportExcelSetObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewTabNameByid_ExportExcel4Users_Cache(string strid_ExportExcel4Users)
{
if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvExportExcelSetEN._CurrTabName_S);
List<clsvExportExcelSetEN> arrvExportExcelSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvExportExcelSetEN> arrvExportExcelSetObjLst_Sel1 =
from objvExportExcelSetEN in arrvExportExcelSetObjLst_Cache
where objvExportExcelSetEN.id_ExportExcel4Users == strid_ExportExcel4Users
select objvExportExcelSetEN;
List <clsvExportExcelSetEN> arrvExportExcelSetObjLst_Sel = new List<clsvExportExcelSetEN>();
foreach (clsvExportExcelSetEN obj in arrvExportExcelSetObjLst_Sel1)
{
arrvExportExcelSetObjLst_Sel.Add(obj);
}
if (arrvExportExcelSetObjLst_Sel.Count > 0)
{
return arrvExportExcelSetObjLst_Sel[0].ViewTabName;
}
string strErrMsgForGetObjById = string.Format("在vExportExcelSet对象缓存列表中,找不到记录[id_ExportExcel4Users = {0}](函数:{1})", strid_ExportExcel4Users, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvExportExcelSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_ExportExcel4Users_Cache(string strid_ExportExcel4Users)
{
if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvExportExcelSetEN._CurrTabName_S);
List<clsvExportExcelSetEN> arrvExportExcelSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvExportExcelSetEN> arrvExportExcelSetObjLst_Sel1 =
from objvExportExcelSetEN in arrvExportExcelSetObjLst_Cache
where objvExportExcelSetEN.id_ExportExcel4Users == strid_ExportExcel4Users
select objvExportExcelSetEN;
List <clsvExportExcelSetEN> arrvExportExcelSetObjLst_Sel = new List<clsvExportExcelSetEN>();
foreach (clsvExportExcelSetEN obj in arrvExportExcelSetObjLst_Sel1)
{
arrvExportExcelSetObjLst_Sel.Add(obj);
}
if (arrvExportExcelSetObjLst_Sel.Count > 0)
{
return arrvExportExcelSetObjLst_Sel[0].ViewTabName;
}
string strErrMsgForGetObjById = string.Format("在vExportExcelSet对象缓存列表中,找不到记录的相关名称[id_ExportExcel4Users = {0}](函数:{1})", strid_ExportExcel4Users, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvExportExcelSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcelSetEN> GetObjLst(string strWhereCond)
{
 List<clsvExportExcelSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcelSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvExportExcelSetEN> GetObjLstById_ExportExcel4UsersLst(List<string> arrId_ExportExcel4Users)
{
 List<clsvExportExcelSetEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExportExcel4UsersLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExportExcel4Users);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcelSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_ExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvExportExcelSetEN> GetObjLstById_ExportExcel4UsersLst_Cache(List<string> arrId_ExportExcel4Users)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvExportExcelSetEN._CurrTabName_S);
List<clsvExportExcelSetEN> arrvExportExcelSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvExportExcelSetEN> arrvExportExcelSetObjLst_Sel =
from objvExportExcelSetEN in arrvExportExcelSetObjLst_Cache
where arrId_ExportExcel4Users.Contains(objvExportExcelSetEN.id_ExportExcel4Users)
select objvExportExcelSetEN;
return arrvExportExcelSetObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcelSetEN> GetObjLstById_ExportExcel4UsersLst_WA_Cache(List<string> arrId_ExportExcel4Users)
{
 List<clsvExportExcelSetEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExportExcel4UsersLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExportExcel4Users);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcelSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvExportExcelSetEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvExportExcelSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcelSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvExportExcelSetEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvExportExcelSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcelSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvExportExcelSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvExportExcelSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcelSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvExportExcelSetEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvExportExcelSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcelSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_ExportExcel4Users)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_ExportExcel4Users"] = strid_ExportExcel4Users
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
 /// <param name = "objvExportExcelSetENS">源对象</param>
 /// <param name = "objvExportExcelSetENT">目标对象</param>
 public static void CopyTo(clsvExportExcelSetEN objvExportExcelSetENS, clsvExportExcelSetEN objvExportExcelSetENT)
{
try
{
objvExportExcelSetENT.id_ExportExcel4Users = objvExportExcelSetENS.id_ExportExcel4Users; //导出Excel用户字段流水号
objvExportExcelSetENT.ViewName = objvExportExcelSetENS.ViewName; //界面名称
objvExportExcelSetENT.TabName = objvExportExcelSetENS.TabName; //表名
objvExportExcelSetENT.ViewTabName = objvExportExcelSetENS.ViewTabName; //ViewTabName
objvExportExcelSetENT.UserId = objvExportExcelSetENS.UserId; //用户ID
objvExportExcelSetENT.UserName = objvExportExcelSetENS.UserName; //用户名
objvExportExcelSetENT.IsDefaultUser = objvExportExcelSetENS.IsDefaultUser; //是否默认用户
objvExportExcelSetENT.ExportFileName = objvExportExcelSetENS.ExportFileName; //导出文件名
objvExportExcelSetENT.UpdDate = objvExportExcelSetENS.UpdDate; //修改日期
objvExportExcelSetENT.UpdUserId = objvExportExcelSetENS.UpdUserId; //修改用户Id
objvExportExcelSetENT.Memo = objvExportExcelSetENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvExportExcelSetEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvExportExcelSetEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvExportExcelSetEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvExportExcelSetEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvExportExcelSetEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvExportExcelSetEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsExportExcelSetWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsExportExcelSetWApi没有刷新缓存机制(clsExportExcelSetWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_ExportExcel4Users");
//if (arrvExportExcelSetObjLst_Cache == null)
//{
//arrvExportExcelSetObjLst_Cache = await clsvExportExcelSetWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvExportExcelSetEN._CurrTabName_S);
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
public static List<clsvExportExcelSetEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvExportExcelSetEN._CurrTabName_S);
List<clsvExportExcelSetEN> arrvExportExcelSetObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvExportExcelSetObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvExportExcelSetEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convExportExcelSet.id_ExportExcel4Users, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcelSet.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcelSet.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcelSet.ViewTabName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcelSet.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcelSet.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcelSet.IsDefaultUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convExportExcelSet.ExportFileName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcelSet.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcelSet.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcelSet.Memo, Type.GetType("System.String"));
foreach (clsvExportExcelSetEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convExportExcelSet.id_ExportExcel4Users] = objInFor[convExportExcelSet.id_ExportExcel4Users];
objDR[convExportExcelSet.ViewName] = objInFor[convExportExcelSet.ViewName];
objDR[convExportExcelSet.TabName] = objInFor[convExportExcelSet.TabName];
objDR[convExportExcelSet.ViewTabName] = objInFor[convExportExcelSet.ViewTabName];
objDR[convExportExcelSet.UserId] = objInFor[convExportExcelSet.UserId];
objDR[convExportExcelSet.UserName] = objInFor[convExportExcelSet.UserName];
objDR[convExportExcelSet.IsDefaultUser] = objInFor[convExportExcelSet.IsDefaultUser];
objDR[convExportExcelSet.ExportFileName] = objInFor[convExportExcelSet.ExportFileName];
objDR[convExportExcelSet.UpdDate] = objInFor[convExportExcelSet.UpdDate];
objDR[convExportExcelSet.UpdUserId] = objInFor[convExportExcelSet.UpdUserId];
objDR[convExportExcelSet.Memo] = objInFor[convExportExcelSet.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}