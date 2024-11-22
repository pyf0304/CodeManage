
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsBigConceptBLEx
 表名:BigConcept(01120972)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/08 21:36:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:游戏化教育平台(000041, 变量首字母小写)-全部函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:大概念教学(BigConceptTeaching)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx,0021)
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
 public class RelatedActions_BigConceptEx: RelatedActions_BigConcept
{
public override bool UpdRelaTabDate(string strIdBigConcept, string strOpUser)
{
return true;
}
}
public static class  clsBigConceptBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objBigConceptENS">源对象</param>
 /// <returns>目标对象=>clsBigConceptEN:objBigConceptENT</returns>
 public static clsBigConceptENEx CopyToEx(this clsBigConceptEN objBigConceptENS)
{
try
{
 clsBigConceptENEx objBigConceptENT = new clsBigConceptENEx();
clsBigConceptBL.BigConceptDA.CopyTo(objBigConceptENS, objBigConceptENT);
 return objBigConceptENT;
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
 /// <param name = "objBigConceptENS">源对象</param>
 /// <returns>目标对象=>clsBigConceptEN:objBigConceptENT</returns>
 public static clsBigConceptEN CopyTo(this clsBigConceptENEx objBigConceptENS)
{
try
{
 clsBigConceptEN objBigConceptENT = new clsBigConceptEN();
clsBigConceptBL.CopyTo(objBigConceptENS, objBigConceptENT);
 return objBigConceptENT;
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
 /// 大概念(BigConcept)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsBigConceptBLEx : clsBigConceptBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsBigConceptDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsBigConceptDAEx BigConceptDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsBigConceptDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objBigConceptENS">源对象</param>
 /// <returns>目标对象=>clsBigConceptEN:objBigConceptENT</returns>
 public static clsBigConceptENEx CopyToEx(clsBigConceptEN objBigConceptENS)
{
try
{
 clsBigConceptENEx objBigConceptENT = new clsBigConceptENEx();
clsBigConceptBL.BigConceptDA.CopyTo(objBigConceptENS, objBigConceptENT);
 return objBigConceptENT;
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
public static List<clsBigConceptENEx> GetObjExLst(string strCondition)
{
List <clsBigConceptEN> arrObjLst = clsBigConceptBL.GetObjLst(strCondition);
List <clsBigConceptENEx> arrObjExLst = new List<clsBigConceptENEx>();
foreach (clsBigConceptEN objInFor in arrObjLst)
{
clsBigConceptENEx objBigConceptENEx = new clsBigConceptENEx();
clsBigConceptBL.CopyTo(objInFor, objBigConceptENEx);
arrObjExLst.Add(objBigConceptENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strIdBigConcept">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsBigConceptENEx GetObjExByIdBigConcept(string strIdBigConcept)
{
clsBigConceptEN objBigConceptEN = clsBigConceptBL.GetObjByIdBigConcept(strIdBigConcept);
clsBigConceptENEx objBigConceptENEx = new clsBigConceptENEx();
clsBigConceptBL.CopyTo(objBigConceptEN, objBigConceptENEx);
return objBigConceptENEx;
}
}
}