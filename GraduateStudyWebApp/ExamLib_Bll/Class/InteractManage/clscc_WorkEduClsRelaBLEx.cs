
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkEduClsRelaBLEx
 表名:cc_WorkEduClsRela(01120164)
 生成代码版本:2021.06.19.1
 生成日期:2021/06/19 17:55:30
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
public static class clscc_WorkEduClsRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkEduClsRelaEN:objcc_WorkEduClsRelaENT</returns>
 public static clscc_WorkEduClsRelaENEx CopyToEx(this clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaENS)
{
try
{
 clscc_WorkEduClsRelaENEx objcc_WorkEduClsRelaENT = new clscc_WorkEduClsRelaENEx();
clscc_WorkEduClsRelaBL.cc_WorkEduClsRelaDA.CopyTo(objcc_WorkEduClsRelaENS, objcc_WorkEduClsRelaENT);
 return objcc_WorkEduClsRelaENT;
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
 /// <param name = "objcc_WorkEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkEduClsRelaEN:objcc_WorkEduClsRelaENT</returns>
 public static clscc_WorkEduClsRelaEN CopyTo(this clscc_WorkEduClsRelaENEx objcc_WorkEduClsRelaENS)
{
try
{
 clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaENT = new clscc_WorkEduClsRelaEN();
clscc_WorkEduClsRelaBL.CopyTo(objcc_WorkEduClsRelaENS, objcc_WorkEduClsRelaENT);
 return objcc_WorkEduClsRelaENT;
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
 /// 作业教学班关系(cc_WorkEduClsRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_WorkEduClsRelaBLEx : clscc_WorkEduClsRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_WorkEduClsRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_WorkEduClsRelaDAEx cc_WorkEduClsRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_WorkEduClsRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_WorkEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkEduClsRelaEN:objcc_WorkEduClsRelaENT</returns>
 public static clscc_WorkEduClsRelaENEx CopyToEx(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaENS)
{
try
{
 clscc_WorkEduClsRelaENEx objcc_WorkEduClsRelaENT = new clscc_WorkEduClsRelaENEx();
clscc_WorkEduClsRelaBL.cc_WorkEduClsRelaDA.CopyTo(objcc_WorkEduClsRelaENS, objcc_WorkEduClsRelaENT);
 return objcc_WorkEduClsRelaENT;
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
public static List<clscc_WorkEduClsRelaENEx> GetObjExLst(string strCondition)
{
List <clscc_WorkEduClsRelaEN> arrObjLst = clscc_WorkEduClsRelaBL.GetObjLst(strCondition);
List <clscc_WorkEduClsRelaENEx> arrObjExLst = new List<clscc_WorkEduClsRelaENEx>();
foreach (clscc_WorkEduClsRelaEN objInFor in arrObjLst)
{
clscc_WorkEduClsRelaENEx objcc_WorkEduClsRelaENEx = new clscc_WorkEduClsRelaENEx();
clscc_WorkEduClsRelaBL.CopyTo(objInFor, objcc_WorkEduClsRelaENEx);
arrObjExLst.Add(objcc_WorkEduClsRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngId_WorkEduClsRela">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_WorkEduClsRelaENEx GetObjExById_WorkEduClsRela(long lngId_WorkEduClsRela)
{
clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN = clscc_WorkEduClsRelaBL.GetObjByIdWorkEduClsRela(lngId_WorkEduClsRela);
clscc_WorkEduClsRelaENEx objcc_WorkEduClsRelaENEx = new clscc_WorkEduClsRelaENEx();
clscc_WorkEduClsRelaBL.CopyTo(objcc_WorkEduClsRelaEN, objcc_WorkEduClsRelaENEx);
return objcc_WorkEduClsRelaENEx;
}
}
}