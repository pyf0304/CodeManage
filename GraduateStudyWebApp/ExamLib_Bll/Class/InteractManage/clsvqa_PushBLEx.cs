﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_PushBLEx
 表名:vqa_Push(01120634)
 生成代码版本:2020.06.17.1
 生成日期:2020/06/18 18:43:48
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsvqa_PushBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvqa_PushENS">源对象</param>
 /// <returns>目标对象=>clsvqa_PushEN:objvqa_PushENT</returns>
 public static clsvqa_PushENEx CopyToEx(this clsvqa_PushEN objvqa_PushENS)
{
try
{
 clsvqa_PushENEx objvqa_PushENT = new clsvqa_PushENEx();
clsvqa_PushBL.vqa_PushDA.CopyTo(objvqa_PushENS, objvqa_PushENT);
 return objvqa_PushENT;
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
 /// <param name = "objvqa_PushENS">源对象</param>
 /// <returns>目标对象=>clsvqa_PushEN:objvqa_PushENT</returns>
 public static clsvqa_PushEN CopyTo(this clsvqa_PushENEx objvqa_PushENS)
{
try
{
 clsvqa_PushEN objvqa_PushENT = new clsvqa_PushEN();
clsvqa_PushBL.CopyTo(objvqa_PushENS, objvqa_PushENT);
 return objvqa_PushENT;
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
 /// v答疑推送(vqa_Push)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvqa_PushBLEx : clsvqa_PushBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvqa_PushDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvqa_PushDAEx vqa_PushDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvqa_PushDAEx();
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
public static List<clsvqa_PushENEx> GetObjExLst(string strCondition)
{
List <clsvqa_PushEN> arrObjLst = clsvqa_PushBL.GetObjLst(strCondition);
List <clsvqa_PushENEx> arrObjExLst = new List<clsvqa_PushENEx>();
foreach (clsvqa_PushEN objInFor in arrObjLst)
{
clsvqa_PushENEx objvqa_PushENEx = new clsvqa_PushENEx();
clsvqa_PushBL.CopyTo(objInFor, objvqa_PushENEx);
arrObjExLst.Add(objvqa_PushENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvqa_PushENEx GetObjExByPushId(long lngPushId)
{
clsvqa_PushEN objvqa_PushEN = clsvqa_PushBL.GetObjByPushId(lngPushId);
clsvqa_PushENEx objvqa_PushENEx = new clsvqa_PushENEx();
clsvqa_PushBL.CopyTo(objvqa_PushEN, objvqa_PushENEx);
return objvqa_PushENEx;
}
}
}