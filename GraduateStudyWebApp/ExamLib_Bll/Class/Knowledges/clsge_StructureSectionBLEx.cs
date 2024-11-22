﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureSectionBLEx
 表名:ge_StructureSection(01120896)
 生成代码版本:2021.03.13.1
 生成日期:2021/03/16 11:06:11
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
public static class clsge_StructureSectionBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objge_StructureSectionENS">源对象</param>
 /// <returns>目标对象=>clsge_StructureSectionEN:objge_StructureSectionENT</returns>
 public static clsge_StructureSectionENEx CopyToEx(this clsge_StructureSectionEN objge_StructureSectionENS)
{
try
{
 clsge_StructureSectionENEx objge_StructureSectionENT = new clsge_StructureSectionENEx();
clsge_StructureSectionBL.ge_StructureSectionDA.CopyTo(objge_StructureSectionENS, objge_StructureSectionENT);
 return objge_StructureSectionENT;
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
 /// <param name = "objge_StructureSectionENS">源对象</param>
 /// <returns>目标对象=>clsge_StructureSectionEN:objge_StructureSectionENT</returns>
 public static clsge_StructureSectionEN CopyTo(this clsge_StructureSectionENEx objge_StructureSectionENS)
{
try
{
 clsge_StructureSectionEN objge_StructureSectionENT = new clsge_StructureSectionEN();
clsge_StructureSectionBL.CopyTo(objge_StructureSectionENS, objge_StructureSectionENT);
 return objge_StructureSectionENT;
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
 /// 结构章节(ge_StructureSection)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsge_StructureSectionBLEx : clsge_StructureSectionBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsge_StructureSectionDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsge_StructureSectionDAEx ge_StructureSectionDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsge_StructureSectionDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objge_StructureSectionENS">源对象</param>
 /// <returns>目标对象=>clsge_StructureSectionEN:objge_StructureSectionENT</returns>
 public static clsge_StructureSectionENEx CopyToEx(clsge_StructureSectionEN objge_StructureSectionENS)
{
try
{
 clsge_StructureSectionENEx objge_StructureSectionENT = new clsge_StructureSectionENEx();
clsge_StructureSectionBL.ge_StructureSectionDA.CopyTo(objge_StructureSectionENS, objge_StructureSectionENT);
 return objge_StructureSectionENT;
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
public static List<clsge_StructureSectionENEx> GetObjExLst(string strCondition)
{
List <clsge_StructureSectionEN> arrObjLst = clsge_StructureSectionBL.GetObjLst(strCondition);
List <clsge_StructureSectionENEx> arrObjExLst = new List<clsge_StructureSectionENEx>();
foreach (clsge_StructureSectionEN objInFor in arrObjLst)
{
clsge_StructureSectionENEx objge_StructureSectionENEx = new clsge_StructureSectionENEx();
clsge_StructureSectionBL.CopyTo(objInFor, objge_StructureSectionENEx);
arrObjExLst.Add(objge_StructureSectionENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strStructureSectionId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsge_StructureSectionENEx GetObjExByStructureSectionId(string strStructureSectionId)
{
clsge_StructureSectionEN objge_StructureSectionEN = clsge_StructureSectionBL.GetObjByStructureSectionId(strStructureSectionId);
clsge_StructureSectionENEx objge_StructureSectionENEx = new clsge_StructureSectionENEx();
clsge_StructureSectionBL.CopyTo(objge_StructureSectionEN, objge_StructureSectionENEx);
return objge_StructureSectionENEx;
}
}
}