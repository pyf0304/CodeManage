
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_KnowledgesLogicRela_SimBLEx
 表名:vgs_KnowledgesLogicRela_Sim(01120934)
 生成代码版本:2022.11.12.1
 生成日期:2022/11/14 14:51:00
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
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_vgs_KnowledgesLogicRela_SimEx: RelatedActions_vgs_KnowledgesLogicRela_Sim
{
public override bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
public static class clsvgs_KnowledgesLogicRela_SimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimENS">源对象</param>
 /// <returns>目标对象=>clsvgs_KnowledgesLogicRela_SimEN:objvgs_KnowledgesLogicRela_SimENT</returns>
 public static clsvgs_KnowledgesLogicRela_SimENEx CopyToEx(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimENS)
{
try
{
 clsvgs_KnowledgesLogicRela_SimENEx objvgs_KnowledgesLogicRela_SimENT = new clsvgs_KnowledgesLogicRela_SimENEx();
clsvgs_KnowledgesLogicRela_SimBL.vgs_KnowledgesLogicRela_SimDA.CopyTo(objvgs_KnowledgesLogicRela_SimENS, objvgs_KnowledgesLogicRela_SimENT);
 return objvgs_KnowledgesLogicRela_SimENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimENS">源对象</param>
 /// <returns>目标对象=>clsvgs_KnowledgesLogicRela_SimEN:objvgs_KnowledgesLogicRela_SimENT</returns>
 public static clsvgs_KnowledgesLogicRela_SimEN CopyTo(this clsvgs_KnowledgesLogicRela_SimENEx objvgs_KnowledgesLogicRela_SimENS)
{
try
{
 clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimENT = new clsvgs_KnowledgesLogicRela_SimEN();
clsvgs_KnowledgesLogicRela_SimBL.CopyTo(objvgs_KnowledgesLogicRela_SimENS, objvgs_KnowledgesLogicRela_SimENT);
 return objvgs_KnowledgesLogicRela_SimENT;
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
 /// v知识点逻辑关系_Sim(vgs_KnowledgesLogicRela_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_KnowledgesLogicRela_SimBLEx : clsvgs_KnowledgesLogicRela_SimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_KnowledgesLogicRela_SimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_KnowledgesLogicRela_SimDAEx vgs_KnowledgesLogicRela_SimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_KnowledgesLogicRela_SimDAEx();
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
public static List<clsvgs_KnowledgesLogicRela_SimENEx> GetObjExLst(string strCondition)
{
List <clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = clsvgs_KnowledgesLogicRela_SimBL.GetObjLst(strCondition);
List <clsvgs_KnowledgesLogicRela_SimENEx> arrObjExLst = new List<clsvgs_KnowledgesLogicRela_SimENEx>();
foreach (clsvgs_KnowledgesLogicRela_SimEN objInFor in arrObjLst)
{
clsvgs_KnowledgesLogicRela_SimENEx objvgs_KnowledgesLogicRela_SimENEx = new clsvgs_KnowledgesLogicRela_SimENEx();
clsvgs_KnowledgesLogicRela_SimBL.CopyTo(objInFor, objvgs_KnowledgesLogicRela_SimENEx);
arrObjExLst.Add(objvgs_KnowledgesLogicRela_SimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_KnowledgesLogicRela_SimENEx GetObjExBymId(long lngmId)
{
clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = clsvgs_KnowledgesLogicRela_SimBL.GetObjBymId(lngmId);
clsvgs_KnowledgesLogicRela_SimENEx objvgs_KnowledgesLogicRela_SimENEx = new clsvgs_KnowledgesLogicRela_SimENEx();
clsvgs_KnowledgesLogicRela_SimBL.CopyTo(objvgs_KnowledgesLogicRela_SimEN, objvgs_KnowledgesLogicRela_SimENEx);
return objvgs_KnowledgesLogicRela_SimENEx;
}
}
}