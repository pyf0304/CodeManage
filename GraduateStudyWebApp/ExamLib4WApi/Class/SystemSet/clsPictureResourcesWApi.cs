
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPictureResourcesWApi
 表名:PictureResources(01120040)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:33
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
public static class clsPictureResourcesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetMemo(this clsPictureResourcesEN objPictureResourcesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPictureResources.Memo);
objPictureResourcesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.Memo) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.Memo, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.Memo] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetPictureId(this clsPictureResourcesEN objPictureResourcesEN, int intPictureId, string strComparisonOp="")
	{
objPictureResourcesEN.PictureId = intPictureId; //PictureId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.PictureId) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.PictureId, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.PictureId] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetPictureName(this clsPictureResourcesEN objPictureResourcesEN, string strPictureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPictureName, conPictureResources.PictureName);
clsCheckSql.CheckFieldLen(strPictureName, 100, conPictureResources.PictureName);
objPictureResourcesEN.PictureName = strPictureName; //PictureName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.PictureName) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.PictureName, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.PictureName] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetOrginialFileName(this clsPictureResourcesEN objPictureResourcesEN, string strOrginialFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOrginialFileName, 100, conPictureResources.OrginialFileName);
objPictureResourcesEN.OrginialFileName = strOrginialFileName; //OrginialFileName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.OrginialFileName) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.OrginialFileName, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.OrginialFileName] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetOrginialFileSize(this clsPictureResourcesEN objPictureResourcesEN, int intOrginialFileSize, string strComparisonOp="")
	{
objPictureResourcesEN.OrginialFileSize = intOrginialFileSize; //OrginialFileSize
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.OrginialFileSize) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.OrginialFileSize, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.OrginialFileSize] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetResizePictureSize(this clsPictureResourcesEN objPictureResourcesEN, int intResizePictureSize, string strComparisonOp="")
	{
objPictureResourcesEN.ResizePictureSize = intResizePictureSize; //ResizePictureSize
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.ResizePictureSize) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.ResizePictureSize, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.ResizePictureSize] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetThumbSize(this clsPictureResourcesEN objPictureResourcesEN, int intThumbSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intThumbSize, conPictureResources.ThumbSize);
objPictureResourcesEN.ThumbSize = intThumbSize; //ThumbSize
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.ThumbSize) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.ThumbSize, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.ThumbSize] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetOrginialFileWidth(this clsPictureResourcesEN objPictureResourcesEN, int intOrginialFileWidth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrginialFileWidth, conPictureResources.OrginialFileWidth);
objPictureResourcesEN.OrginialFileWidth = intOrginialFileWidth; //OrginialFileWidth
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.OrginialFileWidth) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.OrginialFileWidth, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.OrginialFileWidth] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetPictureConfigerId(this clsPictureResourcesEN objPictureResourcesEN, string strPictureConfigerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPictureConfigerId, 4, conPictureResources.PictureConfigerId);
clsCheckSql.CheckFieldForeignKey(strPictureConfigerId, 4, conPictureResources.PictureConfigerId);
objPictureResourcesEN.PictureConfigerId = strPictureConfigerId; //PictureConfigerId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.PictureConfigerId) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.PictureConfigerId, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.PictureConfigerId] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetResizePictureName(this clsPictureResourcesEN objPictureResourcesEN, string strResizePictureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResizePictureName, conPictureResources.ResizePictureName);
clsCheckSql.CheckFieldLen(strResizePictureName, 100, conPictureResources.ResizePictureName);
objPictureResourcesEN.ResizePictureName = strResizePictureName; //ResizePictureName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.ResizePictureName) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.ResizePictureName, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.ResizePictureName] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetThumbName(this clsPictureResourcesEN objPictureResourcesEN, string strThumbName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strThumbName, conPictureResources.ThumbName);
clsCheckSql.CheckFieldLen(strThumbName, 100, conPictureResources.ThumbName);
objPictureResourcesEN.ThumbName = strThumbName; //ThumbName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.ThumbName) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.ThumbName, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.ThumbName] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPictureResourcesEN SetOrginialFileHeight(this clsPictureResourcesEN objPictureResourcesEN, int intOrginialFileHeight, string strComparisonOp="")
	{
objPictureResourcesEN.OrginialFileHeight = intOrginialFileHeight; //OrginialFileHeight
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPictureResourcesEN.dicFldComparisonOp.ContainsKey(conPictureResources.OrginialFileHeight) == false)
{
objPictureResourcesEN.dicFldComparisonOp.Add(conPictureResources.OrginialFileHeight, strComparisonOp);
}
else
{
objPictureResourcesEN.dicFldComparisonOp[conPictureResources.OrginialFileHeight] = strComparisonOp;
}
}
return objPictureResourcesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPictureResourcesEN objPictureResources_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPictureResources_Cond.IsUpdated(conPictureResources.Memo) == true)
{
string strComparisonOp_Memo = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.Memo, objPictureResources_Cond.Memo, strComparisonOp_Memo);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.PictureId) == true)
{
string strComparisonOp_PictureId = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.PictureId];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.PictureId, objPictureResources_Cond.PictureId, strComparisonOp_PictureId);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.PictureName) == true)
{
string strComparisonOp_PictureName = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.PictureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.PictureName, objPictureResources_Cond.PictureName, strComparisonOp_PictureName);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.OrginialFileName) == true)
{
string strComparisonOp_OrginialFileName = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.OrginialFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.OrginialFileName, objPictureResources_Cond.OrginialFileName, strComparisonOp_OrginialFileName);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.OrginialFileSize) == true)
{
string strComparisonOp_OrginialFileSize = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.OrginialFileSize];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.OrginialFileSize, objPictureResources_Cond.OrginialFileSize, strComparisonOp_OrginialFileSize);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.ResizePictureSize) == true)
{
string strComparisonOp_ResizePictureSize = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.ResizePictureSize];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.ResizePictureSize, objPictureResources_Cond.ResizePictureSize, strComparisonOp_ResizePictureSize);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.ThumbSize) == true)
{
string strComparisonOp_ThumbSize = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.ThumbSize];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.ThumbSize, objPictureResources_Cond.ThumbSize, strComparisonOp_ThumbSize);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.OrginialFileWidth) == true)
{
string strComparisonOp_OrginialFileWidth = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.OrginialFileWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.OrginialFileWidth, objPictureResources_Cond.OrginialFileWidth, strComparisonOp_OrginialFileWidth);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.PictureConfigerId) == true)
{
string strComparisonOp_PictureConfigerId = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.PictureConfigerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.PictureConfigerId, objPictureResources_Cond.PictureConfigerId, strComparisonOp_PictureConfigerId);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.ResizePictureName) == true)
{
string strComparisonOp_ResizePictureName = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.ResizePictureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.ResizePictureName, objPictureResources_Cond.ResizePictureName, strComparisonOp_ResizePictureName);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.ThumbName) == true)
{
string strComparisonOp_ThumbName = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.ThumbName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPictureResources.ThumbName, objPictureResources_Cond.ThumbName, strComparisonOp_ThumbName);
}
if (objPictureResources_Cond.IsUpdated(conPictureResources.OrginialFileHeight) == true)
{
string strComparisonOp_OrginialFileHeight = objPictureResources_Cond.dicFldComparisonOp[conPictureResources.OrginialFileHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conPictureResources.OrginialFileHeight, objPictureResources_Cond.OrginialFileHeight, strComparisonOp_OrginialFileHeight);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPictureResourcesEN objPictureResourcesEN)
{
 if (objPictureResourcesEN.PictureId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPictureResourcesEN.sf_UpdFldSetStr = objPictureResourcesEN.getsf_UpdFldSetStr();
clsPictureResourcesWApi.CheckPropertyNew(objPictureResourcesEN); 
bool bolResult = clsPictureResourcesWApi.UpdateRecord(objPictureResourcesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--PictureResources(图片资源), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPictureResourcesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_PictureName_PictureConfigerId(this clsPictureResourcesEN objPictureResourcesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPictureResourcesEN == null) return "";
if (objPictureResourcesEN.PictureId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PictureName = '{0}'", objPictureResourcesEN.PictureName);
 sbCondition.AppendFormat(" and PictureConfigerId = '{0}'", objPictureResourcesEN.PictureConfigerId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PictureId !=  {0}", objPictureResourcesEN.PictureId);
 sbCondition.AppendFormat(" and PictureName = '{0}'", objPictureResourcesEN.PictureName);
 sbCondition.AppendFormat(" and PictureConfigerId = '{0}'", objPictureResourcesEN.PictureConfigerId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPictureResourcesEN objPictureResourcesEN)
{
try
{
clsPictureResourcesWApi.CheckPropertyNew(objPictureResourcesEN); 
bool bolResult = clsPictureResourcesWApi.AddNewRecord(objPictureResourcesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPictureResourcesEN objPictureResourcesEN, string strWhereCond)
{
try
{
clsPictureResourcesWApi.CheckPropertyNew(objPictureResourcesEN); 
bool bolResult = clsPictureResourcesWApi.UpdateWithCondition(objPictureResourcesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesWApi.ReFreshCache();
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
 /// 图片资源(PictureResources)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPictureResourcesWApi
{
private static readonly string mstrApiControllerName = "PictureResourcesApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsPictureResourcesWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPictureResourcesEN objPictureResourcesEN)
{
if (!Object.Equals(null, objPictureResourcesEN.Memo) && GetStrLen(objPictureResourcesEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objPictureResourcesEN.PictureName) && GetStrLen(objPictureResourcesEN.PictureName) > 100)
{
 throw new Exception("字段[PictureName]的长度不能超过100!");
}
if (!Object.Equals(null, objPictureResourcesEN.OrginialFileName) && GetStrLen(objPictureResourcesEN.OrginialFileName) > 100)
{
 throw new Exception("字段[OrginialFileName]的长度不能超过100!");
}
if (!Object.Equals(null, objPictureResourcesEN.PictureConfigerId) && GetStrLen(objPictureResourcesEN.PictureConfigerId) > 4)
{
 throw new Exception("字段[PictureConfigerId]的长度不能超过4!");
}
if (!Object.Equals(null, objPictureResourcesEN.ResizePictureName) && GetStrLen(objPictureResourcesEN.ResizePictureName) > 100)
{
 throw new Exception("字段[ResizePictureName]的长度不能超过100!");
}
if (!Object.Equals(null, objPictureResourcesEN.ThumbName) && GetStrLen(objPictureResourcesEN.ThumbName) > 100)
{
 throw new Exception("字段[ThumbName]的长度不能超过100!");
}
 objPictureResourcesEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "intPictureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPictureResourcesEN GetObjByPictureId(int intPictureId)
{
string strAction = "GetObjByPictureId";
string strErrMsg = string.Empty;
string strResult = "";
clsPictureResourcesEN objPictureResourcesEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PictureId"] = intPictureId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPictureResourcesEN = JsonConvert.DeserializeObject<clsPictureResourcesEN>((string)jobjReturn["ReturnObj"]);
return objPictureResourcesEN;
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
 /// <param name = "intPictureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPictureResourcesEN GetObjByPictureId_WA_Cache(int intPictureId)
{
string strAction = "GetObjByPictureId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsPictureResourcesEN objPictureResourcesEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PictureId"] = intPictureId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPictureResourcesEN = JsonConvert.DeserializeObject<clsPictureResourcesEN>((string)jobjReturn["ReturnObj"]);
return objPictureResourcesEN;
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
public static int GetFirstID(string strWhereCond)
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
return int.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsPictureResourcesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsPictureResourcesEN objPictureResourcesEN = null;
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
objPictureResourcesEN = JsonConvert.DeserializeObject<clsPictureResourcesEN>((string)jobjReturn["ReturnObj"]);
return objPictureResourcesEN;
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
 /// <param name = "intPictureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPictureResourcesEN GetObjByPictureId_Cache(int intPictureId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPictureResourcesEN._CurrTabName_S);
List<clsPictureResourcesEN> arrPictureResourcesObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPictureResourcesEN> arrPictureResourcesObjLst_Sel =
from objPictureResourcesEN in arrPictureResourcesObjLst_Cache
where objPictureResourcesEN.PictureId == intPictureId
select objPictureResourcesEN;
if (arrPictureResourcesObjLst_Sel.Count() == 0)
{
   clsPictureResourcesEN obj = clsPictureResourcesWApi.GetObjByPictureId(intPictureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPictureResourcesObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureResourcesEN> GetObjLst(string strWhereCond)
{
 List<clsPictureResourcesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureResourcesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPictureResourcesEN> GetObjLstByPictureIdLst(List<int> arrPictureId)
{
 List<clsPictureResourcesEN> arrObjLst = null; 
string strAction = "GetObjLstByPictureIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPictureId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureResourcesEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "intPictureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsPictureResourcesEN> GetObjLstByPictureIdLst_Cache(List<int> arrPictureId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPictureResourcesEN._CurrTabName_S);
List<clsPictureResourcesEN> arrPictureResourcesObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPictureResourcesEN> arrPictureResourcesObjLst_Sel =
from objPictureResourcesEN in arrPictureResourcesObjLst_Cache
where arrPictureId.Contains(objPictureResourcesEN.PictureId)
select objPictureResourcesEN;
return arrPictureResourcesObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPictureResourcesEN> GetObjLstByPictureIdLst_WA_Cache(List<int> arrPictureId)
{
 List<clsPictureResourcesEN> arrObjLst = null; 
string strAction = "GetObjLstByPictureIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPictureId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureResourcesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPictureResourcesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPictureResourcesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureResourcesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPictureResourcesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPictureResourcesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureResourcesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPictureResourcesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPictureResourcesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureResourcesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPictureResourcesEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsPictureResourcesEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPictureResourcesEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(int intPictureId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsPictureResourcesEN objPictureResourcesEN = clsPictureResourcesWApi.GetObjByPictureId(intPictureId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, intPictureId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPictureResourcesWApi.ReFreshCache();
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
public static int DelPictureResourcess(List<string> arrPictureId)
{
string strAction = "DelPictureResourcess";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPictureId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPictureResourcesWApi.ReFreshCache();
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
public static int DelPictureResourcessByCond(string strWhereCond)
{
string strAction = "DelPictureResourcessByCond";
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
public static bool AddNewRecord(clsPictureResourcesEN objPictureResourcesEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPictureResourcesEN>(objPictureResourcesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objPictureResourcesEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsPictureResourcesEN objPictureResourcesEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPictureResourcesEN>(objPictureResourcesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPictureResourcesWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsPictureResourcesEN objPictureResourcesEN)
{
if (string.IsNullOrEmpty(objPictureResourcesEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPictureResourcesEN.PictureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPictureResourcesEN>(objPictureResourcesEN);
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
 /// <param name = "objPictureResourcesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPictureResourcesEN objPictureResourcesEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPictureResourcesEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPictureResourcesEN.PictureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPictureResourcesEN.PictureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPictureResourcesEN>(objPictureResourcesEN);
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
public static bool IsExist(int intPictureId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PictureId"] = intPictureId.ToString()
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
 /// <param name = "objPictureResourcesENS">源对象</param>
 /// <param name = "objPictureResourcesENT">目标对象</param>
 public static void CopyTo(clsPictureResourcesEN objPictureResourcesENS, clsPictureResourcesEN objPictureResourcesENT)
{
try
{
objPictureResourcesENT.Memo = objPictureResourcesENS.Memo; //备注
objPictureResourcesENT.PictureId = objPictureResourcesENS.PictureId; //PictureId
objPictureResourcesENT.PictureName = objPictureResourcesENS.PictureName; //PictureName
objPictureResourcesENT.OrginialFileName = objPictureResourcesENS.OrginialFileName; //OrginialFileName
objPictureResourcesENT.OrginialFileSize = objPictureResourcesENS.OrginialFileSize; //OrginialFileSize
objPictureResourcesENT.ResizePictureSize = objPictureResourcesENS.ResizePictureSize; //ResizePictureSize
objPictureResourcesENT.ThumbSize = objPictureResourcesENS.ThumbSize; //ThumbSize
objPictureResourcesENT.OrginialFileWidth = objPictureResourcesENS.OrginialFileWidth; //OrginialFileWidth
objPictureResourcesENT.PictureConfigerId = objPictureResourcesENS.PictureConfigerId; //PictureConfigerId
objPictureResourcesENT.ResizePictureName = objPictureResourcesENS.ResizePictureName; //ResizePictureName
objPictureResourcesENT.ThumbName = objPictureResourcesENS.ThumbName; //ThumbName
objPictureResourcesENT.OrginialFileHeight = objPictureResourcesENS.OrginialFileHeight; //OrginialFileHeight
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
public static DataTable ToDataTable(List<clsPictureResourcesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPictureResourcesEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPictureResourcesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPictureResourcesEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPictureResourcesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPictureResourcesEN.AttributeName)
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
if (clsPictureResourcesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPictureResourcesWApi没有刷新缓存机制(clsPictureResourcesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PictureId");
//if (arrPictureResourcesObjLst_Cache == null)
//{
//arrPictureResourcesObjLst_Cache = await clsPictureResourcesWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsPictureResourcesEN._CurrTabName_S);
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
if (clsPictureResourcesWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPictureResourcesEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsPictureResourcesWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPictureResourcesEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsPictureResourcesEN._CurrTabName_S);
List<clsPictureResourcesEN> arrPictureResourcesObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPictureResourcesObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPictureResourcesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPictureResources.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conPictureResources.PictureId, Type.GetType("System.Int32"));
objDT.Columns.Add(conPictureResources.PictureName, Type.GetType("System.String"));
objDT.Columns.Add(conPictureResources.OrginialFileName, Type.GetType("System.String"));
objDT.Columns.Add(conPictureResources.OrginialFileSize, Type.GetType("System.Int32"));
objDT.Columns.Add(conPictureResources.ResizePictureSize, Type.GetType("System.Int32"));
objDT.Columns.Add(conPictureResources.ThumbSize, Type.GetType("System.Int32"));
objDT.Columns.Add(conPictureResources.OrginialFileWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(conPictureResources.PictureConfigerId, Type.GetType("System.String"));
objDT.Columns.Add(conPictureResources.ResizePictureName, Type.GetType("System.String"));
objDT.Columns.Add(conPictureResources.ThumbName, Type.GetType("System.String"));
objDT.Columns.Add(conPictureResources.OrginialFileHeight, Type.GetType("System.Int32"));
foreach (clsPictureResourcesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPictureResources.Memo] = objInFor[conPictureResources.Memo];
objDR[conPictureResources.PictureId] = objInFor[conPictureResources.PictureId];
objDR[conPictureResources.PictureName] = objInFor[conPictureResources.PictureName];
objDR[conPictureResources.OrginialFileName] = objInFor[conPictureResources.OrginialFileName];
objDR[conPictureResources.OrginialFileSize] = objInFor[conPictureResources.OrginialFileSize];
objDR[conPictureResources.ResizePictureSize] = objInFor[conPictureResources.ResizePictureSize];
objDR[conPictureResources.ThumbSize] = objInFor[conPictureResources.ThumbSize];
objDR[conPictureResources.OrginialFileWidth] = objInFor[conPictureResources.OrginialFileWidth];
objDR[conPictureResources.PictureConfigerId] = objInFor[conPictureResources.PictureConfigerId];
objDR[conPictureResources.ResizePictureName] = objInFor[conPictureResources.ResizePictureName];
objDR[conPictureResources.ThumbName] = objInFor[conPictureResources.ThumbName];
objDR[conPictureResources.OrginialFileHeight] = objInFor[conPictureResources.OrginialFileHeight];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 图片资源(PictureResources)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4PictureResources : clsCommFun4BL
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
clsPictureResourcesWApi.ReFreshThisCache();
}
}

}