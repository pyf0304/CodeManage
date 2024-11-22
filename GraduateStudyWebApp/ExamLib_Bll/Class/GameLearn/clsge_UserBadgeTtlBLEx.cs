
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_UserBadgeTtlBLEx
 表名:ge_UserBadgeTtl(01120882)
 生成代码版本:2021.02.21.1
 生成日期:2021/02/24 18:50:53
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
public static class clsge_UserBadgeTtlBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objge_UserBadgeTtlENS">源对象</param>
 /// <returns>目标对象=>clsge_UserBadgeTtlEN:objge_UserBadgeTtlENT</returns>
 public static clsge_UserBadgeTtlENEx CopyToEx(this clsge_UserBadgeTtlEN objge_UserBadgeTtlENS)
{
try
{
 clsge_UserBadgeTtlENEx objge_UserBadgeTtlENT = new clsge_UserBadgeTtlENEx();
clsge_UserBadgeTtlBL.ge_UserBadgeTtlDA.CopyTo(objge_UserBadgeTtlENS, objge_UserBadgeTtlENT);
 return objge_UserBadgeTtlENT;
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
 /// <param name = "objge_UserBadgeTtlENS">源对象</param>
 /// <returns>目标对象=>clsge_UserBadgeTtlEN:objge_UserBadgeTtlENT</returns>
 public static clsge_UserBadgeTtlEN CopyTo(this clsge_UserBadgeTtlENEx objge_UserBadgeTtlENS)
{
try
{
 clsge_UserBadgeTtlEN objge_UserBadgeTtlENT = new clsge_UserBadgeTtlEN();
clsge_UserBadgeTtlBL.CopyTo(objge_UserBadgeTtlENS, objge_UserBadgeTtlENT);
 return objge_UserBadgeTtlENT;
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
 /// 用户徽章汇总(ge_UserBadgeTtl)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsge_UserBadgeTtlBLEx : clsge_UserBadgeTtlBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsge_UserBadgeTtlDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsge_UserBadgeTtlDAEx ge_UserBadgeTtlDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsge_UserBadgeTtlDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objge_UserBadgeTtlENS">源对象</param>
 /// <returns>目标对象=>clsge_UserBadgeTtlEN:objge_UserBadgeTtlENT</returns>
 public static clsge_UserBadgeTtlENEx CopyToEx(clsge_UserBadgeTtlEN objge_UserBadgeTtlENS)
{
try
{
 clsge_UserBadgeTtlENEx objge_UserBadgeTtlENT = new clsge_UserBadgeTtlENEx();
clsge_UserBadgeTtlBL.ge_UserBadgeTtlDA.CopyTo(objge_UserBadgeTtlENS, objge_UserBadgeTtlENT);
 return objge_UserBadgeTtlENT;
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
public static List<clsge_UserBadgeTtlENEx> GetObjExLst(string strCondition)
{
List <clsge_UserBadgeTtlEN> arrObjLst = clsge_UserBadgeTtlBL.GetObjLst(strCondition);
List <clsge_UserBadgeTtlENEx> arrObjExLst = new List<clsge_UserBadgeTtlENEx>();
foreach (clsge_UserBadgeTtlEN objInFor in arrObjLst)
{
clsge_UserBadgeTtlENEx objge_UserBadgeTtlENEx = new clsge_UserBadgeTtlENEx();
clsge_UserBadgeTtlBL.CopyTo(objInFor, objge_UserBadgeTtlENEx);
arrObjExLst.Add(objge_UserBadgeTtlENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsge_UserBadgeTtlENEx GetObjExBymId(long lngmId)
{
clsge_UserBadgeTtlEN objge_UserBadgeTtlEN = clsge_UserBadgeTtlBL.GetObjBymId(lngmId);
clsge_UserBadgeTtlENEx objge_UserBadgeTtlENEx = new clsge_UserBadgeTtlENEx();
clsge_UserBadgeTtlBL.CopyTo(objge_UserBadgeTtlEN, objge_UserBadgeTtlENEx);
return objge_UserBadgeTtlENEx;
}
}
}