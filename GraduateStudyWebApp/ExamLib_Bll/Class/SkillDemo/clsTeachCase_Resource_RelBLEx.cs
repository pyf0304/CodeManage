
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCase_Resource_RelBLEx
 表名:TeachCase_Resource_Rel(01120511)
 生成代码版本:2021.02.21.1
 生成日期:2021/02/23 22:08:38
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范
 模块英文名:SkillDemo
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
public static class clsTeachCase_Resource_RelBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsTeachCase_Resource_RelEN:objTeachCase_Resource_RelENT</returns>
 public static clsTeachCase_Resource_RelENEx CopyToEx(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENS)
{
try
{
 clsTeachCase_Resource_RelENEx objTeachCase_Resource_RelENT = new clsTeachCase_Resource_RelENEx();
clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.CopyTo(objTeachCase_Resource_RelENS, objTeachCase_Resource_RelENT);
 return objTeachCase_Resource_RelENT;
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
 /// <param name = "objTeachCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsTeachCase_Resource_RelEN:objTeachCase_Resource_RelENT</returns>
 public static clsTeachCase_Resource_RelEN CopyTo(this clsTeachCase_Resource_RelENEx objTeachCase_Resource_RelENS)
{
try
{
 clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENT = new clsTeachCase_Resource_RelEN();
clsTeachCase_Resource_RelBL.CopyTo(objTeachCase_Resource_RelENS, objTeachCase_Resource_RelENT);
 return objTeachCase_Resource_RelENT;
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
 /// 案例与资源表系(TeachCase_Resource_Rel)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsTeachCase_Resource_RelBLEx : clsTeachCase_Resource_RelBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsTeachCase_Resource_RelDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsTeachCase_Resource_RelDAEx TeachCase_Resource_RelDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsTeachCase_Resource_RelDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsTeachCase_Resource_RelEN:objTeachCase_Resource_RelENT</returns>
 public static clsTeachCase_Resource_RelENEx CopyToEx(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENS)
{
try
{
 clsTeachCase_Resource_RelENEx objTeachCase_Resource_RelENT = new clsTeachCase_Resource_RelENEx();
clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.CopyTo(objTeachCase_Resource_RelENS, objTeachCase_Resource_RelENT);
 return objTeachCase_Resource_RelENT;
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
public static List<clsTeachCase_Resource_RelENEx> GetObjExLst(string strCondition)
{
List <clsTeachCase_Resource_RelEN> arrObjLst = clsTeachCase_Resource_RelBL.GetObjLst(strCondition);
List <clsTeachCase_Resource_RelENEx> arrObjExLst = new List<clsTeachCase_Resource_RelENEx>();
foreach (clsTeachCase_Resource_RelEN objInFor in arrObjLst)
{
clsTeachCase_Resource_RelENEx objTeachCase_Resource_RelENEx = new clsTeachCase_Resource_RelENEx();
clsTeachCase_Resource_RelBL.CopyTo(objInFor, objTeachCase_Resource_RelENEx);
arrObjExLst.Add(objTeachCase_Resource_RelENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngid_TeachCase_Resource_Rel">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsTeachCase_Resource_RelENEx GetObjExByid_TeachCase_Resource_Rel(long lngid_TeachCase_Resource_Rel)
{
clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = clsTeachCase_Resource_RelBL.GetObjByIdTeachCaseResourceRel(lngid_TeachCase_Resource_Rel);
clsTeachCase_Resource_RelENEx objTeachCase_Resource_RelENEx = new clsTeachCase_Resource_RelENEx();
clsTeachCase_Resource_RelBL.CopyTo(objTeachCase_Resource_RelEN, objTeachCase_Resource_RelENEx);
return objTeachCase_Resource_RelENEx;
}
}
}