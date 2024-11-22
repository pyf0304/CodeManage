﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TopicTaskStatusBLEx
 表名:gs_TopicTaskStatus(01120664)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/10 19:31:11
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培参数
 模块英文名:ParameterTable
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
public static class clsgs_TopicTaskStatusBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_TopicTaskStatusENS">源对象</param>
 /// <returns>目标对象=>clsgs_TopicTaskStatusEN:objgs_TopicTaskStatusENT</returns>
 public static clsgs_TopicTaskStatusENEx CopyToEx(this clsgs_TopicTaskStatusEN objgs_TopicTaskStatusENS)
{
try
{
 clsgs_TopicTaskStatusENEx objgs_TopicTaskStatusENT = new clsgs_TopicTaskStatusENEx();
clsgs_TopicTaskStatusBL.gs_TopicTaskStatusDA.CopyTo(objgs_TopicTaskStatusENS, objgs_TopicTaskStatusENT);
 return objgs_TopicTaskStatusENT;
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
 /// <param name = "objgs_TopicTaskStatusENS">源对象</param>
 /// <returns>目标对象=>clsgs_TopicTaskStatusEN:objgs_TopicTaskStatusENT</returns>
 public static clsgs_TopicTaskStatusEN CopyTo(this clsgs_TopicTaskStatusENEx objgs_TopicTaskStatusENS)
{
try
{
 clsgs_TopicTaskStatusEN objgs_TopicTaskStatusENT = new clsgs_TopicTaskStatusEN();
clsgs_TopicTaskStatusBL.CopyTo(objgs_TopicTaskStatusENS, objgs_TopicTaskStatusENT);
 return objgs_TopicTaskStatusENT;
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
 /// 主题任务状态(gs_TopicTaskStatus)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_TopicTaskStatusBLEx : clsgs_TopicTaskStatusBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_TopicTaskStatusDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_TopicTaskStatusDAEx gs_TopicTaskStatusDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_TopicTaskStatusDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_TopicTaskStatusENS">源对象</param>
 /// <returns>目标对象=>clsgs_TopicTaskStatusEN:objgs_TopicTaskStatusENT</returns>
 public static clsgs_TopicTaskStatusENEx CopyToEx(clsgs_TopicTaskStatusEN objgs_TopicTaskStatusENS)
{
try
{
 clsgs_TopicTaskStatusENEx objgs_TopicTaskStatusENT = new clsgs_TopicTaskStatusENEx();
clsgs_TopicTaskStatusBL.gs_TopicTaskStatusDA.CopyTo(objgs_TopicTaskStatusENS, objgs_TopicTaskStatusENT);
 return objgs_TopicTaskStatusENT;
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
public static List<clsgs_TopicTaskStatusENEx> GetObjExLst(string strCondition)
{
List <clsgs_TopicTaskStatusEN> arrObjLst = clsgs_TopicTaskStatusBL.GetObjLst(strCondition);
List <clsgs_TopicTaskStatusENEx> arrObjExLst = new List<clsgs_TopicTaskStatusENEx>();
foreach (clsgs_TopicTaskStatusEN objInFor in arrObjLst)
{
clsgs_TopicTaskStatusENEx objgs_TopicTaskStatusENEx = new clsgs_TopicTaskStatusENEx();
clsgs_TopicTaskStatusBL.CopyTo(objInFor, objgs_TopicTaskStatusENEx);
arrObjExLst.Add(objgs_TopicTaskStatusENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strStatusId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_TopicTaskStatusENEx GetObjExByStatusId(string strStatusId)
{
clsgs_TopicTaskStatusEN objgs_TopicTaskStatusEN = clsgs_TopicTaskStatusBL.GetObjByStatusId(strStatusId);
clsgs_TopicTaskStatusENEx objgs_TopicTaskStatusENEx = new clsgs_TopicTaskStatusENEx();
clsgs_TopicTaskStatusBL.CopyTo(objgs_TopicTaskStatusEN, objgs_TopicTaskStatusENEx);
return objgs_TopicTaskStatusENEx;
}
}
}