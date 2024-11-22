
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_qa_PushBLEx
 表名:zx_qa_Push(01120811)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:56:57
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
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
public static class clszx_qa_PushBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_qa_PushENS">源对象</param>
 /// <returns>目标对象=>clszx_qa_PushEN:objzx_qa_PushENT</returns>
 public static clszx_qa_PushENEx CopyToEx(this clszx_qa_PushEN objzx_qa_PushENS)
{
try
{
 clszx_qa_PushENEx objzx_qa_PushENT = new clszx_qa_PushENEx();
clszx_qa_PushBL.zx_qa_PushDA.CopyTo(objzx_qa_PushENS, objzx_qa_PushENT);
 return objzx_qa_PushENT;
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
 /// <param name = "objzx_qa_PushENS">源对象</param>
 /// <returns>目标对象=>clszx_qa_PushEN:objzx_qa_PushENT</returns>
 public static clszx_qa_PushEN CopyTo(this clszx_qa_PushENEx objzx_qa_PushENS)
{
try
{
 clszx_qa_PushEN objzx_qa_PushENT = new clszx_qa_PushEN();
clszx_qa_PushBL.CopyTo(objzx_qa_PushENS, objzx_qa_PushENT);
 return objzx_qa_PushENT;
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
 /// 中学答疑推送_Copy(zx_qa_Push)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_qa_PushBLEx : clszx_qa_PushBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_qa_PushDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_qa_PushDAEx zx_qa_PushDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_qa_PushDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_qa_PushENS">源对象</param>
 /// <returns>目标对象=>clszx_qa_PushEN:objzx_qa_PushENT</returns>
 public static clszx_qa_PushENEx CopyToEx(clszx_qa_PushEN objzx_qa_PushENS)
{
try
{
 clszx_qa_PushENEx objzx_qa_PushENT = new clszx_qa_PushENEx();
clszx_qa_PushBL.zx_qa_PushDA.CopyTo(objzx_qa_PushENS, objzx_qa_PushENT);
 return objzx_qa_PushENT;
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
public static List<clszx_qa_PushENEx> GetObjExLst(string strCondition)
{
List <clszx_qa_PushEN> arrObjLst = clszx_qa_PushBL.GetObjLst(strCondition);
List <clszx_qa_PushENEx> arrObjExLst = new List<clszx_qa_PushENEx>();
foreach (clszx_qa_PushEN objInFor in arrObjLst)
{
clszx_qa_PushENEx objzx_qa_PushENEx = new clszx_qa_PushENEx();
clszx_qa_PushBL.CopyTo(objInFor, objzx_qa_PushENEx);
arrObjExLst.Add(objzx_qa_PushENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_qa_PushENEx GetObjExByPushId(long lngPushId)
{
clszx_qa_PushEN objzx_qa_PushEN = clszx_qa_PushBL.GetObjByPushId(lngPushId);
clszx_qa_PushENEx objzx_qa_PushENEx = new clszx_qa_PushENEx();
clszx_qa_PushBL.CopyTo(objzx_qa_PushEN, objzx_qa_PushENEx);
return objzx_qa_PushENEx;
}
}
}