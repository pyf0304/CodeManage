
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCommonDataNodeBLEx
 表名:CommonDataNode(01120940)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:AI模块(AIModule)
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
 public class RelatedActions_CommonDataNodeEx: RelatedActions_CommonDataNode
{
public override bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
public static class  clsCommonDataNodeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objCommonDataNodeENS">源对象</param>
 /// <returns>目标对象=>clsCommonDataNodeEN:objCommonDataNodeENT</returns>
 public static clsCommonDataNodeENEx CopyToEx(this clsCommonDataNodeEN objCommonDataNodeENS)
{
try
{
 clsCommonDataNodeENEx objCommonDataNodeENT = new clsCommonDataNodeENEx();
clsCommonDataNodeBL.CommonDataNodeDA.CopyTo(objCommonDataNodeENS, objCommonDataNodeENT);
 return objCommonDataNodeENT;
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
 /// <param name = "objCommonDataNodeENS">源对象</param>
 /// <returns>目标对象=>clsCommonDataNodeEN:objCommonDataNodeENT</returns>
 public static clsCommonDataNodeEN CopyTo(this clsCommonDataNodeENEx objCommonDataNodeENS)
{
try
{
 clsCommonDataNodeEN objCommonDataNodeENT = new clsCommonDataNodeEN();
clsCommonDataNodeBL.CopyTo(objCommonDataNodeENS, objCommonDataNodeENT);
 return objCommonDataNodeENT;
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
 /// 公共数据结点(CommonDataNode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsCommonDataNodeBLEx : clsCommonDataNodeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsCommonDataNodeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsCommonDataNodeDAEx CommonDataNodeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsCommonDataNodeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objCommonDataNodeENS">源对象</param>
 /// <returns>目标对象=>clsCommonDataNodeEN:objCommonDataNodeENT</returns>
 public static clsCommonDataNodeENEx CopyToEx(clsCommonDataNodeEN objCommonDataNodeENS)
{
try
{
 clsCommonDataNodeENEx objCommonDataNodeENT = new clsCommonDataNodeENEx();
clsCommonDataNodeBL.CommonDataNodeDA.CopyTo(objCommonDataNodeENS, objCommonDataNodeENT);
 return objCommonDataNodeENT;
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
public static List<clsCommonDataNodeENEx> GetObjExLst(string strCondition)
{
List <clsCommonDataNodeEN> arrObjLst = clsCommonDataNodeBL.GetObjLst(strCondition);
List <clsCommonDataNodeENEx> arrObjExLst = new List<clsCommonDataNodeENEx>();
foreach (clsCommonDataNodeEN objInFor in arrObjLst)
{
clsCommonDataNodeENEx objCommonDataNodeENEx = new clsCommonDataNodeENEx();
clsCommonDataNodeBL.CopyTo(objInFor, objCommonDataNodeENEx);
arrObjExLst.Add(objCommonDataNodeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsCommonDataNodeENEx GetObjExBymId(long lngmId)
{
clsCommonDataNodeEN objCommonDataNodeEN = clsCommonDataNodeBL.GetObjBymId(lngmId);
clsCommonDataNodeENEx objCommonDataNodeENEx = new clsCommonDataNodeENEx();
clsCommonDataNodeBL.CopyTo(objCommonDataNodeEN, objCommonDataNodeENEx);
return objCommonDataNodeENEx;
}
}
}