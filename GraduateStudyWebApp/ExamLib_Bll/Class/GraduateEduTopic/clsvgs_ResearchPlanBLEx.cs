
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_ResearchPlanBLEx
 表名:vgs_ResearchPlan(01120662)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/10 19:31:03
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培主题
 模块英文名:GraduateEduTopic
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
public static class clsvgs_ResearchPlanBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanENS">源对象</param>
 /// <returns>目标对象=>clsvgs_ResearchPlanEN:objvgs_ResearchPlanENT</returns>
 public static clsvgs_ResearchPlanENEx CopyToEx(this clsvgs_ResearchPlanEN objvgs_ResearchPlanENS)
{
try
{
 clsvgs_ResearchPlanENEx objvgs_ResearchPlanENT = new clsvgs_ResearchPlanENEx();
clsvgs_ResearchPlanBL.vgs_ResearchPlanDA.CopyTo(objvgs_ResearchPlanENS, objvgs_ResearchPlanENT);
 return objvgs_ResearchPlanENT;
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
 /// <param name = "objvgs_ResearchPlanENS">源对象</param>
 /// <returns>目标对象=>clsvgs_ResearchPlanEN:objvgs_ResearchPlanENT</returns>
 public static clsvgs_ResearchPlanEN CopyTo(this clsvgs_ResearchPlanENEx objvgs_ResearchPlanENS)
{
try
{
 clsvgs_ResearchPlanEN objvgs_ResearchPlanENT = new clsvgs_ResearchPlanEN();
clsvgs_ResearchPlanBL.CopyTo(objvgs_ResearchPlanENS, objvgs_ResearchPlanENT);
 return objvgs_ResearchPlanENT;
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
 /// 主题研究计划视图(vgs_ResearchPlan)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_ResearchPlanBLEx : clsvgs_ResearchPlanBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_ResearchPlanDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_ResearchPlanDAEx vgs_ResearchPlanDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_ResearchPlanDAEx();
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
public static List<clsvgs_ResearchPlanENEx> GetObjExLst(string strCondition)
{
List <clsvgs_ResearchPlanEN> arrObjLst = clsvgs_ResearchPlanBL.GetObjLst(strCondition);
List <clsvgs_ResearchPlanENEx> arrObjExLst = new List<clsvgs_ResearchPlanENEx>();
foreach (clsvgs_ResearchPlanEN objInFor in arrObjLst)
{
clsvgs_ResearchPlanENEx objvgs_ResearchPlanENEx = new clsvgs_ResearchPlanENEx();
clsvgs_ResearchPlanBL.CopyTo(objInFor, objvgs_ResearchPlanENEx);
arrObjExLst.Add(objvgs_ResearchPlanENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strPlanId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_ResearchPlanENEx GetObjExByPlanId(string strPlanId)
{
clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = clsvgs_ResearchPlanBL.GetObjByPlanId(strPlanId);
clsvgs_ResearchPlanENEx objvgs_ResearchPlanENEx = new clsvgs_ResearchPlanENEx();
clsvgs_ResearchPlanBL.CopyTo(objvgs_ResearchPlanEN, objvgs_ResearchPlanENEx);
return objvgs_ResearchPlanENEx;
}
}
}