
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_GroupTextRelaBLEx
 表名:zx_GroupTextRela(01120735)
 生成代码版本:2020.09.09.1
 生成日期:2020/09/14 15:28:32
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文
 模块英文名:zxGroupText
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
public static class clszx_GroupTextRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_GroupTextRelaENS">源对象</param>
 /// <returns>目标对象=>clszx_GroupTextRelaEN:objzx_GroupTextRelaENT</returns>
 public static clszx_GroupTextRelaENEx CopyToEx(this clszx_GroupTextRelaEN objzx_GroupTextRelaENS)
{
try
{
 clszx_GroupTextRelaENEx objzx_GroupTextRelaENT = new clszx_GroupTextRelaENEx();
clszx_GroupTextRelaBL.zx_GroupTextRelaDA.CopyTo(objzx_GroupTextRelaENS, objzx_GroupTextRelaENT);
 return objzx_GroupTextRelaENT;
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
 /// <param name = "objzx_GroupTextRelaENS">源对象</param>
 /// <returns>目标对象=>clszx_GroupTextRelaEN:objzx_GroupTextRelaENT</returns>
 public static clszx_GroupTextRelaEN CopyTo(this clszx_GroupTextRelaENEx objzx_GroupTextRelaENS)
{
try
{
 clszx_GroupTextRelaEN objzx_GroupTextRelaENT = new clszx_GroupTextRelaEN();
clszx_GroupTextRelaBL.CopyTo(objzx_GroupTextRelaENS, objzx_GroupTextRelaENT);
 return objzx_GroupTextRelaENT;
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
 /// 小组课文关系表(zx_GroupTextRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_GroupTextRelaBLEx : clszx_GroupTextRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_GroupTextRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_GroupTextRelaDAEx zx_GroupTextRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_GroupTextRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_GroupTextRelaENS">源对象</param>
 /// <returns>目标对象=>clszx_GroupTextRelaEN:objzx_GroupTextRelaENT</returns>
 public static clszx_GroupTextRelaENEx CopyToEx(clszx_GroupTextRelaEN objzx_GroupTextRelaENS)
{
try
{
 clszx_GroupTextRelaENEx objzx_GroupTextRelaENT = new clszx_GroupTextRelaENEx();
clszx_GroupTextRelaBL.zx_GroupTextRelaDA.CopyTo(objzx_GroupTextRelaENS, objzx_GroupTextRelaENT);
 return objzx_GroupTextRelaENT;
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
public static List<clszx_GroupTextRelaENEx> GetObjExLst(string strCondition)
{
List <clszx_GroupTextRelaEN> arrObjLst = clszx_GroupTextRelaBL.GetObjLst(strCondition);
List <clszx_GroupTextRelaENEx> arrObjExLst = new List<clszx_GroupTextRelaENEx>();
foreach (clszx_GroupTextRelaEN objInFor in arrObjLst)
{
clszx_GroupTextRelaENEx objzx_GroupTextRelaENEx = new clszx_GroupTextRelaENEx();
clszx_GroupTextRelaBL.CopyTo(objInFor, objzx_GroupTextRelaENEx);
arrObjExLst.Add(objzx_GroupTextRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strGroupTextRelaId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_GroupTextRelaENEx GetObjExByGroupTextRelaId(string strGroupTextRelaId)
{
clszx_GroupTextRelaEN objzx_GroupTextRelaEN = clszx_GroupTextRelaBL.GetObjByGroupTextRelaId(strGroupTextRelaId);
clszx_GroupTextRelaENEx objzx_GroupTextRelaENEx = new clszx_GroupTextRelaENEx();
clszx_GroupTextRelaBL.CopyTo(objzx_GroupTextRelaEN, objzx_GroupTextRelaENEx);
return objzx_GroupTextRelaENEx;
}
}
}