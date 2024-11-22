
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseBLEx
 表名:MicroteachCase(01120322)
 生成代码版本:2021.02.21.1
 生成日期:2021/02/24 10:55:55
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
public static class clsMicroteachCaseBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objMicroteachCaseENS">源对象</param>
 /// <returns>目标对象=>clsMicroteachCaseEN:objMicroteachCaseENT</returns>
 public static clsMicroteachCaseENEx CopyToEx(this clsMicroteachCaseEN objMicroteachCaseENS)
{
try
{
 clsMicroteachCaseENEx objMicroteachCaseENT = new clsMicroteachCaseENEx();
clsMicroteachCaseBL.MicroteachCaseDA.CopyTo(objMicroteachCaseENS, objMicroteachCaseENT);
 return objMicroteachCaseENT;
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
 /// <param name = "objMicroteachCaseENS">源对象</param>
 /// <returns>目标对象=>clsMicroteachCaseEN:objMicroteachCaseENT</returns>
 public static clsMicroteachCaseEN CopyTo(this clsMicroteachCaseENEx objMicroteachCaseENS)
{
try
{
 clsMicroteachCaseEN objMicroteachCaseENT = new clsMicroteachCaseEN();
clsMicroteachCaseBL.CopyTo(objMicroteachCaseENS, objMicroteachCaseENT);
 return objMicroteachCaseENT;
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
 /// 微格教学案例(MicroteachCase)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsMicroteachCaseBLEx : clsMicroteachCaseBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsMicroteachCaseDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsMicroteachCaseDAEx MicroteachCaseDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsMicroteachCaseDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objMicroteachCaseENS">源对象</param>
 /// <returns>目标对象=>clsMicroteachCaseEN:objMicroteachCaseENT</returns>
 public static clsMicroteachCaseENEx CopyToEx(clsMicroteachCaseEN objMicroteachCaseENS)
{
try
{
 clsMicroteachCaseENEx objMicroteachCaseENT = new clsMicroteachCaseENEx();
clsMicroteachCaseBL.MicroteachCaseDA.CopyTo(objMicroteachCaseENS, objMicroteachCaseENT);
 return objMicroteachCaseENT;
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
public static List<clsMicroteachCaseENEx> GetObjExLst(string strCondition)
{
List <clsMicroteachCaseEN> arrObjLst = clsMicroteachCaseBL.GetObjLst(strCondition);
List <clsMicroteachCaseENEx> arrObjExLst = new List<clsMicroteachCaseENEx>();
foreach (clsMicroteachCaseEN objInFor in arrObjLst)
{
clsMicroteachCaseENEx objMicroteachCaseENEx = new clsMicroteachCaseENEx();
clsMicroteachCaseBL.CopyTo(objInFor, objMicroteachCaseENEx);
arrObjExLst.Add(objMicroteachCaseENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_MicroteachCase">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsMicroteachCaseENEx GetObjExByid_MicroteachCase(string strid_MicroteachCase)
{
clsMicroteachCaseEN objMicroteachCaseEN = clsMicroteachCaseBL.GetObjByIdMicroteachCase(strid_MicroteachCase);
clsMicroteachCaseENEx objMicroteachCaseENEx = new clsMicroteachCaseENEx();
clsMicroteachCaseBL.CopyTo(objMicroteachCaseEN, objMicroteachCaseENEx);
return objMicroteachCaseENEx;
}
}
}