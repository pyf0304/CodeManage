
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextReadBLEx
 表名:zx_TextRead(01120716)
 生成代码版本:2020.08.04.1
 生成日期:2020/08/20 16:02:37
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
public static class clszx_TextReadBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TextReadENS">源对象</param>
 /// <returns>目标对象=>clszx_TextReadEN:objzx_TextReadENT</returns>
 public static clszx_TextReadENEx CopyToEx(this clszx_TextReadEN objzx_TextReadENS)
{
try
{
 clszx_TextReadENEx objzx_TextReadENT = new clszx_TextReadENEx();
clszx_TextReadBL.zx_TextReadDA.CopyTo(objzx_TextReadENS, objzx_TextReadENT);
 return objzx_TextReadENT;
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
 /// <param name = "objzx_TextReadENS">源对象</param>
 /// <returns>目标对象=>clszx_TextReadEN:objzx_TextReadENT</returns>
 public static clszx_TextReadEN CopyTo(this clszx_TextReadENEx objzx_TextReadENS)
{
try
{
 clszx_TextReadEN objzx_TextReadENT = new clszx_TextReadEN();
clszx_TextReadBL.CopyTo(objzx_TextReadENS, objzx_TextReadENT);
 return objzx_TextReadENT;
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
 /// 课文阅读(zx_TextRead)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_TextReadBLEx : clszx_TextReadBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_TextReadDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_TextReadDAEx zx_TextReadDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_TextReadDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TextReadENS">源对象</param>
 /// <returns>目标对象=>clszx_TextReadEN:objzx_TextReadENT</returns>
 public static clszx_TextReadENEx CopyToEx(clszx_TextReadEN objzx_TextReadENS)
{
try
{
 clszx_TextReadENEx objzx_TextReadENT = new clszx_TextReadENEx();
clszx_TextReadBL.zx_TextReadDA.CopyTo(objzx_TextReadENS, objzx_TextReadENT);
 return objzx_TextReadENT;
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
public static List<clszx_TextReadENEx> GetObjExLst(string strCondition)
{
List <clszx_TextReadEN> arrObjLst = clszx_TextReadBL.GetObjLst(strCondition);
List <clszx_TextReadENEx> arrObjExLst = new List<clszx_TextReadENEx>();
foreach (clszx_TextReadEN objInFor in arrObjLst)
{
clszx_TextReadENEx objzx_TextReadENEx = new clszx_TextReadENEx();
clszx_TextReadBL.CopyTo(objInFor, objzx_TextReadENEx);
arrObjExLst.Add(objzx_TextReadENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTextRId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_TextReadENEx GetObjExByTextRId(string strTextRId)
{
clszx_TextReadEN objzx_TextReadEN = clszx_TextReadBL.GetObjByTextRId(strTextRId);
clszx_TextReadENEx objzx_TextReadENEx = new clszx_TextReadENEx();
clszx_TextReadBL.CopyTo(objzx_TextReadEN, objzx_TextReadENEx);
return objzx_TextReadENEx;
}
}
}