
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsStu4CorrectBLEx
 表名:CurrEduClsStu4Correct(01120180)
 生成代码版本:2021.06.20.1
 生成日期:2021/06/26 17:15:32
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:UsersRight
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
public static class clsCurrEduClsStu4CorrectBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectENS">源对象</param>
 /// <returns>目标对象=>clsCurrEduClsStu4CorrectEN:objCurrEduClsStu4CorrectENT</returns>
 public static clsCurrEduClsStu4CorrectENEx CopyToEx(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENS)
{
try
{
 clsCurrEduClsStu4CorrectENEx objCurrEduClsStu4CorrectENT = new clsCurrEduClsStu4CorrectENEx();
clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.CopyTo(objCurrEduClsStu4CorrectENS, objCurrEduClsStu4CorrectENT);
 return objCurrEduClsStu4CorrectENT;
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
 /// <param name = "objCurrEduClsStu4CorrectENS">源对象</param>
 /// <returns>目标对象=>clsCurrEduClsStu4CorrectEN:objCurrEduClsStu4CorrectENT</returns>
 public static clsCurrEduClsStu4CorrectEN CopyTo(this clsCurrEduClsStu4CorrectENEx objCurrEduClsStu4CorrectENS)
{
try
{
 clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENT = new clsCurrEduClsStu4CorrectEN();
clsCurrEduClsStu4CorrectBL.CopyTo(objCurrEduClsStu4CorrectENS, objCurrEduClsStu4CorrectENT);
 return objCurrEduClsStu4CorrectENT;
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
 /// 教学班学生_批改作业(CurrEduClsStu4Correct)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsCurrEduClsStu4CorrectBLEx : clsCurrEduClsStu4CorrectBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsCurrEduClsStu4CorrectDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsCurrEduClsStu4CorrectDAEx CurrEduClsStu4CorrectDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsCurrEduClsStu4CorrectDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectENS">源对象</param>
 /// <returns>目标对象=>clsCurrEduClsStu4CorrectEN:objCurrEduClsStu4CorrectENT</returns>
 public static clsCurrEduClsStu4CorrectENEx CopyToEx(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENS)
{
try
{
 clsCurrEduClsStu4CorrectENEx objCurrEduClsStu4CorrectENT = new clsCurrEduClsStu4CorrectENEx();
clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.CopyTo(objCurrEduClsStu4CorrectENS, objCurrEduClsStu4CorrectENT);
 return objCurrEduClsStu4CorrectENT;
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
public static List<clsCurrEduClsStu4CorrectENEx> GetObjExLst(string strCondition)
{
List <clsCurrEduClsStu4CorrectEN> arrObjLst = clsCurrEduClsStu4CorrectBL.GetObjLst(strCondition);
List <clsCurrEduClsStu4CorrectENEx> arrObjExLst = new List<clsCurrEduClsStu4CorrectENEx>();
foreach (clsCurrEduClsStu4CorrectEN objInFor in arrObjLst)
{
clsCurrEduClsStu4CorrectENEx objCurrEduClsStu4CorrectENEx = new clsCurrEduClsStu4CorrectENEx();
clsCurrEduClsStu4CorrectBL.CopyTo(objInFor, objCurrEduClsStu4CorrectENEx);
arrObjExLst.Add(objCurrEduClsStu4CorrectENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngIdCurrEduClsStu4Correct">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsCurrEduClsStu4CorrectENEx GetObjExByIdCurrEduClsStu4Correct(long lngIdCurrEduClsStu4Correct)
{
clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = clsCurrEduClsStu4CorrectBL.GetObjByIdCurrEduClsStu4Correct(lngIdCurrEduClsStu4Correct);
clsCurrEduClsStu4CorrectENEx objCurrEduClsStu4CorrectENEx = new clsCurrEduClsStu4CorrectENEx();
clsCurrEduClsStu4CorrectBL.CopyTo(objCurrEduClsStu4CorrectEN, objCurrEduClsStu4CorrectENEx);
return objCurrEduClsStu4CorrectENEx;
}
}
}