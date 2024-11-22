﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCase_BaseBLEx
 表名:vClsRmTeachingCase_Base(01120488)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 public class RelatedActions_vClsRmTeachingCase_BaseEx: RelatedActions_vClsRmTeachingCase_Base
{
public override bool UpdRelaTabDate(string strIdClsRmTeachingCase, string strOpUser)
{
return true;
}
}
public static class  clsvClsRmTeachingCase_BaseBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseENS">源对象</param>
 /// <returns>目标对象=>clsvClsRmTeachingCase_BaseEN:objvClsRmTeachingCase_BaseENT</returns>
 public static clsvClsRmTeachingCase_BaseENEx CopyToEx(this clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENS)
{
try
{
 clsvClsRmTeachingCase_BaseENEx objvClsRmTeachingCase_BaseENT = new clsvClsRmTeachingCase_BaseENEx();
clsvClsRmTeachingCase_BaseBL.vClsRmTeachingCase_BaseDA.CopyTo(objvClsRmTeachingCase_BaseENS, objvClsRmTeachingCase_BaseENT);
 return objvClsRmTeachingCase_BaseENT;
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
 /// <param name = "objvClsRmTeachingCase_BaseENS">源对象</param>
 /// <returns>目标对象=>clsvClsRmTeachingCase_BaseEN:objvClsRmTeachingCase_BaseENT</returns>
 public static clsvClsRmTeachingCase_BaseEN CopyTo(this clsvClsRmTeachingCase_BaseENEx objvClsRmTeachingCase_BaseENS)
{
try
{
 clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENT = new clsvClsRmTeachingCase_BaseEN();
clsvClsRmTeachingCase_BaseBL.CopyTo(objvClsRmTeachingCase_BaseENS, objvClsRmTeachingCase_BaseENT);
 return objvClsRmTeachingCase_BaseENT;
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
 /// v课堂教学案例_Base(vClsRmTeachingCase_Base)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsvClsRmTeachingCase_BaseBLEx : clsvClsRmTeachingCase_BaseBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvClsRmTeachingCase_BaseDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvClsRmTeachingCase_BaseDAEx vClsRmTeachingCase_BaseDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvClsRmTeachingCase_BaseDAEx();
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
public static List<clsvClsRmTeachingCase_BaseENEx> GetObjExLst(string strCondition)
{
List <clsvClsRmTeachingCase_BaseEN> arrObjLst = clsvClsRmTeachingCase_BaseBL.GetObjLst(strCondition);
List <clsvClsRmTeachingCase_BaseENEx> arrObjExLst = new List<clsvClsRmTeachingCase_BaseENEx>();
foreach (clsvClsRmTeachingCase_BaseEN objInFor in arrObjLst)
{
clsvClsRmTeachingCase_BaseENEx objvClsRmTeachingCase_BaseENEx = new clsvClsRmTeachingCase_BaseENEx();
clsvClsRmTeachingCase_BaseBL.CopyTo(objInFor, objvClsRmTeachingCase_BaseENEx);
arrObjExLst.Add(objvClsRmTeachingCase_BaseENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvClsRmTeachingCase_BaseENEx GetObjExByIdClsRmTeachingCase(string strIdClsRmTeachingCase)
{
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = clsvClsRmTeachingCase_BaseBL.GetObjByIdClsRmTeachingCase(strIdClsRmTeachingCase);
clsvClsRmTeachingCase_BaseENEx objvClsRmTeachingCase_BaseENEx = new clsvClsRmTeachingCase_BaseENEx();
clsvClsRmTeachingCase_BaseBL.CopyTo(objvClsRmTeachingCase_BaseEN, objvClsRmTeachingCase_BaseENEx);
return objvClsRmTeachingCase_BaseENEx;
}
}
}