
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseIsLikeBLEx
 表名:cc_CourseIsLike(01120202)
 生成代码版本:2021.09.26.2
 生成日期:2021/09/29 17:05:33
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理
 模块英文名:CourseManage
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
public static class clscc_CourseIsLikeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_CourseIsLikeENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseIsLikeEN:objcc_CourseIsLikeENT</returns>
 public static clscc_CourseIsLikeENEx CopyToEx(this clscc_CourseIsLikeEN objcc_CourseIsLikeENS)
{
try
{
 clscc_CourseIsLikeENEx objcc_CourseIsLikeENT = new clscc_CourseIsLikeENEx();
clscc_CourseIsLikeBL.cc_CourseIsLikeDA.CopyTo(objcc_CourseIsLikeENS, objcc_CourseIsLikeENT);
 return objcc_CourseIsLikeENT;
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
 /// <param name = "objcc_CourseIsLikeENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseIsLikeEN:objcc_CourseIsLikeENT</returns>
 public static clscc_CourseIsLikeEN CopyTo(this clscc_CourseIsLikeENEx objcc_CourseIsLikeENS)
{
try
{
 clscc_CourseIsLikeEN objcc_CourseIsLikeENT = new clscc_CourseIsLikeEN();
clscc_CourseIsLikeBL.CopyTo(objcc_CourseIsLikeENS, objcc_CourseIsLikeENT);
 return objcc_CourseIsLikeENT;
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
 /// 课程点赞日志(cc_CourseIsLike)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_CourseIsLikeBLEx : clscc_CourseIsLikeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_CourseIsLikeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_CourseIsLikeDAEx cc_CourseIsLikeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_CourseIsLikeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_CourseIsLikeENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseIsLikeEN:objcc_CourseIsLikeENT</returns>
 public static clscc_CourseIsLikeENEx CopyToEx(clscc_CourseIsLikeEN objcc_CourseIsLikeENS)
{
try
{
 clscc_CourseIsLikeENEx objcc_CourseIsLikeENT = new clscc_CourseIsLikeENEx();
clscc_CourseIsLikeBL.cc_CourseIsLikeDA.CopyTo(objcc_CourseIsLikeENS, objcc_CourseIsLikeENT);
 return objcc_CourseIsLikeENT;
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
public static List<clscc_CourseIsLikeENEx> GetObjExLst(string strCondition)
{
List <clscc_CourseIsLikeEN> arrObjLst = clscc_CourseIsLikeBL.GetObjLst(strCondition);
List <clscc_CourseIsLikeENEx> arrObjExLst = new List<clscc_CourseIsLikeENEx>();
foreach (clscc_CourseIsLikeEN objInFor in arrObjLst)
{
clscc_CourseIsLikeENEx objcc_CourseIsLikeENEx = new clscc_CourseIsLikeENEx();
clscc_CourseIsLikeBL.CopyTo(objInFor, objcc_CourseIsLikeENEx);
arrObjExLst.Add(objcc_CourseIsLikeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_CourseIsLikeENEx GetObjExBymId(long lngmId)
{
clscc_CourseIsLikeEN objcc_CourseIsLikeEN = clscc_CourseIsLikeBL.GetObjBymId(lngmId);
clscc_CourseIsLikeENEx objcc_CourseIsLikeENEx = new clscc_CourseIsLikeENEx();
clscc_CourseIsLikeBL.CopyTo(objcc_CourseIsLikeEN, objcc_CourseIsLikeENEx);
return objcc_CourseIsLikeENEx;
}
}
}