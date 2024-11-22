﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFldTabNumBLEx
 表名:vFldTabNum(00050598)
 生成代码版本:2022.11.12.1
 生成日期:2022/11/16 02:07:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_vFldTabNumEx: RelatedActions_vFldTabNum
{
public override bool UpdRelaTabDate(string strFldId, string strOpUser)
{
return true;
}
}
public static class clsvFldTabNumBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvFldTabNumENS">源对象</param>
 /// <returns>目标对象=>clsvFldTabNumEN:objvFldTabNumENT</returns>
 public static clsvFldTabNumENEx CopyToEx(this clsvFldTabNumEN objvFldTabNumENS)
{
try
{
 clsvFldTabNumENEx objvFldTabNumENT = new clsvFldTabNumENEx();
clsvFldTabNumBL.vFldTabNumDA.CopyTo(objvFldTabNumENS, objvFldTabNumENT);
 return objvFldTabNumENT;
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
 /// <param name = "objvFldTabNumENS">源对象</param>
 /// <returns>目标对象=>clsvFldTabNumEN:objvFldTabNumENT</returns>
 public static clsvFldTabNumEN CopyTo(this clsvFldTabNumENEx objvFldTabNumENS)
{
try
{
 clsvFldTabNumEN objvFldTabNumENT = new clsvFldTabNumEN();
clsvFldTabNumBL.CopyTo(objvFldTabNumENS, objvFldTabNumENT);
 return objvFldTabNumENT;
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
 /// v字段-表数(vFldTabNum)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvFldTabNumBLEx : clsvFldTabNumBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvFldTabNumDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvFldTabNumDAEx vFldTabNumDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvFldTabNumDAEx();
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
public static List<clsvFldTabNumENEx> GetObjExLst(string strCondition)
{
List <clsvFldTabNumEN> arrObjLst = clsvFldTabNumBL.GetObjLst(strCondition);
List <clsvFldTabNumENEx> arrObjExLst = new List<clsvFldTabNumENEx>();
foreach (clsvFldTabNumEN objInFor in arrObjLst)
{
clsvFldTabNumENEx objvFldTabNumENEx = new clsvFldTabNumENEx();
clsvFldTabNumBL.CopyTo(objInFor, objvFldTabNumENEx);
arrObjExLst.Add(objvFldTabNumENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvFldTabNumENEx GetObjExByFldId(string strFldId)
{
clsvFldTabNumEN objvFldTabNumEN = clsvFldTabNumBL.GetObjByFldId(strFldId);
clsvFldTabNumENEx objvFldTabNumENEx = new clsvFldTabNumENEx();
clsvFldTabNumBL.CopyTo(objvFldTabNumEN, objvFldTabNumENEx);
return objvFldTabNumENEx;
}
}
}