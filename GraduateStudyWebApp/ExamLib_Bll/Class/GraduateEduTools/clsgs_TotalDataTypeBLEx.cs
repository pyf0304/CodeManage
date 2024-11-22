
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TotalDataTypeBLEx
 表名:gs_TotalDataType(01120685)
 生成代码版本:2020.06.21.1
 生成日期:2020/06/23 22:51:10
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
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
public static class clsgs_TotalDataTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_TotalDataTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_TotalDataTypeEN:objgs_TotalDataTypeENT</returns>
 public static clsgs_TotalDataTypeENEx CopyToEx(this clsgs_TotalDataTypeEN objgs_TotalDataTypeENS)
{
try
{
 clsgs_TotalDataTypeENEx objgs_TotalDataTypeENT = new clsgs_TotalDataTypeENEx();
clsgs_TotalDataTypeBL.gs_TotalDataTypeDA.CopyTo(objgs_TotalDataTypeENS, objgs_TotalDataTypeENT);
 return objgs_TotalDataTypeENT;
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
 /// <param name = "objgs_TotalDataTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_TotalDataTypeEN:objgs_TotalDataTypeENT</returns>
 public static clsgs_TotalDataTypeEN CopyTo(this clsgs_TotalDataTypeENEx objgs_TotalDataTypeENS)
{
try
{
 clsgs_TotalDataTypeEN objgs_TotalDataTypeENT = new clsgs_TotalDataTypeEN();
clsgs_TotalDataTypeBL.CopyTo(objgs_TotalDataTypeENS, objgs_TotalDataTypeENT);
 return objgs_TotalDataTypeENT;
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
 /// 总数据类型表(gs_TotalDataType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_TotalDataTypeBLEx : clsgs_TotalDataTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_TotalDataTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_TotalDataTypeDAEx gs_TotalDataTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_TotalDataTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_TotalDataTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_TotalDataTypeEN:objgs_TotalDataTypeENT</returns>
 public static clsgs_TotalDataTypeENEx CopyToEx(clsgs_TotalDataTypeEN objgs_TotalDataTypeENS)
{
try
{
 clsgs_TotalDataTypeENEx objgs_TotalDataTypeENT = new clsgs_TotalDataTypeENEx();
clsgs_TotalDataTypeBL.gs_TotalDataTypeDA.CopyTo(objgs_TotalDataTypeENS, objgs_TotalDataTypeENT);
 return objgs_TotalDataTypeENT;
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
public static List<clsgs_TotalDataTypeENEx> GetObjExLst(string strCondition)
{
List <clsgs_TotalDataTypeEN> arrObjLst = clsgs_TotalDataTypeBL.GetObjLst(strCondition);
List <clsgs_TotalDataTypeENEx> arrObjExLst = new List<clsgs_TotalDataTypeENEx>();
foreach (clsgs_TotalDataTypeEN objInFor in arrObjLst)
{
clsgs_TotalDataTypeENEx objgs_TotalDataTypeENEx = new clsgs_TotalDataTypeENEx();
clsgs_TotalDataTypeBL.CopyTo(objInFor, objgs_TotalDataTypeENEx);
arrObjExLst.Add(objgs_TotalDataTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTotalDataTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_TotalDataTypeENEx GetObjExByTotalDataTypeId(string strTotalDataTypeId)
{
clsgs_TotalDataTypeEN objgs_TotalDataTypeEN = clsgs_TotalDataTypeBL.GetObjByTotalDataTypeId(strTotalDataTypeId);
clsgs_TotalDataTypeENEx objgs_TotalDataTypeENEx = new clsgs_TotalDataTypeENEx();
clsgs_TotalDataTypeBL.CopyTo(objgs_TotalDataTypeEN, objgs_TotalDataTypeENEx);
return objgs_TotalDataTypeENEx;
}
}
}