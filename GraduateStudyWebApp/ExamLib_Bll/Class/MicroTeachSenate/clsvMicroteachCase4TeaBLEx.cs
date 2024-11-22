
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase4TeaBLEx
 表名:vMicroteachCase4Tea(01120503)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 public class RelatedActions_vMicroteachCase4TeaEx: RelatedActions_vMicroteachCase4Tea
{
public override bool UpdRelaTabDate(string strIdMicroteachCase, string strOpUser)
{
return true;
}
}
public static class  clsvMicroteachCase4TeaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCase4TeaEN:objvMicroteachCase4TeaENT</returns>
 public static clsvMicroteachCase4TeaENEx CopyToEx(this clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENS)
{
try
{
 clsvMicroteachCase4TeaENEx objvMicroteachCase4TeaENT = new clsvMicroteachCase4TeaENEx();
clsvMicroteachCase4TeaBL.vMicroteachCase4TeaDA.CopyTo(objvMicroteachCase4TeaENS, objvMicroteachCase4TeaENT);
 return objvMicroteachCase4TeaENT;
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
 /// <param name = "objvMicroteachCase4TeaENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCase4TeaEN:objvMicroteachCase4TeaENT</returns>
 public static clsvMicroteachCase4TeaEN CopyTo(this clsvMicroteachCase4TeaENEx objvMicroteachCase4TeaENS)
{
try
{
 clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENT = new clsvMicroteachCase4TeaEN();
clsvMicroteachCase4TeaBL.CopyTo(objvMicroteachCase4TeaENS, objvMicroteachCase4TeaENT);
 return objvMicroteachCase4TeaENT;
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
 /// vMicroteachCase4Tea(vMicroteachCase4Tea)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsvMicroteachCase4TeaBLEx : clsvMicroteachCase4TeaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvMicroteachCase4TeaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvMicroteachCase4TeaDAEx vMicroteachCase4TeaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvMicroteachCase4TeaDAEx();
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
public static List<clsvMicroteachCase4TeaENEx> GetObjExLst(string strCondition)
{
List <clsvMicroteachCase4TeaEN> arrObjLst = clsvMicroteachCase4TeaBL.GetObjLst(strCondition);
List <clsvMicroteachCase4TeaENEx> arrObjExLst = new List<clsvMicroteachCase4TeaENEx>();
foreach (clsvMicroteachCase4TeaEN objInFor in arrObjLst)
{
clsvMicroteachCase4TeaENEx objvMicroteachCase4TeaENEx = new clsvMicroteachCase4TeaENEx();
clsvMicroteachCase4TeaBL.CopyTo(objInFor, objvMicroteachCase4TeaENEx);
arrObjExLst.Add(objvMicroteachCase4TeaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvMicroteachCase4TeaENEx GetObjExByIdMicroteachCase(string strIdMicroteachCase)
{
clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = clsvMicroteachCase4TeaBL.GetObjByIdMicroteachCase(strIdMicroteachCase);
clsvMicroteachCase4TeaENEx objvMicroteachCase4TeaENEx = new clsvMicroteachCase4TeaENEx();
clsvMicroteachCase4TeaBL.CopyTo(objvMicroteachCase4TeaEN, objvMicroteachCase4TeaENEx);
return objvMicroteachCase4TeaENEx;
}
}
}