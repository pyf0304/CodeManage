
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TotalDataTypeBLEx
 表名:zx_TotalDataType(01120792)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:01:27
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置
 模块英文名:GraduateEduTools
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
public static class clszx_TotalDataTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TotalDataTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_TotalDataTypeEN:objzx_TotalDataTypeENT</returns>
 public static clszx_TotalDataTypeENEx CopyToEx(this clszx_TotalDataTypeEN objzx_TotalDataTypeENS)
{
try
{
 clszx_TotalDataTypeENEx objzx_TotalDataTypeENT = new clszx_TotalDataTypeENEx();
clszx_TotalDataTypeBL.zx_TotalDataTypeDA.CopyTo(objzx_TotalDataTypeENS, objzx_TotalDataTypeENT);
 return objzx_TotalDataTypeENT;
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
 /// <param name = "objzx_TotalDataTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_TotalDataTypeEN:objzx_TotalDataTypeENT</returns>
 public static clszx_TotalDataTypeEN CopyTo(this clszx_TotalDataTypeENEx objzx_TotalDataTypeENS)
{
try
{
 clszx_TotalDataTypeEN objzx_TotalDataTypeENT = new clszx_TotalDataTypeEN();
clszx_TotalDataTypeBL.CopyTo(objzx_TotalDataTypeENS, objzx_TotalDataTypeENT);
 return objzx_TotalDataTypeENT;
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
 /// 中学总数据类型表(zx_TotalDataType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_TotalDataTypeBLEx : clszx_TotalDataTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_TotalDataTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_TotalDataTypeDAEx zx_TotalDataTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_TotalDataTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TotalDataTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_TotalDataTypeEN:objzx_TotalDataTypeENT</returns>
 public static clszx_TotalDataTypeENEx CopyToEx(clszx_TotalDataTypeEN objzx_TotalDataTypeENS)
{
try
{
 clszx_TotalDataTypeENEx objzx_TotalDataTypeENT = new clszx_TotalDataTypeENEx();
clszx_TotalDataTypeBL.zx_TotalDataTypeDA.CopyTo(objzx_TotalDataTypeENS, objzx_TotalDataTypeENT);
 return objzx_TotalDataTypeENT;
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
public static List<clszx_TotalDataTypeENEx> GetObjExLst(string strCondition)
{
List <clszx_TotalDataTypeEN> arrObjLst = clszx_TotalDataTypeBL.GetObjLst(strCondition);
List <clszx_TotalDataTypeENEx> arrObjExLst = new List<clszx_TotalDataTypeENEx>();
foreach (clszx_TotalDataTypeEN objInFor in arrObjLst)
{
clszx_TotalDataTypeENEx objzx_TotalDataTypeENEx = new clszx_TotalDataTypeENEx();
clszx_TotalDataTypeBL.CopyTo(objInFor, objzx_TotalDataTypeENEx);
arrObjExLst.Add(objzx_TotalDataTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxTotalDataTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_TotalDataTypeENEx GetObjExByzxTotalDataTypeId(string strzxTotalDataTypeId)
{
clszx_TotalDataTypeEN objzx_TotalDataTypeEN = clszx_TotalDataTypeBL.GetObjByzxTotalDataTypeId(strzxTotalDataTypeId);
clszx_TotalDataTypeENEx objzx_TotalDataTypeENEx = new clszx_TotalDataTypeENEx();
clszx_TotalDataTypeBL.CopyTo(objzx_TotalDataTypeEN, objzx_TotalDataTypeENEx);
return objzx_TotalDataTypeENEx;
}
}
}