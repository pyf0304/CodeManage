
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCjGetScoreWayBLEx
 表名:CjGetScoreWay(01120575)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 17:26:52
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成绩管理
 模块英文名:ScoreManage
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
public static class clsCjGetScoreWayBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objCjGetScoreWayENS">源对象</param>
 /// <returns>目标对象=>clsCjGetScoreWayEN:objCjGetScoreWayENT</returns>
 public static clsCjGetScoreWayENEx CopyToEx(this clsCjGetScoreWayEN objCjGetScoreWayENS)
{
try
{
 clsCjGetScoreWayENEx objCjGetScoreWayENT = new clsCjGetScoreWayENEx();
clsCjGetScoreWayBL.CjGetScoreWayDA.CopyTo(objCjGetScoreWayENS, objCjGetScoreWayENT);
 return objCjGetScoreWayENT;
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
 /// <param name = "objCjGetScoreWayENS">源对象</param>
 /// <returns>目标对象=>clsCjGetScoreWayEN:objCjGetScoreWayENT</returns>
 public static clsCjGetScoreWayEN CopyTo(this clsCjGetScoreWayENEx objCjGetScoreWayENS)
{
try
{
 clsCjGetScoreWayEN objCjGetScoreWayENT = new clsCjGetScoreWayEN();
clsCjGetScoreWayBL.CopyTo(objCjGetScoreWayENS, objCjGetScoreWayENT);
 return objCjGetScoreWayENT;
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
 /// 成绩导入方式(CjGetScoreWay)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsCjGetScoreWayBLEx : clsCjGetScoreWayBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsCjGetScoreWayDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsCjGetScoreWayDAEx CjGetScoreWayDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsCjGetScoreWayDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objCjGetScoreWayENS">源对象</param>
 /// <returns>目标对象=>clsCjGetScoreWayEN:objCjGetScoreWayENT</returns>
 public static clsCjGetScoreWayENEx CopyToEx(clsCjGetScoreWayEN objCjGetScoreWayENS)
{
try
{
 clsCjGetScoreWayENEx objCjGetScoreWayENT = new clsCjGetScoreWayENEx();
clsCjGetScoreWayBL.CjGetScoreWayDA.CopyTo(objCjGetScoreWayENS, objCjGetScoreWayENT);
 return objCjGetScoreWayENT;
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
public static List<clsCjGetScoreWayENEx> GetObjExLst(string strCondition)
{
List <clsCjGetScoreWayEN> arrObjLst = clsCjGetScoreWayBL.GetObjLst(strCondition);
List <clsCjGetScoreWayENEx> arrObjExLst = new List<clsCjGetScoreWayENEx>();
foreach (clsCjGetScoreWayEN objInFor in arrObjLst)
{
clsCjGetScoreWayENEx objCjGetScoreWayENEx = new clsCjGetScoreWayENEx();
clsCjGetScoreWayBL.CopyTo(objInFor, objCjGetScoreWayENEx);
arrObjExLst.Add(objCjGetScoreWayENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strGetScoreWayId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsCjGetScoreWayENEx GetObjExByGetScoreWayId(string strGetScoreWayId)
{
clsCjGetScoreWayEN objCjGetScoreWayEN = clsCjGetScoreWayBL.GetObjByGetScoreWayId(strGetScoreWayId);
clsCjGetScoreWayENEx objCjGetScoreWayENEx = new clsCjGetScoreWayENEx();
clsCjGetScoreWayBL.CopyTo(objCjGetScoreWayEN, objCjGetScoreWayENEx);
return objCjGetScoreWayENEx;
}
}
}