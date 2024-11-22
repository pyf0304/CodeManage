
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_AnswerBLEx
 表名:zx_Answer(01120721)
 生成代码版本:2020.08.04.1
 生成日期:2020/08/20 16:02:28
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理
 模块英文名:ZXCourseware
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
public static class clszx_AnswerBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_AnswerENS">源对象</param>
 /// <returns>目标对象=>clszx_AnswerEN:objzx_AnswerENT</returns>
 public static clszx_AnswerENEx CopyToEx(this clszx_AnswerEN objzx_AnswerENS)
{
try
{
 clszx_AnswerENEx objzx_AnswerENT = new clszx_AnswerENEx();
clszx_AnswerBL.zx_AnswerDA.CopyTo(objzx_AnswerENS, objzx_AnswerENT);
 return objzx_AnswerENT;
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
 /// <param name = "objzx_AnswerENS">源对象</param>
 /// <returns>目标对象=>clszx_AnswerEN:objzx_AnswerENT</returns>
 public static clszx_AnswerEN CopyTo(this clszx_AnswerENEx objzx_AnswerENS)
{
try
{
 clszx_AnswerEN objzx_AnswerENT = new clszx_AnswerEN();
clszx_AnswerBL.CopyTo(objzx_AnswerENS, objzx_AnswerENT);
 return objzx_AnswerENT;
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
 /// zx_Answer(zx_Answer)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_AnswerBLEx : clszx_AnswerBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_AnswerDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_AnswerDAEx zx_AnswerDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_AnswerDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_AnswerENS">源对象</param>
 /// <returns>目标对象=>clszx_AnswerEN:objzx_AnswerENT</returns>
 public static clszx_AnswerENEx CopyToEx(clszx_AnswerEN objzx_AnswerENS)
{
try
{
 clszx_AnswerENEx objzx_AnswerENT = new clszx_AnswerENEx();
clszx_AnswerBL.zx_AnswerDA.CopyTo(objzx_AnswerENS, objzx_AnswerENT);
 return objzx_AnswerENT;
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
public static List<clszx_AnswerENEx> GetObjExLst(string strCondition)
{
List <clszx_AnswerEN> arrObjLst = clszx_AnswerBL.GetObjLst(strCondition);
List <clszx_AnswerENEx> arrObjExLst = new List<clszx_AnswerENEx>();
foreach (clszx_AnswerEN objInFor in arrObjLst)
{
clszx_AnswerENEx objzx_AnswerENEx = new clszx_AnswerENEx();
clszx_AnswerBL.CopyTo(objInFor, objzx_AnswerENEx);
arrObjExLst.Add(objzx_AnswerENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_AnswerENEx GetObjExByAnswerId(string strAnswerId)
{
clszx_AnswerEN objzx_AnswerEN = clszx_AnswerBL.GetObjByzxAnswerId(strAnswerId);
clszx_AnswerENEx objzx_AnswerENEx = new clszx_AnswerENEx();
clszx_AnswerBL.CopyTo(objzx_AnswerEN, objzx_AnswerENEx);
return objzx_AnswerENEx;
}
}
}