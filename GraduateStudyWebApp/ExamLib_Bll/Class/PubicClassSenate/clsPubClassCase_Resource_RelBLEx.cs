﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCase_Resource_RelBLEx
 表名:PubClassCase_Resource_Rel(01120408)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 17:31:13
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩
 模块英文名:PubicClassSenate
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
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
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
public static class clsPubClassCase_Resource_RelBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsPubClassCase_Resource_RelEN:objPubClassCase_Resource_RelENT</returns>
 public static clsPubClassCase_Resource_RelENEx CopyToEx(this clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelENS)
{
try
{
 clsPubClassCase_Resource_RelENEx objPubClassCase_Resource_RelENT = new clsPubClassCase_Resource_RelENEx();
clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.CopyTo(objPubClassCase_Resource_RelENS, objPubClassCase_Resource_RelENT);
 return objPubClassCase_Resource_RelENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsPubClassCase_Resource_RelEN:objPubClassCase_Resource_RelENT</returns>
 public static clsPubClassCase_Resource_RelEN CopyTo(this clsPubClassCase_Resource_RelENEx objPubClassCase_Resource_RelENS)
{
try
{
 clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelENT = new clsPubClassCase_Resource_RelEN();
clsPubClassCase_Resource_RelBL.CopyTo(objPubClassCase_Resource_RelENS, objPubClassCase_Resource_RelENT);
 return objPubClassCase_Resource_RelENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 案例与资源关系(PubClassCase_Resource_Rel)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsPubClassCase_Resource_RelBLEx : clsPubClassCase_Resource_RelBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsPubClassCase_Resource_RelDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsPubClassCase_Resource_RelDAEx PubClassCase_Resource_RelDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsPubClassCase_Resource_RelDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objPubClassCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsPubClassCase_Resource_RelEN:objPubClassCase_Resource_RelENT</returns>
 public static clsPubClassCase_Resource_RelENEx CopyToEx(clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelENS)
{
try
{
 clsPubClassCase_Resource_RelENEx objPubClassCase_Resource_RelENT = new clsPubClassCase_Resource_RelENEx();
clsPubClassCase_Resource_RelBL.PubClassCase_Resource_RelDA.CopyTo(objPubClassCase_Resource_RelENS, objPubClassCase_Resource_RelENT);
 return objPubClassCase_Resource_RelENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsPubClassCase_Resource_RelENEx> GetObjExLst(string strCondition)
{
List <clsPubClassCase_Resource_RelEN> arrObjLst = clsPubClassCase_Resource_RelBL.GetObjLst(strCondition);
List <clsPubClassCase_Resource_RelENEx> arrObjExLst = new List<clsPubClassCase_Resource_RelENEx>();
foreach (clsPubClassCase_Resource_RelEN objInFor in arrObjLst)
{
clsPubClassCase_Resource_RelENEx objPubClassCase_Resource_RelENEx = new clsPubClassCase_Resource_RelENEx();
clsPubClassCase_Resource_RelBL.CopyTo(objInFor, objPubClassCase_Resource_RelENEx);
arrObjExLst.Add(objPubClassCase_Resource_RelENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngid_PubClassCase_Resource_Rel">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsPubClassCase_Resource_RelENEx GetObjExByid_PubClassCase_Resource_Rel(long lngid_PubClassCase_Resource_Rel)
{
clsPubClassCase_Resource_RelEN objPubClassCase_Resource_RelEN = clsPubClassCase_Resource_RelBL.GetObjByIdPubClassCaseResourceRel(lngid_PubClassCase_Resource_Rel);
clsPubClassCase_Resource_RelENEx objPubClassCase_Resource_RelENEx = new clsPubClassCase_Resource_RelENEx();
clsPubClassCase_Resource_RelBL.CopyTo(objPubClassCase_Resource_RelEN, objPubClassCase_Resource_RelENEx);
return objPubClassCase_Resource_RelENEx;
}
}
}