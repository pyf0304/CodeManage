
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsBLEx
 表名:vCurrEduCls(01120126)
 生成代码版本:2020.01.15.1
 生成日期:2020/01/16 13:54:45
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:日常运行
 模块英文名:DailyRunning
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
public static class clsvCurrEduClsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvCurrEduClsENS">源对象</param>
 /// <returns>目标对象=>clsvCurrEduClsEN:objvCurrEduClsENT</returns>
 public static clsvCurrEduClsENEx CopyToEx(this clsvCurrEduClsEN objvCurrEduClsENS)
{
try
{
 clsvCurrEduClsENEx objvCurrEduClsENT = new clsvCurrEduClsENEx();
clsvCurrEduClsBL.vCurrEduClsDA.CopyTo(objvCurrEduClsENS, objvCurrEduClsENT);
 return objvCurrEduClsENT;
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
 /// <param name = "objvCurrEduClsENS">源对象</param>
 /// <returns>目标对象=>clsvCurrEduClsEN:objvCurrEduClsENT</returns>
 public static clsvCurrEduClsEN CopyTo(this clsvCurrEduClsENEx objvCurrEduClsENS)
{
try
{
 clsvCurrEduClsEN objvCurrEduClsENT = new clsvCurrEduClsEN();
clsvCurrEduClsBL.CopyTo(objvCurrEduClsENS, objvCurrEduClsENT);
 return objvCurrEduClsENT;
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
 /// v当前教学班(vCurrEduCls)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvCurrEduClsBLEx : clsvCurrEduClsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvCurrEduClsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvCurrEduClsDAEx vCurrEduClsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvCurrEduClsDAEx();
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
public static List<clsvCurrEduClsENEx> GetObjExLst(string strCondition)
{
List <clsvCurrEduClsEN> arrObjLst = clsvCurrEduClsBL.GetObjLst(strCondition);
List <clsvCurrEduClsENEx> arrObjExLst = new List<clsvCurrEduClsENEx>();
foreach (clsvCurrEduClsEN objInFor in arrObjLst)
{
clsvCurrEduClsENEx objvCurrEduClsENEx = new clsvCurrEduClsENEx();
clsvCurrEduClsBL.CopyTo(objInFor, objvCurrEduClsENEx);
arrObjExLst.Add(objvCurrEduClsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "stridCurrEduCls">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvCurrEduClsENEx GetObjExByidCurrEduCls(string stridCurrEduCls)
{
clsvCurrEduClsEN objvCurrEduClsEN = clsvCurrEduClsBL.GetObjByIdCurrEduCls(stridCurrEduCls);
clsvCurrEduClsENEx objvCurrEduClsENEx = new clsvCurrEduClsENEx();
clsvCurrEduClsBL.CopyTo(objvCurrEduClsEN, objvCurrEduClsENEx);
return objvCurrEduClsENEx;
}
}
}

