
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ControlTypeBLEx
 表名:ge_ControlType(01120900)
 生成代码版本:2021.03.13.1
 生成日期:2021/03/16 16:59:07
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
public static class clsge_ControlTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objge_ControlTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_ControlTypeEN:objge_ControlTypeENT</returns>
 public static clsge_ControlTypeENEx CopyToEx(this clsge_ControlTypeEN objge_ControlTypeENS)
{
try
{
 clsge_ControlTypeENEx objge_ControlTypeENT = new clsge_ControlTypeENEx();
clsge_ControlTypeBL.ge_ControlTypeDA.CopyTo(objge_ControlTypeENS, objge_ControlTypeENT);
 return objge_ControlTypeENT;
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
 /// <param name = "objge_ControlTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_ControlTypeEN:objge_ControlTypeENT</returns>
 public static clsge_ControlTypeEN CopyTo(this clsge_ControlTypeENEx objge_ControlTypeENS)
{
try
{
 clsge_ControlTypeEN objge_ControlTypeENT = new clsge_ControlTypeEN();
clsge_ControlTypeBL.CopyTo(objge_ControlTypeENS, objge_ControlTypeENT);
 return objge_ControlTypeENT;
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
 /// 控件类型(ge_ControlType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsge_ControlTypeBLEx : clsge_ControlTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsge_ControlTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsge_ControlTypeDAEx ge_ControlTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsge_ControlTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objge_ControlTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_ControlTypeEN:objge_ControlTypeENT</returns>
 public static clsge_ControlTypeENEx CopyToEx(clsge_ControlTypeEN objge_ControlTypeENS)
{
try
{
 clsge_ControlTypeENEx objge_ControlTypeENT = new clsge_ControlTypeENEx();
clsge_ControlTypeBL.ge_ControlTypeDA.CopyTo(objge_ControlTypeENS, objge_ControlTypeENT);
 return objge_ControlTypeENT;
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
public static List<clsge_ControlTypeENEx> GetObjExLst(string strCondition)
{
List <clsge_ControlTypeEN> arrObjLst = clsge_ControlTypeBL.GetObjLst(strCondition);
List <clsge_ControlTypeENEx> arrObjExLst = new List<clsge_ControlTypeENEx>();
foreach (clsge_ControlTypeEN objInFor in arrObjLst)
{
clsge_ControlTypeENEx objge_ControlTypeENEx = new clsge_ControlTypeENEx();
clsge_ControlTypeBL.CopyTo(objInFor, objge_ControlTypeENEx);
arrObjExLst.Add(objge_ControlTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strControlTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsge_ControlTypeENEx GetObjExByControlTypeId(string strControlTypeId)
{
clsge_ControlTypeEN objge_ControlTypeEN = clsge_ControlTypeBL.GetObjByControlTypeId(strControlTypeId);
clsge_ControlTypeENEx objge_ControlTypeENEx = new clsge_ControlTypeENEx();
clsge_ControlTypeBL.CopyTo(objge_ControlTypeEN, objge_ControlTypeENEx);
return objge_ControlTypeENEx;
}
}
}