
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingSolutionBLEx
 表名:vTeachingSolution(01120138)
 生成代码版本:2021.01.04.1
 生成日期:2021/01/04 16:18:55
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
public static class clsvTeachingSolutionBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvTeachingSolutionENS">源对象</param>
 /// <returns>目标对象=>clsvTeachingSolutionEN:objvTeachingSolutionENT</returns>
 public static clsvTeachingSolutionENEx CopyToEx(this clsvTeachingSolutionEN objvTeachingSolutionENS)
{
try
{
 clsvTeachingSolutionENEx objvTeachingSolutionENT = new clsvTeachingSolutionENEx();
clsvTeachingSolutionBL.vTeachingSolutionDA.CopyTo(objvTeachingSolutionENS, objvTeachingSolutionENT);
 return objvTeachingSolutionENT;
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
 /// <param name = "objvTeachingSolutionENS">源对象</param>
 /// <returns>目标对象=>clsvTeachingSolutionEN:objvTeachingSolutionENT</returns>
 public static clsvTeachingSolutionEN CopyTo(this clsvTeachingSolutionENEx objvTeachingSolutionENS)
{
try
{
 clsvTeachingSolutionEN objvTeachingSolutionENT = new clsvTeachingSolutionEN();
clsvTeachingSolutionBL.CopyTo(objvTeachingSolutionENS, objvTeachingSolutionENT);
 return objvTeachingSolutionENT;
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
 /// v教学方案(vTeachingSolution)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvTeachingSolutionBLEx : clsvTeachingSolutionBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvTeachingSolutionDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvTeachingSolutionDAEx vTeachingSolutionDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvTeachingSolutionDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvTeachingSolutionENEx> GetObjExLst(string strCondition)
{
List <clsvTeachingSolutionEN> arrObjLst = clsvTeachingSolutionBL.GetObjLst(strCondition);
List <clsvTeachingSolutionENEx> arrObjExLst = new List<clsvTeachingSolutionENEx>();
foreach (clsvTeachingSolutionEN objInFor in arrObjLst)
{
clsvTeachingSolutionENEx objvTeachingSolutionENEx = new clsvTeachingSolutionENEx();
clsvTeachingSolutionBL.CopyTo(objInFor, objvTeachingSolutionENEx);
arrObjExLst.Add(objvTeachingSolutionENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTeachingSolutionId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvTeachingSolutionENEx GetObjExByTeachingSolutionId(string strTeachingSolutionId)
{
clsvTeachingSolutionEN objvTeachingSolutionEN = clsvTeachingSolutionBL.GetObjByTeachingSolutionId(strTeachingSolutionId);
clsvTeachingSolutionENEx objvTeachingSolutionENEx = new clsvTeachingSolutionENEx();
clsvTeachingSolutionBL.CopyTo(objvTeachingSolutionEN, objvTeachingSolutionENEx);
return objvTeachingSolutionENEx;
}
}
}