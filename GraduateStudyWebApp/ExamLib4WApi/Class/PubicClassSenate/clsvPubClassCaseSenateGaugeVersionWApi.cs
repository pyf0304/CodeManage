
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseSenateGaugeVersionWApi
 表名:vPubClassCaseSenateGaugeVersion(01120505)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:16
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩
 模块英文名:PubicClassSenate
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
public static class clsvPubClassCaseSenateGaugeVersionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN Setid_PubClassCaseSenateGaugeVersion(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, string strid_PubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_PubClassCaseSenateGaugeVersion, 4, convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCaseSenateGaugeVersion, 4, convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion);
objvPubClassCaseSenateGaugeVersionEN.id_PubClassCaseSenateGaugeVersion = strid_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionID(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionName(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetVersionNo(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, int intVersionNo, string strComparisonOp="")
	{
objvPubClassCaseSenateGaugeVersionEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.VersionNo) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.VersionNo, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.VersionNo] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetIsUse(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, bool bolIsUse, string strComparisonOp="")
	{
objvPubClassCaseSenateGaugeVersionEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.IsUse) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.IsUse, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.IsUse] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionTtlScore(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionMemo(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = strsenateGaugeVersionMemo; //评价量表版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetSenateGaugeNum(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, int intSenateGaugeNum, string strComparisonOp="")
	{
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = intSenateGaugeNum; //SenateGaugeNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.SenateGaugeNum) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.SenateGaugeNum, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersion_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCaseSenateGaugeVersion_Cond.IsUpdated(convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOp_id_PubClassCaseSenateGaugeVersion = objvPubClassCaseSenateGaugeVersion_Cond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion, objvPubClassCaseSenateGaugeVersion_Cond.id_PubClassCaseSenateGaugeVersion, strComparisonOp_id_PubClassCaseSenateGaugeVersion);
}
if (objvPubClassCaseSenateGaugeVersion_Cond.IsUpdated(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvPubClassCaseSenateGaugeVersion_Cond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenateGaugeVersion.senateGaugeVersionID, objvPubClassCaseSenateGaugeVersion_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvPubClassCaseSenateGaugeVersion_Cond.IsUpdated(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvPubClassCaseSenateGaugeVersion_Cond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenateGaugeVersion.senateGaugeVersionName, objvPubClassCaseSenateGaugeVersion_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvPubClassCaseSenateGaugeVersion_Cond.IsUpdated(convPubClassCaseSenateGaugeVersion.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvPubClassCaseSenateGaugeVersion_Cond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseSenateGaugeVersion.VersionNo, objvPubClassCaseSenateGaugeVersion_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvPubClassCaseSenateGaugeVersion_Cond.IsUpdated(convPubClassCaseSenateGaugeVersion.IsUse) == true)
{
if (objvPubClassCaseSenateGaugeVersion_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseSenateGaugeVersion.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseSenateGaugeVersion.IsUse);
}
}
if (objvPubClassCaseSenateGaugeVersion_Cond.IsUpdated(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvPubClassCaseSenateGaugeVersion_Cond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore, objvPubClassCaseSenateGaugeVersion_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvPubClassCaseSenateGaugeVersion_Cond.IsUpdated(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo) == true)
{
string strComparisonOp_senateGaugeVersionMemo = objvPubClassCaseSenateGaugeVersion_Cond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo, objvPubClassCaseSenateGaugeVersion_Cond.senateGaugeVersionMemo, strComparisonOp_senateGaugeVersionMemo);
}
if (objvPubClassCaseSenateGaugeVersion_Cond.IsUpdated(convPubClassCaseSenateGaugeVersion.SenateGaugeNum) == true)
{
string strComparisonOp_SenateGaugeNum = objvPubClassCaseSenateGaugeVersion_Cond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.SenateGaugeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseSenateGaugeVersion.SenateGaugeNum, objvPubClassCaseSenateGaugeVersion_Cond.SenateGaugeNum, strComparisonOp_SenateGaugeNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v公开课评价量规版本(vPubClassCaseSenateGaugeVersion)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCaseSenateGaugeVersionWApi
{
private static readonly string mstrApiControllerName = "vPubClassCaseSenateGaugeVersionApi";

 public clsvPubClassCaseSenateGaugeVersionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_PubClassCaseSenateGaugeVersion(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v公开课评价量规版本]...","0");
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_PubClassCaseSenateGaugeVersion";
objDDL.DataTextField="senateGaugeVersionName";
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
public static void BindCbo_id_PubClassCaseSenateGaugeVersion(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion); 
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = clsvPubClassCaseSenateGaugeVersionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN()
{
id_PubClassCaseSenateGaugeVersion = "0",
senateGaugeVersionName = "选[v公开课评价量规版本]..."
};
arrObjLst.Insert(0, objvPubClassCaseSenateGaugeVersionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion;
objComboBox.DisplayMember = convPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_PubClassCaseSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseSenateGaugeVersionEN GetObjByid_PubClassCaseSenateGaugeVersion(string strid_PubClassCaseSenateGaugeVersion)
{
string strAction = "GetObjByid_PubClassCaseSenateGaugeVersion";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseSenateGaugeVersion"] = strid_PubClassCaseSenateGaugeVersion
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubClassCaseSenateGaugeVersionEN = JsonConvert.DeserializeObject<clsvPubClassCaseSenateGaugeVersionEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseSenateGaugeVersionEN;
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
 /// <param name = "strid_PubClassCaseSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseSenateGaugeVersionEN GetObjByid_PubClassCaseSenateGaugeVersion_WA_Cache(string strid_PubClassCaseSenateGaugeVersion)
{
string strAction = "GetObjByid_PubClassCaseSenateGaugeVersion_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseSenateGaugeVersion"] = strid_PubClassCaseSenateGaugeVersion
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubClassCaseSenateGaugeVersionEN = JsonConvert.DeserializeObject<clsvPubClassCaseSenateGaugeVersionEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseSenateGaugeVersionEN;
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
public static clsvPubClassCaseSenateGaugeVersionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = null;
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
objvPubClassCaseSenateGaugeVersionEN = JsonConvert.DeserializeObject<clsvPubClassCaseSenateGaugeVersionEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseSenateGaugeVersionEN;
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
 /// <param name = "strid_PubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseSenateGaugeVersionEN GetObjByid_PubClassCaseSenateGaugeVersion_Cache(string strid_PubClassCaseSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strid_PubClassCaseSenateGaugeVersion) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseSenateGaugeVersionEN._CurrTabName_S);
List<clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Sel =
from objvPubClassCaseSenateGaugeVersionEN in arrvPubClassCaseSenateGaugeVersionObjLst_Cache
where objvPubClassCaseSenateGaugeVersionEN.id_PubClassCaseSenateGaugeVersion == strid_PubClassCaseSenateGaugeVersion
select objvPubClassCaseSenateGaugeVersionEN;
if (arrvPubClassCaseSenateGaugeVersionObjLst_Sel.Count() == 0)
{
   clsvPubClassCaseSenateGaugeVersionEN obj = clsvPubClassCaseSenateGaugeVersionWApi.GetObjByid_PubClassCaseSenateGaugeVersion(strid_PubClassCaseSenateGaugeVersion);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPubClassCaseSenateGaugeVersionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_PubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeVersionNameByid_PubClassCaseSenateGaugeVersion_Cache(string strid_PubClassCaseSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strid_PubClassCaseSenateGaugeVersion) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseSenateGaugeVersionEN._CurrTabName_S);
List<clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Sel1 =
from objvPubClassCaseSenateGaugeVersionEN in arrvPubClassCaseSenateGaugeVersionObjLst_Cache
where objvPubClassCaseSenateGaugeVersionEN.id_PubClassCaseSenateGaugeVersion == strid_PubClassCaseSenateGaugeVersion
select objvPubClassCaseSenateGaugeVersionEN;
List <clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Sel = new List<clsvPubClassCaseSenateGaugeVersionEN>();
foreach (clsvPubClassCaseSenateGaugeVersionEN obj in arrvPubClassCaseSenateGaugeVersionObjLst_Sel1)
{
arrvPubClassCaseSenateGaugeVersionObjLst_Sel.Add(obj);
}
if (arrvPubClassCaseSenateGaugeVersionObjLst_Sel.Count > 0)
{
return arrvPubClassCaseSenateGaugeVersionObjLst_Sel[0].senateGaugeVersionName;
}
string strErrMsgForGetObjById = string.Format("在vPubClassCaseSenateGaugeVersion对象缓存列表中,找不到记录[id_PubClassCaseSenateGaugeVersion = {0}](函数:{1})", strid_PubClassCaseSenateGaugeVersion, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvPubClassCaseSenateGaugeVersionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_PubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_PubClassCaseSenateGaugeVersion_Cache(string strid_PubClassCaseSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strid_PubClassCaseSenateGaugeVersion) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseSenateGaugeVersionEN._CurrTabName_S);
List<clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Sel1 =
from objvPubClassCaseSenateGaugeVersionEN in arrvPubClassCaseSenateGaugeVersionObjLst_Cache
where objvPubClassCaseSenateGaugeVersionEN.id_PubClassCaseSenateGaugeVersion == strid_PubClassCaseSenateGaugeVersion
select objvPubClassCaseSenateGaugeVersionEN;
List <clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Sel = new List<clsvPubClassCaseSenateGaugeVersionEN>();
foreach (clsvPubClassCaseSenateGaugeVersionEN obj in arrvPubClassCaseSenateGaugeVersionObjLst_Sel1)
{
arrvPubClassCaseSenateGaugeVersionObjLst_Sel.Add(obj);
}
if (arrvPubClassCaseSenateGaugeVersionObjLst_Sel.Count > 0)
{
return arrvPubClassCaseSenateGaugeVersionObjLst_Sel[0].senateGaugeVersionName;
}
string strErrMsgForGetObjById = string.Format("在vPubClassCaseSenateGaugeVersion对象缓存列表中,找不到记录的相关名称[id_PubClassCaseSenateGaugeVersion = {0}](函数:{1})", strid_PubClassCaseSenateGaugeVersion, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvPubClassCaseSenateGaugeVersionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLst(string strWhereCond)
{
 List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstById_PubClassCaseSenateGaugeVersionLst(List<string> arrId_PubClassCaseSenateGaugeVersion)
{
 List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseSenateGaugeVersionLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCaseSenateGaugeVersion);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_PubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstById_PubClassCaseSenateGaugeVersionLst_Cache(List<string> arrId_PubClassCaseSenateGaugeVersion)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseSenateGaugeVersionEN._CurrTabName_S);
List<clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Sel =
from objvPubClassCaseSenateGaugeVersionEN in arrvPubClassCaseSenateGaugeVersionObjLst_Cache
where arrId_PubClassCaseSenateGaugeVersion.Contains(objvPubClassCaseSenateGaugeVersionEN.id_PubClassCaseSenateGaugeVersion)
select objvPubClassCaseSenateGaugeVersionEN;
return arrvPubClassCaseSenateGaugeVersionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstById_PubClassCaseSenateGaugeVersionLst_WA_Cache(List<string> arrId_PubClassCaseSenateGaugeVersion)
{
 List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseSenateGaugeVersionLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCaseSenateGaugeVersion);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_PubClassCaseSenateGaugeVersion)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseSenateGaugeVersion"] = strid_PubClassCaseSenateGaugeVersion
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
 /// <param name = "objvPubClassCaseSenateGaugeVersionENS">源对象</param>
 /// <param name = "objvPubClassCaseSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionENS, clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionENT)
{
try
{
objvPubClassCaseSenateGaugeVersionENT.id_PubClassCaseSenateGaugeVersion = objvPubClassCaseSenateGaugeVersionENS.id_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionID = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionName = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseSenateGaugeVersionENT.VersionNo = objvPubClassCaseSenateGaugeVersionENS.VersionNo; //版本号
objvPubClassCaseSenateGaugeVersionENT.IsUse = objvPubClassCaseSenateGaugeVersionENS.IsUse; //是否使用
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionTtlScore = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionMemo = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
objvPubClassCaseSenateGaugeVersionENT.SenateGaugeNum = objvPubClassCaseSenateGaugeVersionENS.SenateGaugeNum; //SenateGaugeNum
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
public static DataTable ToDataTable(List<clsvPubClassCaseSenateGaugeVersionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPubClassCaseSenateGaugeVersionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPubClassCaseSenateGaugeVersionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPubClassCaseSenateGaugeVersionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPubClassCaseSenateGaugeVersionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPubClassCaseSenateGaugeVersionEN.AttributeName)
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
if (clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionWApi没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_PubClassCaseSenateGaugeVersion");
//if (arrvPubClassCaseSenateGaugeVersionObjLst_Cache == null)
//{
//arrvPubClassCaseSenateGaugeVersionObjLst_Cache = await clsvPubClassCaseSenateGaugeVersionWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPubClassCaseSenateGaugeVersionEN._CurrTabName_S);
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCaseSenateGaugeVersionEN._CurrTabName_S);
List<clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCaseSenateGaugeVersionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenateGaugeVersion.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convPubClassCaseSenateGaugeVersion.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseSenateGaugeVersion.SenateGaugeNum, Type.GetType("System.Int32"));
foreach (clsvPubClassCaseSenateGaugeVersionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion] = objInFor[convPubClassCaseSenateGaugeVersion.id_PubClassCaseSenateGaugeVersion];
objDR[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] = objInFor[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID];
objDR[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] = objInFor[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName];
objDR[convPubClassCaseSenateGaugeVersion.VersionNo] = objInFor[convPubClassCaseSenateGaugeVersion.VersionNo];
objDR[convPubClassCaseSenateGaugeVersion.IsUse] = objInFor[convPubClassCaseSenateGaugeVersion.IsUse];
objDR[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] = objInFor[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore];
objDR[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] = objInFor[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo];
objDR[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] = objInFor[convPubClassCaseSenateGaugeVersion.SenateGaugeNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}