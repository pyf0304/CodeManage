
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ReflectLogBLEx
 表名:zx_ReflectLog(01120728)
 生成代码版本:2020.09.07.1
 生成日期:2020/09/09 09:07:40
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
public static class clszx_ReflectLogBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ReflectLogENS">源对象</param>
 /// <returns>目标对象=>clszx_ReflectLogEN:objzx_ReflectLogENT</returns>
 public static clszx_ReflectLogENEx CopyToEx(this clszx_ReflectLogEN objzx_ReflectLogENS)
{
try
{
 clszx_ReflectLogENEx objzx_ReflectLogENT = new clszx_ReflectLogENEx();
clszx_ReflectLogBL.zx_ReflectLogDA.CopyTo(objzx_ReflectLogENS, objzx_ReflectLogENT);
 return objzx_ReflectLogENT;
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
 /// <param name = "objzx_ReflectLogENS">源对象</param>
 /// <returns>目标对象=>clszx_ReflectLogEN:objzx_ReflectLogENT</returns>
 public static clszx_ReflectLogEN CopyTo(this clszx_ReflectLogENEx objzx_ReflectLogENS)
{
try
{
 clszx_ReflectLogEN objzx_ReflectLogENT = new clszx_ReflectLogEN();
clszx_ReflectLogBL.CopyTo(objzx_ReflectLogENS, objzx_ReflectLogENT);
 return objzx_ReflectLogENT;
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
 /// 中学课文反思(zx_ReflectLog)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_ReflectLogBLEx : clszx_ReflectLogBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_ReflectLogDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_ReflectLogDAEx zx_ReflectLogDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_ReflectLogDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ReflectLogENS">源对象</param>
 /// <returns>目标对象=>clszx_ReflectLogEN:objzx_ReflectLogENT</returns>
 public static clszx_ReflectLogENEx CopyToEx(clszx_ReflectLogEN objzx_ReflectLogENS)
{
try
{
 clszx_ReflectLogENEx objzx_ReflectLogENT = new clszx_ReflectLogENEx();
clszx_ReflectLogBL.zx_ReflectLogDA.CopyTo(objzx_ReflectLogENS, objzx_ReflectLogENT);
 return objzx_ReflectLogENT;
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
public static List<clszx_ReflectLogENEx> GetObjExLst(string strCondition)
{
List <clszx_ReflectLogEN> arrObjLst = clszx_ReflectLogBL.GetObjLst(strCondition);
List <clszx_ReflectLogENEx> arrObjExLst = new List<clszx_ReflectLogENEx>();
foreach (clszx_ReflectLogEN objInFor in arrObjLst)
{
clszx_ReflectLogENEx objzx_ReflectLogENEx = new clszx_ReflectLogENEx();
clszx_ReflectLogBL.CopyTo(objInFor, objzx_ReflectLogENEx);
arrObjExLst.Add(objzx_ReflectLogENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_ReflectLogENEx GetObjExBymId(long lngmId)
{
clszx_ReflectLogEN objzx_ReflectLogEN = clszx_ReflectLogBL.GetObjBymId(lngmId);
clszx_ReflectLogENEx objzx_ReflectLogENEx = new clszx_ReflectLogENEx();
clszx_ReflectLogBL.CopyTo(objzx_ReflectLogEN, objzx_ReflectLogENEx);
return objzx_ReflectLogENEx;
}
}
}