
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StuErrorLibBLEx
 表名:ge_StuErrorLib(01120887)
 生成代码版本:2021.03.01.1
 生成日期:2021/03/01 15:24:18
 生成者:yy
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
public static class clsge_StuErrorLibBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objge_StuErrorLibENS">源对象</param>
 /// <returns>目标对象=>clsge_StuErrorLibEN:objge_StuErrorLibENT</returns>
 public static clsge_StuErrorLibENEx CopyToEx(this clsge_StuErrorLibEN objge_StuErrorLibENS)
{
try
{
 clsge_StuErrorLibENEx objge_StuErrorLibENT = new clsge_StuErrorLibENEx();
clsge_StuErrorLibBL.ge_StuErrorLibDA.CopyTo(objge_StuErrorLibENS, objge_StuErrorLibENT);
 return objge_StuErrorLibENT;
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
 /// <param name = "objge_StuErrorLibENS">源对象</param>
 /// <returns>目标对象=>clsge_StuErrorLibEN:objge_StuErrorLibENT</returns>
 public static clsge_StuErrorLibEN CopyTo(this clsge_StuErrorLibENEx objge_StuErrorLibENS)
{
try
{
 clsge_StuErrorLibEN objge_StuErrorLibENT = new clsge_StuErrorLibEN();
clsge_StuErrorLibBL.CopyTo(objge_StuErrorLibENS, objge_StuErrorLibENT);
 return objge_StuErrorLibENT;
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
 /// 学生错误作业集(ge_StuErrorLib)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsge_StuErrorLibBLEx : clsge_StuErrorLibBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsge_StuErrorLibDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsge_StuErrorLibDAEx ge_StuErrorLibDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsge_StuErrorLibDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objge_StuErrorLibENS">源对象</param>
 /// <returns>目标对象=>clsge_StuErrorLibEN:objge_StuErrorLibENT</returns>
 public static clsge_StuErrorLibENEx CopyToEx(clsge_StuErrorLibEN objge_StuErrorLibENS)
{
try
{
 clsge_StuErrorLibENEx objge_StuErrorLibENT = new clsge_StuErrorLibENEx();
clsge_StuErrorLibBL.ge_StuErrorLibDA.CopyTo(objge_StuErrorLibENS, objge_StuErrorLibENT);
 return objge_StuErrorLibENT;
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
public static List<clsge_StuErrorLibENEx> GetObjExLst(string strCondition)
{
List <clsge_StuErrorLibEN> arrObjLst = clsge_StuErrorLibBL.GetObjLst(strCondition);
List <clsge_StuErrorLibENEx> arrObjExLst = new List<clsge_StuErrorLibENEx>();
foreach (clsge_StuErrorLibEN objInFor in arrObjLst)
{
clsge_StuErrorLibENEx objge_StuErrorLibENEx = new clsge_StuErrorLibENEx();
clsge_StuErrorLibBL.CopyTo(objInFor, objge_StuErrorLibENEx);
arrObjExLst.Add(objge_StuErrorLibENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsge_StuErrorLibENEx GetObjExBymId(long lngmId)
{
clsge_StuErrorLibEN objge_StuErrorLibEN = clsge_StuErrorLibBL.GetObjBymId(lngmId);
clsge_StuErrorLibENEx objge_StuErrorLibENEx = new clsge_StuErrorLibENEx();
clsge_StuErrorLibBL.CopyTo(objge_StuErrorLibEN, objge_StuErrorLibENEx);
return objge_StuErrorLibENEx;
}
}
}