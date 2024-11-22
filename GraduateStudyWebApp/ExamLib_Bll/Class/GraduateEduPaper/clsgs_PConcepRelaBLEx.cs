
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PConcepRelaBLEx
 表名:gs_PConcepRela(01120670)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/12 21:50:33
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
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
public static class clsgs_PConcepRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PConcepRelaENS">源对象</param>
 /// <returns>目标对象=>clsgs_PConcepRelaEN:objgs_PConcepRelaENT</returns>
 public static clsgs_PConcepRelaENEx CopyToEx(this clsgs_PConcepRelaEN objgs_PConcepRelaENS)
{
try
{
 clsgs_PConcepRelaENEx objgs_PConcepRelaENT = new clsgs_PConcepRelaENEx();
clsgs_PConcepRelaBL.gs_PConcepRelaDA.CopyTo(objgs_PConcepRelaENS, objgs_PConcepRelaENT);
 return objgs_PConcepRelaENT;
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
 /// <param name = "objgs_PConcepRelaENS">源对象</param>
 /// <returns>目标对象=>clsgs_PConcepRelaEN:objgs_PConcepRelaENT</returns>
 public static clsgs_PConcepRelaEN CopyTo(this clsgs_PConcepRelaENEx objgs_PConcepRelaENS)
{
try
{
 clsgs_PConcepRelaEN objgs_PConcepRelaENT = new clsgs_PConcepRelaEN();
clsgs_PConcepRelaBL.CopyTo(objgs_PConcepRelaENS, objgs_PConcepRelaENT);
 return objgs_PConcepRelaENT;
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
 /// 论文概念关系(gs_PConcepRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_PConcepRelaBLEx : clsgs_PConcepRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_PConcepRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_PConcepRelaDAEx gs_PConcepRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_PConcepRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PConcepRelaENS">源对象</param>
 /// <returns>目标对象=>clsgs_PConcepRelaEN:objgs_PConcepRelaENT</returns>
 public static clsgs_PConcepRelaENEx CopyToEx(clsgs_PConcepRelaEN objgs_PConcepRelaENS)
{
try
{
 clsgs_PConcepRelaENEx objgs_PConcepRelaENT = new clsgs_PConcepRelaENEx();
clsgs_PConcepRelaBL.gs_PConcepRelaDA.CopyTo(objgs_PConcepRelaENS, objgs_PConcepRelaENT);
 return objgs_PConcepRelaENT;
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
public static List<clsgs_PConcepRelaENEx> GetObjExLst(string strCondition)
{
List <clsgs_PConcepRelaEN> arrObjLst = clsgs_PConcepRelaBL.GetObjLst(strCondition);
List <clsgs_PConcepRelaENEx> arrObjExLst = new List<clsgs_PConcepRelaENEx>();
foreach (clsgs_PConcepRelaEN objInFor in arrObjLst)
{
clsgs_PConcepRelaENEx objgs_PConcepRelaENEx = new clsgs_PConcepRelaENEx();
clsgs_PConcepRelaBL.CopyTo(objInFor, objgs_PConcepRelaENEx);
arrObjExLst.Add(objgs_PConcepRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_PConcepRelaENEx GetObjExBymId(long lngmId)
{
clsgs_PConcepRelaEN objgs_PConcepRelaEN = clsgs_PConcepRelaBL.GetObjBymId(lngmId);
clsgs_PConcepRelaENEx objgs_PConcepRelaENEx = new clsgs_PConcepRelaENEx();
clsgs_PConcepRelaBL.CopyTo(objgs_PConcepRelaEN, objgs_PConcepRelaENEx);
return objgs_PConcepRelaENEx;
}
}
}