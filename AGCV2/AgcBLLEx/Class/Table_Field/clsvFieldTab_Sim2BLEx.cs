﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab_Sim2BLEx
 表名:vFieldTab_Sim2(00050608)
 生成代码版本:2022.04.02.1
 生成日期:2022/04/04 17:42:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa前端(变量首字母小写)
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
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
public static class clsvFieldTab_Sim2BLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2ENS">源对象</param>
 /// <returns>目标对象=>clsvFieldTab_Sim2EN:objvFieldTab_Sim2ENT</returns>
 public static clsvFieldTab_Sim2ENEx CopyToEx(this clsvFieldTab_Sim2EN objvFieldTab_Sim2ENS)
{
try
{
 clsvFieldTab_Sim2ENEx objvFieldTab_Sim2ENT = new clsvFieldTab_Sim2ENEx();
clsvFieldTab_Sim2BL.vFieldTab_Sim2DA.CopyTo(objvFieldTab_Sim2ENS, objvFieldTab_Sim2ENT);
 return objvFieldTab_Sim2ENT;
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
 /// <param name = "objvFieldTab_Sim2ENS">源对象</param>
 /// <returns>目标对象=>clsvFieldTab_Sim2EN:objvFieldTab_Sim2ENT</returns>
 public static clsvFieldTab_Sim2EN CopyTo(this clsvFieldTab_Sim2ENEx objvFieldTab_Sim2ENS)
{
try
{
 clsvFieldTab_Sim2EN objvFieldTab_Sim2ENT = new clsvFieldTab_Sim2EN();
clsvFieldTab_Sim2BL.CopyTo(objvFieldTab_Sim2ENS, objvFieldTab_Sim2ENT);
 return objvFieldTab_Sim2ENT;
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
 /// vFieldTab_Sim2(vFieldTab_Sim2)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvFieldTab_Sim2BLEx : clsvFieldTab_Sim2BL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvFieldTab_Sim2DAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvFieldTab_Sim2DAEx vFieldTab_Sim2DAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvFieldTab_Sim2DAEx();
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
public static List<clsvFieldTab_Sim2ENEx> GetObjExLst(string strCondition)
{
List <clsvFieldTab_Sim2EN> arrObjLst = clsvFieldTab_Sim2BL.GetObjLst(strCondition);
List <clsvFieldTab_Sim2ENEx> arrObjExLst = new List<clsvFieldTab_Sim2ENEx>();
foreach (clsvFieldTab_Sim2EN objInFor in arrObjLst)
{
clsvFieldTab_Sim2ENEx objvFieldTab_Sim2ENEx = new clsvFieldTab_Sim2ENEx();
clsvFieldTab_Sim2BL.CopyTo(objInFor, objvFieldTab_Sim2ENEx);
arrObjExLst.Add(objvFieldTab_Sim2ENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvFieldTab_Sim2ENEx GetObjExByFldId(string strFldId)
{
clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = clsvFieldTab_Sim2BL.GetObjByFldId(strFldId);
clsvFieldTab_Sim2ENEx objvFieldTab_Sim2ENEx = new clsvFieldTab_Sim2ENEx();
clsvFieldTab_Sim2BL.CopyTo(objvFieldTab_Sim2EN, objvFieldTab_Sim2ENEx);
return objvFieldTab_Sim2ENEx;
}
}
}