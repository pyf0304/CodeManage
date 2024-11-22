
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExcellentTypeBLEx
 表名:cc_ExcellentType(01120062)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:50:22
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clscc_ExcellentTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_ExcellentTypeENS">源对象</param>
 /// <returns>目标对象=>clscc_ExcellentTypeEN:objcc_ExcellentTypeENT</returns>
 public static clscc_ExcellentTypeENEx CopyToEx(this clscc_ExcellentTypeEN objcc_ExcellentTypeENS)
{
try
{
 clscc_ExcellentTypeENEx objcc_ExcellentTypeENT = new clscc_ExcellentTypeENEx();
clscc_ExcellentTypeBL.cc_ExcellentTypeDA.CopyTo(objcc_ExcellentTypeENS, objcc_ExcellentTypeENT);
 return objcc_ExcellentTypeENT;
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
 /// <param name = "objcc_ExcellentTypeENS">源对象</param>
 /// <returns>目标对象=>clscc_ExcellentTypeEN:objcc_ExcellentTypeENT</returns>
 public static clscc_ExcellentTypeEN CopyTo(this clscc_ExcellentTypeENEx objcc_ExcellentTypeENS)
{
try
{
 clscc_ExcellentTypeEN objcc_ExcellentTypeENT = new clscc_ExcellentTypeEN();
clscc_ExcellentTypeBL.CopyTo(objcc_ExcellentTypeENS, objcc_ExcellentTypeENT);
 return objcc_ExcellentTypeENT;
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
 /// 精品课程类型(cc_ExcellentType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_ExcellentTypeBLEx : clscc_ExcellentTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_ExcellentTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_ExcellentTypeDAEx cc_ExcellentTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_ExcellentTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_ExcellentTypeENS">源对象</param>
 /// <returns>目标对象=>clscc_ExcellentTypeEN:objcc_ExcellentTypeENT</returns>
 public static clscc_ExcellentTypeENEx CopyToEx(clscc_ExcellentTypeEN objcc_ExcellentTypeENS)
{
try
{
 clscc_ExcellentTypeENEx objcc_ExcellentTypeENT = new clscc_ExcellentTypeENEx();
clscc_ExcellentTypeBL.cc_ExcellentTypeDA.CopyTo(objcc_ExcellentTypeENS, objcc_ExcellentTypeENT);
 return objcc_ExcellentTypeENT;
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
public static List<clscc_ExcellentTypeENEx> GetObjExLst(string strCondition)
{
List <clscc_ExcellentTypeEN> arrObjLst = clscc_ExcellentTypeBL.GetObjLst(strCondition);
List <clscc_ExcellentTypeENEx> arrObjExLst = new List<clscc_ExcellentTypeENEx>();
foreach (clscc_ExcellentTypeEN objInFor in arrObjLst)
{
clscc_ExcellentTypeENEx objcc_ExcellentTypeENEx = new clscc_ExcellentTypeENEx();
clscc_ExcellentTypeBL.CopyTo(objInFor, objcc_ExcellentTypeENEx);
arrObjExLst.Add(objcc_ExcellentTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strExcellentTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_ExcellentTypeENEx GetObjExByExcellentTypeId(string strExcellentTypeId)
{
clscc_ExcellentTypeEN objcc_ExcellentTypeEN = clscc_ExcellentTypeBL.GetObjByExcellentTypeId(strExcellentTypeId);
clscc_ExcellentTypeENEx objcc_ExcellentTypeENEx = new clscc_ExcellentTypeENEx();
clscc_ExcellentTypeBL.CopyTo(objcc_ExcellentTypeEN, objcc_ExcellentTypeENEx);
return objcc_ExcellentTypeENEx;
}
}
}