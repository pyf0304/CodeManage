
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation_TotalByQuTypeBLEx
 表名:cc_WorkStuRelation_TotalByQuType(01120354)
 生成代码版本:2021.06.20.1
 生成日期:2021/06/26 15:21:01
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
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
public static class clscc_WorkStuRelation_TotalByQuTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkStuRelation_TotalByQuTypeEN:objcc_WorkStuRelation_TotalByQuTypeENT</returns>
 public static clscc_WorkStuRelation_TotalByQuTypeENEx CopyToEx(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeENS)
{
try
{
 clscc_WorkStuRelation_TotalByQuTypeENEx objcc_WorkStuRelation_TotalByQuTypeENT = new clscc_WorkStuRelation_TotalByQuTypeENEx();
clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.CopyTo(objcc_WorkStuRelation_TotalByQuTypeENS, objcc_WorkStuRelation_TotalByQuTypeENT);
 return objcc_WorkStuRelation_TotalByQuTypeENT;
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkStuRelation_TotalByQuTypeEN:objcc_WorkStuRelation_TotalByQuTypeENT</returns>
 public static clscc_WorkStuRelation_TotalByQuTypeEN CopyTo(this clscc_WorkStuRelation_TotalByQuTypeENEx objcc_WorkStuRelation_TotalByQuTypeENS)
{
try
{
 clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeENT = new clscc_WorkStuRelation_TotalByQuTypeEN();
clscc_WorkStuRelation_TotalByQuTypeBL.CopyTo(objcc_WorkStuRelation_TotalByQuTypeENS, objcc_WorkStuRelation_TotalByQuTypeENT);
 return objcc_WorkStuRelation_TotalByQuTypeENT;
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
 /// 作业完成情况汇总表ByQuType(cc_WorkStuRelation_TotalByQuType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_WorkStuRelation_TotalByQuTypeBLEx : clscc_WorkStuRelation_TotalByQuTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_WorkStuRelation_TotalByQuTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_WorkStuRelation_TotalByQuTypeDAEx cc_WorkStuRelation_TotalByQuTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_WorkStuRelation_TotalByQuTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkStuRelation_TotalByQuTypeEN:objcc_WorkStuRelation_TotalByQuTypeENT</returns>
 public static clscc_WorkStuRelation_TotalByQuTypeENEx CopyToEx(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeENS)
{
try
{
 clscc_WorkStuRelation_TotalByQuTypeENEx objcc_WorkStuRelation_TotalByQuTypeENT = new clscc_WorkStuRelation_TotalByQuTypeENEx();
clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.CopyTo(objcc_WorkStuRelation_TotalByQuTypeENS, objcc_WorkStuRelation_TotalByQuTypeENT);
 return objcc_WorkStuRelation_TotalByQuTypeENT;
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
public static List<clscc_WorkStuRelation_TotalByQuTypeENEx> GetObjExLst(string strCondition)
{
List <clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = clscc_WorkStuRelation_TotalByQuTypeBL.GetObjLst(strCondition);
List <clscc_WorkStuRelation_TotalByQuTypeENEx> arrObjExLst = new List<clscc_WorkStuRelation_TotalByQuTypeENEx>();
foreach (clscc_WorkStuRelation_TotalByQuTypeEN objInFor in arrObjLst)
{
clscc_WorkStuRelation_TotalByQuTypeENEx objcc_WorkStuRelation_TotalByQuTypeENEx = new clscc_WorkStuRelation_TotalByQuTypeENEx();
clscc_WorkStuRelation_TotalByQuTypeBL.CopyTo(objInFor, objcc_WorkStuRelation_TotalByQuTypeENEx);
arrObjExLst.Add(objcc_WorkStuRelation_TotalByQuTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngId_WorkStuRelation_Total">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_WorkStuRelation_TotalByQuTypeENEx GetObjExById_WorkStuRelation_Total(long lngId_WorkStuRelation_Total)
{
clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = clscc_WorkStuRelation_TotalByQuTypeBL.GetObjByIdWorkStuRelationTotal(lngId_WorkStuRelation_Total);
clscc_WorkStuRelation_TotalByQuTypeENEx objcc_WorkStuRelation_TotalByQuTypeENEx = new clscc_WorkStuRelation_TotalByQuTypeENEx();
clscc_WorkStuRelation_TotalByQuTypeBL.CopyTo(objcc_WorkStuRelation_TotalByQuTypeEN, objcc_WorkStuRelation_TotalByQuTypeENEx);
return objcc_WorkStuRelation_TotalByQuTypeENEx;
}
}
}