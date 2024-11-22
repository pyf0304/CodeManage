
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_KnowledgeModulesBLEx
 表名:cc_KnowledgeModules(01120959)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/05 00:37:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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

using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_cc_KnowledgeModulesEx: RelatedActions_cc_KnowledgeModules
{
public override bool UpdRelaTabDate(string strKnowledgeModuleId, string strOpUser)
{
return true;
}
}
public static class  clscc_KnowledgeModulesBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesENS">源对象</param>
 /// <returns>目标对象=>clscc_KnowledgeModulesEN:objcc_KnowledgeModulesENT</returns>
 public static clscc_KnowledgeModulesENEx CopyToEx(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesENS)
{
try
{
 clscc_KnowledgeModulesENEx objcc_KnowledgeModulesENT = new clscc_KnowledgeModulesENEx();
clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.CopyTo(objcc_KnowledgeModulesENS, objcc_KnowledgeModulesENT);
 return objcc_KnowledgeModulesENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesENS">源对象</param>
 /// <returns>目标对象=>clscc_KnowledgeModulesEN:objcc_KnowledgeModulesENT</returns>
 public static clscc_KnowledgeModulesEN CopyTo(this clscc_KnowledgeModulesENEx objcc_KnowledgeModulesENS)
{
try
{
 clscc_KnowledgeModulesEN objcc_KnowledgeModulesENT = new clscc_KnowledgeModulesEN();
clscc_KnowledgeModulesBL.CopyTo(objcc_KnowledgeModulesENS, objcc_KnowledgeModulesENT);
 return objcc_KnowledgeModulesENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 知识点模块(cc_KnowledgeModules)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clscc_KnowledgeModulesBLEx : clscc_KnowledgeModulesBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_KnowledgeModulesDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_KnowledgeModulesDAEx cc_KnowledgeModulesDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_KnowledgeModulesDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesENS">源对象</param>
 /// <returns>目标对象=>clscc_KnowledgeModulesEN:objcc_KnowledgeModulesENT</returns>
 public static clscc_KnowledgeModulesENEx CopyToEx(clscc_KnowledgeModulesEN objcc_KnowledgeModulesENS)
{
try
{
 clscc_KnowledgeModulesENEx objcc_KnowledgeModulesENT = new clscc_KnowledgeModulesENEx();
clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.CopyTo(objcc_KnowledgeModulesENS, objcc_KnowledgeModulesENT);
 return objcc_KnowledgeModulesENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
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
public static List<clscc_KnowledgeModulesENEx> GetObjExLst(string strCondition)
{
List <clscc_KnowledgeModulesEN> arrObjLst = clscc_KnowledgeModulesBL.GetObjLst(strCondition);
List <clscc_KnowledgeModulesENEx> arrObjExLst = new List<clscc_KnowledgeModulesENEx>();
foreach (clscc_KnowledgeModulesEN objInFor in arrObjLst)
{
clscc_KnowledgeModulesENEx objcc_KnowledgeModulesENEx = new clscc_KnowledgeModulesENEx();
clscc_KnowledgeModulesBL.CopyTo(objInFor, objcc_KnowledgeModulesENEx);
arrObjExLst.Add(objcc_KnowledgeModulesENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strKnowledgeModuleId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_KnowledgeModulesENEx GetObjExByKnowledgeModuleId(string strKnowledgeModuleId)
{
clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = clscc_KnowledgeModulesBL.GetObjByKnowledgeModuleId(strKnowledgeModuleId);
clscc_KnowledgeModulesENEx objcc_KnowledgeModulesENEx = new clscc_KnowledgeModulesENEx();
clscc_KnowledgeModulesBL.CopyTo(objcc_KnowledgeModulesEN, objcc_KnowledgeModulesENEx);
return objcc_KnowledgeModulesENEx;
}
}
}