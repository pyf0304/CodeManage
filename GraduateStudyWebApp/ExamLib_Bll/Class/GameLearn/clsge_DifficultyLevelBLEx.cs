
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_DifficultyLevelBLEx
 表名:ge_DifficultyLevel(01120905)
 生成代码版本:2021.03.27.2
 生成日期:2021/03/27 16:42:06
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习
 模块英文名:GameLearn
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
public static class clsge_DifficultyLevelBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objge_DifficultyLevelENS">源对象</param>
 /// <returns>目标对象=>clsge_DifficultyLevelEN:objge_DifficultyLevelENT</returns>
 public static clsge_DifficultyLevelENEx CopyToEx(this clsge_DifficultyLevelEN objge_DifficultyLevelENS)
{
try
{
 clsge_DifficultyLevelENEx objge_DifficultyLevelENT = new clsge_DifficultyLevelENEx();
clsge_DifficultyLevelBL.ge_DifficultyLevelDA.CopyTo(objge_DifficultyLevelENS, objge_DifficultyLevelENT);
 return objge_DifficultyLevelENT;
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
 /// <param name = "objge_DifficultyLevelENS">源对象</param>
 /// <returns>目标对象=>clsge_DifficultyLevelEN:objge_DifficultyLevelENT</returns>
 public static clsge_DifficultyLevelEN CopyTo(this clsge_DifficultyLevelENEx objge_DifficultyLevelENS)
{
try
{
 clsge_DifficultyLevelEN objge_DifficultyLevelENT = new clsge_DifficultyLevelEN();
clsge_DifficultyLevelBL.CopyTo(objge_DifficultyLevelENS, objge_DifficultyLevelENT);
 return objge_DifficultyLevelENT;
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
 /// 难度等级表(ge_DifficultyLevel)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsge_DifficultyLevelBLEx : clsge_DifficultyLevelBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsge_DifficultyLevelDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsge_DifficultyLevelDAEx ge_DifficultyLevelDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsge_DifficultyLevelDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objge_DifficultyLevelENS">源对象</param>
 /// <returns>目标对象=>clsge_DifficultyLevelEN:objge_DifficultyLevelENT</returns>
 public static clsge_DifficultyLevelENEx CopyToEx(clsge_DifficultyLevelEN objge_DifficultyLevelENS)
{
try
{
 clsge_DifficultyLevelENEx objge_DifficultyLevelENT = new clsge_DifficultyLevelENEx();
clsge_DifficultyLevelBL.ge_DifficultyLevelDA.CopyTo(objge_DifficultyLevelENS, objge_DifficultyLevelENT);
 return objge_DifficultyLevelENT;
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
public static List<clsge_DifficultyLevelENEx> GetObjExLst(string strCondition)
{
List <clsge_DifficultyLevelEN> arrObjLst = clsge_DifficultyLevelBL.GetObjLst(strCondition);
List <clsge_DifficultyLevelENEx> arrObjExLst = new List<clsge_DifficultyLevelENEx>();
foreach (clsge_DifficultyLevelEN objInFor in arrObjLst)
{
clsge_DifficultyLevelENEx objge_DifficultyLevelENEx = new clsge_DifficultyLevelENEx();
clsge_DifficultyLevelBL.CopyTo(objInFor, objge_DifficultyLevelENEx);
arrObjExLst.Add(objge_DifficultyLevelENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strDifficultyLevelId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsge_DifficultyLevelENEx GetObjExByDifficultyLevelId(string strDifficultyLevelId)
{
clsge_DifficultyLevelEN objge_DifficultyLevelEN = clsge_DifficultyLevelBL.GetObjByDifficultyLevelId(strDifficultyLevelId);
clsge_DifficultyLevelENEx objge_DifficultyLevelENEx = new clsge_DifficultyLevelENEx();
clsge_DifficultyLevelBL.CopyTo(objge_DifficultyLevelEN, objge_DifficultyLevelENEx);
return objge_DifficultyLevelENEx;
}
}
}