
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ResearchPlanBLEx
 表名:zx_ResearchPlan(01120729)
 生成代码版本:2020.09.07.1
 生成日期:2020/09/09 09:07:36
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
public static class clszx_ResearchPlanBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ResearchPlanENS">源对象</param>
 /// <returns>目标对象=>clszx_ResearchPlanEN:objzx_ResearchPlanENT</returns>
 public static clszx_ResearchPlanENEx CopyToEx(this clszx_ResearchPlanEN objzx_ResearchPlanENS)
{
try
{
 clszx_ResearchPlanENEx objzx_ResearchPlanENT = new clszx_ResearchPlanENEx();
clszx_ResearchPlanBL.zx_ResearchPlanDA.CopyTo(objzx_ResearchPlanENS, objzx_ResearchPlanENT);
 return objzx_ResearchPlanENT;
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
 /// <param name = "objzx_ResearchPlanENS">源对象</param>
 /// <returns>目标对象=>clszx_ResearchPlanEN:objzx_ResearchPlanENT</returns>
 public static clszx_ResearchPlanEN CopyTo(this clszx_ResearchPlanENEx objzx_ResearchPlanENS)
{
try
{
 clszx_ResearchPlanEN objzx_ResearchPlanENT = new clszx_ResearchPlanEN();
clszx_ResearchPlanBL.CopyTo(objzx_ResearchPlanENS, objzx_ResearchPlanENT);
 return objzx_ResearchPlanENT;
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
 /// 中学研究计划(zx_ResearchPlan)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_ResearchPlanBLEx : clszx_ResearchPlanBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_ResearchPlanDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_ResearchPlanDAEx zx_ResearchPlanDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_ResearchPlanDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ResearchPlanENS">源对象</param>
 /// <returns>目标对象=>clszx_ResearchPlanEN:objzx_ResearchPlanENT</returns>
 public static clszx_ResearchPlanENEx CopyToEx(clszx_ResearchPlanEN objzx_ResearchPlanENS)
{
try
{
 clszx_ResearchPlanENEx objzx_ResearchPlanENT = new clszx_ResearchPlanENEx();
clszx_ResearchPlanBL.zx_ResearchPlanDA.CopyTo(objzx_ResearchPlanENS, objzx_ResearchPlanENT);
 return objzx_ResearchPlanENT;
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
public static List<clszx_ResearchPlanENEx> GetObjExLst(string strCondition)
{
List <clszx_ResearchPlanEN> arrObjLst = clszx_ResearchPlanBL.GetObjLst(strCondition);
List <clszx_ResearchPlanENEx> arrObjExLst = new List<clszx_ResearchPlanENEx>();
foreach (clszx_ResearchPlanEN objInFor in arrObjLst)
{
clszx_ResearchPlanENEx objzx_ResearchPlanENEx = new clszx_ResearchPlanENEx();
clszx_ResearchPlanBL.CopyTo(objInFor, objzx_ResearchPlanENEx);
arrObjExLst.Add(objzx_ResearchPlanENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strPlanId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_ResearchPlanENEx GetObjExByPlanId(string strPlanId)
{
clszx_ResearchPlanEN objzx_ResearchPlanEN = clszx_ResearchPlanBL.GetObjByzxPlanId(strPlanId);
clszx_ResearchPlanENEx objzx_ResearchPlanENEx = new clszx_ResearchPlanENEx();
clszx_ResearchPlanBL.CopyTo(objzx_ResearchPlanEN, objzx_ResearchPlanENEx);
return objzx_ResearchPlanENEx;
}
}
}