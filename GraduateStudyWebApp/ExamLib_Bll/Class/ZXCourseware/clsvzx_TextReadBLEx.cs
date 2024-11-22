
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TextReadBLEx
 表名:vzx_TextRead(01120732)
 生成代码版本:2020.09.07.1
 生成日期:2020/09/09 09:07:27
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
public static class clsvzx_TextReadBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_TextReadENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TextReadEN:objvzx_TextReadENT</returns>
 public static clsvzx_TextReadENEx CopyToEx(this clsvzx_TextReadEN objvzx_TextReadENS)
{
try
{
 clsvzx_TextReadENEx objvzx_TextReadENT = new clsvzx_TextReadENEx();
clsvzx_TextReadBL.vzx_TextReadDA.CopyTo(objvzx_TextReadENS, objvzx_TextReadENT);
 return objvzx_TextReadENT;
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
 /// <param name = "objvzx_TextReadENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TextReadEN:objvzx_TextReadENT</returns>
 public static clsvzx_TextReadEN CopyTo(this clsvzx_TextReadENEx objvzx_TextReadENS)
{
try
{
 clsvzx_TextReadEN objvzx_TextReadENT = new clsvzx_TextReadEN();
clsvzx_TextReadBL.CopyTo(objvzx_TextReadENS, objvzx_TextReadENT);
 return objvzx_TextReadENT;
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
 /// vzx_TextRead(vzx_TextRead)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_TextReadBLEx : clsvzx_TextReadBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_TextReadDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_TextReadDAEx vzx_TextReadDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_TextReadDAEx();
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
public static List<clsvzx_TextReadENEx> GetObjExLst(string strCondition)
{
List <clsvzx_TextReadEN> arrObjLst = clsvzx_TextReadBL.GetObjLst(strCondition);
List <clsvzx_TextReadENEx> arrObjExLst = new List<clsvzx_TextReadENEx>();
foreach (clsvzx_TextReadEN objInFor in arrObjLst)
{
clsvzx_TextReadENEx objvzx_TextReadENEx = new clsvzx_TextReadENEx();
clsvzx_TextReadBL.CopyTo(objInFor, objvzx_TextReadENEx);
arrObjExLst.Add(objvzx_TextReadENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTextRId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_TextReadENEx GetObjExByTextRId(string strTextRId)
{
clsvzx_TextReadEN objvzx_TextReadEN = clsvzx_TextReadBL.GetObjByTextRId(strTextRId);
clsvzx_TextReadENEx objvzx_TextReadENEx = new clsvzx_TextReadENEx();
clsvzx_TextReadBL.CopyTo(objvzx_TextReadEN, objvzx_TextReadENEx);
return objvzx_TextReadENEx;
}
}
}