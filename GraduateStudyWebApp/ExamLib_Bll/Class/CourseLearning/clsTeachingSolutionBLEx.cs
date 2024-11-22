
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingSolutionBLEx
 表名:TeachingSolution(01120137)
 生成代码版本:2021.01.04.1
 生成日期:2021/01/04 16:18:50
 生成者:lyl
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
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
public static class clsTeachingSolutionBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objTeachingSolutionENS">源对象</param>
 /// <returns>目标对象=>clsTeachingSolutionEN:objTeachingSolutionENT</returns>
 public static clsTeachingSolutionENEx CopyToEx(this clsTeachingSolutionEN objTeachingSolutionENS)
{
try
{
 clsTeachingSolutionENEx objTeachingSolutionENT = new clsTeachingSolutionENEx();
clsTeachingSolutionBL.TeachingSolutionDA.CopyTo(objTeachingSolutionENS, objTeachingSolutionENT);
 return objTeachingSolutionENT;
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
 /// <param name = "objTeachingSolutionENS">源对象</param>
 /// <returns>目标对象=>clsTeachingSolutionEN:objTeachingSolutionENT</returns>
 public static clsTeachingSolutionEN CopyTo(this clsTeachingSolutionENEx objTeachingSolutionENS)
{
try
{
 clsTeachingSolutionEN objTeachingSolutionENT = new clsTeachingSolutionEN();
clsTeachingSolutionBL.CopyTo(objTeachingSolutionENS, objTeachingSolutionENT);
 return objTeachingSolutionENT;
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
 /// 教学方案(TeachingSolution)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsTeachingSolutionBLEx : clsTeachingSolutionBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsTeachingSolutionDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsTeachingSolutionDAEx TeachingSolutionDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsTeachingSolutionDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objTeachingSolutionENS">源对象</param>
 /// <returns>目标对象=>clsTeachingSolutionEN:objTeachingSolutionENT</returns>
 public static clsTeachingSolutionENEx CopyToEx(clsTeachingSolutionEN objTeachingSolutionENS)
{
try
{
 clsTeachingSolutionENEx objTeachingSolutionENT = new clsTeachingSolutionENEx();
clsTeachingSolutionBL.TeachingSolutionDA.CopyTo(objTeachingSolutionENS, objTeachingSolutionENT);
 return objTeachingSolutionENT;
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
public static List<clsTeachingSolutionENEx> GetObjExLst(string strCondition)
{
List <clsTeachingSolutionEN> arrObjLst = clsTeachingSolutionBL.GetObjLst(strCondition);
List <clsTeachingSolutionENEx> arrObjExLst = new List<clsTeachingSolutionENEx>();
foreach (clsTeachingSolutionEN objInFor in arrObjLst)
{
clsTeachingSolutionENEx objTeachingSolutionENEx = new clsTeachingSolutionENEx();
clsTeachingSolutionBL.CopyTo(objInFor, objTeachingSolutionENEx);
arrObjExLst.Add(objTeachingSolutionENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTeachingSolutionId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsTeachingSolutionENEx GetObjExByTeachingSolutionId(string strTeachingSolutionId)
{
clsTeachingSolutionEN objTeachingSolutionEN = clsTeachingSolutionBL.GetObjByTeachingSolutionId(strTeachingSolutionId);
clsTeachingSolutionENEx objTeachingSolutionENEx = new clsTeachingSolutionENEx();
clsTeachingSolutionBL.CopyTo(objTeachingSolutionEN, objTeachingSolutionENEx);
return objTeachingSolutionENEx;
}
}
}