﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeTypeBLEx
 表名:KnowledgeType(01120890)
 生成代码版本:2021.03.07.1
 生成日期:2021/03/10 14:30:55
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsKnowledgeTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objKnowledgeTypeENS">源对象</param>
 /// <returns>目标对象=>clsKnowledgeTypeEN:objKnowledgeTypeENT</returns>
 public static clsKnowledgeTypeENEx CopyToEx(this clsKnowledgeTypeEN objKnowledgeTypeENS)
{
try
{
 clsKnowledgeTypeENEx objKnowledgeTypeENT = new clsKnowledgeTypeENEx();
clsKnowledgeTypeBL.KnowledgeTypeDA.CopyTo(objKnowledgeTypeENS, objKnowledgeTypeENT);
 return objKnowledgeTypeENT;
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
 /// <param name = "objKnowledgeTypeENS">源对象</param>
 /// <returns>目标对象=>clsKnowledgeTypeEN:objKnowledgeTypeENT</returns>
 public static clsKnowledgeTypeEN CopyTo(this clsKnowledgeTypeENEx objKnowledgeTypeENS)
{
try
{
 clsKnowledgeTypeEN objKnowledgeTypeENT = new clsKnowledgeTypeEN();
clsKnowledgeTypeBL.CopyTo(objKnowledgeTypeENS, objKnowledgeTypeENT);
 return objKnowledgeTypeENT;
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
 /// 知识点类型(KnowledgeType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsKnowledgeTypeBLEx : clsKnowledgeTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsKnowledgeTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsKnowledgeTypeDAEx KnowledgeTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsKnowledgeTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objKnowledgeTypeENS">源对象</param>
 /// <returns>目标对象=>clsKnowledgeTypeEN:objKnowledgeTypeENT</returns>
 public static clsKnowledgeTypeENEx CopyToEx(clsKnowledgeTypeEN objKnowledgeTypeENS)
{
try
{
 clsKnowledgeTypeENEx objKnowledgeTypeENT = new clsKnowledgeTypeENEx();
clsKnowledgeTypeBL.KnowledgeTypeDA.CopyTo(objKnowledgeTypeENS, objKnowledgeTypeENT);
 return objKnowledgeTypeENT;
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
public static List<clsKnowledgeTypeENEx> GetObjExLst(string strCondition)
{
List <clsKnowledgeTypeEN> arrObjLst = clsKnowledgeTypeBL.GetObjLst(strCondition);
List <clsKnowledgeTypeENEx> arrObjExLst = new List<clsKnowledgeTypeENEx>();
foreach (clsKnowledgeTypeEN objInFor in arrObjLst)
{
clsKnowledgeTypeENEx objKnowledgeTypeENEx = new clsKnowledgeTypeENEx();
clsKnowledgeTypeBL.CopyTo(objInFor, objKnowledgeTypeENEx);
arrObjExLst.Add(objKnowledgeTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsKnowledgeTypeENEx GetObjExByKnowledgeTypeId(string strKnowledgeTypeId)
{
clsKnowledgeTypeEN objKnowledgeTypeEN = clsKnowledgeTypeBL.GetObjByKnowledgeTypeId(strKnowledgeTypeId);
clsKnowledgeTypeENEx objKnowledgeTypeENEx = new clsKnowledgeTypeENEx();
clsKnowledgeTypeBL.CopyTo(objKnowledgeTypeEN, objKnowledgeTypeENEx);
return objKnowledgeTypeENEx;
}
}
}