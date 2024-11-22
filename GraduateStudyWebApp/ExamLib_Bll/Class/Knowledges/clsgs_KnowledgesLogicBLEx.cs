
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesLogicBLEx
 表名:gs_KnowledgesLogic(01120872)
 生成代码版本:2021.01.26.1
 生成日期:2021/01/26 23:46:59
 生成者:lyl
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsgs_KnowledgesLogicBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesLogicEN:objgs_KnowledgesLogicENT</returns>
 public static clsgs_KnowledgesLogicENEx CopyToEx(this clsgs_KnowledgesLogicEN objgs_KnowledgesLogicENS)
{
try
{
 clsgs_KnowledgesLogicENEx objgs_KnowledgesLogicENT = new clsgs_KnowledgesLogicENEx();
clsgs_KnowledgesLogicBL.gs_KnowledgesLogicDA.CopyTo(objgs_KnowledgesLogicENS, objgs_KnowledgesLogicENT);
 return objgs_KnowledgesLogicENT;
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
 /// <param name = "objgs_KnowledgesLogicENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesLogicEN:objgs_KnowledgesLogicENT</returns>
 public static clsgs_KnowledgesLogicEN CopyTo(this clsgs_KnowledgesLogicENEx objgs_KnowledgesLogicENS)
{
try
{
 clsgs_KnowledgesLogicEN objgs_KnowledgesLogicENT = new clsgs_KnowledgesLogicEN();
clsgs_KnowledgesLogicBL.CopyTo(objgs_KnowledgesLogicENS, objgs_KnowledgesLogicENT);
 return objgs_KnowledgesLogicENT;
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
 /// 知识点逻辑(gs_KnowledgesLogic)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_KnowledgesLogicBLEx : clsgs_KnowledgesLogicBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_KnowledgesLogicDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_KnowledgesLogicDAEx gs_KnowledgesLogicDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_KnowledgesLogicDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesLogicEN:objgs_KnowledgesLogicENT</returns>
 public static clsgs_KnowledgesLogicENEx CopyToEx(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicENS)
{
try
{
 clsgs_KnowledgesLogicENEx objgs_KnowledgesLogicENT = new clsgs_KnowledgesLogicENEx();
clsgs_KnowledgesLogicBL.gs_KnowledgesLogicDA.CopyTo(objgs_KnowledgesLogicENS, objgs_KnowledgesLogicENT);
 return objgs_KnowledgesLogicENT;
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
public static List<clsgs_KnowledgesLogicENEx> GetObjExLst(string strCondition)
{
List <clsgs_KnowledgesLogicEN> arrObjLst = clsgs_KnowledgesLogicBL.GetObjLst(strCondition);
List <clsgs_KnowledgesLogicENEx> arrObjExLst = new List<clsgs_KnowledgesLogicENEx>();
foreach (clsgs_KnowledgesLogicEN objInFor in arrObjLst)
{
clsgs_KnowledgesLogicENEx objgs_KnowledgesLogicENEx = new clsgs_KnowledgesLogicENEx();
clsgs_KnowledgesLogicBL.CopyTo(objInFor, objgs_KnowledgesLogicENEx);
arrObjExLst.Add(objgs_KnowledgesLogicENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_KnowledgesLogicENEx GetObjExBymId(long lngmId)
{
clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN = clsgs_KnowledgesLogicBL.GetObjBymId(lngmId);
clsgs_KnowledgesLogicENEx objgs_KnowledgesLogicENEx = new clsgs_KnowledgesLogicENEx();
clsgs_KnowledgesLogicBL.CopyTo(objgs_KnowledgesLogicEN, objgs_KnowledgesLogicENEx);
return objgs_KnowledgesLogicENEx;
}
}
}