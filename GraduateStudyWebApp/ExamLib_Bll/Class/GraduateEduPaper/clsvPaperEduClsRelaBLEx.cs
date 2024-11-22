
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperEduClsRelaBLEx
 表名:vPaperEduClsRela(01120932)
 生成代码版本:2021.09.26.2
 生成日期:2021/09/30 09:25:40
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
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
public static class clsvPaperEduClsRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clsvPaperEduClsRelaEN:objvPaperEduClsRelaENT</returns>
 public static clsvPaperEduClsRelaENEx CopyToEx(this clsvPaperEduClsRelaEN objvPaperEduClsRelaENS)
{
try
{
 clsvPaperEduClsRelaENEx objvPaperEduClsRelaENT = new clsvPaperEduClsRelaENEx();
clsvPaperEduClsRelaBL.vPaperEduClsRelaDA.CopyTo(objvPaperEduClsRelaENS, objvPaperEduClsRelaENT);
 return objvPaperEduClsRelaENT;
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
 /// <param name = "objvPaperEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clsvPaperEduClsRelaEN:objvPaperEduClsRelaENT</returns>
 public static clsvPaperEduClsRelaEN CopyTo(this clsvPaperEduClsRelaENEx objvPaperEduClsRelaENS)
{
try
{
 clsvPaperEduClsRelaEN objvPaperEduClsRelaENT = new clsvPaperEduClsRelaEN();
clsvPaperEduClsRelaBL.CopyTo(objvPaperEduClsRelaENS, objvPaperEduClsRelaENT);
 return objvPaperEduClsRelaENT;
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
 /// vPaperEduClsRela(vPaperEduClsRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvPaperEduClsRelaBLEx : clsvPaperEduClsRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvPaperEduClsRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvPaperEduClsRelaDAEx vPaperEduClsRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvPaperEduClsRelaDAEx();
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
public static List<clsvPaperEduClsRelaENEx> GetObjExLst(string strCondition)
{
List <clsvPaperEduClsRelaEN> arrObjLst = clsvPaperEduClsRelaBL.GetObjLst(strCondition);
List <clsvPaperEduClsRelaENEx> arrObjExLst = new List<clsvPaperEduClsRelaENEx>();
foreach (clsvPaperEduClsRelaEN objInFor in arrObjLst)
{
clsvPaperEduClsRelaENEx objvPaperEduClsRelaENEx = new clsvPaperEduClsRelaENEx();
clsvPaperEduClsRelaBL.CopyTo(objInFor, objvPaperEduClsRelaENEx);
arrObjExLst.Add(objvPaperEduClsRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvPaperEduClsRelaENEx GetObjExBymId(long lngmId)
{
clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = clsvPaperEduClsRelaBL.GetObjBymId(lngmId);
clsvPaperEduClsRelaENEx objvPaperEduClsRelaENEx = new clsvPaperEduClsRelaENEx();
clsvPaperEduClsRelaBL.CopyTo(objvPaperEduClsRelaEN, objvPaperEduClsRelaENEx);
return objvPaperEduClsRelaENEx;
}
}
}