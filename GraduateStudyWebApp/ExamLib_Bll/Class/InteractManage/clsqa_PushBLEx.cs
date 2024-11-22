
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_PushBLEx
 表名:qa_Push(01120640)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/12 21:49:48
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsqa_PushBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objqa_PushENS">源对象</param>
 /// <returns>目标对象=>clsqa_PushEN:objqa_PushENT</returns>
 public static clsqa_PushENEx CopyToEx(this clsqa_PushEN objqa_PushENS)
{
try
{
 clsqa_PushENEx objqa_PushENT = new clsqa_PushENEx();
clsqa_PushBL.qa_PushDA.CopyTo(objqa_PushENS, objqa_PushENT);
 return objqa_PushENT;
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
 /// <param name = "objqa_PushENS">源对象</param>
 /// <returns>目标对象=>clsqa_PushEN:objqa_PushENT</returns>
 public static clsqa_PushEN CopyTo(this clsqa_PushENEx objqa_PushENS)
{
try
{
 clsqa_PushEN objqa_PushENT = new clsqa_PushEN();
clsqa_PushBL.CopyTo(objqa_PushENS, objqa_PushENT);
 return objqa_PushENT;
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
 /// 答疑推送(qa_Push)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsqa_PushBLEx : clsqa_PushBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsqa_PushDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsqa_PushDAEx qa_PushDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsqa_PushDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objqa_PushENS">源对象</param>
 /// <returns>目标对象=>clsqa_PushEN:objqa_PushENT</returns>
 public static clsqa_PushENEx CopyToEx(clsqa_PushEN objqa_PushENS)
{
try
{
 clsqa_PushENEx objqa_PushENT = new clsqa_PushENEx();
clsqa_PushBL.qa_PushDA.CopyTo(objqa_PushENS, objqa_PushENT);
 return objqa_PushENT;
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
public static List<clsqa_PushENEx> GetObjExLst(string strCondition)
{
List <clsqa_PushEN> arrObjLst = clsqa_PushBL.GetObjLst(strCondition);
List <clsqa_PushENEx> arrObjExLst = new List<clsqa_PushENEx>();
foreach (clsqa_PushEN objInFor in arrObjLst)
{
clsqa_PushENEx objqa_PushENEx = new clsqa_PushENEx();
clsqa_PushBL.CopyTo(objInFor, objqa_PushENEx);
arrObjExLst.Add(objqa_PushENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsqa_PushENEx GetObjExByPushId(long lngPushId)
{
clsqa_PushEN objqa_PushEN = clsqa_PushBL.GetObjByPushId(lngPushId);
clsqa_PushENEx objqa_PushENEx = new clsqa_PushENEx();
clsqa_PushBL.CopyTo(objqa_PushEN, objqa_PushENEx);
return objqa_PushENEx;
}
}
}