
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_GroupTextRelaBLEx
 表名:vzx_GroupTextRela(01120867)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:55:34
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
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
public static class clsvzx_GroupTextRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaENS">源对象</param>
 /// <returns>目标对象=>clsvzx_GroupTextRelaEN:objvzx_GroupTextRelaENT</returns>
 public static clsvzx_GroupTextRelaENEx CopyToEx(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaENS)
{
try
{
 clsvzx_GroupTextRelaENEx objvzx_GroupTextRelaENT = new clsvzx_GroupTextRelaENEx();
clsvzx_GroupTextRelaBL.vzx_GroupTextRelaDA.CopyTo(objvzx_GroupTextRelaENS, objvzx_GroupTextRelaENT);
 return objvzx_GroupTextRelaENT;
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
 /// <param name = "objvzx_GroupTextRelaENS">源对象</param>
 /// <returns>目标对象=>clsvzx_GroupTextRelaEN:objvzx_GroupTextRelaENT</returns>
 public static clsvzx_GroupTextRelaEN CopyTo(this clsvzx_GroupTextRelaENEx objvzx_GroupTextRelaENS)
{
try
{
 clsvzx_GroupTextRelaEN objvzx_GroupTextRelaENT = new clsvzx_GroupTextRelaEN();
clsvzx_GroupTextRelaBL.CopyTo(objvzx_GroupTextRelaENS, objvzx_GroupTextRelaENT);
 return objvzx_GroupTextRelaENT;
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
 /// 小组课文关系视图(vzx_GroupTextRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_GroupTextRelaBLEx : clsvzx_GroupTextRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_GroupTextRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_GroupTextRelaDAEx vzx_GroupTextRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_GroupTextRelaDAEx();
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
public static List<clsvzx_GroupTextRelaENEx> GetObjExLst(string strCondition)
{
List <clsvzx_GroupTextRelaEN> arrObjLst = clsvzx_GroupTextRelaBL.GetObjLst(strCondition);
List <clsvzx_GroupTextRelaENEx> arrObjExLst = new List<clsvzx_GroupTextRelaENEx>();
foreach (clsvzx_GroupTextRelaEN objInFor in arrObjLst)
{
clsvzx_GroupTextRelaENEx objvzx_GroupTextRelaENEx = new clsvzx_GroupTextRelaENEx();
clsvzx_GroupTextRelaBL.CopyTo(objInFor, objvzx_GroupTextRelaENEx);
arrObjExLst.Add(objvzx_GroupTextRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strGroupTextRelaId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_GroupTextRelaENEx GetObjExByGroupTextRelaId(string strGroupTextRelaId)
{
clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = clsvzx_GroupTextRelaBL.GetObjByGroupTextRelaId(strGroupTextRelaId);
clsvzx_GroupTextRelaENEx objvzx_GroupTextRelaENEx = new clsvzx_GroupTextRelaENEx();
clsvzx_GroupTextRelaBL.CopyTo(objvzx_GroupTextRelaEN, objvzx_GroupTextRelaENEx);
return objvzx_GroupTextRelaENEx;
}
}
}